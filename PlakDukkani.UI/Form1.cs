using PlakDukkani.DAL;
using PlakDukkani.Entities.Concrete;
using System.Security.Cryptography;
using System.Text;

namespace PlakDukkani.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        PlakDukkaniContext db = new PlakDukkaniContext();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var _admin = db.Admins.Where(x => x.KullaniciAdi == txtUserName.Text).Single();
                string girilenSifre = txtPassword.Text;
                

                if (_admin.Sifre == sha256_hash(girilenSifre))
                {
                    Form3 form3 = new Form3(_admin);
                    form3.ShowDialog();
                }
                else
                {
                    throw new Exception();
                }


            }
            catch (Exception)
            {

                MessageBox.Show($"Bilgilerinizi kontrol ederek tekrar deneyiniz.");
            }
        }

        public string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

       

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}