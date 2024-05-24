using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal
{
    public partial class Aut_Form : Form
    {
        public static string Login = "";
        public static string Password = "";
        public static bool isAdmin = false;

        public Aut_Form()
        {
            InitializeComponent();

            Text = "Авторизация";

           

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");

            foreach(string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);

                if (Login_textBox1.Text == parts[0] && Pass_textBox2.Text == parts[1])
                {
                    Login = parts[0];
                    isAdmin = Convert.ToBoolean(Convert.ToInt32(parts[2]));
                    Close();
                    return;
                }                
            }
            MessageBox.Show("Неправельный пароль или логин");
        }

        private void Login_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
