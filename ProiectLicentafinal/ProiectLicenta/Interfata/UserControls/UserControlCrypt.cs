using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Mechanisms;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlCrypt : UserControl
    {

      
        string user;
        public  string key;
        List<string> selectedFiles;
        bool flag1;
        bool flag2;
        bool flag3;
        bool flag4;
        bool flag5;
      
        FormPrincipal mainForm;
        List<string> cale_fisiere;
        public UserControlCrypt(string who,FormPrincipal main)
        {
         
            mainForm = main;
            InitializeComponent();
            this.user = who;
            selectedFiles = new List<string>();


            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;


            flag1 = false;
            flag2 = false;
            flag3 = false;
            flag4 = false;
            flag5 = false;
           

            cale_fisiere = new List<string>();
        }

        public UserControlCrypt(string newkey)
        {
            
            this.key = newkey;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.selectedFiles.Clear();
                foreach (String file in ofd.FileNames)
                {
                    this.selectedFiles.Add(file);
                    try
                    {
                        if ((myStream = ofd.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                MessageBox.Show(file);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la citire");
                    }
                }

           // bun     this.label2.Text = ofd.FileName.ToString();
            }
        }

   

        public static byte[] GenerateSalt()
        {
            byte[] data = new byte[32];
            using (RNGCryptoServiceProvider rgnCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rgnCryptoServiceProvider.GetBytes(data);
            }
            return data;
        }
      /*  private void button3_Click(object sender, EventArgs e)
        {

            
        }

    */

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.flag1 = true;
  //          this.pictureBox01.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(flag1 == true)
            {
                flag2 = true;
     //           this.pictureBox02.Visible = true;
            }
            else
            {
                MessageBox.Show("Completati pasul anterior");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag2 == true)
            {
                flag3 = true;
      //          this.pictureBox03.Visible = true;
            }
            else
            {
                MessageBox.Show("Completati pasul anterior");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (flag3 == true)
            {
                flag4 = true;
    //            this.pictureBox04.Visible = true;
            }
            else
            {
                MessageBox.Show("Completati pasul anterior");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag4 == true)
            {
                flag5 = true;
                //this.pictureBox05.Visible = true;
                //this.pictureBox06.Visible = true;
            }
            else
            {
                MessageBox.Show("Completati pasul anterior");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (flag5 == true)
            {
                //this.pictureBox06.Visible = true;
            }
            else
            {
                MessageBox.Show("Completati pasul anterior");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.IO.Stream myStream;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.selectedFiles.Clear();
                this.cale_fisiere.Clear();
                foreach (String file in ofd.FileNames)
                {
                    this.selectedFiles.Add(file);
                    try
                    {
                        if ((myStream = ofd.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                this.pictureBox1.Visible = true;
                                this.cale_fisiere.Add(file);
                                MessageBox.Show(file);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la citire");
                    }
                }
                this.pictureBox1.Visible = true;
                this.label3.Text = ofd.SafeFileName.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Crypt(string fisier)
        {
            byte[] salt = GenerateSalt();
            byte[] passwords = Encoding.UTF8.GetBytes(this.key);
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;//aes 256 bit encryption c#
            AES.BlockSize = 128;//aes 128 bit encryption c#
            AES.Padding = PaddingMode.PKCS7;
            var key = new Rfc2898DeriveBytes(passwords, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;
            string newname = fisier;
            int i = 1000;
            newname = newname.Substring(0,fisier.Length - 4) + i.ToString();
            bool isok = false;
            
            while(isok == false)
            {
                if (File.Exists(newname + ".pdf"))
                {
                    newname = newname.Substring(0, newname.Length - 4);
                    i++;
                    newname = newname + i.ToString();

                    
                    continue;
                }
                else
                {

                    isok = true;
                    
                }
            }
            
            using (FileStream fsCrypt = new FileStream(newname + ".pdf", FileMode.Create))
            {
                fsCrypt.Write(salt, 0, salt.Length);
                using (CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (FileStream fsIn = new FileStream(fisier, FileMode.Open))
                    {
                        byte[] buffer = new byte[1048576];
                        int read;
                        while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cs.Write(buffer, 0, read);
                        }
                    }
                }
            }
            Database db = new Database("dbtest");
            db.WriteToLogFile("Operatiune_Criptare", this.label3.Text, "", this.user);
            MessageBox.Show("Fisier Criptat");
            this.pictureBox3.Visible = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            for(int i=0;i<cale_fisiere.Count;i++)
            {
                Crypt(cale_fisiere[i]);
            }
            
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (key != null)
            {
                MessageBox.Show(key);
            }
            else
            {
                mainForm.BringGenerateKeyToFront("E");

            }
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
