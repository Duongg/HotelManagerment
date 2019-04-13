using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary {
    public class RoomData {
        public RoomData() {

        }
        string strConnnection = "server=.;database=Hotel;uid=sa;pwd=22011998";
        //add new room in hotel
        public bool AddNewRoom(Room room) {
            int count;
            string sql = "Insert Room values(@RoomNo,@RoomType,@Price,'True',@description)";
            SqlConnection cnn = new SqlConnection(strConnnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            // cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
            cmd.Parameters.AddWithValue("@RoomNo", room.RoomName);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
            cmd.Parameters.AddWithValue("@Price", room.RoomPrice);
            cmd.Parameters.AddWithValue("@Status", room.RoomStatus);
            cmd.Parameters.AddWithValue("@Description", room.Description);

            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();

                }
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception) {

                throw;
            }
            finally {
                cnn.Close();
            }
            return (count > 0);
        }//end of add new room
        //-------------------------------------------
        //Update room in hotel
        public bool UpdateRoom(Room room) {
            int count;
            string sql = "Update Room SET RoomType = @RoomType, Price = @Price, description = @description where RoomNo = @RoomNo";
            SqlConnection cnn = new SqlConnection(strConnnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            
            cmd.Parameters.AddWithValue("@RoomNo", room.RoomName);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
            cmd.Parameters.AddWithValue("@Price", room.RoomPrice);
            cmd.Parameters.AddWithValue("@Description", room.Description);

            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                }
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception) {

                throw;
            }
            finally {
                cnn.Close();
            }
            return (count > 0);
        }//end of Update Room
        //---------------------------------------------------
        //Delete Room in hotel
        public bool DeleteRoom(string RoomNo) {
           
            int count;
            string sql = "Delete Room where RoomNo = @RoomNo";
            SqlConnection cnn = new SqlConnection(strConnnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                }
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception) {

                throw;
            }
            finally {
                cnn.Close();
            }
            return (count > 0);
        }
        public DataTable GetAllRoom() {
            string sql = "Select * from Room";
            SqlConnection cnn = new SqlConnection(strConnnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtRoom = new DataTable();
            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                }
                sda.Fill(dtRoom);
            }
            catch (Exception) {

                throw;
            }
            finally {
                cnn.Close();
            }
            return dtRoom;
        }
        public DataTable getAllRoomRented() {
            string sql = "SELECT * FROM dbo.Room WHERE status= '1'";
            SqlConnection cnn = new SqlConnection(strConnnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtRoomRented = new DataTable();
            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                }
                sda.Fill(dtRoomRented);
            }
            catch (Exception) {

                throw;
            }
            finally {
                cnn.Close();
            }
            return dtRoomRented;
        }
        public DataTable getAllEmptyRoom() {
            string sql = "SELECT * FROM dbo.Room WHERE status= '0'";
            SqlConnection cnn = new SqlConnection(strConnnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtEmptyRoom = new DataTable();
            try {
                if (cnn.State == ConnectionState.Closed) {
                    cnn.Open();
                }
                sda.Fill(dtEmptyRoom);
            }
            catch (Exception) {

                throw;
            }
            finally {
                cnn.Close();
            }
            return dtEmptyRoom;
        }
    }
}
