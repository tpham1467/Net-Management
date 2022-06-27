namespace NetManagement.View.FormEmployee
{
    partial class ServicePay_Form
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnfill = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Green;
            this.btnPayment.Location = new System.Drawing.Point(426, 399);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(195, 33);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnfill
            // 
            this.btnfill.BackColor = System.Drawing.Color.Red;
            this.btnfill.Location = new System.Drawing.Point(129, 404);
            this.btnfill.Name = "btnfill";
            this.btnfill.Size = new System.Drawing.Size(115, 23);
            this.btnfill.TabIndex = 2;
            this.btnfill.Text = "fill ";
            this.btnfill.UseVisualStyleBackColor = false;
            this.btnfill.Click += new System.EventHandler(this.btnfill_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(293, 403);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // ServicePay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.btnfill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPayment);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ServicePay_Form";
            this.Text = "ServicePay_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfill;
        private System.Windows.Forms.Button buttonReload;
    }
}