using HotelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerment {
    public partial class Payment : Form {
        int bookingIDaa;
        string customerIDaa;
        string roomNoaa;
        int totaldayaa;
        float totalaa;

        public Payment(int bookingID, string CustomerID, string RoomNo, DateTime CheckInDay, DateTime CheckOutDay, float TotalPay, float PrePay) {
            RoomAccess data = new RoomAccess();
            InitializeComponent();
            txtPayBookintID.Text = bookingID.ToString();
            txtPayCustNo.Text = data.getCusName(CustomerID);
            txtPayRoomNo.Text = RoomNo;
            txtPayCheckin.Text = CheckInDay.ToShortDateString();
            txtPayCheckOut.Text = CheckOutDay.ToShortDateString();
            TimeSpan ngayo = CheckOutDay.Subtract(CheckInDay);
            txtNgayO.Text = (ngayo.Days + 1).ToString();
            txtPayTotal.Text = TotalPay.ToString();
            txtPayPre.Text = PrePay.ToString();
            txtConLai.Text = (TotalPay - PrePay).ToString();

            bookingIDaa = bookingID;
            customerIDaa = CustomerID;
            roomNoaa = RoomNo;
            totaldayaa = ngayo.Days + 1;
            totalaa = TotalPay;



        }

        private void Payment_Load(object sender, EventArgs e) {

        }

        private void btnTraTien_Click(object sender, EventArgs e) {
            RoomAccess data = new RoomAccess();
            if (data.CheckOUt(bookingIDaa, customerIDaa, roomNoaa, totaldayaa, totalaa)) {
                MessageBox.Show("Trả Phòng Thành Công");
                this.Hide();
                Thread t = new Thread(new ThreadStart(showServerForm));
                t.Start();
                this.Close();
            }
            else {
                MessageBox.Show("Trả Phòng Không Thành Công");
                this.Hide();
                Thread t = new Thread(new ThreadStart(showServerForm));
                t.Start();
                this.Close();
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showServerForm));
            t.Start();
            this.Close();
        }
        private void showServerForm() {
            Server tp = new Server();
            Application.Run(tp);
        }
    }

    

    
}
