
namespace PRG282_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnViewModUpdt = new System.Windows.Forms.Button();
            this.btnViewStudntUpdt = new System.Windows.Forms.Button();
            this.btnViewModCrt = new System.Windows.Forms.Button();
            this.btnViewStudntCrt = new System.Windows.Forms.Button();
            this.btnViewDB = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ucUpdateMod1 = new PRG282_Project.Presentation_Layer.ucUpdateMod();
            this.ucCreateMod1 = new PRG282_Project.Presentation_Layer.ucCreateMod();
            this.ucUpdateStudent = new PRG282_Project.ucUpdateStdnt();
            this.ucDatabase1 = new PRG282_Project.ucDatabase();
            this.ucCreateStudent = new PRG282_Project.ucCreate();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.pnlTop.Controls.Add(this.imgLogo);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1017, 107);
            this.pnlTop.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::PRG282_Project.Properties.Resources.BC_Logo;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgLogo.Location = new System.Drawing.Point(613, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(404, 107);
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcome.Location = new System.Drawing.Point(12, 54);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(336, 38);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Username";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.pnlLeft.Controls.Add(this.btnViewModUpdt);
            this.pnlLeft.Controls.Add(this.btnViewStudntUpdt);
            this.pnlLeft.Controls.Add(this.btnViewModCrt);
            this.pnlLeft.Controls.Add(this.btnViewStudntCrt);
            this.pnlLeft.Controls.Add(this.btnViewDB);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlLeft.Location = new System.Drawing.Point(0, 107);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(169, 494);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnViewModUpdt
            // 
            this.btnViewModUpdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.btnViewModUpdt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewModUpdt.FlatAppearance.BorderSize = 0;
            this.btnViewModUpdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewModUpdt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewModUpdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnViewModUpdt.Location = new System.Drawing.Point(0, 180);
            this.btnViewModUpdt.Name = "btnViewModUpdt";
            this.btnViewModUpdt.Size = new System.Drawing.Size(169, 45);
            this.btnViewModUpdt.TabIndex = 4;
            this.btnViewModUpdt.Text = "Update Module";
            this.btnViewModUpdt.UseVisualStyleBackColor = false;
            this.btnViewModUpdt.Click += new System.EventHandler(this.btnViewModUpdt_Click);
            // 
            // btnViewStudntUpdt
            // 
            this.btnViewStudntUpdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.btnViewStudntUpdt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewStudntUpdt.FlatAppearance.BorderSize = 0;
            this.btnViewStudntUpdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudntUpdt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudntUpdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnViewStudntUpdt.Location = new System.Drawing.Point(0, 135);
            this.btnViewStudntUpdt.Name = "btnViewStudntUpdt";
            this.btnViewStudntUpdt.Size = new System.Drawing.Size(169, 45);
            this.btnViewStudntUpdt.TabIndex = 5;
            this.btnViewStudntUpdt.Text = "Update Student";
            this.btnViewStudntUpdt.UseVisualStyleBackColor = false;
            this.btnViewStudntUpdt.Click += new System.EventHandler(this.btnViewStudntUpdt_Click);
            // 
            // btnViewModCrt
            // 
            this.btnViewModCrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.btnViewModCrt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewModCrt.FlatAppearance.BorderSize = 0;
            this.btnViewModCrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewModCrt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewModCrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnViewModCrt.Location = new System.Drawing.Point(0, 90);
            this.btnViewModCrt.Name = "btnViewModCrt";
            this.btnViewModCrt.Size = new System.Drawing.Size(169, 45);
            this.btnViewModCrt.TabIndex = 3;
            this.btnViewModCrt.Text = "Add Module";
            this.btnViewModCrt.UseVisualStyleBackColor = false;
            this.btnViewModCrt.Click += new System.EventHandler(this.btnViewModCrt_Click);
            // 
            // btnViewStudntCrt
            // 
            this.btnViewStudntCrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.btnViewStudntCrt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewStudntCrt.FlatAppearance.BorderSize = 0;
            this.btnViewStudntCrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudntCrt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudntCrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnViewStudntCrt.Location = new System.Drawing.Point(0, 45);
            this.btnViewStudntCrt.Name = "btnViewStudntCrt";
            this.btnViewStudntCrt.Size = new System.Drawing.Size(169, 45);
            this.btnViewStudntCrt.TabIndex = 2;
            this.btnViewStudntCrt.Text = "Add Student";
            this.btnViewStudntCrt.UseVisualStyleBackColor = false;
            this.btnViewStudntCrt.Click += new System.EventHandler(this.btnViewStudntCrt_Click);
            // 
            // btnViewDB
            // 
            this.btnViewDB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDB.FlatAppearance.BorderSize = 0;
            this.btnViewDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnViewDB.Location = new System.Drawing.Point(0, 0);
            this.btnViewDB.Name = "btnViewDB";
            this.btnViewDB.Size = new System.Drawing.Size(169, 45);
            this.btnViewDB.TabIndex = 1;
            this.btnViewDB.Text = "Database";
            this.btnViewDB.UseVisualStyleBackColor = false;
            this.btnViewDB.Click += new System.EventHandler(this.btnViewDB_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(0, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ucUpdateMod1
            // 
            this.ucUpdateMod1.Location = new System.Drawing.Point(169, 107);
            this.ucUpdateMod1.Name = "ucUpdateMod1";
            this.ucUpdateMod1.Size = new System.Drawing.Size(848, 494);
            this.ucUpdateMod1.TabIndex = 6;
            this.ucUpdateMod1.Visible = false;
            // 
            // ucCreateMod1
            // 
            this.ucCreateMod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCreateMod1.Location = new System.Drawing.Point(169, 107);
            this.ucCreateMod1.Name = "ucCreateMod1";
            this.ucCreateMod1.Size = new System.Drawing.Size(848, 494);
            this.ucCreateMod1.TabIndex = 5;
            this.ucCreateMod1.Visible = false;
            // 
            // ucUpdateStudent
            // 
            this.ucUpdateStudent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ucUpdateStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUpdateStudent.Location = new System.Drawing.Point(169, 107);
            this.ucUpdateStudent.Name = "ucUpdateStudent";
            this.ucUpdateStudent.Size = new System.Drawing.Size(848, 494);
            this.ucUpdateStudent.TabIndex = 3;
            this.ucUpdateStudent.Visible = false;
            // 
            // ucDatabase1
            // 
            this.ucDatabase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatabase1.Location = new System.Drawing.Point(169, 107);
            this.ucDatabase1.Name = "ucDatabase1";
            this.ucDatabase1.Size = new System.Drawing.Size(848, 494);
            this.ucDatabase1.TabIndex = 4;
            // 
            // ucCreateStudent
            // 
            this.ucCreateStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCreateStudent.Location = new System.Drawing.Point(169, 107);
            this.ucCreateStudent.Name = "ucCreateStudent";
            this.ucCreateStudent.Size = new System.Drawing.Size(848, 494);
            this.ucCreateStudent.TabIndex = 2;
            this.ucCreateStudent.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 601);
            this.Controls.Add(this.ucUpdateMod1);
            this.Controls.Add(this.ucCreateMod1);
            this.Controls.Add(this.ucUpdateStudent);
            this.Controls.Add(this.ucDatabase1);
            this.Controls.Add(this.ucCreateStudent);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belgium Campus Student Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewStudntCrt;
        private System.Windows.Forms.Button btnViewDB;
        private System.Windows.Forms.Button btnViewModCrt;
        private ucUpdateStdnt ucUpdate1;
        private System.Windows.Forms.Button btnViewModUpdt;
        private System.Windows.Forms.Button btnViewStudntUpdt;
        private ucCreate ucCreateStudent;
        private ucUpdateStdnt ucUpdateStudent;
        private ucDatabase ucDatabase1;
        private Presentation_Layer.ucCreateMod ucCreateMod1;
        private Presentation_Layer.ucUpdateMod ucUpdateMod1;
    }
}