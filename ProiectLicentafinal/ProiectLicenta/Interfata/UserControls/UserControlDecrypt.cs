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
    public partial class UserControlDecrypt : UserControl
    {
        string user;
        public string key;
        List<string> selectedFiles;
        List<string> cale_fisiere;
        FormPrincipal mainForm;
        public UserControlDecrypt(string who, FormPrincipal mainF)
        {
            mainForm = mainF;
            InitializeComponent();
            this.user = who;
            selectedFiles = new List<string>();


            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;


            cale_fisiere = new List<string>();
        }
    
        private void buttonKey_Click(object sender, EventArgs e)
        {
            if (key != null)
            {
                MessageBox.Show(key);
            }
            else
            {
                mainForm.BringGenerateKeyToFront("D");

            }


        }
        public void Decrypt(string fisier)
        {
            Database db = new Database("dbtest");
            db.WriteToLogFile("Operatiune_Decriptare", this.label3.Text, "", this.user);
            MessageBox.Show("Fisier Decriptat");
            this.pictureBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cale_fisiere.Count; i++)
            {
                Decrypt(cale_fisiere[i]);
            }

        }


        private void button1_Click(object sender, EventArgs e)
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

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
