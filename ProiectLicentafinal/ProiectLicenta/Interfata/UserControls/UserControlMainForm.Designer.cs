namespace ProiectLicenta.Interfata.UserControls
{
    partial class UserControlMainForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogare = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_mini = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonLogare);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 462);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.button1.Location = new System.Drawing.Point(355, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "ÎNREGISTRARE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonLogare
            // 
            this.buttonLogare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.buttonLogare.FlatAppearance.BorderSize = 0;
            this.buttonLogare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogare.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogare.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLogare.Location = new System.Drawing.Point(93, 375);
            this.buttonLogare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogare.Name = "buttonLogare";
            this.buttonLogare.Size = new System.Drawing.Size(209, 49);
            this.buttonLogare.TabIndex = 6;
            this.buttonLogare.Text = "AUTENTIFICARE";
            this.buttonLogare.UseVisualStyleBackColor = false;
            this.buttonLogare.TextChanged += new System.EventHandler(this.ButtonLogare_Click);
            this.buttonLogare.Click += new System.EventHandler(this.buttonLogare_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.textBox2_password);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(93, 294);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(471, 49);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // textBox2_password
            // 
            this.textBox2_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2_password.Location = new System.Drawing.Point(69, 17);
            this.textBox2_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.Size = new System.Drawing.Size(391, 20);
            this.textBox2_password.TabIndex = 8;
            this.textBox2_password.Tag = "";
            this.textBox2_password.TextChanged += new System.EventHandler(this.TextBox2_password_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProiectLicenta.Properties.Resources.passwordsmall;
            this.pictureBox3.Location = new System.Drawing.Point(15, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.textBox_user);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(93, 237);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 49);
            this.panel4.TabIndex = 4;
            // 
            // textBox_user
            // 
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_user.Location = new System.Drawing.Point(69, 17);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(392, 20);
            this.textBox_user.TabIndex = 7;
            this.textBox_user.TextChanged += new System.EventHandler(this.TextBox_user_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProiectLicenta.Properties.Resources.accountsmall;
            this.pictureBox2.Location = new System.Drawing.Point(16, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(185, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Autentificare în aplicație";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_exit);
            this.panel3.Controls.Add(this.button_mini);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 69);
            this.panel3.TabIndex = 2;
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = global::ProiectLicenta.Properties.Resources.close;
            this.button_exit.Location = new System.Drawing.Point(608, 15);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(43, 39);
            this.button_exit.TabIndex = 0;
            this.button_exit.TabStop = false;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.TextChanged += new System.EventHandler(this.Button_exit_Click);
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_mini
            // 
            this.button_mini.FlatAppearance.BorderSize = 0;
            this.button_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mini.Image = global::ProiectLicenta.Properties.Resources.mini;
            this.button_mini.Location = new System.Drawing.Point(557, 15);
            this.button_mini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_mini.Name = "button_mini";
            this.button_mini.Size = new System.Drawing.Size(43, 39);
            this.button_mini.TabIndex = 1;
            this.button_mini.TabStop = false;
            this.button_mini.UseVisualStyleBackColor = true;
            this.button_mini.TextChanged += new System.EventHandler(this.Button_mini_Click);
            this.button_mini.Click += new System.EventHandler(this.Button_mini_Click);
            // 
            // UserControlMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlMainForm";
            this.Size = new System.Drawing.Size(667, 462);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogare;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_mini;
    }
}
