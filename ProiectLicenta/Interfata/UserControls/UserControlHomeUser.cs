using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlHomeUser : UserControl
    {
        string user;
        public UserControlHomeUser(string user)
        {
            InitializeComponent();
            this.user = user;
        

        }

       
        private void UserControlHomeUser_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            label_time_user.Text = DateTime.Now.ToLongTimeString();
            label_date_user.Text = DateTime.Now.ToLongDateString().ToUpperInvariant();
            label_numeuser.Text = this.user+" !";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label_time_user.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
