
namespace PRG282_Project
{
    partial class ucCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxFullname = new System.Windows.Forms.TextBox();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.picStudent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(436, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(436, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name and Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(436, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(436, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(9, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Upload Picture";
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxID.Location = new System.Drawing.Point(610, 13);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(223, 31);
            this.tbxID.TabIndex = 13;
            // 
            // tbxFullname
            // 
            this.tbxFullname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFullname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxFullname.Location = new System.Drawing.Point(610, 59);
            this.tbxFullname.Name = "tbxFullname";
            this.tbxFullname.Size = new System.Drawing.Size(223, 31);
            this.tbxFullname.TabIndex = 14;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMale.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbnMale.Location = new System.Drawing.Point(610, 201);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(66, 23);
            this.rbnMale.TabIndex = 18;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            this.rbnMale.CheckedChanged += new System.EventHandler(this.rbnMale_CheckedChanged);
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbnFemale.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbnFemale.Location = new System.Drawing.Point(747, 201);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(86, 23);
            this.rbnFemale.TabIndex = 19;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            this.rbnFemale.CheckedChanged += new System.EventHandler(this.rbnFemale_CheckedChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "";
            this.dtpDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(610, 155);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(223, 23);
            this.dtpDOB.TabIndex = 20;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxAddress.Location = new System.Drawing.Point(610, 335);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(223, 31);
            this.tbxAddress.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(436, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Address";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxPhone.Location = new System.Drawing.Point(610, 289);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(223, 31);
            this.tbxPhone.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(436, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone Num";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(436, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Modules";
            // 
            // cmbModules
            // 
            this.cmbModules.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModules.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Items.AddRange(new object[] {
            "LPR281",
            "MAT281",
            "PMM281",
            "PRG281",
            "PRG282",
            "WPR281"});
            this.cmbModules.Location = new System.Drawing.Point(610, 381);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(223, 27);
            this.cmbModules.TabIndex = 28;
            this.cmbModules.Text = "Search Options";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 2;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(440, 444);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(393, 31);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(76, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Click Me";
            // 
            // picStudent
            // 
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudent.ErrorImage = global::PRG282_Project.Properties.Resources.DefaultUser;
            this.picStudent.Image = global::PRG282_Project.Properties.Resources.DefaultUser;
            this.picStudent.InitialImage = null;
            this.picStudent.Location = new System.Drawing.Point(13, 55);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(200, 150);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 12;
            this.picStudent.TabStop = false;
            this.picStudent.Click += new System.EventHandler(this.picStudent_Click);
            // 
            // ucCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbModules);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rbnFemale);
            this.Controls.Add(this.rbnMale);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxFullname);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucCreate";
            this.Size = new System.Drawing.Size(848, 494);
            this.Load += new System.EventHandler(this.ucCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxFullname;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModules;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
    }
}
