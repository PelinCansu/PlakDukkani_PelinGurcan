using Microsoft.EntityFrameworkCore.Metadata;
using PlakDukkani.BLL.Concrete;
using PlakDukkani.DAL;
using PlakDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkani.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            PlakDukkaniContext db = new PlakDukkaniContext();
            AdminRepository adminRepository = new AdminRepository();
            Admin _newAdmin = new Admin();

            try
            {

                var kullanicilar = db.Admins.Where(x => x.KullaniciAdi == txtUserNameKayit.Text).SingleOrDefault();

                if (kullanicilar is null)
                {
                    _newAdmin.KullaniciAdi = txtUserNameKayit.Text;

                    if (txtPassword.Text == txtPasswordCorrection.Text)
                    {
                        _newAdmin.Sifre = txtPassword.Text;
                        _newAdmin.CreatedDate = DateTime.Now;
                        _newAdmin.ModifiedDate = DateTime.Now;

                    }

                    else
                    {
                        throw new Exception ("Şifreler farklı girildi.");
                    }
                }
                else
                {
                    throw new Exception ("Kullanıcı adı sistemde kayıtlı. Lütfen giriş yapınız.");
                }

                adminRepository.Ekle(_newAdmin);
                MessageBox.Show("Kayıt Gerçekleştirildi. Giriş Ekranına yönlendiriliyorsunuz..");
                this.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
            
            
        }
    }
}
