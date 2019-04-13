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
    public partial class frmBookingRoom : Form {
        public frmBookingRoom() {
            InitializeComponent();
        }
        RoomData roomData = new RoomData();
        DataTable dtRoomRented;
        private void showServer() {
            Server server = new Server();
            Application.Run(server);
        }
        private void loadRoomRented() {
            dtRoomRented = roomData.getAllRoomRented();
            bsRoomRented.DataSource = dtRoomRented;
            dgvRoomRented.DataSource = bsRoomRented;
        }
        private void frmRoomRented_Load(object sender, EventArgs e) {
            loadRoomRented();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showServer));
            t.Start();
            this.Close();
        }

        private void dgvRoomRented_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
