namespace HotelManagerment {
    partial class Server {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.bsRoom = new System.Windows.Forms.BindingSource(this.components);
            this.bsRoomRental = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbAdmin = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnPhongMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRentCustNo = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtRentTotal = new System.Windows.Forms.TextBox();
            this.txtRentCheckOut = new System.Windows.Forms.TextBox();
            this.txtRentCheckin = new System.Windows.Forms.TextBox();
            this.txtRentRoomNo = new System.Windows.Forms.TextBox();
            this.txtRentBookintID = new System.Windows.Forms.TextBox();
            this.dgvRoomRental = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDanhSachPhongTrong = new System.Windows.Forms.Button();
            this.btnDanhSachThue = new System.Windows.Forms.Button();
            this.btnDenNgayTra = new System.Windows.Forms.Button();
            this.btnDoiPhong = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.tbcServer = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoomRental)).BeginInit();
            this.tbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomRental)).BeginInit();
            this.tbcServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1181, 630);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hóa Đơn";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbAdmin
            // 
            this.tbAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbAdmin.BackgroundImage")));
            this.tbAdmin.Controls.Add(this.label5);
            this.tbAdmin.Controls.Add(this.label3);
            this.tbAdmin.Controls.Add(this.label2);
            this.tbAdmin.Controls.Add(this.label1);
            this.tbAdmin.Controls.Add(this.btnRefresh);
            this.tbAdmin.Controls.Add(this.txtGhiChu);
            this.tbAdmin.Controls.Add(this.txtGia);
            this.tbAdmin.Controls.Add(this.txtLoaiPhong);
            this.tbAdmin.Controls.Add(this.txtTenPhong);
            this.tbAdmin.Controls.Add(this.btnPhongMoi);
            this.tbAdmin.Controls.Add(this.btnXoa);
            this.tbAdmin.Controls.Add(this.btnSua);
            this.tbAdmin.Controls.Add(this.dgvRoom);
            this.tbAdmin.Location = new System.Drawing.Point(4, 22);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdmin.Size = new System.Drawing.Size(1181, 630);
            this.tbAdmin.TabIndex = 2;
            this.tbAdmin.Text = "Admin";
            this.tbAdmin.UseVisualStyleBackColor = true;
            this.tbAdmin.Click += new System.EventHandler(this.tbAdmin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(31, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Gía Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Loại Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tên Phòng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(332, 486);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 70);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Location = new System.Drawing.Point(89, 236);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 20);
            this.txtGhiChu.TabIndex = 45;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(89, 188);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 44;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Location = new System.Drawing.Point(89, 147);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiPhong.TabIndex = 43;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Enabled = false;
            this.txtTenPhong.Location = new System.Drawing.Point(89, 99);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(100, 20);
            this.txtTenPhong.TabIndex = 42;
            // 
            // btnPhongMoi
            // 
            this.btnPhongMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPhongMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongMoi.Image")));
            this.btnPhongMoi.Location = new System.Drawing.Point(528, 486);
            this.btnPhongMoi.Name = "btnPhongMoi";
            this.btnPhongMoi.Size = new System.Drawing.Size(70, 70);
            this.btnPhongMoi.TabIndex = 30;
            this.btnPhongMoi.Text = "Phòng Mới";
            this.btnPhongMoi.UseVisualStyleBackColor = true;
            this.btnPhongMoi.Click += new System.EventHandler(this.btnPhongMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(867, 486);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 70);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa Phòng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(707, 486);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 70);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa Phòng";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(220, 58);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(852, 406);
            this.dgvRoom.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1181, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dịch Vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.txtRentCustNo);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.txtRentTotal);
            this.tabPage1.Controls.Add(this.txtRentCheckOut);
            this.tabPage1.Controls.Add(this.txtRentCheckin);
            this.tabPage1.Controls.Add(this.txtRentRoomNo);
            this.tabPage1.Controls.Add(this.txtRentBookintID);
            this.tabPage1.Controls.Add(this.dgvRoomRental);
            this.tabPage1.Controls.Add(this.btnLogout);
            this.tabPage1.Controls.Add(this.btnDanhSachPhongTrong);
            this.tabPage1.Controls.Add(this.btnDanhSachThue);
            this.tabPage1.Controls.Add(this.btnDenNgayTra);
            this.tabPage1.Controls.Add(this.btnDoiPhong);
            this.tabPage1.Controls.Add(this.btnGiaHan);
            this.tabPage1.Controls.Add(this.btnTraPhong);
            this.tabPage1.Controls.Add(this.btnThuePhong);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRentCustNo
            // 
            this.txtRentCustNo.Location = new System.Drawing.Point(808, 474);
            this.txtRentCustNo.Name = "txtRentCustNo";
            this.txtRentCustNo.Size = new System.Drawing.Size(100, 20);
            this.txtRentCustNo.TabIndex = 39;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(702, 474);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 38;
            // 
            // txtRentTotal
            // 
            this.txtRentTotal.Location = new System.Drawing.Point(596, 474);
            this.txtRentTotal.Name = "txtRentTotal";
            this.txtRentTotal.Size = new System.Drawing.Size(100, 20);
            this.txtRentTotal.TabIndex = 37;
            // 
            // txtRentCheckOut
            // 
            this.txtRentCheckOut.Location = new System.Drawing.Point(490, 474);
            this.txtRentCheckOut.Name = "txtRentCheckOut";
            this.txtRentCheckOut.Size = new System.Drawing.Size(100, 20);
            this.txtRentCheckOut.TabIndex = 36;
            // 
            // txtRentCheckin
            // 
            this.txtRentCheckin.Location = new System.Drawing.Point(384, 474);
            this.txtRentCheckin.Name = "txtRentCheckin";
            this.txtRentCheckin.Size = new System.Drawing.Size(100, 20);
            this.txtRentCheckin.TabIndex = 35;
            // 
            // txtRentRoomNo
            // 
            this.txtRentRoomNo.Location = new System.Drawing.Point(278, 474);
            this.txtRentRoomNo.Name = "txtRentRoomNo";
            this.txtRentRoomNo.Size = new System.Drawing.Size(100, 20);
            this.txtRentRoomNo.TabIndex = 34;
            // 
            // txtRentBookintID
            // 
            this.txtRentBookintID.Location = new System.Drawing.Point(172, 474);
            this.txtRentBookintID.Name = "txtRentBookintID";
            this.txtRentBookintID.Size = new System.Drawing.Size(100, 20);
            this.txtRentBookintID.TabIndex = 33;
            // 
            // dgvRoomRental
            // 
            this.dgvRoomRental.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoomRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomRental.Location = new System.Drawing.Point(172, 137);
            this.dgvRoomRental.Name = "dgvRoomRental";
            this.dgvRoomRental.ReadOnly = true;
            this.dgvRoomRental.Size = new System.Drawing.Size(837, 288);
            this.dgvRoomRental.TabIndex = 32;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(839, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 67);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDanhSachPhongTrong
            // 
            this.btnDanhSachPhongTrong.Location = new System.Drawing.Point(713, 13);
            this.btnDanhSachPhongTrong.Name = "btnDanhSachPhongTrong";
            this.btnDanhSachPhongTrong.Size = new System.Drawing.Size(77, 67);
            this.btnDanhSachPhongTrong.TabIndex = 23;
            this.btnDanhSachPhongTrong.Text = "Danh Sách Phòng Trống";
            this.btnDanhSachPhongTrong.UseVisualStyleBackColor = true;
            this.btnDanhSachPhongTrong.Click += new System.EventHandler(this.btnDanhSachPhongTrong_Click);
            // 
            // btnDanhSachThue
            // 
            this.btnDanhSachThue.Location = new System.Drawing.Point(574, 13);
            this.btnDanhSachThue.Name = "btnDanhSachThue";
            this.btnDanhSachThue.Size = new System.Drawing.Size(79, 67);
            this.btnDanhSachThue.TabIndex = 22;
            this.btnDanhSachThue.Text = "Danh Sách Phòng Thuê";
            this.btnDanhSachThue.UseVisualStyleBackColor = true;
            this.btnDanhSachThue.Click += new System.EventHandler(this.btnDanhSachThue_Click);
            // 
            // btnDenNgayTra
            // 
            this.btnDenNgayTra.Location = new System.Drawing.Point(461, 13);
            this.btnDenNgayTra.Name = "btnDenNgayTra";
            this.btnDenNgayTra.Size = new System.Drawing.Size(69, 67);
            this.btnDenNgayTra.TabIndex = 21;
            this.btnDenNgayTra.Text = "Đến Ngày Sẽ Trả";
            this.btnDenNgayTra.UseVisualStyleBackColor = true;
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.Location = new System.Drawing.Point(352, 13);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Size = new System.Drawing.Size(75, 67);
            this.btnDoiPhong.TabIndex = 20;
            this.btnDoiPhong.Text = "Đổi Phòng";
            this.btnDoiPhong.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(238, 13);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(75, 67);
            this.btnGiaHan.TabIndex = 19;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(140, 13);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(75, 67);
            this.btnTraPhong.TabIndex = 18;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Location = new System.Drawing.Point(44, 13);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(75, 67);
            this.btnThuePhong.TabIndex = 17;
            this.btnThuePhong.Text = "Thuê Phòng";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // tbcServer
            // 
            this.tbcServer.Controls.Add(this.tabPage1);
            this.tbcServer.Controls.Add(this.tabPage2);
            this.tbcServer.Controls.Add(this.tbAdmin);
            this.tbcServer.Controls.Add(this.tabPage5);
            this.tbcServer.Location = new System.Drawing.Point(0, 0);
            this.tbcServer.Name = "tbcServer";
            this.tbcServer.SelectedIndex = 0;
            this.tbcServer.Size = new System.Drawing.Size(1189, 656);
            this.tbcServer.TabIndex = 0;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tbcServer);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoomRental)).EndInit();
            this.tbAdmin.ResumeLayout(false);
            this.tbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomRental)).EndInit();
            this.tbcServer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsRoom;
        private System.Windows.Forms.BindingSource bsRoomRental;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tbAdmin;
        private System.Windows.Forms.Button btnPhongMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDanhSachPhongTrong;
        private System.Windows.Forms.Button btnDanhSachThue;
        private System.Windows.Forms.Button btnDenNgayTra;
        private System.Windows.Forms.Button btnDoiPhong;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.TabControl tbcServer;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRentCustNo;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtRentTotal;
        private System.Windows.Forms.TextBox txtRentCheckOut;
        private System.Windows.Forms.TextBox txtRentCheckin;
        private System.Windows.Forms.TextBox txtRentRoomNo;
        private System.Windows.Forms.TextBox txtRentBookintID;
        private System.Windows.Forms.DataGridView dgvRoomRental;
    }
}