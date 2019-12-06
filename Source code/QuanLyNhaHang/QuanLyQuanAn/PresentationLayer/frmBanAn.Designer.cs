namespace QuanLyQuanAn.PresentationLayer
{
    partial class frmBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanAn));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvtable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.cmbarea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvarea = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxtenkv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsua2 = new System.Windows.Forms.Button();
            this.btnhuy2 = new System.Windows.Forms.Button();
            this.btnthem2 = new System.Windows.Forms.Button();
            this.btnthoat2 = new System.Windows.Forms.Button();
            this.btnluu2 = new System.Windows.Forms.Button();
            this.btnxoa2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtable)).BeginInit();
            this.pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarea)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvtable);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pnl);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvtable
            // 
            this.dgvtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dgvtable.Location = new System.Drawing.Point(6, 186);
            this.dgvtable.Name = "dgvtable";
            this.dgvtable.RowHeadersWidth = 51;
            this.dgvtable.RowTemplate.Height = 24;
            this.dgvtable.Size = new System.Drawing.Size(912, 253);
            this.dgvtable.TabIndex = 24;
            this.dgvtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtable_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDTABLE";
            this.Column1.HeaderText = "Mã bàn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NAME";
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IDAREA";
            this.Column4.HeaderText = "Mã KV";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NAME1";
            this.Column5.HeaderText = "Khu vực";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "STATUS";
            this.Column3.HeaderText = "Trạng thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Set up Bàn ăn";
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.cmbarea);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.tbxname);
            this.pnl.Controls.Add(this.lb);
            this.pnl.Location = new System.Drawing.Point(6, 49);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(912, 50);
            this.pnl.TabIndex = 22;
            // 
            // cmbarea
            // 
            this.cmbarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbarea.FormattingEnabled = true;
            this.cmbarea.Location = new System.Drawing.Point(509, 13);
            this.cmbarea.Name = "cmbarea";
            this.cmbarea.Size = new System.Drawing.Size(278, 28);
            this.cmbarea.TabIndex = 2;
            this.cmbarea.SelectedIndexChanged += new System.EventHandler(this.cmbarea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Khu vực:";
            // 
            // tbxname
            // 
            this.tbxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxname.Location = new System.Drawing.Point(101, 14);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(251, 26);
            this.tbxname.TabIndex = 1;
            this.tbxname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(21, 17);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(74, 20);
            this.lb.TabIndex = 4;
            this.lb.Text = "Tên bàn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Location = new System.Drawing.Point(11, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 75);
            this.panel1.TabIndex = 21;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(165, 20);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(97, 38);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(633, 20);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(93, 38);
            this.btnhuy.TabIndex = 14;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(20, 20);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 38);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(789, 20);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(95, 38);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(318, 20);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(93, 38);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(477, 20);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(97, 38);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvarea);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Area";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvarea
            // 
            this.dgvarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvarea.Location = new System.Drawing.Point(11, 188);
            this.dgvarea.Name = "dgvarea";
            this.dgvarea.RowHeadersWidth = 51;
            this.dgvarea.RowTemplate.Height = 24;
            this.dgvarea.Size = new System.Drawing.Size(916, 253);
            this.dgvarea.TabIndex = 24;
            this.dgvarea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarea_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Khu vực";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Khu vực";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxtenkv);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(11, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 50);
            this.panel2.TabIndex = 22;
            // 
            // tbxtenkv
            // 
            this.tbxtenkv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtenkv.Location = new System.Drawing.Point(106, 12);
            this.tbxtenkv.Name = "tbxtenkv";
            this.tbxtenkv.Size = new System.Drawing.Size(349, 26);
            this.tbxtenkv.TabIndex = 7;
            this.tbxtenkv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên KV:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnsua2);
            this.panel3.Controls.Add(this.btnhuy2);
            this.panel3.Controls.Add(this.btnthem2);
            this.panel3.Controls.Add(this.btnthoat2);
            this.panel3.Controls.Add(this.btnluu2);
            this.panel3.Controls.Add(this.btnxoa2);
            this.panel3.Location = new System.Drawing.Point(16, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 75);
            this.panel3.TabIndex = 21;
            // 
            // btnsua2
            // 
            this.btnsua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua2.Location = new System.Drawing.Point(167, 18);
            this.btnsua2.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua2.Name = "btnsua2";
            this.btnsua2.Size = new System.Drawing.Size(97, 38);
            this.btnsua2.TabIndex = 11;
            this.btnsua2.Text = "Sửa";
            this.btnsua2.UseVisualStyleBackColor = true;
            this.btnsua2.Click += new System.EventHandler(this.btnsua2_Click);
            // 
            // btnhuy2
            // 
            this.btnhuy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy2.Location = new System.Drawing.Point(635, 18);
            this.btnhuy2.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuy2.Name = "btnhuy2";
            this.btnhuy2.Size = new System.Drawing.Size(93, 38);
            this.btnhuy2.TabIndex = 14;
            this.btnhuy2.Text = "Hủy";
            this.btnhuy2.UseVisualStyleBackColor = true;
            this.btnhuy2.Click += new System.EventHandler(this.btnhuy2_Click);
            // 
            // btnthem2
            // 
            this.btnthem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem2.Location = new System.Drawing.Point(15, 18);
            this.btnthem2.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(93, 38);
            this.btnthem2.TabIndex = 10;
            this.btnthem2.Text = "Thêm";
            this.btnthem2.UseVisualStyleBackColor = true;
            this.btnthem2.Click += new System.EventHandler(this.btnthem2_Click);
            // 
            // btnthoat2
            // 
            this.btnthoat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat2.Location = new System.Drawing.Point(785, 18);
            this.btnthoat2.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat2.Name = "btnthoat2";
            this.btnthoat2.Size = new System.Drawing.Size(95, 38);
            this.btnthoat2.TabIndex = 15;
            this.btnthoat2.Text = "Thoát";
            this.btnthoat2.UseVisualStyleBackColor = true;
            this.btnthoat2.Click += new System.EventHandler(this.btnthoat2_Click);
            // 
            // btnluu2
            // 
            this.btnluu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu2.Location = new System.Drawing.Point(327, 18);
            this.btnluu2.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu2.Name = "btnluu2";
            this.btnluu2.Size = new System.Drawing.Size(93, 38);
            this.btnluu2.TabIndex = 12;
            this.btnluu2.Text = "Lưu";
            this.btnluu2.UseVisualStyleBackColor = true;
            this.btnluu2.Click += new System.EventHandler(this.btnluu2_Click);
            // 
            // btnxoa2
            // 
            this.btnxoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa2.Location = new System.Drawing.Point(474, 18);
            this.btnxoa2.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa2.Name = "btnxoa2";
            this.btnxoa2.Size = new System.Drawing.Size(97, 38);
            this.btnxoa2.TabIndex = 13;
            this.btnxoa2.Text = "Xóa";
            this.btnxoa2.UseVisualStyleBackColor = true;
            this.btnxoa2.Click += new System.EventHandler(this.btnxoa2_Click);
            // 
            // frmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(965, 502);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin bàn ăn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtable)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarea)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ComboBox cmbarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxtenkv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsua2;
        private System.Windows.Forms.Button btnhuy2;
        private System.Windows.Forms.Button btnthem2;
        private System.Windows.Forms.Button btnthoat2;
        private System.Windows.Forms.Button btnluu2;
        private System.Windows.Forms.Button btnxoa2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}