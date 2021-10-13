﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.Logic_Layer
{
    class FileHandler
    {
        List<Users> user = new List<Users>();
        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        public static string LoginUsername;

        public void Login(string uname, string p1)
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"bin\Registerd.txt");
            StreamReader sr = new StreamReader(@"" + file);
            string line = "";

            while ((line = sr.ReadLine()) != null)
            {
                string[] component = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(component[0]);
                pass.Add(component[1]);
            }

            if (users.Contains(uname) && pass.Contains(p1) && Array.IndexOf(users.ToArray(), uname) == Array.IndexOf(pass.ToArray(), p1))
            {
                MessageBox.Show("Welcome " + uname);
                frmMain MainLoad = new frmMain();
                frmLogin frmlog = new frmLogin();
                LoginUsername = uname;
                frmlog.Hide();   //TODO: lucien please look at why this doesnt hide
                MainLoad.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }

            sr.Close();
        }

        public void Register(string un, string p1, string p2)
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"bin\Registerd.txt");
            TextWriter wrt = new StreamWriter(@"" + file, true);
            string usern = un;
            string pas1 = p1;
            string pas2 = p2;

            if (pas1 == pas2)
            {
                wrt.WriteLine(usern + " " + pas1);
                MessageBox.Show("Acount succesfully created please log in to continue");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }

            wrt.Close();
        }
    }
}