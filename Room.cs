using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary {
    public class Room {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public float RoomPrice { get; set; }
        public bool RoomStatus { get; set; }
        public string Description { get; set; }

        public Room() {
        }

        public Room(string roomName, string roomType, float roomPrice, string description) {
            RoomName = roomName;
            RoomType = roomType;
            RoomPrice = roomPrice;
            Description = description;
        }

        public Room(string roomName, string roomType, float roomPrice, bool roomStatus, string description) {
            RoomName = roomName;
            RoomType = roomType;
            RoomPrice = roomPrice;
            RoomStatus = roomStatus;
            Description = description;
        }

        public Room(int roomID, string roomName, string roomType, float roomPrice, string description) {
            RoomID = roomID;
            RoomName = roomName;
            RoomType = roomType;
            RoomPrice = roomPrice;
            Description = description;
        }

        public Room(int roomID, string roomName, string roomType, float roomPrice, bool roomStatus, string description) {
            RoomID = roomID;
            RoomName = roomName;
            RoomType = roomType;
            RoomPrice = roomPrice;
            RoomStatus = roomStatus;
            Description = description;
        }
    }
}
