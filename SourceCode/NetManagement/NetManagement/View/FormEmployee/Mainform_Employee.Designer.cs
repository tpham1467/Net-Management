﻿namespace NetManagement.View.FormEmployee
{
    partial class Mainform_Employee
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.butSpMailbox = new System.Windows.Forms.Button();
            this.butCheckIO = new System.Windows.Forms.Button();
            this.butServicePay = new System.Windows.Forms.Button();
            this.butAccManager = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_left.Controls.Add(this.button1);
            this.panel_left.Controls.Add(this.butSpMailbox);
            this.panel_left.Controls.Add(this.butCheckIO);
            this.panel_left.Controls.Add(this.butServicePay);
            this.panel_left.Controls.Add(this.butAccManager);
            this.panel_left.Controls.Add(this.pictureBox2);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(249, 519);
            this.panel_left.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butSpMailbox
            // 
            this.butSpMailbox.BackColor = System.Drawing.Color.DarkCyan;
            this.butSpMailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSpMailbox.Location = new System.Drawing.Point(0, 323);
            this.butSpMailbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butSpMailbox.Name = "butSpMailbox";
            this.butSpMailbox.Size = new System.Drawing.Size(249, 52);
            this.butSpMailbox.TabIndex = 4;
            this.butSpMailbox.Text = "Support Mailbox";
            this.butSpMailbox.UseVisualStyleBackColor = false;
            this.butSpMailbox.Click += new System.EventHandler(this.butSpMailbox_Click);
            // 
            // butCheckIO
            // 
            this.butCheckIO.BackColor = System.Drawing.Color.DarkCyan;
            this.butCheckIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCheckIO.Location = new System.Drawing.Point(0, 266);
            this.butCheckIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butCheckIO.Name = "butCheckIO";
            this.butCheckIO.Size = new System.Drawing.Size(249, 52);
            this.butCheckIO.TabIndex = 3;
            this.butCheckIO.Text = "Check Work I-O";
            this.butCheckIO.UseVisualStyleBackColor = false;
            this.butCheckIO.Click += new System.EventHandler(this.butCheckIO_Click);
            // 
            // butServicePay
            // 
            this.butServicePay.BackColor = System.Drawing.Color.DarkCyan;
            this.butServicePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butServicePay.Location = new System.Drawing.Point(0, 212);
            this.butServicePay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butServicePay.Name = "butServicePay";
            this.butServicePay.Size = new System.Drawing.Size(249, 49);
            this.butServicePay.TabIndex = 2;
            this.butServicePay.Text = "Service payment";
            this.butServicePay.UseVisualStyleBackColor = false;
            this.butServicePay.Click += new System.EventHandler(this.butServicePay_Click);
            // 
            // butAccManager
            // 
            this.butAccManager.BackColor = System.Drawing.Color.DarkCyan;
            this.butAccManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAccManager.Location = new System.Drawing.Point(0, 154);
            this.butAccManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAccManager.Name = "butAccManager";
            this.butAccManager.Size = new System.Drawing.Size(249, 53);
            this.butAccManager.TabIndex = 1;
            this.butAccManager.Text = "Account Management";
            this.butAccManager.UseVisualStyleBackColor = false;
            this.butAccManager.Click += new System.EventHandler(this.butAccManager_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_top.Controls.Add(this.labelHome);
            this.panel_top.Controls.Add(this.labelTop);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(249, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(863, 150);
            this.panel_top.TabIndex = 2;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.Transparent;
            this.labelHome.Location = new System.Drawing.Point(29, 123);
            this.labelHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(67, 17);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "HOME  |";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.Transparent;
            this.labelTop.Location = new System.Drawing.Point(100, 123);
            this.labelTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(0, 17);
            this.labelTop.TabIndex = 0;
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(249, 150);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(863, 369);
            this.panel_body.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NetManagement.Properties.Resources.backgroud;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::NetManagement.Properties.Resources.Thiết_kế_chưa_có_tên__7_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(513, 296);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mainform_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1112, 519);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mainform_Employee";
            this.Text = "Mainform_Employee";
            this.panel_left.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button butAccManager;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button butCheckIO;
        private System.Windows.Forms.Button butServicePay;
        private System.Windows.Forms.Button butSpMailbox;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button button1;
    }
}