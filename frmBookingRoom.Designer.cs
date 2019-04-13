namespace HotelManagerment {
    partial class frmBookingRoom {
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
            this.dgvRoomRented = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.bsRoomRented = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoomRented)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomRented
            // 
            this.dgvRoomRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomRented.Location = new System.Drawing.Point(32, 28);
            this.dgvRoomRented.Name = "dgvRoomRented";
            this.dgvRoomRented.ReadOnly = true;
            this.dgvRoomRented.Size = new System.Drawing.Size(567, 299);
            this.dgvRoomRented.TabIndex = 0;
            this.dgvRoomRented.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomRented_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(260, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 377);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvRoomRented);
            this.Name = "frmBookingRoom";
            this.Text = "frmRoomRented";
            this.Load += new System.EventHandler(this.frmRoomRented_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoomRented)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomRented;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource bsRoomRented;
    }
}