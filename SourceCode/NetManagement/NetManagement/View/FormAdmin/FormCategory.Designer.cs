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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbInc_dec = new System.Windows.Forms.ComboBox();
            this.cbb_SortCTR = new System.Windows.Forms.ComboBox();
            this.btnSortCTR = new System.Windows.Forms.Button();
            this.btnUpCTR = new System.Windows.Forms.Button();
            this.btnDelCTR = new System.Windows.Forms.Button();
            this.btnAddCTR = new System.Windows.Forms.Button();
            this.dgvShowCTR = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCTR)).BeginInit();
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
            this.btnSearch.Size = new System.Drawing.Size(83, 40);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbInc_dec);
            this.panel2.Controls.Add(this.cbb_SortCTR);
            this.panel2.Controls.Add(this.btnSortCTR);
            this.panel2.Controls.Add(this.btnUpCTR);
            this.panel2.Controls.Add(this.btnDelCTR);
            this.panel2.Controls.Add(this.btnAddCTR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 61);
            this.panel2.TabIndex = 8;
            // 
            // cbbInc_dec
            // 
            this.cbbInc_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbInc_dec.FormattingEnabled = true;
            this.cbbInc_dec.Location = new System.Drawing.Point(1127, 12);
            this.cbbInc_dec.Name = "cbbInc_dec";
            this.cbbInc_dec.Size = new System.Drawing.Size(121, 37);
            this.cbbInc_dec.TabIndex = 11;
            // 
            // cbb_SortCTR
            // 
            this.cbb_SortCTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_SortCTR.FormattingEnabled = true;
            this.cbb_SortCTR.Location = new System.Drawing.Point(958, 12);
            this.cbb_SortCTR.Name = "cbb_SortCTR";
            this.cbb_SortCTR.Size = new System.Drawing.Size(163, 37);
            this.cbb_SortCTR.TabIndex = 10;
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
            this.btnSortCTR.Location = new System.Drawing.Point(835, 13);
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
            this.btnUpCTR.Location = new System.Drawing.Point(452, 13);
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
            this.btnDelCTR.Location = new System.Drawing.Point(302, 13);
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
            this.btnAddCTR.Location = new System.Drawing.Point(94, 13);
            this.btnAddCTR.Name = "btnAddCTR";
            this.btnAddCTR.Size = new System.Drawing.Size(165, 40);
            this.btnAddCTR.TabIndex = 6;
            this.btnAddCTR.Text = "AddCategory";
            this.btnAddCTR.UseVisualStyleBackColor = false;
            this.btnAddCTR.Click += new System.EventHandler(this.btnAddCTR_Click_1);
            // 
            // dgvShowCTR
            // 
            this.dgvShowCTR.AllowUserToAddRows = false;
            this.dgvShowCTR.AllowUserToDeleteRows = false;
            this.dgvShowCTR.AllowUserToOrderColumns = true;
            this.dgvShowCTR.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            this.dgvShowCTR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvShowCTR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowCTR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowCTR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvShowCTR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowCTR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowCTR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvShowCTR.ColumnHeadersHeight = 36;
            this.dgvShowCTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowCTR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.dgvShowCTR.EnableHeadersVisualStyles = false;
            this.dgvShowCTR.Location = new System.Drawing.Point(24, 96);
            this.dgvShowCTR.Name = "dgvShowCTR";
            this.dgvShowCTR.RowHeadersVisible = false;
            this.dgvShowCTR.RowHeadersWidth = 51;
            this.dgvShowCTR.RowTemplate.Height = 40;
            this.dgvShowCTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowCTR.Size = new System.Drawing.Size(1247, 436);
            this.dgvShowCTR.TabIndex = 9;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 599);
            this.Controls.Add(this.dgvShowCTR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCTR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbInc_dec;
        private System.Windows.Forms.ComboBox cbb_SortCTR;
        private System.Windows.Forms.Button btnSortCTR;
        private System.Windows.Forms.Button btnUpCTR;
        private System.Windows.Forms.Button btnDelCTR;
        private System.Windows.Forms.Button btnAddCTR;
        private System.Windows.Forms.DataGridView dgvShowCTR;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}