using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halıDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Sabit kullanıcı adı ve şifre kontrolü
            if (username == "admin" && password == "1234")
            {
                // Giriş başarılı, Form2'ye geçiş yap
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); // Mevcut formu gizle
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");

            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false; // Şifreyi göster
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;  // Şifreyi gizle
            }
        }
    }
}