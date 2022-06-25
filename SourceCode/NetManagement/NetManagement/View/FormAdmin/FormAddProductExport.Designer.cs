namespace NetManagement.View.FormAdmin
{
    partial class FormAddProductExport
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
            this.lbidPro = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.txtSalePr = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpIm = new System.Windows.Forms.DateTimePicker();
            this.dtpEx = new System.Windows.Forms.DateTimePicker();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbidPro
            // 
            this.lbidPro.AutoSize = true;
            this.lbidPro.BackColor = System.Drawing.Color.Transparent;
            this.lbidPro.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbidPro.Location = new System.Drawing.Point(41, 20);
            this.lbidPro.Name = "lbidPro";
            this.lbidPro.Size = new System.Drawing.Size(111, 30);
            this.lbidPro.TabIndex = 0;
            this.lbidPro.Text = "Product";
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.BackColor = System.Drawing.Color.Transparent;
            this.lbDC.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbDC.Location = new System.Drawing.Point(41, 211);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(155, 30);
            this.lbDC.TabIndex = 4;
            this.lbDC.Text = "ExpiryDate";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.BackColor = System.Drawing.Color.Transparent;
            this.lbDOB.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbDOB.Location = new System.Drawing.Point(41, 119);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(148, 30);
            this.lbDOB.TabIndex = 5;
            this.lbDOB.Text = "ImportDay";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbEmail.Location = new System.Drawing.Point(296, 211);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(130, 30);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "SalePrice";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbPhone.Location = new System.Drawing.Point(296, 119);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(175, 30);
            this.lbPhone.TabIndex = 7;
            this.lbPhone.Text = "ImportPrices";
            // 
            // txtImport
            // 
            this.txtImport.BackColor = System.Drawing.Color.MistyRose;
            this.txtImport.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txtImport.Location = new System.Drawing.Point(301, 152);
            this.txtImport.Name = "txtImport";
            this.txtImport.Size = new System.Drawing.Size(240, 35);
            this.txtImport.TabIndex = 12;
            // 
            // txtSalePr
            // 
            this.txtSalePr.BackColor = System.Drawing.Color.MistyRose;
            this.txtSalePr.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txtSalePr.Location = new System.Drawing.Point(301, 253);
            this.txtSalePr.Name = "txtSalePr";
            this.txtSalePr.Size = new System.Drawing.Size(240, 35);
            this.txtSalePr.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::NetManagement.Properties.Resources.imagesButton;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Location = new System.Drawing.Point(98, 430);
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
            this.btnCancel.Location = new System.Drawing.Point(343, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 44);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpIm
            // 
            this.dtpIm.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtpIm.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dtpIm.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpIm.Location = new System.Drawing.Point(38, 157);
            this.dtpIm.Name = "dtpIm";
            this.dtpIm.Size = new System.Drawing.Size(240, 32);
            this.dtpIm.TabIndex = 21;
            this.dtpIm.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // dtpEx
            // 
            this.dtpEx.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtpEx.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dtpEx.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpEx.Location = new System.Drawing.Point(38, 256);
            this.dtpEx.Name = "dtpEx";
            this.dtpEx.Size = new System.Drawing.Size(240, 32);
            this.dtpEx.TabIndex = 22;
            this.dtpEx.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // cbbProduct
            // 
            this.cbbProduct.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(38, 64);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(240, 38);
            this.cbbProduct.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(296, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.MistyRose;
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txtAmount.Location = new System.Drawing.Point(301, 370);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(240, 35);
            this.txtAmount.TabIndex = 25;
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::NetManagement.Properties.Resources.images1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 540);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbProduct);
            this.Controls.Add(this.dtpEx);
            this.Controls.Add(this.dtpIm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSalePr);
            this.Controls.Add(this.txtImport);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.lbDC);
            this.Controls.Add(this.lbidPro);
            this.Name = "FormAddProduct";
            this.Text = "FormAdd_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtFirst;
        private System.Windows.Forms.Label lbidPro;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtImport;
        private System.Windows.Forms.TextBox txtSalePr;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpIm;
        private System.Windows.Forms.DateTimePicker dtpEx;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
    }
}