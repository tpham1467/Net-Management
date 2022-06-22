namespace NetManagement.View.FormAdmin
{
    partial class FormAddUpShift
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
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbWorkday = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpWD = new System.Windows.Forms.DateTimePicker();
            this.cbbNameE = new System.Windows.Forms.ComboBox();
            this.mTbStartTime = new System.Windows.Forms.MaskedTextBox();
            this.mTbEndTime = new System.Windows.Forms.MaskedTextBox();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lbStartTime.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbStartTime.Location = new System.Drawing.Point(56, 166);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(217, 30);
            this.lbStartTime.TabIndex = 4;
            this.lbStartTime.Text = "Shift Start Time";
            // 
            // lbWorkday
            // 
            this.lbWorkday.AutoSize = true;
            this.lbWorkday.BackColor = System.Drawing.Color.Transparent;
            this.lbWorkday.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbWorkday.Location = new System.Drawing.Point(41, 53);
            this.lbWorkday.Name = "lbWorkday";
            this.lbWorkday.Size = new System.Drawing.Size(132, 30);
            this.lbWorkday.TabIndex = 5;
            this.lbWorkday.Text = "WorkDay";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbPhone.Location = new System.Drawing.Point(296, 53);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(132, 30);
            this.lbPhone.TabIndex = 7;
            this.lbPhone.Text = "Employee";
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::NetManagement.Properties.Resources.imagesButton;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Location = new System.Drawing.Point(102, 317);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(128, 44);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::NetManagement.Properties.Resources.redBackground;
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(343, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 44);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpWD
            // 
            this.dtpWD.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtpWD.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dtpWD.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpWD.Location = new System.Drawing.Point(46, 86);
            this.dtpWD.Name = "dtpWD";
            this.dtpWD.Size = new System.Drawing.Size(240, 32);
            this.dtpWD.TabIndex = 21;
            this.dtpWD.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // cbbNameE
            // 
            this.cbbNameE.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNameE.FormattingEnabled = true;
            this.cbbNameE.Location = new System.Drawing.Point(301, 86);
            this.cbbNameE.Name = "cbbNameE";
            this.cbbNameE.Size = new System.Drawing.Size(236, 38);
            this.cbbNameE.TabIndex = 23;
            // 
            // mTbStartTime
            // 
            this.mTbStartTime.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTbStartTime.Location = new System.Drawing.Point(103, 216);
            this.mTbStartTime.Mask = "00:00";
            this.mTbStartTime.Name = "mTbStartTime";
            this.mTbStartTime.Size = new System.Drawing.Size(127, 38);
            this.mTbStartTime.TabIndex = 26;
            this.mTbStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mTbEndTime
            // 
            this.mTbEndTime.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTbEndTime.Location = new System.Drawing.Point(343, 169);
            this.mTbEndTime.Mask = "00:00";
            this.mTbEndTime.Name = "mTbEndTime";
            this.mTbEndTime.Size = new System.Drawing.Size(127, 38);
            this.mTbEndTime.TabIndex = 27;
            this.mTbEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lbEndTime.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbEndTime.Location = new System.Drawing.Point(296, 136);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(206, 30);
            this.lbEndTime.TabIndex = 28;
            this.lbEndTime.Text = "Shift End Time";
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Đã làm",
            "Chưa làm",
            "Nghỉ phép"});
            this.cbbStatus.Location = new System.Drawing.Point(343, 253);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(194, 35);
            this.cbbStatus.TabIndex = 29;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.BackColor = System.Drawing.Color.Transparent;
            this.lbstatus.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbstatus.Location = new System.Drawing.Point(296, 220);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(90, 30);
            this.lbstatus.TabIndex = 30;
            this.lbstatus.Text = "Status";
            // 
            // FormAddUpShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::NetManagement.Properties.Resources.images1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.lbEndTime);
            this.Controls.Add(this.mTbEndTime);
            this.Controls.Add(this.mTbStartTime);
            this.Controls.Add(this.cbbNameE);
            this.Controls.Add(this.dtpWD);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbWorkday);
            this.Controls.Add(this.lbStartTime);
            this.Name = "FormAddUpShift";
            this.Text = "FormAddUpShift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtFirst;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbWorkday;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpWD;
        private System.Windows.Forms.ComboBox cbbNameE;
        private System.Windows.Forms.MaskedTextBox mTbStartTime;
        private System.Windows.Forms.MaskedTextBox mTbEndTime;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label lbstatus;
    }
}