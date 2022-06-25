namespace NetManagement.View.FormAdmin
{
    partial class FormCustommer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustommer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbSortProperty = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSortby = new System.Windows.Forms.ComboBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabHisUsed = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvHUse = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbCusMana = new System.Windows.Forms.TabPage();
            this.dgvShowCus = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbMana = new System.Windows.Forms.TabControl();
            this.tabOrderHis = new System.Windows.Forms.TabPage();
            this.cbbTypeView = new System.Windows.Forms.ComboBox();
            this.lbView = new System.Windows.Forms.Label();
            this.dgvOrHis = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tabHisUsed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHUse)).BeginInit();
            this.tbCusMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCus)).BeginInit();
            this.tbMana.SuspendLayout();
            this.tabOrderHis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrHis)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSortProperty
            // 
            this.cbbSortProperty.DropDownWidth = 200;
            this.cbbSortProperty.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortProperty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbSortProperty.ItemHeight = 29;
            this.cbbSortProperty.Location = new System.Drawing.Point(1112, 30);
            this.cbbSortProperty.Name = "cbbSortProperty";
            this.cbbSortProperty.Size = new System.Drawing.Size(192, 37);
            this.cbbSortProperty.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cbbSortby);
            this.panel1.Controls.Add(this.cbbSortProperty);
            this.panel1.Controls.Add(this.cbbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 90);
            this.panel1.TabIndex = 0;
            // 
            // cbbSortby
            // 
            this.cbbSortby.DropDownWidth = 200;
            this.cbbSortby.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortby.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbSortby.ItemHeight = 29;
            this.cbbSortby.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.cbbSortby.Location = new System.Drawing.Point(997, 29);
            this.cbbSortby.Name = "cbbSortby";
            this.cbbSortby.Size = new System.Drawing.Size(90, 37);
            this.cbbSortby.TabIndex = 13;
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownWidth = 200;
            this.cbbSearch.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbSearch.ItemHeight = 29;
            this.cbbSearch.Location = new System.Drawing.Point(414, 29);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(192, 37);
            this.cbbSearch.TabIndex = 11;
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
            this.btnSort.Location = new System.Drawing.Point(863, 29);
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
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(35, 25);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(235, 41);
            this.txtSearch.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUp.Location = new System.Drawing.Point(810, 452);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(106, 40);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(288, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "AddCustomer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CT_icon.png");
            // 
            // tabHisUsed
            // 
            this.tabHisUsed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(99)))));
            this.tabHisUsed.Controls.Add(this.btnDel);
            this.tabHisUsed.Controls.Add(this.dgvHUse);
            this.tabHisUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabHisUsed.Location = new System.Drawing.Point(4, 25);
            this.tabHisUsed.Name = "tabHisUsed";
            this.tabHisUsed.Padding = new System.Windows.Forms.Padding(3);
            this.tabHisUsed.Size = new System.Drawing.Size(1274, 509);
            this.tabHisUsed.TabIndex = 1;
            this.tabHisUsed.Text = "History Used";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDel.Location = new System.Drawing.Point(484, 453);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(165, 40);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // dgvHUse
            // 
            this.dgvHUse.AllowUserToAddRows = false;
            this.dgvHUse.AllowUserToDeleteRows = false;
            this.dgvHUse.AllowUserToOrderColumns = true;
            this.dgvHUse.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.dgvHUse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHUse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHUse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHUse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvHUse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHUse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHUse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHUse.ColumnHeadersHeight = 36;
            this.dgvHUse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHUse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgvHUse.EnableHeadersVisualStyles = false;
            this.dgvHUse.Location = new System.Drawing.Point(14, 6);
            this.dgvHUse.Name = "dgvHUse";
            this.dgvHUse.RowHeadersVisible = false;
            this.dgvHUse.RowHeadersWidth = 51;
            this.dgvHUse.RowTemplate.Height = 40;
            this.dgvHUse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHUse.Size = new System.Drawing.Size(1244, 430);
            this.dgvHUse.TabIndex = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::NetManagement.Properties.Resources.HistoryUsed;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // tbCusMana
            // 
            this.tbCusMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(99)))));
            this.tbCusMana.Controls.Add(this.dgvShowCus);
            this.tbCusMana.Controls.Add(this.btnAdd);
            this.tbCusMana.Controls.Add(this.btnUp);
            this.tbCusMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbCusMana.Location = new System.Drawing.Point(4, 25);
            this.tbCusMana.Name = "tbCusMana";
            this.tbCusMana.Padding = new System.Windows.Forms.Padding(3);
            this.tbCusMana.Size = new System.Drawing.Size(1274, 509);
            this.tbCusMana.TabIndex = 0;
            this.tbCusMana.Text = "Customer Management";
            // 
            // dgvShowCus
            // 
            this.dgvShowCus.AllowUserToAddRows = false;
            this.dgvShowCus.AllowUserToDeleteRows = false;
            this.dgvShowCus.AllowUserToOrderColumns = true;
            this.dgvShowCus.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            this.dgvShowCus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvShowCus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowCus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvShowCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowCus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowCus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvShowCus.ColumnHeadersHeight = 36;
            this.dgvShowCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.dgvShowCus.EnableHeadersVisualStyles = false;
            this.dgvShowCus.Location = new System.Drawing.Point(14, 6);
            this.dgvShowCus.Name = "dgvShowCus";
            this.dgvShowCus.RowHeadersVisible = false;
            this.dgvShowCus.RowHeadersWidth = 51;
            this.dgvShowCus.RowTemplate.Height = 40;
            this.dgvShowCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowCus.Size = new System.Drawing.Size(1247, 428);
            this.dgvShowCus.TabIndex = 4;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 30F;
            this.Column8.HeaderText = "";
            this.Column8.Image = global::NetManagement.Properties.Resources.customer_management;
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // tbMana
            // 
            this.tbMana.Controls.Add(this.tbCusMana);
            this.tbMana.Controls.Add(this.tabHisUsed);
            this.tbMana.Controls.Add(this.tabOrderHis);
            this.tbMana.Location = new System.Drawing.Point(26, 96);
            this.tbMana.Name = "tbMana";
            this.tbMana.SelectedIndex = 0;
            this.tbMana.Size = new System.Drawing.Size(1282, 538);
            this.tbMana.TabIndex = 4;
            this.tbMana.SelectedIndexChanged += new System.EventHandler(this.tbMana_SelectedIndexChanged);
            // 
            // tabOrderHis
            // 
            this.tabOrderHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(99)))));
            this.tabOrderHis.Controls.Add(this.cbbTypeView);
            this.tabOrderHis.Controls.Add(this.lbView);
            this.tabOrderHis.Controls.Add(this.dgvOrHis);
            this.tabOrderHis.Location = new System.Drawing.Point(4, 25);
            this.tabOrderHis.Name = "tabOrderHis";
            this.tabOrderHis.Size = new System.Drawing.Size(1274, 509);
            this.tabOrderHis.TabIndex = 2;
            this.tabOrderHis.Text = "Order History";
            // 
            // cbbTypeView
            // 
            this.cbbTypeView.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeView.ForeColor = System.Drawing.Color.Salmon;
            this.cbbTypeView.FormattingEnabled = true;
            this.cbbTypeView.Location = new System.Drawing.Point(306, 13);
            this.cbbTypeView.Name = "cbbTypeView";
            this.cbbTypeView.Size = new System.Drawing.Size(174, 33);
            this.cbbTypeView.TabIndex = 7;
            this.cbbTypeView.SelectedIndexChanged += new System.EventHandler(this.cbbTypeView_SelectedIndexChanged);
            // 
            // lbView
            // 
            this.lbView.AutoSize = true;
            this.lbView.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView.ForeColor = System.Drawing.Color.Salmon;
            this.lbView.Location = new System.Drawing.Point(10, 16);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(279, 25);
            this.lbView.TabIndex = 6;
            this.lbView.Text = "Xem Theo Loại Sản Phẩm";
            // 
            // dgvOrHis
            // 
            this.dgvOrHis.AllowUserToAddRows = false;
            this.dgvOrHis.AllowUserToDeleteRows = false;
            this.dgvOrHis.AllowUserToOrderColumns = true;
            this.dgvOrHis.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            this.dgvOrHis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrHis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrHis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrHis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvOrHis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrHis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrHis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrHis.ColumnHeadersHeight = 36;
            this.dgvOrHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrHis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2});
            this.dgvOrHis.EnableHeadersVisualStyles = false;
            this.dgvOrHis.Location = new System.Drawing.Point(15, 62);
            this.dgvOrHis.Name = "dgvOrHis";
            this.dgvOrHis.RowHeadersVisible = false;
            this.dgvOrHis.RowHeadersWidth = 51;
            this.dgvOrHis.RowTemplate.Height = 40;
            this.dgvOrHis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrHis.Size = new System.Drawing.Size(1247, 434);
            this.dgvOrHis.TabIndex = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 30F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::NetManagement.Properties.Resources.OrderHistory;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 30F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::NetManagement.Properties.Resources.customer_management;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 1246;
            // 
            // FormCustommer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1323, 646);
            this.Controls.Add(this.tbMana);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustommer";
            this.Text = "FormEmployees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabHisUsed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHUse)).EndInit();
            this.tbCusMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCus)).EndInit();
            this.tbMana.ResumeLayout(false);
            this.tabOrderHis.ResumeLayout(false);
            this.tabOrderHis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrHis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbbSortProperty;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TabPage tabHisUsed;
        private System.Windows.Forms.DataGridView dgvHUse;
        private System.Windows.Forms.TabPage tbCusMana;
        private System.Windows.Forms.DataGridView dgvShowCus;
        private System.Windows.Forms.TabControl tbMana;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TabPage tabOrderHis;
        private System.Windows.Forms.DataGridView dgvOrHis;
        private System.Windows.Forms.ComboBox cbbTypeView;
        private System.Windows.Forms.Label lbView;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox cbbSortby;
    }
}