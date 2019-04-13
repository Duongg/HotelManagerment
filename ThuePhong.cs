using HotelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerment {
    public partial class ThuePhong : Form {
        public ThuePhong() {
            InitializeComponent();
        }

        float cost = 0;
        Boolean khachQuen = false;
        RoomAccess data = new RoomAccess();


        public void caculteMoney() {
            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;

            int days = diff.Days + 1;
            
            if (days <= 0) {
                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker2.Value = DateTime.Today;
                txtTotal.Text = "ERROR";
                return;
            }
            else
                txtTotal.Text = Convert.ToString(days * cost);
        }

        
        private void btnThuePhong_Click(object sender, EventArgs e) {
            
          
        }
     

        private void ThuePhong_Load(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            dt = data.loadRoomType();
            cbxLoaiPhong.DisplayMember = "roomtype";
            cbxLoaiPhong.DataSource = dt;
            caculteMoney();
        }

        private void cbxMaPhong_SelectedIndexChanged(object sender, EventArgs e) {
            

        }
        private void showServer() {
            Server server = new Server();
            Application.Run(server);
        }
        private void btnHuy_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showServer));
            t.Start();
            this.Close();
        }

        private void cbxLoaiPhong_SelectedIndexChanged(object sender, EventArgs e) {
            string loaiPhong = cbxLoaiPhong.GetItemText(cbxLoaiPhong.SelectedItem);
            RoomAccess data = new RoomAccess();
            DataTable dt = new DataTable();
            dt = data.loadIDCost(loaiPhong);
            cbxMaPhong.DisplayMember = "roomno";
            cbxMaPhong.DataSource = dt;
            cbxtienPhong.DisplayMember = "price";
            cbxtienPhong.DataSource = dt;
            txtCostPerDay.Text = cbxtienPhong.GetItemText(cbxtienPhong.SelectedItem);
            cost = float.Parse(txtCostPerDay.Text);
            caculteMoney();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            caculteMoney();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {
            caculteMoney();
        }

        private void btnThuePhong_Click_1(object sender, EventArgs e) {
            try {
                if (khachQuen) {
                    string customerID = txtCMND.Text;
                    string roomNo = cbxMaPhong.GetItemText(cbxMaPhong.SelectedItem);
                    string username = txtTenKhachHang.Text;
                    DateTime checkInDay = dateTimePicker1.Value;
                    DateTime checkOutDay = dateTimePicker2.Value;
                    float totalPay = float.Parse(txtTotal.Text);
                    float prePay = float.Parse(txtTraTruoc.Text);
                    BookingRoom book1 = new BookingRoom(customerID, roomNo, username, checkInDay, checkOutDay, totalPay, prePay);
                    bool result1 = data.checkinKhachQuen(book1, txtCMND.Text);
                    if (result1) {
                        MessageBox.Show("Thuê Phòng Thành Công");
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(showServerForm));
                        t.Start();
                        this.Close();
                    } else {
                        MessageBox.Show("Không Thành Công");
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(showServerForm));
                        t.Start();
                        this.Close();
                    }
                } else {
                    string customerID = txtCMND.Text;
                    string roomNo = cbxMaPhong.GetItemText(cbxMaPhong.SelectedItem);
                    string username = txtTenKhachHang.Text;
                    DateTime checkInDay = dateTimePicker1.Value;
                    DateTime checkOutDay = dateTimePicker2.Value;
                    float totalPay = float.Parse(txtTotal.Text);
                    float prePay = float.Parse(txtTraTruoc.Text);

                    BookingRoom book2 = new BookingRoom(customerID, roomNo, username, checkInDay, checkOutDay, totalPay, prePay);
                    Customer cus = new Customer(txtCMND.Text, txtTenKhachHang.Text, txtSoDienThoai.Text, dateTimePicker3.Value);
                    bool result2 = data.checkin(cus, book2);
                    if (result2) {
                        MessageBox.Show("Thành Công");
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(showServerForm));
                        t.Start();
                        this.Close();
                    } else {
                        MessageBox.Show("Không Thành Công");
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(showServerForm));
                        t.Start();
                        this.Close();
                    }
                }
            } catch (Exception) {

                MessageBox.Show("Vui Lòng thử lại");
            }
            

        }

        private void txtCMND_Leave(object sender, EventArgs e) {
            Customer customer = data.getCustomer(txtCMND.Text);
            if (customer != null) {
                MessageBox.Show("Thành Công");
                txtTenKhachHang.Text = customer.customerName;
                txtSoDienThoai.Text = customer.phone;
                dateTimePicker3.Value = customer.birthday;
                khachQuen = true;
                return;
            }
        }

        private void showServerForm() {
            Server tp = new Server();
            Application.Run(tp);
        }

        private void btnHuy_Click_1(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showServerForm));
            t.Start();
            this.Close();
        }

        private void txtTraTruoc_Leave(object sender, EventArgs e) {
            try {
                if (float.Parse(txtTraTruoc.Text) < 0) {
                    MessageBox.Show("Gía Phòng Không Hợp Lệ");

                }
            } catch (Exception) {

                MessageBox.Show("Gía Phòng Là Một Số");

            }
        }
    }
}
