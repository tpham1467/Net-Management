namespace NetManagement.View.FormEmployee
{
    partial class CheckIO_Form
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
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAveWorkingTime = new System.Windows.Forms.Label();
            this.labeAveWorkingTimelable = new System.Windows.Forms.Label();
            this.labeltotalworkingtime = new System.Windows.Forms.Label();
            this.labelTotalWorkingTimelabel = new System.Windows.Forms.Label();
            this.labelTotal_WorkingDay = new System.Windows.Forms.Label();
            this.labelTotal_WorkingDaylable = new System.Windows.Forms.Label();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.labelTimEnd = new System.Windows.Forms.Label();
            this.buttonSetoff = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxmode = new System.Windows.Forms.ComboBox();
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.checkBoxDalam = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(495, 25);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(115, 39);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(633, 23);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(115, 39);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bắt đầu ca làm việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết thúc ca làm việc:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 242);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelAveWorkingTime
            // 
            this.labelAveWorkingTime.AutoSize = true;
            this.labelAveWorkingTime.Location = new System.Drawing.Point(630, 111);
            this.labelAveWorkingTime.Name = "labelAveWorkingTime";
            this.labelAveWorkingTime.Size = new System.Drawing.Size(28, 17);
            this.labelAveWorkingTime.TabIndex = 7;
            this.labelAveWorkingTime.Text = "6.8";
            // 
            // labeAveWorkingTimelable
            // 
            this.labeAveWorkingTimelable.AutoSize = true;
            this.labeAveWorkingTimelable.Location = new System.Drawing.Point(462, 111);
            this.labeAveWorkingTimelable.Name = "labeAveWorkingTimelable";
            this.labeAveWorkingTimelable.Size = new System.Drawing.Size(123, 17);
            this.labeAveWorkingTimelable.TabIndex = 8;
            this.labeAveWorkingTimelable.Text = "AveWorkingTime :";
            // 
            // labeltotalworkingtime
            // 
            this.labeltotalworkingtime.AutoSize = true;
            this.labeltotalworkingtime.Location = new System.Drawing.Point(383, 111);
            this.labeltotalworkingtime.Name = "labeltotalworkingtime";
            this.labeltotalworkingtime.Size = new System.Drawing.Size(24, 17);
            this.labeltotalworkingtime.TabIndex = 9;
            this.labeltotalworkingtime.Text = "50";
            // 
            // labelTotalWorkingTimelabel
            // 
            this.labelTotalWorkingTimelabel.AutoSize = true;
            this.labelTotalWorkingTimelabel.Location = new System.Drawing.Point(229, 111);
            this.labelTotalWorkingTimelabel.Name = "labelTotalWorkingTimelabel";
            this.labelTotalWorkingTimelabel.Size = new System.Drawing.Size(131, 17);
            this.labelTotalWorkingTimelabel.TabIndex = 10;
            this.labelTotalWorkingTimelabel.Text = "TotalWorkingTime :";
            // 
            // labelTotal_WorkingDay
            // 
            this.labelTotal_WorkingDay.AutoSize = true;
            this.labelTotal_WorkingDay.Location = new System.Drawing.Point(140, 111);
            this.labelTotal_WorkingDay.Name = "labelTotal_WorkingDay";
            this.labelTotal_WorkingDay.Size = new System.Drawing.Size(24, 17);
            this.labelTotal_WorkingDay.TabIndex = 11;
            this.labelTotal_WorkingDay.Text = "10";
            // 
            // labelTotal_WorkingDaylable
            // 
            this.labelTotal_WorkingDaylable.AutoSize = true;
            this.labelTotal_WorkingDaylable.Location = new System.Drawing.Point(1, 111);
            this.labelTotal_WorkingDaylable.Name = "labelTotal_WorkingDaylable";
            this.labelTotal_WorkingDaylable.Size = new System.Drawing.Size(133, 17);
            this.labelTotal_WorkingDaylable.TabIndex = 12;
            this.labelTotal_WorkingDaylable.Text = "Total_WorkingDay :";
            // 
            // labelTimeStart
            // 
            this.labelTimeStart.AutoSize = true;
            this.labelTimeStart.Location = new System.Drawing.Point(239, 25);
            this.labelTimeStart.Name = "labelTimeStart";
            this.labelTimeStart.Size = new System.Drawing.Size(64, 17);
            this.labelTimeStart.TabIndex = 13;
            this.labelTimeStart.Text = "13:11:12";
            // 
            // labelTimEnd
            // 
            this.labelTimEnd.AutoSize = true;
            this.labelTimEnd.Location = new System.Drawing.Point(239, 55);
            this.labelTimEnd.Name = "labelTimEnd";
            this.labelTimEnd.Size = new System.Drawing.Size(64, 17);
            this.labelTimEnd.TabIndex = 14;
            this.labelTimEnd.Text = "14:34:10";
            // 
            // buttonSetoff
            // 
            this.buttonSetoff.Location = new System.Drawing.Point(4, 407);
            this.buttonSetoff.Name = "buttonSetoff";
            this.buttonSetoff.Size = new System.Drawing.Size(80, 31);
            this.buttonSetoff.TabIndex = 15;
            this.buttonSetoff.Text = "Set Off";
            this.buttonSetoff.UseVisualStyleBackColor = true;
            this.buttonSetoff.Click += new System.EventHandler(this.buttonSetoff_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(143, 411);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(120, 31);
            this.buttonSort.TabIndex = 16;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBoxmode
            // 
            this.comboBoxmode.FormattingEnabled = true;
            this.comboBoxmode.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.comboBoxmode.Location = new System.Drawing.Point(350, 414);
            this.comboBoxmode.Name = "comboBoxmode";
            this.comboBoxmode.Size = new System.Drawing.Size(121, 24);
            this.comboBoxmode.TabIndex = 17;
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Items.AddRange(new object[] {
            "Id",
            "Date Work"});
            this.comboBoxProperty.Location = new System.Drawing.Point(523, 414);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProperty.TabIndex = 18;
            // 
            // checkBoxDalam
            // 
            this.checkBoxDalam.AutoSize = true;
            this.checkBoxDalam.Location = new System.Drawing.Point(12, 131);
            this.checkBoxDalam.Name = "checkBoxDalam";
            this.checkBoxDalam.Size = new System.Drawing.Size(79, 21);
            this.checkBoxDalam.TabIndex = 21;
            this.checkBoxDalam.Text = "Da Lam";
            this.checkBoxDalam.UseVisualStyleBackColor = true;
            this.checkBoxDalam.CheckedChanged += new System.EventHandler(this.checkBoxDalam_CheckedChanged);
            // 
            // CheckIO_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxDalam);
            this.Controls.Add(this.comboBoxProperty);
            this.Controls.Add(this.comboBoxmode);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSetoff);
            this.Controls.Add(this.labelTimEnd);
            this.Controls.Add(this.labelTimeStart);
            this.Controls.Add(this.labelTotal_WorkingDaylable);
            this.Controls.Add(this.labelTotal_WorkingDay);
            this.Controls.Add(this.labelTotalWorkingTimelabel);
            this.Controls.Add(this.labeltotalworkingtime);
            this.Controls.Add(this.labeAveWorkingTimelable);
            this.Controls.Add(this.labelAveWorkingTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckin);
            this.Name = "CheckIO_Form";
            this.Text = "CheckIO_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAveWorkingTime;
        private System.Windows.Forms.Label labeAveWorkingTimelable;
        private System.Windows.Forms.Label labeltotalworkingtime;
        private System.Windows.Forms.Label labelTotalWorkingTimelabel;
        private System.Windows.Forms.Label labelTotal_WorkingDay;
        private System.Windows.Forms.Label labelTotal_WorkingDaylable;
        private System.Windows.Forms.Label labelTimeStart;
        private System.Windows.Forms.Label labelTimEnd;
        private System.Windows.Forms.Button buttonSetoff;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxmode;
        private System.Windows.Forms.ComboBox comboBoxProperty;
        private System.Windows.Forms.CheckBox checkBoxDalam;
    }
}