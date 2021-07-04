namespace ProiectLicenta.Interfata.UserControls
{
    partial class UserControlEditAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEditAccount));
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxNewRetype = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_serviciu1 = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.checkBox_editD = new System.Windows.Forms.CheckBox();
            this.label_serviciu = new System.Windows.Forms.TextBox();
            this.button2_check = new System.Windows.Forms.Button();
            this.button1_check = new System.Windows.Forms.Button();
            this.button_viewNR = new System.Windows.Forms.Button();
            this.button_viewN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(68, 25);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(400, 37);
            this.textBoxNewPassword.TabIndex = 7;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.TextBoxNewPassword_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.textBoxNewRetype);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.textBoxNewPassword);
            this.panel5.Location = new System.Drawing.Point(33, 174);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 142);
            this.panel5.TabIndex = 13;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // textBoxNewRetype
            // 
            this.textBoxNewRetype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewRetype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNewRetype.Location = new System.Drawing.Point(68, 81);
            this.textBoxNewRetype.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewRetype.Multiline = true;
            this.textBoxNewRetype.Name = "textBoxNewRetype";
            this.textBoxNewRetype.Size = new System.Drawing.Size(400, 37);
            this.textBoxNewRetype.TabIndex = 19;
            this.textBoxNewRetype.TextChanged += new System.EventHandler(this.TextBoxNewRetype_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProiectLicenta.Properties.Resources.passwordsmall;
            this.pictureBox1.Location = new System.Drawing.Point(16, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProiectLicenta.Properties.Resources.passwordsmall;
            this.pictureBox3.Location = new System.Drawing.Point(16, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(212, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Editare date generale";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_user.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_user.ForeColor = System.Drawing.SystemColors.Control;
            this.label_user.Location = new System.Drawing.Point(103, 81);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(132, 21);
            this.label_user.TabIndex = 16;
            this.label_user.Text = "Nume utilizator";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_cancel.Location = new System.Drawing.Point(107, 434);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(217, 37);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Renunță";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.close_change_password);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.button_save.Location = new System.Drawing.Point(332, 434);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(217, 37);
            this.button_save.TabIndex = 20;
            this.button_save.Text = "Salvează modificările";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_serviciu1
            // 
            this.label_serviciu1.AutoSize = true;
            this.label_serviciu1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_serviciu1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_serviciu1.ForeColor = System.Drawing.SystemColors.Control;
            this.label_serviciu1.Location = new System.Drawing.Point(284, 81);
            this.label_serviciu1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_serviciu1.Name = "label_serviciu1";
            this.label_serviciu1.Size = new System.Drawing.Size(125, 21);
            this.label_serviciu1.TabIndex = 23;
            this.label_serviciu1.Text = "Nume serviciu";
            this.label_serviciu1.Visible = false;
            this.label_serviciu1.Click += new System.EventHandler(this.Label_serviciu_Click);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_message.Location = new System.Drawing.Point(103, 332);
            this.label_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 21);
            this.label_message.TabIndex = 27;
            this.label_message.Visible = false;
            this.label_message.TextChanged += new System.EventHandler(this.Label_Message_Changed);
            // 
            // checkBox_editD
            // 
            this.checkBox_editD.AutoSize = true;
            this.checkBox_editD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_editD.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox_editD.Location = new System.Drawing.Point(515, 142);
            this.checkBox_editD.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_editD.Name = "checkBox_editD";
            this.checkBox_editD.Size = new System.Drawing.Size(91, 25);
            this.checkBox_editD.TabIndex = 28;
            this.checkBox_editD.Text = "Editare";
            this.checkBox_editD.UseVisualStyleBackColor = true;
            this.checkBox_editD.CheckedChanged += new System.EventHandler(this.Enable_Departament);
            // 
            // label_serviciu
            // 
            this.label_serviciu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.label_serviciu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_serviciu.Enabled = false;
            this.label_serviciu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serviciu.ForeColor = System.Drawing.SystemColors.Window;
            this.label_serviciu.Location = new System.Drawing.Point(107, 138);
            this.label_serviciu.Margin = new System.Windows.Forms.Padding(4);
            this.label_serviciu.Name = "label_serviciu";
            this.label_serviciu.Size = new System.Drawing.Size(405, 20);
            this.label_serviciu.TabIndex = 29;
            // 
            // button2_check
            // 
            this.button2_check.BackColor = System.Drawing.Color.Transparent;
            this.button2_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2_check.FlatAppearance.BorderSize = 0;
            this.button2_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_check.ForeColor = System.Drawing.Color.Transparent;
            this.button2_check.Image = ((System.Drawing.Image)(resources.GetObject("button2_check.Image")));
            this.button2_check.Location = new System.Drawing.Point(553, 255);
            this.button2_check.Margin = new System.Windows.Forms.Padding(0);
            this.button2_check.Name = "button2_check";
            this.button2_check.Size = new System.Drawing.Size(40, 37);
            this.button2_check.TabIndex = 26;
            this.button2_check.UseVisualStyleBackColor = false;
            this.button2_check.Visible = false;
            // 
            // button1_check
            // 
            this.button1_check.BackColor = System.Drawing.Color.Transparent;
            this.button1_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1_check.FlatAppearance.BorderSize = 0;
            this.button1_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_check.ForeColor = System.Drawing.Color.Transparent;
            this.button1_check.Image = ((System.Drawing.Image)(resources.GetObject("button1_check.Image")));
            this.button1_check.Location = new System.Drawing.Point(553, 199);
            this.button1_check.Margin = new System.Windows.Forms.Padding(0);
            this.button1_check.Name = "button1_check";
            this.button1_check.Size = new System.Drawing.Size(40, 37);
            this.button1_check.TabIndex = 24;
            this.button1_check.UseVisualStyleBackColor = false;
            this.button1_check.Visible = false;
            // 
            // button_viewNR
            // 
            this.button_viewNR.BackColor = System.Drawing.SystemColors.Window;
            this.button_viewNR.Enabled = false;
            this.button_viewNR.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_viewNR.FlatAppearance.BorderSize = 0;
            this.button_viewNR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewNR.ForeColor = System.Drawing.Color.Transparent;
            this.button_viewNR.Image = ((System.Drawing.Image)(resources.GetObject("button_viewNR.Image")));
            this.button_viewNR.Location = new System.Drawing.Point(509, 255);
            this.button_viewNR.Margin = new System.Windows.Forms.Padding(4);
            this.button_viewNR.Name = "button_viewNR";
            this.button_viewNR.Size = new System.Drawing.Size(40, 37);
            this.button_viewNR.TabIndex = 20;
            this.button_viewNR.TabStop = false;
            this.button_viewNR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_viewNR.UseVisualStyleBackColor = false;
            this.button_viewNR.Click += new System.EventHandler(this.viewNewRetype);
            // 
            // button_viewN
            // 
            this.button_viewN.BackColor = System.Drawing.SystemColors.Window;
            this.button_viewN.Enabled = false;
            this.button_viewN.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_viewN.FlatAppearance.BorderSize = 0;
            this.button_viewN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewN.ForeColor = System.Drawing.SystemColors.Window;
            this.button_viewN.Image = ((System.Drawing.Image)(resources.GetObject("button_viewN.Image")));
            this.button_viewN.Location = new System.Drawing.Point(509, 199);
            this.button_viewN.Margin = new System.Windows.Forms.Padding(4);
            this.button_viewN.Name = "button_viewN";
            this.button_viewN.Size = new System.Drawing.Size(40, 37);
            this.button_viewN.TabIndex = 18;
            this.button_viewN.TabStop = false;
            this.button_viewN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_viewN.UseVisualStyleBackColor = false;
            this.button_viewN.Click += new System.EventHandler(this.viewNewPassword);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(49, 174);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "     Schimbă parola";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.change_password);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProiectLicenta.Properties.Resources.serviciu;
            this.pictureBox5.Location = new System.Drawing.Point(49, 126);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProiectLicenta.Properties.Resources.accountsmall;
            this.pictureBox2.Location = new System.Drawing.Point(49, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // UserControlEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.label_serviciu);
            this.Controls.Add(this.checkBox_editD);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button2_check);
            this.Controls.Add(this.button1_check);
            this.Controls.Add(this.button_viewNR);
            this.Controls.Add(this.label_serviciu1);
            this.Controls.Add(this.button_viewN);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlEditAccount";
            this.Size = new System.Drawing.Size(667, 485);
            this.Load += new System.EventHandler(this.UserControlEditAccount_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_viewNR;
        private System.Windows.Forms.TextBox textBoxNewRetype;
        private System.Windows.Forms.Button button_viewN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_serviciu1;
        private System.Windows.Forms.Button button1_check;
        private System.Windows.Forms.Button button2_check;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.CheckBox checkBox_editD;
        private System.Windows.Forms.TextBox label_serviciu;
    }
}
