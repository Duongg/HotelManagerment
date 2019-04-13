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
    public partial class frmEmptyRoom : Form {
        public frmEmptyRoom() {
            InitializeComponent();
        }
        RoomData roomData = new RoomData();
        DataTable dtEmptyRoom = new DataTable();
        private void showServer() {
            Server server = new Server();
            Application.Run(server);
        }
        private void frmEmptyRoom_Load(object sender, EventArgs e) {
            loadEmptyRoom();
        }
        private void loadEmptyRoom() {
            dtEmptyRoom = roomData.getAllEmptyRoom();
            bsEmptyRoom.DataSource = dtEmptyRoom;
            dgvEmptyRoom.DataSource = bsEmptyRoom;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showServer));
            t.Start();
            this.Close();
        }
    }
}
