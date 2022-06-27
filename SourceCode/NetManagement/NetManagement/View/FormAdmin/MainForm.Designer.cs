using System;

namespace NetManagement.View.FormAdmin
{
    partial class Main_Form
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.icBtnLogOut = new FontAwesome.Sharp.IconButton();
            this.icCategory = new FontAwesome.Sharp.IconButton();
            this.icBtnPro = new FontAwesome.Sharp.IconButton();
            this.icBtnCus = new FontAwesome.Sharp.IconButton();
            this.icBtnSh = new FontAwesome.Sharp.IconButton();
            this.icBtnE = new FontAwesome.Sharp.IconButton();
            this.icBtnDB = new FontAwesome.Sharp.IconButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.LogoHome = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.icPtHome = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).BeginInit();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icPtHome)).BeginInit();
            this.pnDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnMenu.Controls.Add(this.icBtnLogOut);
            this.pnMenu.Controls.Add(this.icCategory);
            this.pnMenu.Controls.Add(this.icBtnPro);
            this.pnMenu.Controls.Add(this.icBtnCus);
            this.pnMenu.Controls.Add(this.icBtnSh);
            this.pnMenu.Controls.Add(this.icBtnE);
            this.pnMenu.Controls.Add(this.icBtnDB);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(220, 845);
            this.pnMenu.TabIndex = 0;
            // 
            // icBtnLogOut
            // 
            this.icBtnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.icBtnLogOut.IconColor = System.Drawing.Color.Black;
            this.icBtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnLogOut.IconSize = 54;
            this.icBtnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.icBtnLogOut.Location = new System.Drawing.Point(59, 662);
            this.icBtnLogOut.Name = "icBtnLogOut";
            this.icBtnLogOut.Size = new System.Drawing.Size(56, 52);
            this.icBtnLogOut.TabIndex = 2;
            this.icBtnLogOut.UseVisualStyleBackColor = true;
            this.icBtnLogOut.Click += new System.EventHandler(this.icBtnLogOut_Click);
            // 
            // icCategory
            // 
            this.icCategory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.icCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.icCategory.FlatAppearance.BorderSize = 0;
            this.icCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.icCategory.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.icCategory.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.icCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icCategory.IconSize = 32;
            this.icCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icCategory.Location = new System.Drawing.Point(0, 438);
            this.icCategory.Name = "icCategory";
            this.icCategory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icCategory.Size = new System.Drawing.Size(220, 58);
            this.icCategory.TabIndex = 7;
            this.icCategory.Text = "Category";
            this.icCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icCategory.UseVisualStyleBackColor = false;
            this.icCategory.Click += new System.EventHandler(this.icCategory_Click);
            // 
            // icBtnPro
            // 
            this.icBtnPro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.icBtnPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnPro.FlatAppearance.BorderSize = 0;
            this.icBtnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.icBtnPro.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.icBtnPro.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.icBtnPro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnPro.IconSize = 32;
            this.icBtnPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnPro.Location = new System.Drawing.Point(0, 380);
            this.icBtnPro.Name = "icBtnPro";
            this.icBtnPro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icBtnPro.Size = new System.Drawing.Size(220, 58);
            this.icBtnPro.TabIndex = 6;
            this.icBtnPro.Text = "Products";
            this.icBtnPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnPro.UseVisualStyleBackColor = false;
            this.icBtnPro.Click += new System.EventHandler(this.icBtnPro_Click);
            // 
            // icBtnCus
            // 
            this.icBtnCus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.icBtnCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnCus.FlatAppearance.BorderSize = 0;
            this.icBtnCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.icBtnCus.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.icBtnCus.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.icBtnCus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnCus.IconSize = 32;
            this.icBtnCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnCus.Location = new System.Drawing.Point(0, 320);
            this.icBtnCus.Name = "icBtnCus";
            this.icBtnCus.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icBtnCus.Size = new System.Drawing.Size(220, 60);
            this.icBtnCus.TabIndex = 4;
            this.icBtnCus.Text = "Customers";
            this.icBtnCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnCus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnCus.UseVisualStyleBackColor = false;
            this.icBtnCus.Click += new System.EventHandler(this.icBtnCus_Click);
            // 
            // icBtnSh
            // 
            this.icBtnSh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.icBtnSh.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnSh.FlatAppearance.BorderSize = 0;
            this.icBtnSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnSh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.icBtnSh.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.icBtnSh.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.icBtnSh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnSh.IconSize = 32;
            this.icBtnSh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnSh.Location = new System.Drawing.Point(0, 260);
            this.icBtnSh.Name = "icBtnSh";
            this.icBtnSh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icBtnSh.Size = new System.Drawing.Size(220, 60);
            this.icBtnSh.TabIndex = 3;
            this.icBtnSh.Text = "Shift";
            this.icBtnSh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnSh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnSh.UseVisualStyleBackColor = false;
            this.icBtnSh.Click += new System.EventHandler(this.icBtnSh_Click);
            // 
            // icBtnE
            // 
            this.icBtnE.BackColor = System.Drawing.Color.DarkSlateGray;
            this.icBtnE.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnE.FlatAppearance.BorderSize = 0;
            this.icBtnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.icBtnE.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icBtnE.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.icBtnE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnE.IconSize = 32;
            this.icBtnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnE.Location = new System.Drawing.Point(0, 200);
            this.icBtnE.Name = "icBtnE";
            this.icBtnE.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icBtnE.Size = new System.Drawing.Size(220, 60);
            this.icBtnE.TabIndex = 2;
            this.icBtnE.Text = "Employees";
            this.icBtnE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnE.UseVisualStyleBackColor = false;
            this.icBtnE.Click += new System.EventHandler(this.icBtnE_Click);
            // 
            // icBtnDB
            // 
            this.icBtnDB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.icBtnDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnDB.FlatAppearance.BorderSize = 0;
            this.icBtnDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.icBtnDB.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.icBtnDB.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.icBtnDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnDB.IconSize = 32;
            this.icBtnDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnDB.Location = new System.Drawing.Point(0, 140);
            this.icBtnDB.Name = "icBtnDB";
            this.icBtnDB.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icBtnDB.Size = new System.Drawing.Size(220, 60);
            this.icBtnDB.TabIndex = 1;
            this.icBtnDB.Text = "DashBoard";
            this.icBtnDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnDB.UseVisualStyleBackColor = false;
            this.icBtnDB.Click += new System.EventHandler(this.icBtnDB_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.SeaGreen;
            this.pnLogo.Controls.Add(this.LogoHome);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(220, 140);
            this.pnLogo.TabIndex = 0;
            // 
            // LogoHome
            // 
            this.LogoHome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LogoHome.Image = global::NetManagement.Properties.Resources.Logo1;
            this.LogoHome.Location = new System.Drawing.Point(3, 3);
            this.LogoHome.Name = "LogoHome";
            this.LogoHome.Size = new System.Drawing.Size(214, 134);
            this.LogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoHome.TabIndex = 0;
            this.LogoHome.TabStop = false;
            this.LogoHome.Click += new System.EventHandler(this.LogoHome_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Controls.Add(this.icPtHome);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(220, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1320, 140);
            this.pnTitle.TabIndex = 1;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbTitle.Location = new System.Drawing.Point(81, 59);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(171, 61);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Home";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // icPtHome
            // 
            this.icPtHome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.icPtHome.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.icPtHome.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.icPtHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icPtHome.IconColor = System.Drawing.Color.LightSteelBlue;
            this.icPtHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icPtHome.IconSize = 51;
            this.icPtHome.Location = new System.Drawing.Point(24, 59);
            this.icPtHome.Name = "icPtHome";
            this.icPtHome.Size = new System.Drawing.Size(51, 62);
            this.icPtHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icPtHome.TabIndex = 1;
            this.icPtHome.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pnDesktop
            // 
            this.pnDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.pnDesktop.BackgroundImage = global::NetManagement.Properties.Resources.mainBACKGROUND2;
            this.pnDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDesktop.Controls.Add(this.lbTime);
            this.pnDesktop.Controls.Add(this.pictureBox1);
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(220, 140);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1320, 705);
            this.pnDesktop.TabIndex = 3;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Enabled = false;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Aqua;
            this.lbTime.Location = new System.Drawing.Point(582, 499);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(160, 32);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "9:05:21 PM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NetManagement.Properties.Resources.Logo2_remove;
            this.pictureBox1.Location = new System.Drawing.Point(394, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnMenu);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icPtHome)).EndInit();
            this.pnDesktop.ResumeLayout(false);
            this.pnDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox LogoHome;
        private FontAwesome.Sharp.IconButton icBtnCus;
        private FontAwesome.Sharp.IconButton icBtnSh;
        private FontAwesome.Sharp.IconButton icBtnE;
        private FontAwesome.Sharp.IconButton icBtnDB;
        private System.Windows.Forms.Panel pnTitle;
        private FontAwesome.Sharp.IconButton icCategory;
        private FontAwesome.Sharp.IconButton icBtnPro;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconPictureBox icPtHome;
        private System.Windows.Forms.Panel pnDesktop;
        private FontAwesome.Sharp.IconButton icBtnLogOut;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

