namespace NetManagement.View.FormAdmin
{
    partial class FormShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShift));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lbTypeDt = new System.Windows.Forms.Label();
            this.lbTypeView = new System.Windows.Forms.Label();
            this.cbbTypeDt = new System.Windows.Forms.ComboBox();
            this.cbbTypeView = new System.Windows.Forms.ComboBox();
            this.lbView = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnViewAll);
            this.panel1.Controls.Add(this.lbTypeDt);
            this.panel1.Controls.Add(this.lbTypeView);
            this.panel1.Controls.Add(this.cbbTypeDt);
            this.panel1.Controls.Add(this.cbbTypeView);
            this.panel1.Controls.Add(this.lbView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 90);
            this.panel1.TabIndex = 0;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackgroundImage = global::NetManagement.Properties.Resources.color_background;
            this.btnViewAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewAll.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnViewAll.Location = new System.Drawing.Point(35, 43);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(100, 37);
            this.btnViewAll.TabIndex = 12;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // lbTypeDt
            // 
            this.lbTypeDt.AutoSize = true;
            this.lbTypeDt.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeDt.Image = global::NetManagement.Properties.Resources.btnbackground;
            this.lbTypeDt.Location = new System.Drawing.Point(471, 9);
            this.lbTypeDt.Name = "lbTypeDt";
            this.lbTypeDt.Size = new System.Drawing.Size(144, 31);
            this.lbTypeDt.TabIndex = 4;
            this.lbTypeDt.Text = "Type Detail";
            // 
            // lbTypeView
            // 
            this.lbTypeView.AutoSize = true;
            this.lbTypeView.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeView.Image = global::NetManagement.Properties.Resources.btnbackground;
            this.lbTypeView.Location = new System.Drawing.Point(233, 9);
            this.lbTypeView.Name = "lbTypeView";
            this.lbTypeView.Size = new System.Drawing.Size(132, 31);
            this.lbTypeView.TabIndex = 3;
            this.lbTypeView.Text = "Type View";
            // 
            // cbbTypeDt
            // 
            this.cbbTypeDt.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeDt.FormattingEnabled = true;
            this.cbbTypeDt.Location = new System.Drawing.Point(462, 49);
            this.cbbTypeDt.Name = "cbbTypeDt";
            this.cbbTypeDt.Size = new System.Drawing.Size(158, 38);
            this.cbbTypeDt.TabIndex = 2;
            this.cbbTypeDt.SelectedIndexChanged += new System.EventHandler(this.cbTypeDt_SelectedIndexChanged);
            // 
            // cbbTypeView
            // 
            this.cbbTypeView.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeView.FormattingEnabled = true;
            this.cbbTypeView.Items.AddRange(new object[] {
            "Xem theo ngày",
            "Xem theo tháng",
            "Xem theo năm"});
            this.cbbTypeView.Location = new System.Drawing.Point(188, 49);
            this.cbbTypeView.Name = "cbbTypeView";
            this.cbbTypeView.Size = new System.Drawing.Size(219, 38);
            this.cbbTypeView.TabIndex = 1;
            this.cbbTypeView.SelectedIndexChanged += new System.EventHandler(this.cbbView_SelectedIndexChanged);
            // 
            // lbView
            // 
            this.lbView.AutoSize = true;
            this.lbView.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView.Image = global::NetManagement.Properties.Resources.btnbackground;
            this.lbView.Location = new System.Drawing.Point(12, 9);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(140, 31);
            this.lbView.TabIndex = 0;
            this.lbView.Text = "     View     ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 86);
            this.panel2.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::NetManagement.Properties.Resources.color_background;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUp.Location = new System.Drawing.Point(921, 20);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(124, 49);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = global::NetManagement.Properties.Resources.color_background;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.Location = new System.Drawing.Point(700, 20);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 49);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = global::NetManagement.Properties.Resources.color_background;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnadd.Location = new System.Drawing.Point(448, 20);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(124, 49);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "AddShift";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "userTimer.png");
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.AllowUserToOrderColumns = true;
            this.dgvShift.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dgvShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShift.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvShift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShift.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShift.ColumnHeadersHeight = 36;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Picture});
            this.dgvShift.EnableHeadersVisualStyles = false;
            this.dgvShift.Location = new System.Drawing.Point(35, 108);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.RowHeadersVisible = false;
            this.dgvShift.RowHeadersWidth = 51;
            this.dgvShift.RowTemplate.Height = 40;
            this.dgvShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShift.Size = new System.Drawing.Size(1247, 494);
            this.dgvShift.TabIndex = 5;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "";
            this.Picture.Image = global::NetManagement.Properties.Resources.Shift;
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.MinimumWidth = 6;
            this.Picture.Name = "Picture";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 25F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::NetManagement.Properties.Resources.Shift;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 1246;
            // 
            // FormShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1320, 705);
            this.Controls.Add(this.dgvShift);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShift";
            this.Text = "FormEmployees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvShift;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.ComboBox cbbTypeView;
        private System.Windows.Forms.Label lbView;
        private System.Windows.Forms.Label lbTypeDt;
        private System.Windows.Forms.Label lbTypeView;
        private System.Windows.Forms.ComboBox cbbTypeDt;
        private System.Windows.Forms.Button btnViewAll;
    }
}