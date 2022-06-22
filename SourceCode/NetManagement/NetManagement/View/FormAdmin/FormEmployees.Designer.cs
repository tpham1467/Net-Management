namespace NetManagement.View.FormAdmin
{
    partial class FormEmployees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbMana = new System.Windows.Forms.TabControl();
            this.tbManaEm = new System.Windows.Forms.TabPage();
            this.btnUpdateEmp = new FontAwesome.Sharp.IconButton();
            this.btnAddEmp = new FontAwesome.Sharp.IconButton();
            this.dgvManaEmployee = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbTimeKeeping = new System.Windows.Forms.TabPage();
            this.cbPay = new System.Windows.Forms.CheckBox();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.dgvShowTimeKeeping = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbPay = new System.Windows.Forms.TabPage();
            this.dgvShowPayroll = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbCosalaryEm = new System.Windows.Forms.TabPage();
            this.dgvCosalaryEm = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdateSal = new FontAwesome.Sharp.IconButton();
            this.btnAddSala = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.tbMana.SuspendLayout();
            this.tbManaEm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManaEmployee)).BeginInit();
            this.tbTimeKeeping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTimeKeeping)).BeginInit();
            this.tbPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPayroll)).BeginInit();
            this.tbCosalaryEm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosalaryEm)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSort
            // 
            this.cbbSort.DropDownWidth = 200;
            this.cbbSort.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbSort.ItemHeight = 29;
            this.cbbSort.Location = new System.Drawing.Point(1043, 29);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(192, 37);
            this.cbbSort.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cbbSearch);
            this.panel1.Controls.Add(this.cbbSort);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 90);
            this.panel1.TabIndex = 0;
            // 
            // cbbSearch
            // 
            this.cbbSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(406, 25);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(217, 38);
            this.cbbSearch.TabIndex = 11;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(302, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSort.Location = new System.Drawing.Point(917, 29);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(106, 40);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(64)))));
            this.txtSearch.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(35, 25);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(235, 41);
            this.txtSearch.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CT_icon.png");
            // 
            // tbMana
            // 
            this.tbMana.Controls.Add(this.tbManaEm);
            this.tbMana.Controls.Add(this.tbTimeKeeping);
            this.tbMana.Controls.Add(this.tbPay);
            this.tbMana.Controls.Add(this.tbCosalaryEm);
            this.tbMana.Location = new System.Drawing.Point(26, 96);
            this.tbMana.Name = "tbMana";
            this.tbMana.SelectedIndex = 0;
            this.tbMana.Size = new System.Drawing.Size(1282, 538);
            this.tbMana.TabIndex = 4;
            this.tbMana.SelectedIndexChanged += new System.EventHandler(this.tbEm_SelectedIndexChanged);
            // 
            // tbManaEm
            // 
            this.tbManaEm.BackgroundImage = global::NetManagement.Properties.Resources.btnbackground;
            this.tbManaEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbManaEm.Controls.Add(this.btnUpdateEmp);
            this.tbManaEm.Controls.Add(this.btnAddEmp);
            this.tbManaEm.Controls.Add(this.dgvManaEmployee);
            this.tbManaEm.Location = new System.Drawing.Point(4, 25);
            this.tbManaEm.Name = "tbManaEm";
            this.tbManaEm.Size = new System.Drawing.Size(1274, 509);
            this.tbManaEm.TabIndex = 2;
            this.tbManaEm.Text = "Employee Management";
            this.tbManaEm.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmp.BackgroundImage")));
            this.btnUpdateEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateEmp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateEmp.IconColor = System.Drawing.Color.Black;
            this.btnUpdateEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateEmp.Location = new System.Drawing.Point(349, 446);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(171, 44);
            this.btnUpdateEmp.TabIndex = 13;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddEmp.BackgroundImage")));
            this.btnAddEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmp.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddEmp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddEmp.IconColor = System.Drawing.Color.Black;
            this.btnAddEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEmp.Location = new System.Drawing.Point(172, 446);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(171, 44);
            this.btnAddEmp.TabIndex = 12;
            this.btnAddEmp.Text = "Add ";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // dgvManaEmployee
            // 
            this.dgvManaEmployee.AllowUserToAddRows = false;
            this.dgvManaEmployee.AllowUserToDeleteRows = false;
            this.dgvManaEmployee.AllowUserToOrderColumns = true;
            this.dgvManaEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            this.dgvManaEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvManaEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManaEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManaEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvManaEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManaEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManaEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvManaEmployee.ColumnHeadersHeight = 36;
            this.dgvManaEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManaEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn3});
            this.dgvManaEmployee.EnableHeadersVisualStyles = false;
            this.dgvManaEmployee.Location = new System.Drawing.Point(27, 13);
            this.dgvManaEmployee.Name = "dgvManaEmployee";
            this.dgvManaEmployee.RowHeadersVisible = false;
            this.dgvManaEmployee.RowHeadersWidth = 51;
            this.dgvManaEmployee.RowTemplate.Height = 40;
            this.dgvManaEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManaEmployee.Size = new System.Drawing.Size(1225, 427);
            this.dgvManaEmployee.TabIndex = 6;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 25F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::NetManagement.Properties.Resources.PayrollIcon;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // tbTimeKeeping
            // 
            this.tbTimeKeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(99)))));
            this.tbTimeKeeping.BackgroundImage = global::NetManagement.Properties.Resources.light_blue_green;
            this.tbTimeKeeping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimeKeeping.Controls.Add(this.cbPay);
            this.tbTimeKeeping.Controls.Add(this.btnPayroll);
            this.tbTimeKeeping.Controls.Add(this.dgvShowTimeKeeping);
            this.tbTimeKeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbTimeKeeping.Location = new System.Drawing.Point(4, 25);
            this.tbTimeKeeping.Name = "tbTimeKeeping";
            this.tbTimeKeeping.Padding = new System.Windows.Forms.Padding(3);
            this.tbTimeKeeping.Size = new System.Drawing.Size(1274, 509);
            this.tbTimeKeeping.TabIndex = 0;
            this.tbTimeKeeping.Text = "TimeKeeping";
            // 
            // cbPay
            // 
            this.cbPay.AutoSize = true;
            this.cbPay.BackgroundImage = global::NetManagement.Properties.Resources.light_blue_green;
            this.cbPay.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPay.Location = new System.Drawing.Point(116, 15);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(172, 31);
            this.cbPay.TabIndex = 7;
            this.cbPay.Text = "Đã chấm công";
            this.cbPay.UseVisualStyleBackColor = true;
            this.cbPay.CheckedChanged += new System.EventHandler(this.cbPay_CheckedChanged);
            // 
            // btnPayroll
            // 
            this.btnPayroll.BackgroundImage = global::NetManagement.Properties.Resources.btnbackground;
            this.btnPayroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayroll.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.Maroon;
            this.btnPayroll.Image = global::NetManagement.Properties.Resources.payroll1;
            this.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.Location = new System.Drawing.Point(566, 443);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPayroll.Size = new System.Drawing.Size(165, 63);
            this.btnPayroll.TabIndex = 6;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayroll.UseVisualStyleBackColor = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // dgvShowTimeKeeping
            // 
            this.dgvShowTimeKeeping.AllowUserToAddRows = false;
            this.dgvShowTimeKeeping.AllowUserToDeleteRows = false;
            this.dgvShowTimeKeeping.AllowUserToOrderColumns = true;
            this.dgvShowTimeKeeping.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Silver;
            this.dgvShowTimeKeeping.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvShowTimeKeeping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowTimeKeeping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowTimeKeeping.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvShowTimeKeeping.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowTimeKeeping.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowTimeKeeping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvShowTimeKeeping.ColumnHeadersHeight = 36;
            this.dgvShowTimeKeeping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowTimeKeeping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.dgvShowTimeKeeping.EnableHeadersVisualStyles = false;
            this.dgvShowTimeKeeping.Location = new System.Drawing.Point(44, 52);
            this.dgvShowTimeKeeping.Name = "dgvShowTimeKeeping";
            this.dgvShowTimeKeeping.RowHeadersVisible = false;
            this.dgvShowTimeKeeping.RowHeadersWidth = 51;
            this.dgvShowTimeKeeping.RowTemplate.Height = 40;
            this.dgvShowTimeKeeping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowTimeKeeping.Size = new System.Drawing.Size(1193, 388);
            this.dgvShowTimeKeeping.TabIndex = 4;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 25F;
            this.Column8.HeaderText = "";
            this.Column8.Image = global::NetManagement.Properties.Resources.Timekeeping;
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // tbPay
            // 
            this.tbPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(99)))));
            this.tbPay.BackgroundImage = global::NetManagement.Properties.Resources.light_blue_green;
            this.tbPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPay.Controls.Add(this.dgvShowPayroll);
            this.tbPay.Location = new System.Drawing.Point(4, 25);
            this.tbPay.Name = "tbPay";
            this.tbPay.Size = new System.Drawing.Size(1274, 509);
            this.tbPay.TabIndex = 1;
            this.tbPay.Text = "Payroll";
            // 
            // dgvShowPayroll
            // 
            this.dgvShowPayroll.AllowUserToAddRows = false;
            this.dgvShowPayroll.AllowUserToDeleteRows = false;
            this.dgvShowPayroll.AllowUserToOrderColumns = true;
            this.dgvShowPayroll.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Silver;
            this.dgvShowPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvShowPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowPayroll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvShowPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvShowPayroll.ColumnHeadersHeight = 36;
            this.dgvShowPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgvShowPayroll.EnableHeadersVisualStyles = false;
            this.dgvShowPayroll.Location = new System.Drawing.Point(47, 18);
            this.dgvShowPayroll.Name = "dgvShowPayroll";
            this.dgvShowPayroll.RowHeadersVisible = false;
            this.dgvShowPayroll.RowHeadersWidth = 51;
            this.dgvShowPayroll.RowTemplate.Height = 40;
            this.dgvShowPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowPayroll.Size = new System.Drawing.Size(1183, 466);
            this.dgvShowPayroll.TabIndex = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 25F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::NetManagement.Properties.Resources.PayrollIcon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 25F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::NetManagement.Properties.Resources.PayrollIcon;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 1246;
            // 
            // tbCosalaryEm
            // 
            this.tbCosalaryEm.BackgroundImage = global::NetManagement.Properties.Resources.btnbackground;
            this.tbCosalaryEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCosalaryEm.Controls.Add(this.btnUpdateSal);
            this.tbCosalaryEm.Controls.Add(this.btnAddSala);
            this.tbCosalaryEm.Controls.Add(this.dgvCosalaryEm);
            this.tbCosalaryEm.Location = new System.Drawing.Point(4, 25);
            this.tbCosalaryEm.Name = "tbCosalaryEm";
            this.tbCosalaryEm.Padding = new System.Windows.Forms.Padding(3);
            this.tbCosalaryEm.Size = new System.Drawing.Size(1274, 509);
            this.tbCosalaryEm.TabIndex = 3;
            this.tbCosalaryEm.Text = "CoSalary Employee";
            this.tbCosalaryEm.UseVisualStyleBackColor = true;
            // 
            // dgvCosalaryEm
            // 
            this.dgvCosalaryEm.AllowUserToAddRows = false;
            this.dgvCosalaryEm.AllowUserToDeleteRows = false;
            this.dgvCosalaryEm.AllowUserToOrderColumns = true;
            this.dgvCosalaryEm.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
            this.dgvCosalaryEm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCosalaryEm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCosalaryEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCosalaryEm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvCosalaryEm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCosalaryEm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCosalaryEm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCosalaryEm.ColumnHeadersHeight = 36;
            this.dgvCosalaryEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCosalaryEm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn4});
            this.dgvCosalaryEm.EnableHeadersVisualStyles = false;
            this.dgvCosalaryEm.Location = new System.Drawing.Point(30, 6);
            this.dgvCosalaryEm.Name = "dgvCosalaryEm";
            this.dgvCosalaryEm.RowHeadersVisible = false;
            this.dgvCosalaryEm.RowHeadersWidth = 51;
            this.dgvCosalaryEm.RowTemplate.Height = 40;
            this.dgvCosalaryEm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCosalaryEm.Size = new System.Drawing.Size(1225, 427);
            this.dgvCosalaryEm.TabIndex = 7;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.FillWeight = 25F;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::NetManagement.Properties.Resources.PayrollIcon;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 6;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // btnUpdateSal
            // 
            this.btnUpdateSal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateSal.IconColor = System.Drawing.Color.Black;
            this.btnUpdateSal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateSal.Location = new System.Drawing.Point(262, 449);
            this.btnUpdateSal.Name = "btnUpdateSal";
            this.btnUpdateSal.Size = new System.Drawing.Size(171, 44);
            this.btnUpdateSal.TabIndex = 12;
            this.btnUpdateSal.Text = "Update";
            this.btnUpdateSal.UseVisualStyleBackColor = true;
            this.btnUpdateSal.Click += new System.EventHandler(this.btnUpdateSal_Click);
            // 
            // btnAddSala
            // 
            this.btnAddSala.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddSala.IconColor = System.Drawing.Color.Black;
            this.btnAddSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSala.Location = new System.Drawing.Point(85, 449);
            this.btnAddSala.Name = "btnAddSala";
            this.btnAddSala.Size = new System.Drawing.Size(171, 44);
            this.btnAddSala.TabIndex = 11;
            this.btnAddSala.Text = "Add ";
            this.btnAddSala.UseVisualStyleBackColor = true;
            this.btnAddSala.Click += new System.EventHandler(this.btnAddSala_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1323, 646);
            this.Controls.Add(this.tbMana);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbMana.ResumeLayout(false);
            this.tbManaEm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManaEmployee)).EndInit();
            this.tbTimeKeeping.ResumeLayout(false);
            this.tbTimeKeeping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTimeKeeping)).EndInit();
            this.tbPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPayroll)).EndInit();
            this.tbCosalaryEm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosalaryEm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.TabPage tbTimeKeeping;
        private System.Windows.Forms.DataGridView dgvShowTimeKeeping;
        private System.Windows.Forms.TabControl tbMana;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TabPage tbPay;
        private System.Windows.Forms.DataGridView dgvShowPayroll;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.CheckBox cbPay;
        private System.Windows.Forms.TabPage tbManaEm;
        private FontAwesome.Sharp.IconButton btnUpdateEmp;
        private FontAwesome.Sharp.IconButton btnAddEmp;
        private System.Windows.Forms.DataGridView dgvManaEmployee;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.TabPage tbCosalaryEm;
        private FontAwesome.Sharp.IconButton btnUpdateSal;
        private FontAwesome.Sharp.IconButton btnAddSala;
        private System.Windows.Forms.DataGridView dgvCosalaryEm;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
    }
}