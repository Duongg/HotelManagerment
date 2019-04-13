using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary {
    public class Account {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

        public Account() {
        }
        string strConnection = "server=.;database=Hotel;uid=sa;pwd=22011998";

        public int checkLogin(string Username, string Password) {
            int result = -1;

            string sql = "SELECT Role FROM dbo.Account WHERE Username = @Username AND Password=@Password";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);


            SqlDataReader dr;
            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows) {
                        if (dr.Read()) {
                            bool role = dr.GetBoolean(0);
                            if (role)
                                result = 1;
                            else result = 0;
                        }

                    }
                }
                
            } catch (Exception ex) {

                ex.ToString();
                
            } finally {
                cnn.Close();
            }
            return result;
        }
    }
}
