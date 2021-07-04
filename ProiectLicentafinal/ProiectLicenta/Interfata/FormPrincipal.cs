using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectLicenta.Business_Layer;
using Mechanisms;
using ProiectLicenta.Interfata.UserControls;

namespace ProiectLicenta.Interfata
{
    public partial class FormPrincipal : Form
    {
        
        public UserControls.but uc_accounts;
        UserControls.UserControlCrypt uc_cryp;
        UserControls.UserControlDecrypt uc_decrypt;
        UserControls.UserControlHomeAdmin uc_homeadmin;
        UserControls.UserControlHomeUser uc_homeuser;
        UserControlEditAccount uc_edit;
        UserControlEditUser uc_editacc;
        UserControlKey uc_newkey;
        UserControlNewAccount uc_newaccount;
       
        UserControlAudit ucAU;
      

        string user;
      

        public FormPrincipal(string user)
        {
            
            InitializeComponent();
            this.user = user;
            Database db = new Database("dbtest");

            if (db.isAdmin(user) == true)
            {
                InitializareUCAdmin();
            }
            else
            {
                InitializareUC();
            }
            
        }
        public void Initializare()
        {
            InitializareUC();
        }
        public void BringGenerateKeyToFront(String type)
        {
            uc_newkey.typeB = type;
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "newkey")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }

        }

        public void BringEditUserToFront(string _user, string departament, bool admin)
        {
            panel_content.Controls.Remove(uc_accounts);
            uc_editacc = new UserControlEditUser(_user,departament,admin,this);
            uc_editacc.Dock = DockStyle.Fill;
            uc_editacc.Tag = "edit_acc";
          

            this.panel_content.Controls.Add(uc_editacc);
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "edit_acc")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
        public void BringCryptoKeyToFront(String n_key,String type)
        {
            if (type == "E")
            {
                uc_cryp.pictureBox2.Visible = true;
                BringEncryptToFront(n_key);
            }


            else if (type == "D")
            {
                uc_decrypt.pictureBox2.Visible = true;
                BringDecryptToFront(n_key);
            }

           
        }
       
        public void InitializareUCAdmin(int number=1)
        {
       
            this.uc_accounts = new UserControls.but(this.user,this);
            this.uc_accounts.Dock = DockStyle.Fill;
            this.uc_accounts.Tag = "acc";

            this.uc_homeadmin = new UserControls.UserControlHomeAdmin(this.user);
            this.uc_homeadmin.Dock = DockStyle.Fill;
            this.uc_homeadmin.Tag = "hadm";

            
            this.ucAU = new UserControlAudit();
            this.ucAU.Dock = DockStyle.Fill;
            this.ucAU.Tag = "admAU";

           
            this.uc_edit = new UserControlEditAccount(this.user);
            this.uc_edit.Dock = DockStyle.Fill;
            this.uc_edit.Tag = "edit";

            this.uc_newaccount=new UserControlNewAccount(this);
            this.uc_newaccount.Dock = DockStyle.Fill;
            this.uc_newaccount.Tag = "newacc";


       
           this.panel_content.Controls.Add(uc_accounts);
            this.panel_content.Controls.Add(uc_homeadmin);
            this.panel_content.Controls.Add(ucAU);
            this.panel_content.Controls.Add(uc_edit);


            this.panel_content.Controls[1].BringToFront();

            this.button3.Visible = false;
            this.button4.Visible = false;

        }
        public void InitializareUC()
        {

            this.uc_edit = new UserControlEditAccount(this.user);
            this.uc_edit.Dock = DockStyle.Fill;
            this.uc_edit.Tag = "edit";

          

            this.uc_cryp = new UserControls.UserControlCrypt(this.user,this);
            this.uc_cryp.Dock = DockStyle.Fill;
            this.uc_cryp.Tag = "enc";

            this.uc_decrypt = new UserControls.UserControlDecrypt(this.user,this);
            this.uc_decrypt.Dock = DockStyle.Fill;
            this.uc_decrypt.Tag = "decrypt";

            this.uc_homeadmin = new UserControls.UserControlHomeAdmin(this.user);
            this.uc_homeadmin.Dock = DockStyle.Fill;
            this.uc_homeadmin.Tag = "hadm";

            this.uc_homeuser = new UserControls.UserControlHomeUser(this.user);
            this.uc_homeuser.Dock = DockStyle.Fill;
            this.uc_homeuser.Tag = "husr";
            this.uc_newkey = new UserControls.UserControlKey(this.user,this );
            this.uc_newkey.Dock = DockStyle.Fill;
            this.uc_newkey.Tag = "newkey";


            this.panel_content.Controls.Add(uc_edit);
            this.panel_content.Controls.Add(uc_cryp);
            this.panel_content.Controls.Add(uc_homeadmin);
            this.panel_content.Controls.Add(uc_homeuser);
            this.panel_content.Controls.Add(uc_decrypt);
            this.panel_content.Controls.Add(uc_newkey);

            this.panel_content.Controls[3].BringToFront();
         
            this.button5.Visible = false;
            this.button6.Visible = false;
        }

        public void BringHomeToFront()
        {
            if(panel_topbar.Visible==false)
            {
                panel_topbar.Visible = true;
            }
            HideAll();
            string tag;
            Database db = new Database("dbtest");
            if (db.isAdmin(this.user) == true)
            {
                tag = "hadm";
            }
            else
            {
                tag = "husr";
            }
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == tag)
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }

        }
        public void BrindAdministrareBDToFront()
        {
            if (panel_topbar.Visible == false)
            {
                panel_topbar.Visible = true;
            }
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "admBD")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
        public void BringAuditToFront()
        {
            if (panel_topbar.Visible == false)
            {
                panel_topbar.Visible = true;
            }
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "admAU")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
        public void BringPerformantaToFront()
        {
            if (panel_topbar.Visible == false)
            {
                panel_topbar.Visible = true;
            }
            HideAll();
            for(int i=0;i<this.panel_content.Controls.Count;i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "home")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
            
        }
        public void BringAccountToFront()
        {
            if (panel_topbar.Visible == false)
            {
                panel_topbar.Visible = true;
            }
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "edit")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
                
            }
        }

        public void BringAccountsBDToFront()
        {
            bool refresh = false;
            string UC_tag = "acc";
            if (panel_topbar.Visible == false)
            {
                panel_topbar.Visible = true;
            }
            panel_content.Controls.Remove(uc_editacc);
            uc_accounts.title_accounts.Invoke(new MethodInvoker(() => uc_accounts.title_accounts.Text = "Utilizatori existenți în sistem"));

            if (this.panel_content.Controls.Contains(uc_accounts)==false)
            {
                refresh = true;
                
                this.uc_accounts = new UserControls.but(this.user, this);
                this.uc_accounts.Dock = DockStyle.Fill;
                this.uc_accounts.Tag = "refreshacc";
                this.panel_content.Controls.Add(uc_accounts);
            }
            
            HideAll();

            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                  
                   if (refresh==true)
                    {
                        UC_tag = "refreshacc";
                    }
                  
                    if (this.panel_content.Controls[i].Tag.ToString() == UC_tag)
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }

            }
        }
        public void BringKeyToFront()
        {
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "key")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
                
            }
        }
        public void BringEncryptToFront()
        {
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "enc")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        public void BringEncryptToFront(String key)
        {
            uc_cryp.key = key;
           
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "enc")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }


        public void BringDecryptToFront()
        {
          
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "decrypt")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
        public void BringDecryptToFront(string key)
        {
            uc_decrypt.key= key;
            HideAll();
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "decrypt")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
        public void BringTestingToFront()
        {
            HideAll();

            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                if (this.panel_content.Controls[i].Tag.ToString() == "test")
                {
                    this.panel_content.Controls[i].Show();
                    this.panel_content.Controls[i].BringToFront();
                    break;
                }
            }
        }
        public void BringNewAccountToFront()
        {
            panel_topbar.Visible = false;
            panel_content.Controls.Add(uc_newaccount);
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                this.panel_content.Controls[i].Hide();
            }
            for (int i = 0; i < this.panel_content.Controls.Count; i++)
            {
                try
                {
                    if (this.panel_content.Controls[i].Tag.ToString() == "newacc")
                    {
                        this.panel_content.Controls[i].Show();
                        this.panel_content.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }

            }

        }
    
        public void HideAll()
        {
            for(int i=0;i<this.panel_content.Controls.Count;i++)
            {
                this.panel_content.Controls[i].Hide();
            }
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            BringHomeToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BringAccountToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BringKeyToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BringEncryptToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BringPerformantaToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BringDecryptToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BringAccountsBDToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BringAuditToFront();
        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form1 logare = new Form1();
            this.Hide();
            logare.ShowDialog();
            this.Close();
            
        }
    }
}
