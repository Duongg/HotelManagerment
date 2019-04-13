using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary {
    public class RoomAccess {
        string strConnection = "server=.;database=Hotel;uid=sa;pwd=22011998";


        public DataTable loadRoomType() {
            SqlConnection cnn = new SqlConnection(strConnection);
            cnn.Open();
            string sql = "SELECT DISTINCT roomType FROM Room where status = '1'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cnn.Close();
            return dt;
        }

        public DataTable loadIDCost(string loaiPhong) {

            SqlConnection cnn = new SqlConnection(strConnection);
            cnn.Open();
            string sql = "SELECT roomno,price  FROM room WHERE roomType = @roomType AND status = '1'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@roomType", loaiPhong);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cnn.Close();
            return dt;
        }
        public Customer getCustomer(string cmnd) {

            SqlConnection cnn = new SqlConnection(strConnection);
            cnn.Open();
            Customer cus = null;
            string sql = "SELECT name,phone,birthday  FROM customer WHERE customerID = @ID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", cmnd);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) {
                if (dr.Read()) {
                    string name = dr.GetString(0);
                    string phone = dr.GetString(1);

                    DateTime birthday = (DateTime)dr["birthday"];
                    cus = new Customer(cmnd, name, phone, birthday);
                }

            }
            cnn.Close();
            return cus;
        }

        public string getCusName(string cmnd) {

            SqlConnection cnn = new SqlConnection(strConnection);
            cnn.Open();

            string sql = "SELECT name FROM customer WHERE customerID = @ID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", cmnd);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) {
                if (dr.Read()) {
                    string name = dr.GetString(0);
                    return name;
                }

            }
            cnn.Close();
            return null;
        }
        public int getRommID(string tenphong) {

            SqlConnection cnn = new SqlConnection(strConnection);
            cnn.Open();
            string sql = "SELECT roomID  FROM room WHERE roomName = @roomType AND status = '1'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@roomType", tenphong);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cnn.Close();
            return 0;
        }

        public bool checkin(Customer pr, BookingRoom book) {
            bool result, result2, result3 = false;

            SqlConnection cnn = new SqlConnection(strConnection);
            string sql = "Insert into Customer values(@ID,@NAME,@PHONE,@BIRTHDAY)";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.AddWithValue("@ID", pr.customerID);
            cmd.Parameters.AddWithValue("@NAME", pr.customerName);
            cmd.Parameters.AddWithValue("@PHONE", pr.phone);

            cmd.Parameters.AddWithValue("@BIRTHDAY", pr.birthday);
            result = cmd.ExecuteNonQuery() > 0;




            string sql2 = "Insert into Booking (customerID,roomno,checkindate,checkoutdate,totalpay,status,prepay)  values(@customerID,@roomNo,@checkin,@checkout,@totalpay,@status,@prepay)";
            SqlCommand cmd2 = new SqlCommand(sql2, cnn);

            cmd2.Parameters.AddWithValue("@customerID", pr.customerID);
            cmd2.Parameters.AddWithValue("@roomNo", book.RoomNo);
            cmd2.Parameters.AddWithValue("@checkin", book.CheckInDay);
            cmd2.Parameters.AddWithValue("@checkout", book.CheckOutDay);
            cmd2.Parameters.AddWithValue("@totalpay", book.TotalPay);
            cmd2.Parameters.AddWithValue("@status", true);
            cmd2.Parameters.AddWithValue("@prepay", book.PrePay);

            result2 = cmd2.ExecuteNonQuery() > 0;

            string sql3 = "update room set status= @status where roomno = @ROOMNO";
            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
            cmd3.Parameters.AddWithValue("@status", false);
            cmd3.Parameters.AddWithValue("@ROOMNO", book.RoomNo);
            result3 = cmd3.ExecuteNonQuery() > 0;
            cnn.Close();

            if (result && result2 && result3)
                return true;
            else return false;

        }
        public bool checkinKhachQuen(BookingRoom book, string cusID) {
            bool result, result2 = false;
            SqlConnection cnn = new SqlConnection(strConnection);
            cnn.Open();
            string sql2 = "Insert into Booking (customerID,roomno,checkindate,checkoutdate,totalpay,status,prepay) values(@customerID,@roomNo,@checkin,@checkout,@totalpay,@status,@prepay)";
            SqlCommand cmd2 = new SqlCommand(sql2, cnn);

            cmd2.Parameters.AddWithValue("@customerID", cusID);
            cmd2.Parameters.AddWithValue("@roomNo", book.RoomNo);
            cmd2.Parameters.AddWithValue("@checkin", book.CheckInDay);
            cmd2.Parameters.AddWithValue("@checkout", book.CheckOutDay);
            cmd2.Parameters.AddWithValue("@totalpay", book.TotalPay);
            cmd2.Parameters.AddWithValue("@status", true);
            cmd2.Parameters.AddWithValue("@prepay", book.PrePay);

            result = cmd2.ExecuteNonQuery() > 0;

            string sql3 = "update room set status= @status where roomno = @ROOMNO";
            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
            cmd3.Parameters.AddWithValue("@status", false);
            cmd3.Parameters.AddWithValue("@ROOMNO", book.RoomNo);
            result2 = cmd3.ExecuteNonQuery() > 0;
            cnn.Close();

            if (result && result2)
                return true;
            else return false;

        }

        public bool CheckOUt(int bookingID, string customerID, string roomNo, int totalday, float total) {
            bool result1, result2, result3, result = false;
            SqlConnection cnn = new SqlConnection(strConnection);
            string sql = "Insert into Payment (bookingID, customerID, roomNo, totalday,total) values (@bookingID, @customerID, @roomNo, @totalday,@total) ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@bookingID", bookingID);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Parameters.AddWithValue("@roomNo", roomNo);
            cmd.Parameters.AddWithValue("@totalday", totalday);
            cmd.Parameters.AddWithValue("@total", total);

            string sql2 = "Update Booking set status = 'false' where bookingID = @bookingID";
            SqlCommand cmd2 = new SqlCommand(sql2, cnn);
            cmd2.Parameters.AddWithValue("@bookingID", bookingID);

            string sql3 = "Update Room set status = 'true' where roomNo = @roomNo";
            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
            cmd3.Parameters.AddWithValue("@roomNo", roomNo);

            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                }
                result1 = cmd.ExecuteNonQuery() > 0;
                result2 = cmd2.ExecuteNonQuery() > 0;
                result3 = cmd3.ExecuteNonQuery() > 0;

                if (result1 == true && result2 == true && result3 == true) {
                    result = true;
                }
            }

            finally {
                cnn.Close();
            }
            return result;
        }


    }
}
