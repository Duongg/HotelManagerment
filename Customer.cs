using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary {
    public class Customer {
        public string customerID { get; set; }
        public string customerName { get; set; }
        public string phone { get; set; }

        public DateTime birthday { get; set; }

        public Customer(string customerID, string customerName, string phone, DateTime birthday) {
            this.customerID = customerID;
            this.customerName = customerName;
            this.phone = phone;

            this.birthday = birthday;
        }
    }
}
