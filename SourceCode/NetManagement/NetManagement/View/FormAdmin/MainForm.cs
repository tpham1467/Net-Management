﻿using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using NetManagement.View.FormDashBoard;
namespace NetManagement.View.FormAdmin
{
    public partial class Main_Form : Form
    {
        public Action action;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Main_Form()
        {
            InitializeComponent();
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActiveButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon current Child Form
                icPtHome.IconChar = currentBtn.IconChar;
                icPtHome.IconColor = color;
            }
            icPtHome.IconColor = Color.LightSteelBlue;
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(47, 79, 79);
                currentBtn.ForeColor = Color.FromArgb(255, 255, 128);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(255, 255, 128);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(childForm);
            pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lbTitle.Text = childForm.Text;
        }

        private void playSimpleSound()
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"D:\pbl3_1\sound.wav");
            //simpleSound.Play();
        }

        private void icBtnDB_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            lbTitle.Text = icBtnDB.Text;
            playSimpleSound();
            icPtHome.IconChar= icBtnDB.IconChar;
            OpenChildForm(new View.FormDashBoard.FormDashBoard());
        }


        private void icBtnE_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            lbTitle.Text = icBtnE.Text;
            playSimpleSound();
            icPtHome.IconChar = icBtnE.IconChar;
            OpenChildForm(new FormEmployees());
        }

        private void icBtnSh_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            lbTitle.Text = icBtnSh.Text;
            playSimpleSound();
            icPtHome.IconChar = icBtnSh.IconChar;
            OpenChildForm(new FormShift());
        }

        private void icBtnCus_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            lbTitle.Text = icBtnCus.Text;
            playSimpleSound();
            icPtHome.IconChar = icBtnCus.IconChar;
            OpenChildForm(new FormCustommer());
        }

        private void icBtnPro_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            lbTitle.Text = icBtnPro.Text;
            playSimpleSound();
            icPtHome.IconChar = icBtnPro.IconChar;
            OpenChildForm(new FormProducts());
        }

        

        private void LogoHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icPtHome.IconChar = IconChar.Home;
            lbTitle.Text = "Home";
        }

        private void icBtnLogOut_Click(object sender, EventArgs e)
        {
            action();
            this.Dispose();
        }   

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            lbTime.Text = dt.ToString("hh:mm:ss tt");
        }

        private void icCategory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            lbTitle.Text = icCategory.Text;
            playSimpleSound();
            icPtHome.IconChar = icCategory.IconChar;
            OpenChildForm(new FormCategory());
        }
    }

}
