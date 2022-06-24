using System;

namespace NetManagement.View.FormAdmin
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSortBy = new System.Windows.Forms.ComboBox();
            this.cbbSortProperty = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnTab = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.tbControllMana = new System.Windows.Forms.TabControl();
            this.tbMerMana = new System.Windows.Forms.TabPage();
            this.dgvMerMana = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbPrMana = new System.Windows.Forms.TabPage();
            this.dgvPrMana = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbProductMana = new System.Windows.Forms.TabPage();
            this.btnAddNewPro = new System.Windows.Forms.Button();
            this.btnDelPro = new System.Windows.Forms.Button();
            this.BtnUpdateProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.pnTab.SuspendLayout();
            this.tbControllMana.SuspendLayout();
            this.tbMerMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerMana)).BeginInit();
            this.tbPrMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrMana)).BeginInit();
            this.tbProductMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cbbSortBy);
            this.panel1.Controls.Add(this.cbbSortProperty);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cbbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 90);
            this.panel1.TabIndex = 0;
            // 
            // cbbSortBy
            // 
            this.cbbSortBy.DropDownWidth = 200;
            this.cbbSortBy.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortBy.FormattingEnabled = true;
            this.cbbSortBy.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.cbbSortBy.Location = new System.Drawing.Point(1143, 25);
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.Size = new System.Drawing.Size(114, 37);
            this.cbbSortBy.TabIndex = 20;
            // 
            // cbbSortProperty
            // 
            this.cbbSortProperty.DropDownWidth = 200;
            this.cbbSortProperty.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortProperty.FormattingEnabled = true;
            this.cbbSortProperty.Location = new System.Drawing.Point(929, 25);
            this.cbbSortProperty.Name = "cbbSortProperty";
            this.cbbSortProperty.Size = new System.Drawing.Size(192, 37);
            this.cbbSortProperty.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(783, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(156, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 40);
            this.txtSearch.TabIndex = 13;
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownWidth = 200;
            this.cbbSearch.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(25, 25);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(114, 37);
            this.cbbSearch.TabIndex = 12;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(390, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cartIcon.png");
            // 
            // pnTab
            // 
            this.pnTab.Controls.Add(this.btnAdd);
            this.pnTab.Controls.Add(this.btnDel);
            this.pnTab.Controls.Add(this.btnUp);
            this.pnTab.Controls.Add(this.tbControllMana);
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTab.Location = new System.Drawing.Point(0, 90);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(1320, 615);
            this.pnTab.TabIndex = 2;
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
            this.btnAdd.Location = new System.Drawing.Point(237, 547);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.btnDel.Location = new System.Drawing.Point(617, 547);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(106, 40);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
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
            this.btnUp.Location = new System.Drawing.Point(901, 547);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(106, 40);
            this.btnUp.TabIndex = 11;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click_1);
            // 
            // tbControllMana
            // 
            this.tbControllMana.Controls.Add(this.tbMerMana);
            this.tbControllMana.Controls.Add(this.tbPrMana);
            this.tbControllMana.Controls.Add(this.tbProductMana);
            this.tbControllMana.Location = new System.Drawing.Point(0, 0);
            this.tbControllMana.Name = "tbControllMana";
            this.tbControllMana.SelectedIndex = 0;
            this.tbControllMana.Size = new System.Drawing.Size(1320, 523);
            this.tbControllMana.TabIndex = 0;
            this.tbControllMana.SelectedIndexChanged += new System.EventHandler(this.tbControllMana_SelectedIndexChanged);
            // 
            // tbMerMana
            // 
            this.tbMerMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(99)))));
            this.tbMerMana.Controls.Add(this.dgvMerMana);
            this.tbMerMana.Location = new System.Drawing.Point(4, 25);
            this.tbMerMana.Name = "tbMerMana";
            this.tbMerMana.Padding = new System.Windows.Forms.Padding(3);
            this.tbMerMana.Size = new System.Drawing.Size(1312, 494);
            this.tbMerMana.TabIndex = 0;
            this.tbMerMana.Text = "Product Management";
            // 
            // dgvMerMana
            // 
            this.dgvMerMana.AllowUserToAddRows = false;
            this.dgvMerMana.AllowUserToDeleteRows = false;
            this.dgvMerMana.AllowUserToOrderColumns = true;
            this.dgvMerMana.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.dgvMerMana.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMerMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMerMana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMerMana.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvMerMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMerMana.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMerMana.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMerMana.ColumnHeadersHeight = 36;
            this.dgvMerMana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMerMana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.dgvMerMana.EnableHeadersVisualStyles = false;
            this.dgvMerMana.Location = new System.Drawing.Point(21, 6);
            this.dgvMerMana.Name = "dgvMerMana";
            this.dgvMerMana.RowHeadersVisible = false;
            this.dgvMerMana.RowHeadersWidth = 51;
            this.dgvMerMana.RowTemplate.Height = 40;
            this.dgvMerMana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMerMana.Size = new System.Drawing.Size(1264, 482);
            this.dgvMerMana.TabIndex = 5;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // tbPrMana
            // 
            this.tbPrMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(99)))));
            this.tbPrMana.Controls.Add(this.dgvPrMana);
            this.tbPrMana.Location = new System.Drawing.Point(4, 25);
            this.tbPrMana.Name = "tbPrMana";
            this.tbPrMana.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrMana.Size = new System.Drawing.Size(1312, 494);
            this.tbPrMana.TabIndex = 1;
            this.tbPrMana.Text = "Price Management";
            // 
            // dgvPrMana
            // 
            this.dgvPrMana.AllowUserToAddRows = false;
            this.dgvPrMana.AllowUserToDeleteRows = false;
            this.dgvPrMana.AllowUserToOrderColumns = true;
            this.dgvPrMana.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            this.dgvPrMana.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPrMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrMana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrMana.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvPrMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrMana.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrMana.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPrMana.ColumnHeadersHeight = 36;
            this.dgvPrMana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrMana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgvPrMana.EnableHeadersVisualStyles = false;
            this.dgvPrMana.Location = new System.Drawing.Point(30, 6);
            this.dgvPrMana.Name = "dgvPrMana";
            this.dgvPrMana.RowHeadersVisible = false;
            this.dgvPrMana.RowHeadersWidth = 51;
            this.dgvPrMana.RowTemplate.Height = 40;
            this.dgvPrMana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrMana.Size = new System.Drawing.Size(1252, 482);
            this.dgvPrMana.TabIndex = 6;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // tbProductMana
            // 
            this.tbProductMana.Controls.Add(this.btnAddNewPro);
            this.tbProductMana.Controls.Add(this.btnDelPro);
            this.tbProductMana.Controls.Add(this.BtnUpdateProduct);
            this.tbProductMana.Controls.Add(this.dgvProduct);
            this.tbProductMana.Location = new System.Drawing.Point(4, 25);
            this.tbProductMana.Name = "tbProductMana";
            this.tbProductMana.Size = new System.Drawing.Size(1312, 494);
            this.tbProductMana.TabIndex = 2;
            this.tbProductMana.Text = "Product Management";
            this.tbProductMana.UseVisualStyleBackColor = true;
            // 
            // btnAddNewPro
            // 
            this.btnAddNewPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnAddNewPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewPro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNewPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNewPro.Location = new System.Drawing.Point(99, 524);
            this.btnAddNewPro.Name = "btnAddNewPro";
            this.btnAddNewPro.Size = new System.Drawing.Size(211, 40);
            this.btnAddNewPro.TabIndex = 12;
            this.btnAddNewPro.Text = "Add New Product";
            this.btnAddNewPro.UseVisualStyleBackColor = false;
            // 
            // btnDelPro
            // 
            this.btnDelPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDelPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelPro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelPro.Location = new System.Drawing.Point(499, 524);
            this.btnDelPro.Name = "btnDelPro";
            this.btnDelPro.Size = new System.Drawing.Size(167, 40);
            this.btnDelPro.TabIndex = 13;
            this.btnDelPro.Text = "Delete Product";
            this.btnDelPro.UseVisualStyleBackColor = false;
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.BtnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnUpdateProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateProduct.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnUpdateProduct.Location = new System.Drawing.Point(840, 524);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(176, 40);
            this.BtnUpdateProduct.TabIndex = 14;
            this.BtnUpdateProduct.Text = "Update Product";
            this.BtnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProduct.ColumnHeadersHeight = 36;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2});
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(30, 6);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 40;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1252, 471);
            this.dgvProduct.TabIndex = 7;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1320, 705);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.Text = "FormEmployees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnTab.ResumeLayout(false);
            this.tbControllMana.ResumeLayout(false);
            this.tbMerMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerMana)).EndInit();
            this.tbPrMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrMana)).EndInit();
            this.tbProductMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.TabControl tbControllMana;
        private System.Windows.Forms.TabPage tbMerMana;
        private System.Windows.Forms.TabPage tbPrMana;
        private System.Windows.Forms.DataGridView dgvMerMana;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridView dgvPrMana;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tbProductMana;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox cbbSortBy;
        private System.Windows.Forms.ComboBox cbbSortProperty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAddNewPro;
        private System.Windows.Forms.Button btnDelPro;
        private System.Windows.Forms.Button BtnUpdateProduct;
    }
}