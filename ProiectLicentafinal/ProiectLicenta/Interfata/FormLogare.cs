using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mechanisms;
using ProiectLicenta.Business_Layer;
using ProiectLicenta.Interfata.UserControls;

namespace ProiectLicenta
{
    public partial class Form1 : Form
    {
        
        UserControlMainForm uc_main;

        public Form1()
        {
            InitializeComponent();
            InitializeMainComponent();   
        }

        public void InitializeMainComponent()
        {
            ColturiRotunde();
       

            this.uc_main = new UserControlMainForm();
            this.uc_main.Dock = DockStyle.Fill;
            this.uc_main.Tag = "main";


            panel2.Controls.Add(uc_main);
           

            for (int i = 0; i < this.panel2.Controls.Count; i++)
            {
                this.panel2.Controls[i].Hide();
            }
            
            for (int i = 1; i < this.panel2.Controls.Count; i++)
            {
                try
                {
                    if (this.panel2.Controls[i].Tag.ToString() == "main")
                    {
                        this.panel2.Controls[i].Show();
                        this.panel2.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }

            }


        }
        public void ColturiRotunde()
        {
            Rectangle Bounds = new Rectangle(0, 0, this.Width, this.Height);
            int CornerRadius = 15;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }
      

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void TextBox_user_TextChanged(object sender, EventArgs e)
        {

        }

     
   

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      
      
    


    }
}