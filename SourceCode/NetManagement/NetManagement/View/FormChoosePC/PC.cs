using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Drawing;
namespace QLQNet
{
    public class PC : PictureBox
    {

        public static Label CreateLabel(string namepc)
        {
            return new Label()
            {
                AutoSize = true,
                BackColor = System.Drawing.SystemColors.ActiveCaption,
                Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(101, 3),
                Name = namepc,
                Size = new System.Drawing.Size(80, 33),
                TabIndex = 1,
                Text = namepc,
            };
           

        }
        public PC(string namepc ,string id,bool status)
        { 
            
            _Name = namepc;
            IDMay = id;
            Status = true;
            Name = namepc;
            Size = new Size(272, 223);
            Location = new Point(0, 3);
            Image = global::QLQNet.Properties.Resources.PC;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BackColor = System.Drawing.Color.DarkSeaGreen;
            TabIndex = 3;
            TabStop = false;
            
        }
        public string _Name { get; set; }
        public string IDMay { get; set; }
        public bool Status { get; set; }
      
    }
}
