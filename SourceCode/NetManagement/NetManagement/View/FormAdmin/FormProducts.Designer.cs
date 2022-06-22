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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrMana = new System.Windows.Forms.Button();
            this.btnMerMana = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbInDe = new System.Windows.Forms.ComboBox();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnTab = new System.Windows.Forms.Panel();
            this.tbControllMana = new System.Windows.Forms.TabControl();
            this.tbMerMana = new System.Windows.Forms.TabPage();
            this.dgvMerMana = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbPrMana = new System.Windows.Forms.TabPage();
            this.dgvPrMana = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnTab.SuspendLayout();
            this.tbControllMana.SuspendLayout();
            this.tbMerMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerMana)).BeginInit();
            this.tbPrMana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrMana)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cbbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnPrMana);
            this.panel1.Controls.Add(this.btnMerMana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 90);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(948, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 40);
            this.txtSearch.TabIndex = 13;
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownWidth = 200;
            this.cbbSearch.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(1175, 26);
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
            this.btnSearch.Location = new System.Drawing.Point(836, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrMana
            // 
            this.btnPrMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnPrMana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrMana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPrMana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrMana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrMana.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrMana.Location = new System.Drawing.Point(302, 26);
            this.btnPrMana.Name = "btnPrMana";
            this.btnPrMana.Size = new System.Drawing.Size(213, 40);
            this.btnPrMana.TabIndex = 5;
            this.btnPrMana.Text = "Price Management";
            this.btnPrMana.UseVisualStyleBackColor = false;
            this.btnPrMana.Click += new System.EventHandler(this.btnPrMana_Click);
            // 
            // btnMerMana
            // 
            this.btnMerMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnMerMana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerMana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMerMana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMerMana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerMana.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMerMana.Location = new System.Drawing.Point(24, 26);
            this.btnMerMana.Name = "btnMerMana";
            this.btnMerMana.Size = new System.Drawing.Size(272, 40);
            this.btnMerMana.TabIndex = 4;
            this.btnMerMana.Text = "Merchandise Management";
            this.btnMerMana.UseVisualStyleBackColor = false;
            this.btnMerMana.Click += new System.EventHandler(this.btnMerMana_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbInDe);
            this.panel2.Controls.Add(this.cbbSort);
            this.panel2.Controls.Add(this.btnSort);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 86);
            this.panel2.TabIndex = 1;
            // 
            // cbbInDe
            // 
            this.cbbInDe.DropDownWidth = 200;
            this.cbbInDe.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbInDe.FormattingEnabled = true;
            this.cbbInDe.Location = new System.Drawing.Point(1069, 25);
            this.cbbInDe.Name = "cbbInDe";
            this.cbbInDe.Size = new System.Drawing.Size(114, 37);
            this.cbbInDe.TabIndex = 11;
            // 
            // cbbSort
            // 
            this.cbbSort.DropDownWidth = 200;
            this.cbbSort.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(858, 25);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(192, 37);
            this.cbbSort.TabIndex = 10;
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
            this.btnSort.Location = new System.Drawing.Point(725, 22);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(106, 40);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
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
            this.btnUp.Location = new System.Drawing.Point(573, 22);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(106, 40);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
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
            this.btnDel.Location = new System.Drawing.Point(390, 22);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(106, 40);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(156, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cartIcon.png");
            // 
            // pnTab
            // 
            this.pnTab.Controls.Add(this.tbControllMana);
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTab.Location = new System.Drawing.Point(0, 90);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(1320, 529);
            this.pnTab.TabIndex = 2;
            // 
            // tbControllMana
            // 
            this.tbControllMana.Controls.Add(this.tbMerMana);
            this.tbControllMana.Controls.Add(this.tbPrMana);
            this.tbControllMana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControllMana.Location = new System.Drawing.Point(0, 0);
            this.tbControllMana.Name = "tbControllMana";
            this.tbControllMana.SelectedIndex = 0;
            this.tbControllMana.Size = new System.Drawing.Size(1320, 529);
            this.tbControllMana.TabIndex = 0;
            // 
            // tbMerMana
            // 
            this.tbMerMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(99)))));
            this.tbMerMana.Controls.Add(this.dgvMerMana);
            this.tbMerMana.Location = new System.Drawing.Point(4, 25);
            this.tbMerMana.Name = "tbMerMana";
            this.tbMerMana.Padding = new System.Windows.Forms.Padding(3);
            this.tbMerMana.Size = new System.Drawing.Size(1312, 500);
            this.tbMerMana.TabIndex = 0;
            // 
            // dgvMerMana
            // 
            this.dgvMerMana.AllowUserToAddRows = false;
            this.dgvMerMana.AllowUserToDeleteRows = false;
            this.dgvMerMana.AllowUserToOrderColumns = true;
            this.dgvMerMana.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvMerMana.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMerMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMerMana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMerMana.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvMerMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMerMana.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMerMana.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMerMana.ColumnHeadersHeight = 36;
            this.dgvMerMana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMerMana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.dgvMerMana.EnableHeadersVisualStyles = false;
            this.dgvMerMana.Location = new System.Drawing.Point(33, 6);
            this.dgvMerMana.Name = "dgvMerMana";
            this.dgvMerMana.RowHeadersVisible = false;
            this.dgvMerMana.RowHeadersWidth = 51;
            this.dgvMerMana.RowTemplate.Height = 40;
            this.dgvMerMana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMerMana.Size = new System.Drawing.Size(1252, 488);
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
            this.tbPrMana.Size = new System.Drawing.Size(1312, 500);
            this.tbPrMana.TabIndex = 1;
            // 
            // dgvPrMana
            // 
            this.dgvPrMana.AllowUserToAddRows = false;
            this.dgvPrMana.AllowUserToDeleteRows = false;
            this.dgvPrMana.AllowUserToOrderColumns = true;
            this.dgvPrMana.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dgvPrMana.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrMana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrMana.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvPrMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrMana.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrMana.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvPrMana.Size = new System.Drawing.Size(1252, 488);
            this.dgvPrMana.TabIndex = 6;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1320, 705);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.Text = "FormEmployees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnTab.ResumeLayout(false);
            this.tbControllMana.ResumeLayout(false);
            this.tbMerMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerMana)).EndInit();
            this.tbPrMana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrMana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrMana;
        private System.Windows.Forms.Button btnMerMana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.TabControl tbControllMana;
        private System.Windows.Forms.TabPage tbMerMana;
        private System.Windows.Forms.TabPage tbPrMana;
        private System.Windows.Forms.DataGridView dgvMerMana;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridView dgvPrMana;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox cbbInDe;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}