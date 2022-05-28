namespace ChoosePC_UI
{
    partial class Detail_ChoosePC
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
            this.tbTenMay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.rdOn = new System.Windows.Forms.RadioButton();
            this.rdOff = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbMay1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMay1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenMay
            // 
            this.tbTenMay.Enabled = false;
            this.tbTenMay.Font = new System.Drawing.Font("Rosewood Std Regular", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenMay.ForeColor = System.Drawing.Color.IndianRed;
            this.tbTenMay.Location = new System.Drawing.Point(196, 1);
            this.tbTenMay.Name = "tbTenMay";
            this.tbTenMay.Size = new System.Drawing.Size(100, 43);
            this.tbTenMay.TabIndex = 5;
            this.tbTenMay.TextChanged += new System.EventHandler(this.tbTenMay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Máy";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(157, 269);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(168, 34);
            this.tbID.TabIndex = 8;
            // 
            // rdOn
            // 
            this.rdOn.AutoSize = true;
            this.rdOn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOn.Location = new System.Drawing.Point(123, 21);
            this.rdOn.Name = "rdOn";
            this.rdOn.Size = new System.Drawing.Size(66, 29);
            this.rdOn.TabIndex = 9;
            this.rdOn.TabStop = true;
            this.rdOn.Text = "ON";
            this.rdOn.UseVisualStyleBackColor = true;
            // 
            // rdOff
            // 
            this.rdOff.AutoSize = true;
            this.rdOff.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOff.Location = new System.Drawing.Point(123, 56);
            this.rdOff.Name = "rdOff";
            this.rdOff.Size = new System.Drawing.Size(79, 29);
            this.rdOff.TabIndex = 10;
            this.rdOff.TabStop = true;
            this.rdOff.Text = "OFF";
            this.rdOff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdOn);
            this.groupBox1.Controls.Add(this.rdOff);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // pbMay1
            // 
            this.pbMay1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbMay1.Image = global::QLQNet.Properties.Resources.PC;
            this.pbMay1.Location = new System.Drawing.Point(102, 12);
            this.pbMay1.Name = "pbMay1";
            this.pbMay1.Size = new System.Drawing.Size(272, 223);
            this.pbMay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMay1.TabIndex = 4;
            this.pbMay1.TabStop = false;
            // 
            // Detail_ChoosePC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenMay);
            this.Controls.Add(this.pbMay1);
            this.Name = "Detail_ChoosePC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_ChoosePC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMay1;
        private System.Windows.Forms.TextBox tbTenMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.RadioButton rdOn;
        private System.Windows.Forms.RadioButton rdOff;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}