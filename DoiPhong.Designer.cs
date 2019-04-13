namespace HotelManagerment {
    partial class DoiPhong {
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDoiPhong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxLoaiPhongMuonDoi = new System.Windows.Forms.ComboBox();
            this.cbxMaPhongMuonDoi = new System.Windows.Forms.ComboBox();
            this.cbxPhongHienTai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(405, 297);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.Location = new System.Drawing.Point(145, 297);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Size = new System.Drawing.Size(75, 23);
            this.btnDoiPhong.TabIndex = 16;
            this.btnDoiPhong.Text = "Đổi Phòng";
            this.btnDoiPhong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã Phòng Muốn Đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại phòng muốn đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phòng Hiện Tại";
            // 
            // cbxLoaiPhongMuonDoi
            // 
            this.cbxLoaiPhongMuonDoi.FormattingEnabled = true;
            this.cbxLoaiPhongMuonDoi.Location = new System.Drawing.Point(403, 139);
            this.cbxLoaiPhongMuonDoi.Name = "cbxLoaiPhongMuonDoi";
            this.cbxLoaiPhongMuonDoi.Size = new System.Drawing.Size(121, 21);
            this.cbxLoaiPhongMuonDoi.TabIndex = 12;
            // 
            // cbxMaPhongMuonDoi
            // 
            this.cbxMaPhongMuonDoi.FormattingEnabled = true;
            this.cbxMaPhongMuonDoi.Location = new System.Drawing.Point(403, 224);
            this.cbxMaPhongMuonDoi.Name = "cbxMaPhongMuonDoi";
            this.cbxMaPhongMuonDoi.Size = new System.Drawing.Size(121, 21);
            this.cbxMaPhongMuonDoi.TabIndex = 11;
            // 
            // cbxPhongHienTai
            // 
            this.cbxPhongHienTai.FormattingEnabled = true;
            this.cbxPhongHienTai.Location = new System.Drawing.Point(69, 139);
            this.cbxPhongHienTai.Name = "cbxPhongHienTai";
            this.cbxPhongHienTai.Size = new System.Drawing.Size(121, 21);
            this.cbxPhongHienTai.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đổi Phòng";
            // 
            // DoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 387);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDoiPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxLoaiPhongMuonDoi);
            this.Controls.Add(this.cbxMaPhongMuonDoi);
            this.Controls.Add(this.cbxPhongHienTai);
            this.Controls.Add(this.label1);
            this.Name = "DoiPhong";
            this.Text = "DoiPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDoiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxLoaiPhongMuonDoi;
        private System.Windows.Forms.ComboBox cbxMaPhongMuonDoi;
        private System.Windows.Forms.ComboBox cbxPhongHienTai;
        private System.Windows.Forms.Label label1;
    }
}