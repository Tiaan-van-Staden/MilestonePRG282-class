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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnShowRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            btnRegister.Visible = true;
            btnBack.Visible = true;
            btnLogin.Visible = false;
            btnShowRegister.Visible = false;
            this.Height = 630;
            tbxUsername.Text = "";
            tbxPassw1.Text = "";
            tbxPassw2.Text = "";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            btnRegister.Visible = false;
            btnBack.Visible = false;
            btnLogin.Visible = true;
            btnShowRegister.Visible = true;
            this.Height = 550;
            tbxUsername.Text = "";
            tbxPassw1.Text = "";
            tbxPassw2.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TODO: Check account
            frmMain MainLoad = new frmMain();
            this.Hide();
            MainLoad.Show();
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            //TODO: register new account
            frmMain MainLoad = new frmMain();
            this.Hide();
            MainLoad.Show();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Free program from memory/processing
        }
    }
}
