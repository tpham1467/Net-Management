namespace NetManagement.View.FormAdmin
{
    partial class FormCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSortby = new System.Windows.Forms.ComboBox();
            this.cbbSortProperty = new System.Windows.Forms.ComboBox();
            this.btnSortCTR = new System.Windows.Forms.Button();
            this.btnUpCTR = new System.Windows.Forms.Button();
            this.btnDelCTR = new System.Windows.Forms.Button();
            this.btnAddCTR = new System.Windows.Forms.Button();
            this.tbCategory = new System.Windows.Forms.TabControl();
            this.tbCategoryMana = new System.Windows.Forms.TabPage();
            this.dgvShowCTR = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbUnitMana = new System.Windows.Forms.TabPage();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tbCategory.SuspendLayout();
            this.tbCategoryMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCTR)).BeginInit();
            this.tbUnitMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cbbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 90);
            this.panel1.TabIndex = 4;
            // 
            // cbbSearch
            // 
            this.cbbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(425, 27);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(163, 37);
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
            this.btnSearch.Size = new System.Drawing.Size(110, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAll.Location = new System.Drawing.Point(1180, 26);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(83, 40);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(64)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSearch.Location = new System.Drawing.Point(24, 26);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 40);
            this.txtSearch.TabIndex = 1;
            // 
            // cbbSortby
            // 
            this.cbbSortby.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortby.FormattingEnabled = true;
            this.cbbSortby.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.cbbSortby.Location = new System.Drawing.Point(930, 415);
            this.cbbSortby.Name = "cbbSortby";
            this.cbbSortby.Size = new System.Drawing.Size(121, 40);
            this.cbbSortby.TabIndex = 11;
            // 
            // cbbSortProperty
            // 
            this.cbbSortProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortProperty.FormattingEnabled = true;
            this.cbbSortProperty.Location = new System.Drawing.Point(1037, 415);
            this.cbbSortProperty.Name = "cbbSortProperty";
            this.cbbSortProperty.Size = new System.Drawing.Size(163, 37);
            this.cbbSortProperty.TabIndex = 10;
            // 
            // btnSortCTR
            // 
            this.btnSortCTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSortCTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortCTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSortCTR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSortCTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortCTR.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortCTR.Location = new System.Drawing.Point(758, 412);
            this.btnSortCTR.Name = "btnSortCTR";
            this.btnSortCTR.Size = new System.Drawing.Size(102, 40);
            this.btnSortCTR.TabIndex = 9;
            this.btnSortCTR.Text = "Sort";
            this.btnSortCTR.UseVisualStyleBackColor = false;
            this.btnSortCTR.Click += new System.EventHandler(this.btnSortCTR_Click);
            // 
            // btnUpCTR
            // 
            this.btnUpCTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnUpCTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpCTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpCTR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpCTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpCTR.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpCTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpCTR.Location = new System.Drawing.Point(573, 412);
            this.btnUpCTR.Name = "btnUpCTR";
            this.btnUpCTR.Size = new System.Drawing.Size(106, 40);
            this.btnUpCTR.TabIndex = 8;
            this.btnUpCTR.Text = "Update";
            this.btnUpCTR.UseVisualStyleBackColor = false;
            this.btnUpCTR.Click += new System.EventHandler(this.btnUpCTR_Click);
            // 
            // btnDelCTR
            // 
            this.btnDelCTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDelCTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelCTR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelCTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCTR.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelCTR.Location = new System.Drawing.Point(369, 412);
            this.btnDelCTR.Name = "btnDelCTR";
            this.btnDelCTR.Size = new System.Drawing.Size(106, 40);
            this.btnDelCTR.TabIndex = 7;
            this.btnDelCTR.Text = "Delete";
            this.btnDelCTR.UseVisualStyleBackColor = false;
            this.btnDelCTR.Click += new System.EventHandler(this.btnDelCTR_Click);
            // 
            // btnAddCTR
            // 
            this.btnAddCTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnAddCTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddCTR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCTR.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddCTR.Location = new System.Drawing.Point(98, 414);
            this.btnAddCTR.Name = "btnAddCTR";
            this.btnAddCTR.Size = new System.Drawing.Size(165, 40);
            this.btnAddCTR.TabIndex = 6;
            this.btnAddCTR.Text = "AddCategory";
            this.btnAddCTR.UseVisualStyleBackColor = false;
            this.btnAddCTR.Click += new System.EventHandler(this.btnAddCTR_Click_1);
            // 
            // tbCategory
            // 
            this.tbCategory.Controls.Add(this.tbCategoryMana);
            this.tbCategory.Controls.Add(this.tbUnitMana);
            this.tbCategory.Location = new System.Drawing.Point(24, 107);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.SelectedIndex = 0;
            this.tbCategory.Size = new System.Drawing.Size(1257, 490);
            this.tbCategory.TabIndex = 9;
            this.tbCategory.SelectedIndexChanged += new System.EventHandler(this.tbCategory_SelectedIndexChanged);
            // 
            // tbCategoryMana
            // 
            this.tbCategoryMana.BackgroundImage = global::NetManagement.Properties.Resources.btnbackground;
            this.tbCategoryMana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCategoryMana.Controls.Add(this.cbbSortby);
            this.tbCategoryMana.Controls.Add(this.cbbSortProperty);
            this.tbCategoryMana.Controls.Add(this.btnAddCTR);
            this.tbCategoryMana.Controls.Add(this.btnUpCTR);
            this.tbCategoryMana.Controls.Add(this.btnSortCTR);
            this.tbCategoryMana.Controls.Add(this.dgvShowCTR);
            this.tbCategoryMana.Controls.Add(this.btnDelCTR);
            this.tbCategoryMana.Location = new System.Drawing.Point(4, 25);
            this.tbCategoryMana.Name = "tbCategoryMana";
            this.tbCategoryMana.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategoryMana.Size = new System.Drawing.Size(1249, 461);
            this.tbCategoryMana.TabIndex = 0;
            this.tbCategoryMana.Text = "Category Management";
            this.tbCategoryMana.UseVisualStyleBackColor = true;
            // 
            // dgvShowCTR
            // 
            this.dgvShowCTR.AllowUserToAddRows = false;
            this.dgvShowCTR.AllowUserToDeleteRows = false;
            this.dgvShowCTR.AllowUserToOrderColumns = true;
            this.dgvShowCTR.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.dgvShowCTR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowCTR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowCTR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowCTR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvShowCTR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowCTR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowCTR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowCTR.ColumnHeadersHeight = 36;
            this.dgvShowCTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowCTR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.dgvShowCTR.EnableHeadersVisualStyles = false;
            this.dgvShowCTR.Location = new System.Drawing.Point(39, 19);
            this.dgvShowCTR.Name = "dgvShowCTR";
            this.dgvShowCTR.RowHeadersVisible = false;
            this.dgvShowCTR.RowHeadersWidth = 51;
            this.dgvShowCTR.RowTemplate.Height = 40;
            this.dgvShowCTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowCTR.Size = new System.Drawing.Size(1161, 390);
            this.dgvShowCTR.TabIndex = 10;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // tbUnitMana
            // 
            this.tbUnitMana.BackgroundImage = global::NetManagement.Properties.Resources.btnbackground;
            this.tbUnitMana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbUnitMana.Controls.Add(this.btnDeleteUnit);
            this.tbUnitMana.Controls.Add(this.btnUnitUpdate);
            this.tbUnitMana.Controls.Add(this.btnUnitAdd);
            this.tbUnitMana.Controls.Add(this.dgvUnit);
            this.tbUnitMana.Location = new System.Drawing.Point(4, 25);
            this.tbUnitMana.Name = "tbUnitMana";
            this.tbUnitMana.Padding = new System.Windows.Forms.Padding(3);
            this.tbUnitMana.Size = new System.Drawing.Size(1249, 461);
            this.tbUnitMana.TabIndex = 1;
            this.tbUnitMana.Text = "Unit Management";
            this.tbUnitMana.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDeleteUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUnit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUnit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteUnit.Location = new System.Drawing.Point(636, 415);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(106, 40);
            this.btnDeleteUnit.TabIndex = 14;
            this.btnDeleteUnit.Text = "Delete";
            this.btnDeleteUnit.UseVisualStyleBackColor = false;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnUnitUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUnitUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnitUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnitUpdate.Location = new System.Drawing.Point(426, 415);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(106, 40);
            this.btnUnitUpdate.TabIndex = 13;
            this.btnUnitUpdate.Text = "Update";
            this.btnUnitUpdate.UseVisualStyleBackColor = false;
            this.btnUnitUpdate.Click += new System.EventHandler(this.btnUnitUpdate_Click);
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnUnitAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUnitAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitAdd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnitAdd.Location = new System.Drawing.Point(174, 415);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(165, 40);
            this.btnUnitAdd.TabIndex = 12;
            this.btnUnitAdd.Text = "Add";
            this.btnUnitAdd.UseVisualStyleBackColor = false;
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.AllowUserToDeleteRows = false;
            this.dgvUnit.AllowUserToOrderColumns = true;
            this.dgvUnit.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.dgvUnit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUnit.ColumnHeadersHeight = 36;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgvUnit.EnableHeadersVisualStyles = false;
            this.dgvUnit.Location = new System.Drawing.Point(44, 6);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.RowHeadersVisible = false;
            this.dgvUnit.RowHeadersWidth = 51;
            this.dgvUnit.RowTemplate.Height = 40;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(1161, 409);
            this.dgvUnit.TabIndex = 11;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 599);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.panel1);
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbCategory.ResumeLayout(false);
            this.tbCategoryMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCTR)).EndInit();
            this.tbUnitMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSortby;
        private System.Windows.Forms.ComboBox cbbSortProperty;
        private System.Windows.Forms.Button btnSortCTR;
        private System.Windows.Forms.Button btnUpCTR;
        private System.Windows.Forms.Button btnDelCTR;
        private System.Windows.Forms.Button btnAddCTR;
        private System.Windows.Forms.TabControl tbCategory;
        private System.Windows.Forms.TabPage tbCategoryMana;
        private System.Windows.Forms.DataGridView dgvShowCTR;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.TabPage tbUnitMana;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnUnitUpdate;
    }
}