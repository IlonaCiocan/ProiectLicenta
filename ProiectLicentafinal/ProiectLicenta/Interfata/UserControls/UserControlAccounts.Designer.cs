namespace ProiectLicenta.Interfata.UserControls
{
    partial class but
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
            this.panel_acc = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_accounts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_acc
            // 
            this.panel_acc.AutoScroll = true;
            this.panel_acc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_acc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_acc.Location = new System.Drawing.Point(0, 50);
            this.panel_acc.Name = "panel_acc";
            this.panel_acc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel_acc.Size = new System.Drawing.Size(500, 250);
            this.panel_acc.TabIndex = 3;
            this.panel_acc.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_acc_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title_accounts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 2;
            // 
            // title_accounts
            // 
            this.title_accounts.AutoSize = true;
            this.title_accounts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_accounts.ForeColor = System.Drawing.SystemColors.Window;
            this.title_accounts.Location = new System.Drawing.Point(129, 12);
            this.title_accounts.MaximumSize = new System.Drawing.Size(260, 0);
            this.title_accounts.MinimumSize = new System.Drawing.Size(260, 0);
            this.title_accounts.Name = "title_accounts";
            this.title_accounts.Size = new System.Drawing.Size(260, 22);
            this.title_accounts.TabIndex = 0;
            this.title_accounts.Text = "Utilizatori existenți în sistem";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProiectLicenta.Properties.Resources.adduser50p;
            this.button1.Location = new System.Drawing.Point(421, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 51);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_acc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "but";
            this.Size = new System.Drawing.Size(500, 394);
            this.Load += new System.EventHandler(this.But_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_acc;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label title_accounts;
    }
}
