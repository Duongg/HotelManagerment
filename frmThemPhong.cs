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
    public partial class frmThemPhong : Form {
        public frmThemPhong() {
            InitializeComponent();
        }
        RoomData dataRoom = new RoomData();
      

        private void btnThemMoi_Click(object sender, EventArgs e) {
            try {
                string tenPhong = txtTenPhong.Text;
                string loaiPhong = txtLoaiPhong.Text;
                float giaPhong = float.Parse(txtGia.Text);
                bool trangthai = true;
                string ghichu = txtGhiChu.Text;
                Room room = new Room(tenPhong, loaiPhong, giaPhong, trangthai, ghichu);

                if (txtTenPhong.Text.Length == 0 || txtGia.Text.Length == 0 || txtLoaiPhong.Text.Length == 0) {
                    MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin Phòng!");
                }
                try {
                    if (dataRoom.AddNewRoom(room)) {
                        MessageBox.Show("Thêm Phòng Mới Thành Công!");
                    } else {
                        MessageBox.Show("Thêm Phòng Mới Không Thành Công!");
                    }
                } catch (Exception) {
                    MessageBox.Show("Phòng đã tồn tại");
                }
            } catch (Exception) {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!");
            }
            Server sv = new Server();
            sv.loadAllRoom();

        }


        

        private void txtTenPhong_Leave_1(object sender, EventArgs e) {
            if (txtTenPhong.Text.Length == 0) {
                MessageBox.Show("Vui Lòng Nhập Tên Phòng!");
               
            }
        }

        private void txtLoaiPhong_Leave(object sender, EventArgs e) {
            if (txtLoaiPhong.Text.Length == 0) {
                MessageBox.Show("Vui Lòng Nhập Loại Phòng!");
             
            }
        }

        private void txtGia_Leave(object sender, EventArgs e) {
            try {
                if (float.Parse(txtGia.Text) < 0) {
                    MessageBox.Show("Gía Phòng Không Hợp Lệ");
                   
                }
            } catch (Exception) {

                MessageBox.Show("Gía Phòng Là Một Số");
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();            
        }
    }
}
