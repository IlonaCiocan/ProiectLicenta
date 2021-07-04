namespace ProiectLicenta.Interfata
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel_meniuStanga = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_meniu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel_topbar = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_mini = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.panel_meniuStanga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_meniu.SuspendLayout();
            this.panel_principal.SuspendLayout();
            this.panel_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_meniuStanga
            // 
            this.panel_meniuStanga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.panel_meniuStanga.Controls.Add(this.pictureBox1);
            this.panel_meniuStanga.Controls.Add(this.panel_meniu);
            this.panel_meniuStanga.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_meniuStanga.Location = new System.Drawing.Point(0, 0);
            this.panel_meniuStanga.MaximumSize = new System.Drawing.Size(400, 700);
            this.panel_meniuStanga.MinimumSize = new System.Drawing.Size(250, 450);
            this.panel_meniuStanga.Name = "panel_meniuStanga";
            this.panel_meniuStanga.Size = new System.Drawing.Size(250, 450);
            this.panel_meniuStanga.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProiectLicenta.Properties.Resources.iconMainForm1;
            this.pictureBox1.Location = new System.Drawing.Point(57, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel_meniu
            // 
            this.panel_meniu.Controls.Add(this.button7);
            this.panel_meniu.Controls.Add(this.button6);
            this.panel_meniu.Controls.Add(this.button5);
            this.panel_meniu.Controls.Add(this.button4);
            this.panel_meniu.Controls.Add(this.button3);
            this.panel_meniu.Controls.Add(this.button1);
            this.panel_meniu.Controls.Add(this.button_home);
            this.panel_meniu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_meniu.Location = new System.Drawing.Point(0, 149);
            this.panel_meniu.Name = "panel_meniu";
            this.panel_meniu.Size = new System.Drawing.Size(250, 301);
            this.panel_meniu.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button7.ForeColor = System.Drawing.SystemColors.Window;
            this.button7.Image = global::ProiectLicenta.Properties.Resources.logout;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 300);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(250, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "  Ieșire din cont";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Image = global::ProiectLicenta.Properties.Resources.admin;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 250);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "  Administrare";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Image = global::ProiectLicenta.Properties.Resources.log;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 200);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "  Audit";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Image = global::ProiectLicenta.Properties.Resources.testingwhite;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 150);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "  Decriptare";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Image = global::ProiectLicenta.Properties.Resources.encryptwhite;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 100);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "  Criptare";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::ProiectLicenta.Properties.Resources.accountswhite;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "  Contul meu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_home
            // 
            this.button_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button_home.ForeColor = System.Drawing.SystemColors.Window;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home.Location = new System.Drawing.Point(0, 0);
            this.button_home.Name = "button_home";
            this.button_home.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_home.Size = new System.Drawing.Size(250, 50);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "  Acasă";
            this.button_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.panel_content);
            this.panel_principal.Controls.Add(this.panel_topbar);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(250, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(500, 450);
            this.panel_principal.TabIndex = 1;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 56);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(500, 394);
            this.panel_content.TabIndex = 4;
            this.panel_content.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_content_Paint);
            // 
            // panel_topbar
            // 
            this.panel_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.panel_topbar.Controls.Add(this.button_exit);
            this.panel_topbar.Controls.Add(this.button_mini);
            this.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topbar.Location = new System.Drawing.Point(0, 0);
            this.panel_topbar.Name = "panel_topbar";
            this.panel_topbar.Size = new System.Drawing.Size(500, 56);
            this.panel_topbar.TabIndex = 3;
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = global::ProiectLicenta.Properties.Resources.close;
            this.button_exit.Location = new System.Drawing.Point(456, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(32, 32);
            this.button_exit.TabIndex = 0;
            this.button_exit.TabStop = false;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_mini
            // 
            this.button_mini.FlatAppearance.BorderSize = 0;
            this.button_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mini.Image = global::ProiectLicenta.Properties.Resources.mini;
            this.button_mini.Location = new System.Drawing.Point(418, 12);
            this.button_mini.Name = "button_mini";
            this.button_mini.Size = new System.Drawing.Size(32, 32);
            this.button_mini.TabIndex = 1;
            this.button_mini.TabStop = false;
            this.button_mini.UseVisualStyleBackColor = true;
            this.button_mini.Click += new System.EventHandler(this.button_mini_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel_meniuStanga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie Licenta";
            this.panel_meniuStanga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_meniu.ResumeLayout(false);
            this.panel_principal.ResumeLayout(false);
            this.panel_topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_meniuStanga;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel_meniu;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Panel panel_topbar;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_mini;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}