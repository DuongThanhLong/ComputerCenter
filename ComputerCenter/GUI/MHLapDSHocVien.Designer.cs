namespace ComputerCenter
{
    partial class MHLapDSHocVien
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
            this.lbKhoaHoc = new System.Windows.Forms.Label();
            this.lbHocPhan = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.cbbHocPhan = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.dgvDSHV = new System.Windows.Forms.DataGridView();
            this.btnDSHVThiDat = new System.Windows.Forms.Button();
            this.btnDSHVHocLai = new System.Windows.Forms.Button();
            this.dgvDSHVHocLai = new System.Windows.Forms.DataGridView();
            this.lbLanThi = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHVHocLai)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKhoaHoc
            // 
            this.lbKhoaHoc.AutoSize = true;
            this.lbKhoaHoc.Location = new System.Drawing.Point(6, 15);
            this.lbKhoaHoc.Name = "lbKhoaHoc";
            this.lbKhoaHoc.Size = new System.Drawing.Size(53, 13);
            this.lbKhoaHoc.TabIndex = 0;
            this.lbKhoaHoc.Text = "Khóa học";
            // 
            // lbHocPhan
            // 
            this.lbHocPhan.AutoSize = true;
            this.lbHocPhan.Location = new System.Drawing.Point(5, 67);
            this.lbHocPhan.Name = "lbHocPhan";
            this.lbHocPhan.Size = new System.Drawing.Size(54, 13);
            this.lbHocPhan.TabIndex = 1;
            this.lbHocPhan.Text = "Học phần";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Location = new System.Drawing.Point(414, 15);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(49, 13);
            this.lbMonHoc.TabIndex = 2;
            this.lbMonHoc.Text = "Môn học";
            // 
            // cbbHocPhan
            // 
            this.cbbHocPhan.FormattingEnabled = true;
            this.cbbHocPhan.Location = new System.Drawing.Point(65, 64);
            this.cbbHocPhan.Name = "cbbHocPhan";
            this.cbbHocPhan.Size = new System.Drawing.Size(271, 21);
            this.cbbHocPhan.TabIndex = 4;
            this.cbbHocPhan.SelectedIndexChanged += new System.EventHandler(this.cbbHocPhan_SelectedIndexChanged);
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(469, 12);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(277, 21);
            this.cbbMonHoc.TabIndex = 5;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // cbbKhoaHoc
            // 
            this.cbbKhoaHoc.FormattingEnabled = true;
            this.cbbKhoaHoc.Location = new System.Drawing.Point(65, 12);
            this.cbbKhoaHoc.Name = "cbbKhoaHoc";
            this.cbbKhoaHoc.Size = new System.Drawing.Size(271, 21);
            this.cbbKhoaHoc.TabIndex = 6;
            this.cbbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbbKhoaHoc_SelectedIndexChanged);
            // 
            // dgvDSHV
            // 
            this.dgvDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHV.Location = new System.Drawing.Point(12, 130);
            this.dgvDSHV.Name = "dgvDSHV";
            this.dgvDSHV.Size = new System.Drawing.Size(361, 261);
            this.dgvDSHV.TabIndex = 7;
            // 
            // btnDSHVThiDat
            // 
            this.btnDSHVThiDat.Location = new System.Drawing.Point(95, 415);
            this.btnDSHVThiDat.Name = "btnDSHVThiDat";
            this.btnDSHVThiDat.Size = new System.Drawing.Size(113, 23);
            this.btnDSHVThiDat.TabIndex = 8;
            this.btnDSHVThiDat.Text = "Lập DSHV thi đạt";
            this.btnDSHVThiDat.UseVisualStyleBackColor = true;
            this.btnDSHVThiDat.Click += new System.EventHandler(this.btnDSHVThiDat_Click);
            // 
            // btnDSHVHocLai
            // 
            this.btnDSHVHocLai.Location = new System.Drawing.Point(604, 415);
            this.btnDSHVHocLai.Name = "btnDSHVHocLai";
            this.btnDSHVHocLai.Size = new System.Drawing.Size(110, 23);
            this.btnDSHVHocLai.TabIndex = 9;
            this.btnDSHVHocLai.Text = "Lập DSHV học lại";
            this.btnDSHVHocLai.UseVisualStyleBackColor = true;
            this.btnDSHVHocLai.Click += new System.EventHandler(this.btnDSHVHocLai_Click);
            // 
            // dgvDSHVHocLai
            // 
            this.dgvDSHVHocLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHVHocLai.Location = new System.Drawing.Point(421, 130);
            this.dgvDSHVHocLai.Name = "dgvDSHVHocLai";
            this.dgvDSHVHocLai.Size = new System.Drawing.Size(349, 261);
            this.dgvDSHVHocLai.TabIndex = 10;
            // 
            // lbLanThi
            // 
            this.lbLanThi.AutoSize = true;
            this.lbLanThi.Location = new System.Drawing.Point(421, 67);
            this.lbLanThi.Name = "lbLanThi";
            this.lbLanThi.Size = new System.Drawing.Size(39, 13);
            this.lbLanThi.TabIndex = 11;
            this.lbLanThi.Text = "Lần thi";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(469, 64);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(121, 21);
            this.cbbLanThi.TabIndex = 12;
            // 
            // MHLapDSHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbLanThi);
            this.Controls.Add(this.lbLanThi);
            this.Controls.Add(this.dgvDSHVHocLai);
            this.Controls.Add(this.btnDSHVHocLai);
            this.Controls.Add(this.btnDSHVThiDat);
            this.Controls.Add(this.dgvDSHV);
            this.Controls.Add(this.cbbKhoaHoc);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.cbbHocPhan);
            this.Controls.Add(this.lbMonHoc);
            this.Controls.Add(this.lbHocPhan);
            this.Controls.Add(this.lbKhoaHoc);
            this.Name = "MHLapDSHocVien";
            this.Text = "MHLapDSHocVien";
            this.Load += new System.EventHandler(this.MHLapDSHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHVHocLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKhoaHoc;
        private System.Windows.Forms.Label lbHocPhan;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.ComboBox cbbHocPhan;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.ComboBox cbbKhoaHoc;
        private System.Windows.Forms.DataGridView dgvDSHV;
        private System.Windows.Forms.Button btnDSHVThiDat;
        private System.Windows.Forms.Button btnDSHVHocLai;
        private System.Windows.Forms.DataGridView dgvDSHVHocLai;
        private System.Windows.Forms.Label lbLanThi;
        private System.Windows.Forms.ComboBox cbbLanThi;
    }
}