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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        Account acc = new Account();
        private void showAdminServerForm(int result) {
            Server sr = new Server(result);
            Application.Run(sr);

        }
    
        
        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0) {
                MessageBox.Show("Tên Tài khoản hoặc Mật khẩu không được để trống");
                txtUsername.Focus();
                return;
            }
            string uid = txtUsername.Text;
            string pwd = txtPassword.Text;
            int result = -1;
            result = acc.checkLogin(uid, pwd);
            if (result == 1 || result == 0) { 
                this.Hide();
                Thread t = new Thread(() => showAdminServerForm(result));
                t.Start();
                this.Close();
            
            } else {
                MessageBox.Show("Tên Tài khoản hoặc Mật khẩu không đúng");
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
