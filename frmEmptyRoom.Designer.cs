﻿namespace HotelManagerment {
    partial class frmEmptyRoom {
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
            this.dgvEmptyRoom = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.bsEmptyRoom = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmptyRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmptyRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmptyRoom
            // 
            this.dgvEmptyRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmptyRoom.Location = new System.Drawing.Point(39, 12);
            this.dgvEmptyRoom.Name = "dgvEmptyRoom";
            this.dgvEmptyRoom.Size = new System.Drawing.Size(557, 291);
            this.dgvEmptyRoom.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmptyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 391);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvEmptyRoom);
            this.Name = "frmEmptyRoom";
            this.Text = "frmEmptyRoom";
            this.Load += new System.EventHandler(this.frmEmptyRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmptyRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmptyRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmptyRoom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource bsEmptyRoom;
    }
}