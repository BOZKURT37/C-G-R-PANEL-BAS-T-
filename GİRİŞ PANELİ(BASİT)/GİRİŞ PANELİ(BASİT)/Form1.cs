using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GİRİŞ_PANELİ_BASİT_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("GİRİŞ BAŞARILI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
            else
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Kullanıcı adınızı boş bıraktınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Şifrenizi boş bıraktınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox1.Text != textBox2.Text)
                {
                    MessageBox.Show("Kullanıcı Adı Ve Şifreniz Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("GİRİŞ BAŞARISIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
              textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
