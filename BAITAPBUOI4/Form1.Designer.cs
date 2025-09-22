namespace BAITAPBUOI4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltuade = new System.Windows.Forms.Label();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.lblma = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblgt = new System.Windows.Forms.Label();
            this.lblchuyennganh = new System.Windows.Forms.Label();
            this.lbldtb = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.rdonam = new System.Windows.Forms.RadioButton();
            this.rdonu = new System.Windows.Forms.RadioButton();
            this.cmbchuyennganh = new System.Windows.Forms.ComboBox();
            this.btnthemsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvhs = new System.Windows.Forms.DataGridView();
            this.lbltongnam = new System.Windows.Forms.Label();
            this.lbltongnu = new System.Windows.Forms.Label();
            this.txttongnam = new System.Windows.Forms.TextBox();
            this.txttongnu = new System.Windows.Forms.TextBox();
            this.lbltong = new System.Windows.Forms.Label();
            this.grbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltuade
            // 
            this.lbltuade.AutoSize = true;
            this.lbltuade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltuade.ForeColor = System.Drawing.Color.Navy;
            this.lbltuade.Location = new System.Drawing.Point(334, 9);
            this.lbltuade.Name = "lbltuade";
            this.lbltuade.Size = new System.Drawing.Size(491, 39);
            this.lbltuade.TabIndex = 0;
            this.lbltuade.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.cmbchuyennganh);
            this.grbthongtin.Controls.Add(this.rdonu);
            this.grbthongtin.Controls.Add(this.rdonam);
            this.grbthongtin.Controls.Add(this.txtdtb);
            this.grbthongtin.Controls.Add(this.txthoten);
            this.grbthongtin.Controls.Add(this.txtma);
            this.grbthongtin.Controls.Add(this.lblchuyennganh);
            this.grbthongtin.Controls.Add(this.lbldtb);
            this.grbthongtin.Controls.Add(this.lblgt);
            this.grbthongtin.Controls.Add(this.lblhoten);
            this.grbthongtin.Controls.Add(this.lblma);
            this.grbthongtin.Location = new System.Drawing.Point(31, 75);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(329, 219);
            this.grbthongtin.TabIndex = 1;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông Tin Sinh Viên";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(18, 35);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(85, 16);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã Sinh Viên";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(18, 75);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 16);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Họ Tên";
            // 
            // lblgt
            // 
            this.lblgt.AutoSize = true;
            this.lblgt.Location = new System.Drawing.Point(18, 110);
            this.lblgt.Name = "lblgt";
            this.lblgt.Size = new System.Drawing.Size(60, 16);
            this.lblgt.TabIndex = 0;
            this.lblgt.Text = "Giới Tính";
            // 
            // lblchuyennganh
            // 
            this.lblchuyennganh.AutoSize = true;
            this.lblchuyennganh.Location = new System.Drawing.Point(18, 181);
            this.lblchuyennganh.Name = "lblchuyennganh";
            this.lblchuyennganh.Size = new System.Drawing.Size(95, 16);
            this.lblchuyennganh.TabIndex = 0;
            this.lblchuyennganh.Text = "Chuyên Ngành";
            // 
            // lbldtb
            // 
            this.lbldtb.AutoSize = true;
            this.lbldtb.Location = new System.Drawing.Point(18, 147);
            this.lbldtb.Name = "lbldtb";
            this.lbldtb.Size = new System.Drawing.Size(59, 16);
            this.lbldtb.TabIndex = 0;
            this.lbldtb.Text = "Điểm TB";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(123, 28);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(200, 22);
            this.txtma.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(123, 72);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(200, 22);
            this.txthoten.TabIndex = 1;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(123, 144);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(100, 22);
            this.txtdtb.TabIndex = 1;
            // 
            // rdonam
            // 
            this.rdonam.AutoSize = true;
            this.rdonam.Location = new System.Drawing.Point(123, 110);
            this.rdonam.Name = "rdonam";
            this.rdonam.Size = new System.Drawing.Size(57, 20);
            this.rdonam.TabIndex = 2;
            this.rdonam.TabStop = true;
            this.rdonam.Text = "Nam";
            this.rdonam.UseVisualStyleBackColor = true;
            // 
            // rdonu
            // 
            this.rdonu.AutoSize = true;
            this.rdonu.Location = new System.Drawing.Point(225, 110);
            this.rdonu.Name = "rdonu";
            this.rdonu.Size = new System.Drawing.Size(45, 20);
            this.rdonu.TabIndex = 2;
            this.rdonu.TabStop = true;
            this.rdonu.Text = "Nữ";
            this.rdonu.UseVisualStyleBackColor = true;
            // 
            // cmbchuyennganh
            // 
            this.cmbchuyennganh.BackColor = System.Drawing.Color.Silver;
            this.cmbchuyennganh.FormattingEnabled = true;
            this.cmbchuyennganh.Location = new System.Drawing.Point(123, 181);
            this.cmbchuyennganh.Name = "cmbchuyennganh";
            this.cmbchuyennganh.Size = new System.Drawing.Size(200, 24);
            this.cmbchuyennganh.TabIndex = 3;
            // 
            // btnthemsua
            // 
            this.btnthemsua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnthemsua.Location = new System.Drawing.Point(154, 313);
            this.btnthemsua.Name = "btnthemsua";
            this.btnthemsua.Size = new System.Drawing.Size(115, 30);
            this.btnthemsua.TabIndex = 2;
            this.btnthemsua.Text = "Thêm / Sửa";
            this.btnthemsua.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnxoa.Location = new System.Drawing.Point(276, 313);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(84, 30);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // dgvhs
            // 
            this.dgvhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhs.Location = new System.Drawing.Point(390, 75);
            this.dgvhs.Name = "dgvhs";
            this.dgvhs.RowHeadersWidth = 51;
            this.dgvhs.RowTemplate.Height = 24;
            this.dgvhs.Size = new System.Drawing.Size(675, 268);
            this.dgvhs.TabIndex = 3;
            // 
            // lbltongnam
            // 
            this.lbltongnam.AutoSize = true;
            this.lbltongnam.Location = new System.Drawing.Point(678, 357);
            this.lbltongnam.Name = "lbltongnam";
            this.lbltongnam.Size = new System.Drawing.Size(85, 16);
            this.lbltongnam.TabIndex = 0;
            this.lbltongnam.Text = "Mã Sinh Viên";
            // 
            // lbltongnu
            // 
            this.lbltongnu.AutoSize = true;
            this.lbltongnu.Location = new System.Drawing.Point(875, 357);
            this.lbltongnu.Name = "lbltongnu";
            this.lbltongnu.Size = new System.Drawing.Size(85, 16);
            this.lbltongnu.TabIndex = 0;
            this.lbltongnu.Text = "Mã Sinh Viên";
            // 
            // txttongnam
            // 
            this.txttongnam.Location = new System.Drawing.Point(769, 354);
            this.txttongnam.Name = "txttongnam";
            this.txttongnam.Size = new System.Drawing.Size(100, 22);
            this.txttongnam.TabIndex = 1;
            // 
            // txttongnu
            // 
            this.txttongnu.Location = new System.Drawing.Point(966, 354);
            this.txttongnu.Name = "txttongnu";
            this.txttongnu.Size = new System.Drawing.Size(100, 22);
            this.txttongnu.TabIndex = 1;
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Location = new System.Drawing.Point(587, 357);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(85, 16);
            this.lbltong.TabIndex = 0;
            this.lbltong.Text = "Mã Sinh Viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 399);
            this.Controls.Add(this.dgvhs);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthemsua);
            this.Controls.Add(this.txttongnu);
            this.Controls.Add(this.txttongnam);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.lbltuade);
            this.Controls.Add(this.lbltongnu);
            this.Controls.Add(this.lbltong);
            this.Controls.Add(this.lbltongnam);
            this.Name = "Form1";
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltuade;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Label lblchuyennganh;
        private System.Windows.Forms.Label lbldtb;
        private System.Windows.Forms.Label lblgt;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.ComboBox cmbchuyennganh;
        private System.Windows.Forms.RadioButton rdonu;
        private System.Windows.Forms.RadioButton rdonam;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btnthemsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvhs;
        private System.Windows.Forms.Label lbltongnam;
        private System.Windows.Forms.Label lbltongnu;
        private System.Windows.Forms.TextBox txttongnam;
        private System.Windows.Forms.TextBox txttongnu;
        private System.Windows.Forms.Label lbltong;
    }
}

