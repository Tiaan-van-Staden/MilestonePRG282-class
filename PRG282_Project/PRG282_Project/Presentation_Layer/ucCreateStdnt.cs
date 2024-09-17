using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class ucCreate : UserControl
    {
        public ucCreate()
        {
            InitializeComponent();
        }

        private void picStudent_Click(object sender, EventArgs e)
        {
            //TODO: add code to save pic
            MessageBox.Show("Insert code to save image", "Remove this message when done with code");
        }

        private void rbnMale_CheckedChanged(object sender, EventArgs e)
        {   
            //if Male is checked, uncheck Female
            if (rbnMale.Checked == true)   
            {
                rbnFemale.Checked = false;
            }
        }

        private void rbnFemale_CheckedChanged(object sender, EventArgs e)
        {
            //if Female is checked, uncheck Male
            if (rbnFemale.Checked == true)
            {
                rbnMale.Checked = false;
            }
        }

        private void ucCreate_Load(object sender, EventArgs e)
        {
            cmbModules.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbSearch.SelectedItem = "Search for Student ID"; //text instead of item value
            cmbModules.SelectedIndex = 0;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Check for empty fields
            //TODO: Save to database
            tbxID.Text = "";
            tbxFullname.Text = "";
            rbnMale.Checked = false;
            rbnFemale.Checked = false;
            tbxPhone.Text = "";
            tbxAddress.Text = "";
            picStudent.Image = PRG282_Project.Properties.Resources.DefaultUser; //reset picStudent to default.
        }
    }
}
