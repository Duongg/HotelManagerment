using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary {
    public class BookingRoom {
        public string CustomerID { get; set; }
        public string RoomNo { get; set; }
        public string Username { get; set; }
        public DateTime CheckInDay { get; set; }
        public DateTime CheckOutDay { get; set; }
        public float TotalPay { get; set; }
        public float PrePay { get; set; }

        public BookingRoom() {
        }

        public BookingRoom(string customerID, string roomNo, string username, DateTime checkInDay, DateTime checkOutDay, float totalPay, float prePay) {
            CustomerID = customerID;
            RoomNo = roomNo;
            Username = username;
            CheckInDay = checkInDay;
            CheckOutDay = checkOutDay;
            TotalPay = totalPay;
            PrePay = prePay;
        }
    }


}

