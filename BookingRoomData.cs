using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary {
    public class BookingRoomData {
        string strConnection = "server=.;database=Hotel;uid=sa;pwd=22011998";
        public DataTable getAllRoomRental() {
            string sql = "SELECT * FROM dbo.Booking where status = 'true'";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtRoomRental = new DataTable();
            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                }
                sda.Fill(dtRoomRental);
            }
            catch (Exception) {

                throw;
            }
            finally {
                cnn.Close();
            }
            return dtRoomRental;
        }


    }
}

