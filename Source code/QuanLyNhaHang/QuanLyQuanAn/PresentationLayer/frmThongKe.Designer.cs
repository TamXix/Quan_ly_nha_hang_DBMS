namespace QuanLyQuanAn.PresentationLayer
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.dgvdetails = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxten = new System.Windows.Forms.TextBox();
            this.tbxvoucher = new System.Windows.Forms.TextBox();
            this.sidbill = new System.Windows.Forms.Button();
            this.stenban = new System.Windows.Forms.Button();
            this.skhuvuc = new System.Windows.Forms.Button();
            this.sdenluc = new System.Windows.Forms.Button();
            this.sgiamgia = new System.Windows.Forms.Button();
            this.stongtien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvthongke
            // 
            this.dgvthongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvthongke.Location = new System.Drawing.Point(12, 193);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.RowHeadersWidth = 51;
            this.dgvthongke.RowTemplate.Height = 24;
            this.dgvthongke.Size = new System.Drawing.Size(969, 485);
            this.dgvthongke.TabIndex = 0;
            this.dgvthongke.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthongke_CellClick);
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "IDBILL";
            this.Column11.HeaderText = "ID Bill";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenban";
            this.Column1.HeaderText = "Tên bàn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "khuvuc";
            this.Column2.HeaderText = "Khu vực";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tgden";
            this.Column3.HeaderText = "Đến lúc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tgdi";
            this.Column4.HeaderText = "Đi lúc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DISCOUNT";
            this.Column5.HeaderText = "Giảm giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TOTAL";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê thu nhập";
            // 
            // datefrom
            // 
            this.datefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefrom.Location = new System.Drawing.Point(22, 39);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(352, 30);
            this.datefrom.TabIndex = 1;
            this.datefrom.Value = new System.DateTime(2019, 5, 6, 16, 32, 2, 0);
            // 
            // dateto
            // 
            this.dateto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateto.Location = new System.Drawing.Point(586, 39);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(350, 30);
            this.dateto.TabIndex = 2;
            this.dateto.Value = new System.DateTime(2019, 5, 6, 16, 32, 2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "To:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.datefrom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnxem);
            this.panel1.Controls.Add(this.dateto);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 100);
            this.panel1.TabIndex = 7;
            // 
            // btnxem
            // 
            this.btnxem.BackColor = System.Drawing.Color.Ivory;
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.ForeColor = System.Drawing.Color.Maroon;
            this.btnxem.Location = new System.Drawing.Point(421, 39);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(133, 41);
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "View";
            this.btnxem.UseVisualStyleBackColor = false;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click_1);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Ivory;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.Maroon;
            this.btnnext.Location = new System.Drawing.Point(844, 697);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(133, 41);
            this.btnnext.TabIndex = 12;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click_1);
            // 
            // btnpre
            // 
            this.btnpre.BackColor = System.Drawing.Color.Ivory;
            this.btnpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpre.ForeColor = System.Drawing.Color.Maroon;
            this.btnpre.Location = new System.Drawing.Point(25, 697);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(133, 41);
            this.btnpre.TabIndex = 11;
            this.btnpre.Text = "Previous";
            this.btnpre.UseVisualStyleBackColor = false;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click_1);
            // 
            // btnchitiet
            // 
            this.btnchitiet.BackColor = System.Drawing.Color.Ivory;
            this.btnchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchitiet.ForeColor = System.Drawing.Color.Maroon;
            this.btnchitiet.Location = new System.Drawing.Point(382, 697);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(232, 41);
            this.btnchitiet.TabIndex = 13;
            this.btnchitiet.Text = "Chi tiết hóa đơn";
            this.btnchitiet.UseVisualStyleBackColor = false;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // dgvdetails
            // 
            this.dgvdetails.ColumnHeadersHeight = 29;
            this.dgvdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvdetails.Location = new System.Drawing.Point(987, 157);
            this.dgvdetails.Name = "dgvdetails";
            this.dgvdetails.RowHeadersWidth = 51;
            this.dgvdetails.RowTemplate.Height = 24;
            this.dgvdetails.Size = new System.Drawing.Size(546, 236);
            this.dgvdetails.TabIndex = 14;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tenmon";
            this.Column7.HeaderText = "Tên món";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PRICE";
            this.Column8.HeaderText = "Giá";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "COUNT";
            this.Column9.HeaderText = "Số lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "total";
            this.Column10.HeaderText = "Tổng";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1095, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chi tiết hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1095, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "Thông tin chung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(986, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(986, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Loại voucher:";
            // 
            // tbxten
            // 
            this.tbxten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxten.Location = new System.Drawing.Point(1155, 529);
            this.tbxten.Name = "tbxten";
            this.tbxten.ReadOnly = true;
            this.tbxten.Size = new System.Drawing.Size(361, 30);
            this.tbxten.TabIndex = 20;
            // 
            // tbxvoucher
            // 
            this.tbxvoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxvoucher.Location = new System.Drawing.Point(1155, 582);
            this.tbxvoucher.Name = "tbxvoucher";
            this.tbxvoucher.ReadOnly = true;
            this.tbxvoucher.Size = new System.Drawing.Size(361, 30);
            this.tbxvoucher.TabIndex = 21;
            // 
            // sidbill
            // 
            this.sidbill.BackColor = System.Drawing.Color.OldLace;
            this.sidbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidbill.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sidbill.Location = new System.Drawing.Point(79, 157);
            this.sidbill.Name = "sidbill";
            this.sidbill.Size = new System.Drawing.Size(105, 30);
            this.sidbill.TabIndex = 4;
            this.sidbill.Text = "Sort";
            this.sidbill.UseVisualStyleBackColor = false;
            this.sidbill.Click += new System.EventHandler(this.sidbill_Click);
            // 
            // stenban
            // 
            this.stenban.BackColor = System.Drawing.Color.OldLace;
            this.stenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stenban.ForeColor = System.Drawing.Color.SaddleBrown;
            this.stenban.Location = new System.Drawing.Point(208, 157);
            this.stenban.Name = "stenban";
            this.stenban.Size = new System.Drawing.Size(105, 30);
            this.stenban.TabIndex = 5;
            this.stenban.Text = "Sort";
            this.stenban.UseVisualStyleBackColor = false;
            this.stenban.Click += new System.EventHandler(this.stenban_Click);
            // 
            // skhuvuc
            // 
            this.skhuvuc.BackColor = System.Drawing.Color.OldLace;
            this.skhuvuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skhuvuc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.skhuvuc.Location = new System.Drawing.Point(341, 157);
            this.skhuvuc.Name = "skhuvuc";
            this.skhuvuc.Size = new System.Drawing.Size(105, 30);
            this.skhuvuc.TabIndex = 6;
            this.skhuvuc.Text = "Sort";
            this.skhuvuc.UseVisualStyleBackColor = false;
            this.skhuvuc.Click += new System.EventHandler(this.skhuvuc_Click);
            // 
            // sdenluc
            // 
            this.sdenluc.BackColor = System.Drawing.Color.OldLace;
            this.sdenluc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdenluc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sdenluc.Location = new System.Drawing.Point(470, 157);
            this.sdenluc.Name = "sdenluc";
            this.sdenluc.Size = new System.Drawing.Size(105, 30);
            this.sdenluc.TabIndex = 7;
            this.sdenluc.Text = "Sort";
            this.sdenluc.UseVisualStyleBackColor = false;
            this.sdenluc.Click += new System.EventHandler(this.sdenluc_Click);
            // 
            // sgiamgia
            // 
            this.sgiamgia.BackColor = System.Drawing.Color.OldLace;
            this.sgiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgiamgia.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sgiamgia.Location = new System.Drawing.Point(735, 157);
            this.sgiamgia.Name = "sgiamgia";
            this.sgiamgia.Size = new System.Drawing.Size(105, 30);
            this.sgiamgia.TabIndex = 8;
            this.sgiamgia.Text = "Sort";
            this.sgiamgia.UseVisualStyleBackColor = false;
            this.sgiamgia.Click += new System.EventHandler(this.sgiamgia_Click);
            // 
            // stongtien
            // 
            this.stongtien.BackColor = System.Drawing.Color.OldLace;
            this.stongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stongtien.ForeColor = System.Drawing.Color.SaddleBrown;
            this.stongtien.Location = new System.Drawing.Point(862, 157);
            this.stongtien.Name = "stongtien";
            this.stongtien.Size = new System.Drawing.Size(105, 30);
            this.stongtien.TabIndex = 9;
            this.stongtien.Text = "Sort";
            this.stongtien.UseVisualStyleBackColor = false;
            this.stongtien.Click += new System.EventHandler(this.stongtien_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1555, 750);
            this.Controls.Add(this.stongtien);
            this.Controls.Add(this.sgiamgia);
            this.Controls.Add(this.sdenluc);
            this.Controls.Add(this.skhuvuc);
            this.Controls.Add(this.stenban);
            this.Controls.Add(this.sidbill);
            this.Controls.Add(this.tbxvoucher);
            this.Controls.Add(this.tbxten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvdetails);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvthongke);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.DataGridView dgvdetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox tbxten;
        private System.Windows.Forms.TextBox tbxvoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button sidbill;
        private System.Windows.Forms.Button stenban;
        private System.Windows.Forms.Button skhuvuc;
        private System.Windows.Forms.Button sdenluc;
        private System.Windows.Forms.Button sgiamgia;
        private System.Windows.Forms.Button stongtien;
    }
}