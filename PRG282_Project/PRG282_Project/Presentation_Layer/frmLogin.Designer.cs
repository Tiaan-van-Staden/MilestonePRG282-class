
namespace PRG282_Project
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnShowRegister = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblPassw1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxPassw1 = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblPassw2 = new System.Windows.Forms.Label();
            this.tbxPassw2 = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnBack);
            this.pnlBottom.Controls.Add(this.btnRegister);
            this.pnlBottom.Controls.Add(this.btnLogin);
            this.pnlBottom.Controls.Add(this.btnShowRegister);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 411);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(544, 100);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(280, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(252, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(12, 24);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(252, 50);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(280, 24);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(252, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnShowRegister
            // 
            this.btnShowRegister.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnShowRegister.FlatAppearance.BorderSize = 2;
            this.btnShowRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRegister.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRegister.Location = new System.Drawing.Point(12, 24);
            this.btnShowRegister.Name = "btnShowRegister";
            this.btnShowRegister.Size = new System.Drawing.Size(252, 50);
            this.btnShowRegister.TabIndex = 0;
            this.btnShowRegister.Text = "Create New Account?";
            this.btnShowRegister.UseVisualStyleBackColor = true;
            this.btnShowRegister.Click += new System.EventHandler(this.btnShowRegister_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblPassw1);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.tbxPassw1);
            this.pnlMain.Controls.Add(this.tbxUsername);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 199);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(544, 144);
            this.pnlMain.TabIndex = 2;
            // 
            // lblPassw1
            // 
            this.lblPassw1.AutoSize = true;
            this.lblPassw1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassw1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPassw1.Location = new System.Drawing.Point(3, 109);
            this.lblPassw1.Name = "lblPassw1";
            this.lblPassw1.Size = new System.Drawing.Size(105, 32);
            this.lblPassw1.TabIndex = 3;
            this.lblPassw1.Text = "Password";
            this.lblPassw1.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblName.Location = new System.Drawing.Point(3, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Username";
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // tbxPassw1
            // 
            this.tbxPassw1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassw1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxPassw1.Location = new System.Drawing.Point(203, 106);
            this.tbxPassw1.Name = "tbxPassw1";
            this.tbxPassw1.PasswordChar = '•';
            this.tbxPassw1.Size = new System.Drawing.Size(329, 33);
            this.tbxPassw1.TabIndex = 1;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxUsername.Location = new System.Drawing.Point(203, 37);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(329, 33);
            this.tbxUsername.TabIndex = 0;
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.lblPassw2);
            this.pnlRegister.Controls.Add(this.tbxPassw2);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegister.Location = new System.Drawing.Point(0, 343);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(544, 68);
            this.pnlRegister.TabIndex = 3;
            this.pnlRegister.Visible = false;
            // 
            // lblPassw2
            // 
            this.lblPassw2.AutoSize = true;
            this.lblPassw2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassw2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPassw2.Location = new System.Drawing.Point(3, 32);
            this.lblPassw2.Name = "lblPassw2";
            this.lblPassw2.Size = new System.Drawing.Size(194, 32);
            this.lblPassw2.TabIndex = 4;
            this.lblPassw2.Text = "Confirm Password";
            this.lblPassw2.UseCompatibleTextRendering = true;
            // 
            // tbxPassw2
            // 
            this.tbxPassw2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassw2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxPassw2.Location = new System.Drawing.Point(203, 32);
            this.tbxPassw2.Name = "tbxPassw2";
            this.tbxPassw2.PasswordChar = '•';
            this.tbxPassw2.Size = new System.Drawing.Size(329, 33);
            this.tbxPassw2.TabIndex = 4;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTop.BackgroundImage = global::PRG282_Project.Properties.Resources.BC_Logo;
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(544, 199);
            this.pnlTop.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 511);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.pnlBottom.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnShowRegister;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox tbxPassw1;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox tbxPassw2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPassw1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassw2;
    }
}

