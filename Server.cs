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
    public partial class Server : Form {
        int role;

        public Server(int role) {
            this.role = role;
            InitializeComponent();
            if (role == 0)
                tbcServer.TabPages.Remove(tbAdmin);

        }
        public Server() {
            InitializeComponent();
        }
        RoomData dataRoom = new RoomData();
        BookingRoomData dataRoomRental = new BookingRoomData();
        DataTable dtRoom;
        DataTable dtRoomRental;
        Account acc = new Account();

        // Log out form
        private void showLoginForm() {
            Login lg = new Login();
            Application.Run(lg);
        }
        private void showThuePhongForm() {
            ThuePhong tp = new ThuePhong();
            Application.Run(tp);
        }
        private void showRoomRented() {
            frmBookingRoom roomRented = new frmBookingRoom();
            Application.Run(roomRented);
        }
        private void showEmptyRoom() {
            frmEmptyRoom emptyRoom = new frmEmptyRoom();
            Application.Run(emptyRoom);
        }
        private void btnLogout_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showLoginForm));
            t.Start();
            this.Close();
        }


        //----------------------------
        // tab control Admin         |
        //----------------------------
        #region

        // update room
        private void btnSua_Click(object sender, EventArgs e) {

            string tenphong = txtTenPhong.Text;
            string loaiPhong = txtLoaiPhong.Text;
            float giaPhong = float.Parse(txtGia.Text);
            string ghichu = txtGhiChu.Text;

            Room roomUpdate = new Room()
            {
                RoomName = tenphong,
                RoomType = loaiPhong,
                RoomPrice = giaPhong,
                Description = ghichu
            };

            if (dataRoom.UpdateRoom(roomUpdate)) {
                MessageBox.Show("Cập nhật thành công!");
            } else {
                MessageBox.Show("Cập nhật không thành công!");
            }


            loadAllRoom();
        }//end of update
        // delete room
        private void btnXoa_Click(object sender, EventArgs e) {
            try {
                string tenphong = txtTenPhong.Text;
                if (dataRoom.DeleteRoom(tenphong)) {
                    DataRow row = dtRoom.Rows.Find(tenphong);
                    dtRoom.Rows.Remove(row);
                    MessageBox.Show("Xóa Phòng Thành Công");
                } else {
                    MessageBox.Show("Xóa Phòng không thành công!");
                }
            } catch (Exception) {
                MessageBox.Show("Xóa Phòng Không Thành Công!");
            }
            loadAllRoom();

        }   //end of delete

        private void btnPhongMoi_Click(object sender, EventArgs e) {
            frmThemPhong themPhong = new frmThemPhong();
            themPhong.Show();
        }
        public void loadAllRoom() {
            dtRoom = dataRoom.GetAllRoom();
            dtRoom.PrimaryKey = new DataColumn[] { dtRoom.Columns["roomNo"] };
            bsRoom.DataSource = dtRoom;
            txtTenPhong.DataBindings.Clear();
            txtLoaiPhong.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtTenPhong.DataBindings.Add("Text", bsRoom, "roomNo");
            txtLoaiPhong.DataBindings.Add("Text", bsRoom, "roomType");
            txtGia.DataBindings.Add("Text", bsRoom, "price");
            txtGhiChu.DataBindings.Add("Text", bsRoom, "description");
            dgvRoom.DataSource = bsRoom;
        }

        private void loadAllRoomRental() {
            dtRoomRental = dataRoomRental.getAllRoomRental();
            bsRoomRental.DataSource = dtRoomRental;
            dgvRoomRental.DataSource = bsRoomRental;
        }
        private void loadRentData() {
            dtRoomRental = dataRoomRental.getAllRoomRental();

            txtRentBookintID.DataBindings.Clear();
            txtRentCustNo.DataBindings.Clear();
            txtRentRoomNo.DataBindings.Clear();
            txtRentCheckin.DataBindings.Clear();
            txtRentCheckOut.DataBindings.Clear();
            txtRentTotal.DataBindings.Clear();
            textBox6.DataBindings.Clear();




            txtRentBookintID.DataBindings.Add("Text", dtRoomRental, "bookingID");
            txtRentCustNo.DataBindings.Add("Text", dtRoomRental, "customerID");
            txtRentRoomNo.DataBindings.Add("Text", dtRoomRental, "roomNo");
            txtRentCheckin.DataBindings.Add("Text", dtRoomRental, "checkindate");
            txtRentCheckOut.DataBindings.Add("Text", dtRoomRental, "checkoutdate");
            txtRentTotal.DataBindings.Add("Text", dtRoomRental, "totalpay");
            textBox6.DataBindings.Add("Text", dtRoomRental, "prepay");


            dgvRoomRental.DataSource = dtRoomRental;
        }
        #endregion
        //end of tab control admin.
        //-----------------------------
        private void Server_Load(object sender, EventArgs e) {
            loadAllRoom();
            loadAllRoomRental();

            loadRentData();
            txtRentBookintID.Hide();
            txtRentCheckin.Hide();
            txtRentCheckOut.Hide();
            txtRentCustNo.Hide();
            txtRentRoomNo.Hide();
            txtRentTotal.Hide();
            textBox6.Hide();
        }



        private void btnThuePhong_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showThuePhongForm));
            t.Start();
            this.Close();
        }

        private void btnDanhSachThue_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showRoomRented));
            t.Start();
            this.Close();
        }

        private void btnDanhSachPhongTrong_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showEmptyRoom));
            t.Start();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            loadAllRoom();
        }

        private void tbAdmin_Click(object sender, EventArgs e) {

        }

        private void showPaymentForm() {
            int bookingID = int.Parse(txtRentBookintID.Text);
            string CustomerID = txtRentCustNo.Text;
            string RoomNo = txtRentRoomNo.Text;
            DateTime CheckInDay = DateTime.Parse(txtRentCheckin.Text);
            DateTime CheckOutDay = DateTime.Parse(txtRentCheckOut.Text);
            float TotalPay = float.Parse(txtRentTotal.Text);
            float PrePay = float.Parse(textBox6.Text);
            Payment pay = new Payment(bookingID, CustomerID, RoomNo, CheckInDay, CheckOutDay, TotalPay, PrePay);
            Application.Run(pay);
        }


        //private void btnThuePhong_Click(object sender, EventArgs e) {
        //    this.Hide();
        //    Thread t = new Thread(new ThreadStart(showThuePhongForm));
        //    t.Start();
        //    this.Close();
        //}
        private void btnTraPhong_Click(object sender, EventArgs e) {
            //int bookingID = int.Parse(txtRentBookintID.Text);
            //string CustomerID = txtRentCustNo.Text;
            //string RoomNo = txtRentRoomNo.Text;
            //DateTime CheckInDay = DateTime.Parse(txtRentCheckin.Text);
            //DateTime CheckOutDay = DateTime.Parse(txtRentCheckOut.Text);
            //float TotalPay = float.Parse(txtRentTotal.Text);
            //float PrePay = float.Parse(textBox6.Text);
            //Payment pay = new Payment(bookingID, CustomerID, RoomNo, CheckInDay, CheckOutDay, TotalPay, PrePay);
            //pay.Show();
            this.Hide();
            Thread a = new Thread(new ThreadStart(showPaymentForm));
            a.Start();



        }
    }
}
