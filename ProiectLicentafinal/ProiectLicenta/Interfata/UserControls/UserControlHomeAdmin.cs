using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mechanisms;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlHomeAdmin : UserControl
    {
        Database db;
        string user;

        public UserControlHomeAdmin(string user_adm)
        {
            InitializeComponent();
            db = new Database("dbtest");
            this.user = user_adm;
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label_numeadm.Text = this.user;
            label_time.Text = DateTime.Now.ToLongTimeString();
            label_date.Text = DateTime.Now.ToLongDateString().ToUpperInvariant();
            label_numeadm.Text = this.user+" !";
            var array_dep= db.getDepartaments();
            string departaments = "";
            foreach(string dep in array_dep)
            {
                departaments = departaments + dep + ", ";
            }
            label_dep.Text = departaments.Substring(0, departaments.Length - 2);
            label_countacc.Text = db.CountAcc();
            label_countadm.Text = db.CountAdm();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Label_countadm_Click(object sender, EventArgs e)
        {

        }
    }
}
