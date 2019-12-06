namespace QuanLyQuanAn.PresentationLayer
{
    partial class frmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxtienthuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbcalam = new System.Windows.Forms.ComboBox();
            this.cmbcongviec = new System.Windows.Forms.ComboBox();
            this.tbxluongthang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rabNu = new System.Windows.Forms.RadioButton();
            this.rabNam = new System.Windows.Forms.RadioButton();
            this.tbxsdt = new System.Windows.Forms.TextBox();
            this.tbxten = new System.Windows.Forms.TextBox();
            this.tbxcmnd = new System.Windows.Forms.TextBox();
            this.tbxdiachi = new System.Windows.Forms.TextBox();
            this.tbxma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.Button();
            this.sname = new System.Windows.Forms.Button();
            this.sgioitinh = new System.Windows.Forms.Button();
            this.sns = new System.Windows.Forms.Button();
            this.sngaylam = new System.Windows.Forms.Button();
            this.svitri = new System.Windows.Forms.Button();
            this.scalam = new System.Windows.Forms.Button();
            this.stienthuong = new System.Windows.Forms.Button();
            this.sluong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column4,
            this.Column10,
            this.Column8,
            this.Column12,
            this.Column11,
            this.Column9});
            this.dgvNV.Location = new System.Drawing.Point(12, 385);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(1448, 376);
            this.dgvNV.TabIndex = 50;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDEMPLOYEE";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "empname";
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SEX";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IDENTITYCARD";
            this.Column5.HeaderText = "Số CMND";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PHONENUMBER";
            this.Column7.HeaderText = "Số Điện Thoại";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ADDRESS";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DATEOFBIRTH";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "STARTDAY";
            this.Column10.HeaderText = "Ngày làm";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "WorkName";
            this.Column8.HeaderText = "Vị trí";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "CaLam";
            this.Column12.HeaderText = "Ca làm";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "BONUS";
            this.Column11.HeaderText = "Tiền thưởng";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TongLuong";
            this.Column9.HeaderText = "Lương Tháng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.OldLace;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnthem.Location = new System.Drawing.Point(126, 280);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 46);
            this.btnthem.TabIndex = 20;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.OldLace;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnxoa.Location = new System.Drawing.Point(545, 280);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(138, 46);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.OldLace;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnluu.Location = new System.Drawing.Point(765, 280);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(138, 46);
            this.btnluu.TabIndex = 23;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.OldLace;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnhuy.Location = new System.Drawing.Point(973, 280);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(138, 46);
            this.btnhuy.TabIndex = 24;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.OldLace;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnsua.Location = new System.Drawing.Point(336, 280);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(138, 46);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.OldLace;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnthoat.Location = new System.Drawing.Point(1173, 280);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(138, 46);
            this.btnthoat.TabIndex = 25;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxtienthuong);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbcalam);
            this.panel1.Controls.Add(this.cmbcongviec);
            this.panel1.Controls.Add(this.tbxluongthang);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpngaybatdau);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtpngaysinh);
            this.panel1.Controls.Add(this.rabNu);
            this.panel1.Controls.Add(this.rabNam);
            this.panel1.Controls.Add(this.tbxsdt);
            this.panel1.Controls.Add(this.tbxten);
            this.panel1.Controls.Add(this.tbxcmnd);
            this.panel1.Controls.Add(this.tbxdiachi);
            this.panel1.Controls.Add(this.tbxma);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(68, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 232);
            this.panel1.TabIndex = 29;
            // 
            // tbxtienthuong
            // 
            this.tbxtienthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtienthuong.Location = new System.Drawing.Point(1073, 130);
            this.tbxtienthuong.Name = "tbxtienthuong";
            this.tbxtienthuong.Size = new System.Drawing.Size(219, 30);
            this.tbxtienthuong.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(926, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 27);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tiền thưởng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(941, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 27);
            this.label13.TabIndex = 37;
            this.label13.Text = "Ca làm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(926, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 27);
            this.label12.TabIndex = 36;
            this.label12.Text = "Công việc:";
            // 
            // cmbcalam
            // 
            this.cmbcalam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcalam.FormattingEnabled = true;
            this.cmbcalam.Items.AddRange(new object[] {
            "Ca Sáng",
            "Ca Chiều",
            "Ca Tối"});
            this.cmbcalam.Location = new System.Drawing.Point(1073, 81);
            this.cmbcalam.Name = "cmbcalam";
            this.cmbcalam.Size = new System.Drawing.Size(219, 33);
            this.cmbcalam.TabIndex = 11;
            this.cmbcalam.SelectedIndexChanged += new System.EventHandler(this.cmbcalam_SelectedIndexChanged);
            // 
            // cmbcongviec
            // 
            this.cmbcongviec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcongviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcongviec.FormattingEnabled = true;
            this.cmbcongviec.Location = new System.Drawing.Point(1073, 27);
            this.cmbcongviec.Name = "cmbcongviec";
            this.cmbcongviec.Size = new System.Drawing.Size(219, 33);
            this.cmbcongviec.TabIndex = 10;
            this.cmbcongviec.SelectedIndexChanged += new System.EventHandler(this.cmbcongviec_SelectedIndexChanged);
            // 
            // tbxluongthang
            // 
            this.tbxluongthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxluongthang.Location = new System.Drawing.Point(1073, 176);
            this.tbxluongthang.Name = "tbxluongthang";
            this.tbxluongthang.ReadOnly = true;
            this.tbxluongthang.Size = new System.Drawing.Size(219, 30);
            this.tbxluongthang.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(926, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tổng lương:";
            // 
            // dtpngaybatdau
            // 
            this.dtpngaybatdau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaybatdau.Location = new System.Drawing.Point(650, 130);
            this.dtpngaybatdau.Name = "dtpngaybatdau";
            this.dtpngaybatdau.Size = new System.Drawing.Size(233, 28);
            this.dtpngaybatdau.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(475, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "Ngày bắt đầu:";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(650, 81);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(233, 28);
            this.dtpngaysinh.TabIndex = 7;
            // 
            // rabNu
            // 
            this.rabNu.AutoSize = true;
            this.rabNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabNu.Location = new System.Drawing.Point(342, 129);
            this.rabNu.Name = "rabNu";
            this.rabNu.Size = new System.Drawing.Size(58, 29);
            this.rabNu.TabIndex = 4;
            this.rabNu.TabStop = true;
            this.rabNu.Text = "Nữ";
            this.rabNu.UseVisualStyleBackColor = true;
            // 
            // rabNam
            // 
            this.rabNam.AutoSize = true;
            this.rabNam.Checked = true;
            this.rabNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabNam.Location = new System.Drawing.Point(209, 128);
            this.rabNam.Name = "rabNam";
            this.rabNam.Size = new System.Drawing.Size(74, 29);
            this.rabNam.TabIndex = 3;
            this.rabNam.TabStop = true;
            this.rabNam.Text = "Nam";
            this.rabNam.UseVisualStyleBackColor = true;
            // 
            // tbxsdt
            // 
            this.tbxsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsdt.Location = new System.Drawing.Point(649, 177);
            this.tbxsdt.Name = "tbxsdt";
            this.tbxsdt.Size = new System.Drawing.Size(236, 30);
            this.tbxsdt.TabIndex = 9;
            // 
            // tbxten
            // 
            this.tbxten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxten.Location = new System.Drawing.Point(209, 78);
            this.tbxten.Name = "tbxten";
            this.tbxten.Size = new System.Drawing.Size(227, 30);
            this.tbxten.TabIndex = 2;
            // 
            // tbxcmnd
            // 
            this.tbxcmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxcmnd.Location = new System.Drawing.Point(209, 177);
            this.tbxcmnd.Name = "tbxcmnd";
            this.tbxcmnd.Size = new System.Drawing.Size(227, 30);
            this.tbxcmnd.TabIndex = 5;
            // 
            // tbxdiachi
            // 
            this.tbxdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxdiachi.Location = new System.Drawing.Point(650, 30);
            this.tbxdiachi.Name = "tbxdiachi";
            this.tbxdiachi.Size = new System.Drawing.Size(233, 30);
            this.tbxdiachi.TabIndex = 6;
            // 
            // tbxma
            // 
            this.tbxma.Enabled = false;
            this.tbxma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxma.Location = new System.Drawing.Point(209, 27);
            this.tbxma.Name = "tbxma";
            this.tbxma.Size = new System.Drawing.Size(227, 30);
            this.tbxma.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(477, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 27);
            this.label8.TabIndex = 28;
            this.label8.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(504, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 27);
            this.label7.TabIndex = 27;
            this.label7.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã nhân viên:";
            // 
            // sid
            // 
            this.sid.BackColor = System.Drawing.Color.OldLace;
            this.sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sid.Location = new System.Drawing.Point(68, 349);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(105, 30);
            this.sid.TabIndex = 30;
            this.sid.Text = "Sort";
            this.sid.UseVisualStyleBackColor = false;
            this.sid.Click += new System.EventHandler(this.sid_Click);
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.Color.OldLace;
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sname.Location = new System.Drawing.Point(188, 349);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(105, 30);
            this.sname.TabIndex = 31;
            this.sname.Text = "Sort";
            this.sname.UseVisualStyleBackColor = false;
            this.sname.Click += new System.EventHandler(this.sname_Click);
            // 
            // sgioitinh
            // 
            this.sgioitinh.BackColor = System.Drawing.Color.OldLace;
            this.sgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgioitinh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sgioitinh.Location = new System.Drawing.Point(299, 349);
            this.sgioitinh.Name = "sgioitinh";
            this.sgioitinh.Size = new System.Drawing.Size(105, 30);
            this.sgioitinh.TabIndex = 32;
            this.sgioitinh.Text = "Sort";
            this.sgioitinh.UseVisualStyleBackColor = false;
            this.sgioitinh.Click += new System.EventHandler(this.sgioitinh_Click);
            // 
            // sns
            // 
            this.sns.BackColor = System.Drawing.Color.OldLace;
            this.sns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sns.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sns.Location = new System.Drawing.Point(765, 349);
            this.sns.Name = "sns";
            this.sns.Size = new System.Drawing.Size(105, 30);
            this.sns.TabIndex = 33;
            this.sns.Text = "Sort";
            this.sns.UseVisualStyleBackColor = false;
            this.sns.Click += new System.EventHandler(this.sns_Click);
            // 
            // sngaylam
            // 
            this.sngaylam.BackColor = System.Drawing.Color.OldLace;
            this.sngaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sngaylam.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sngaylam.Location = new System.Drawing.Point(886, 349);
            this.sngaylam.Name = "sngaylam";
            this.sngaylam.Size = new System.Drawing.Size(105, 30);
            this.sngaylam.TabIndex = 34;
            this.sngaylam.Text = "Sort";
            this.sngaylam.UseVisualStyleBackColor = false;
            this.sngaylam.Click += new System.EventHandler(this.sngaylam_Click);
            // 
            // svitri
            // 
            this.svitri.BackColor = System.Drawing.Color.OldLace;
            this.svitri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svitri.ForeColor = System.Drawing.Color.SaddleBrown;
            this.svitri.Location = new System.Drawing.Point(999, 349);
            this.svitri.Name = "svitri";
            this.svitri.Size = new System.Drawing.Size(105, 30);
            this.svitri.TabIndex = 35;
            this.svitri.Text = "Sort";
            this.svitri.UseVisualStyleBackColor = false;
            this.svitri.Click += new System.EventHandler(this.svitri_Click);
            // 
            // scalam
            // 
            this.scalam.BackColor = System.Drawing.Color.OldLace;
            this.scalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalam.ForeColor = System.Drawing.Color.SaddleBrown;
            this.scalam.Location = new System.Drawing.Point(1110, 349);
            this.scalam.Name = "scalam";
            this.scalam.Size = new System.Drawing.Size(105, 30);
            this.scalam.TabIndex = 36;
            this.scalam.Text = "Sort";
            this.scalam.UseVisualStyleBackColor = false;
            this.scalam.Click += new System.EventHandler(this.scalam_Click);
            // 
            // stienthuong
            // 
            this.stienthuong.BackColor = System.Drawing.Color.OldLace;
            this.stienthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stienthuong.ForeColor = System.Drawing.Color.SaddleBrown;
            this.stienthuong.Location = new System.Drawing.Point(1232, 349);
            this.stienthuong.Name = "stienthuong";
            this.stienthuong.Size = new System.Drawing.Size(105, 30);
            this.stienthuong.TabIndex = 37;
            this.stienthuong.Text = "Sort";
            this.stienthuong.UseVisualStyleBackColor = false;
            this.stienthuong.Click += new System.EventHandler(this.stienthuong_Click);
            // 
            // sluong
            // 
            this.sluong.BackColor = System.Drawing.Color.OldLace;
            this.sluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sluong.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sluong.Location = new System.Drawing.Point(1343, 349);
            this.sluong.Name = "sluong";
            this.sluong.Size = new System.Drawing.Size(105, 30);
            this.sluong.TabIndex = 38;
            this.sluong.Text = "Sort";
            this.sluong.UseVisualStyleBackColor = false;
            this.sluong.Click += new System.EventHandler(this.sluong_Click);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1472, 770);
            this.Controls.Add(this.sluong);
            this.Controls.Add(this.stienthuong);
            this.Controls.Add(this.scalam);
            this.Controls.Add(this.svitri);
            this.Controls.Add(this.sngaylam);
            this.Controls.Add(this.sns);
            this.Controls.Add(this.sgioitinh);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.RadioButton rabNu;
        private System.Windows.Forms.RadioButton rabNam;
        private System.Windows.Forms.TextBox tbxsdt;
        private System.Windows.Forms.TextBox tbxten;
        private System.Windows.Forms.TextBox tbxcmnd;
        private System.Windows.Forms.TextBox tbxdiachi;
        private System.Windows.Forms.TextBox tbxma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxluongthang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpngaybatdau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxtienthuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbcalam;
        private System.Windows.Forms.ComboBox cmbcongviec;
        private System.Windows.Forms.Button sid;
        private System.Windows.Forms.Button sname;
        private System.Windows.Forms.Button sgioitinh;
        private System.Windows.Forms.Button sns;
        private System.Windows.Forms.Button sngaylam;
        private System.Windows.Forms.Button svitri;
        private System.Windows.Forms.Button scalam;
        private System.Windows.Forms.Button stienthuong;
        private System.Windows.Forms.Button sluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}