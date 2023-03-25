using Microsoft.EntityFrameworkCore;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Admin gelenAdmin;
        public Form3(Admin girisYapanAdmin)
        {
            gelenAdmin = girisYapanAdmin;
            InitializeComponent();
        }

        AlbumRepository albumRepository = new AlbumRepository();
        PlakDukkaniContext db = new PlakDukkaniContext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Album _newAlbum = new Album();
                if(txtName.Text!= " ")
                { 
                    _newAlbum.AlbumAdi = txtName.Text;

                }

                else
                {
                    throw new Exception("Ad boş bırakılamaz");
                }
               
                if(txtSanatci.Text != " ")
                {
                    _newAlbum.Sanatci = txtSanatci.Text;

                }
                else
                {
                    throw new Exception("Sanatçı boş bırakılamaz");
                }
                
                _newAlbum.CikisTarihi = dateTimePicker1.Value;
                _newAlbum.CreatedDate = dateTimePicker1.Value;
                _newAlbum.ModifiedDate = dateTimePicker1.Value;

                if(txtPrice.Text != " ")
                {
                    _newAlbum.Fiyat = Convert.ToDecimal(txtPrice.Text);
                }
                else
                {
                    throw new Exception("Fiyat boş bırakılamaz");
                }

                if (txtIndirim.Text != " ")
                {
                  _newAlbum.IndirimOrani = Convert.ToDecimal(txtIndirim.Text);
                }
                else
                {
                    throw new Exception("İndirim oranı boş bırakılamaz");
                }
                
                if (rbBitti.Checked)
                {
                    _newAlbum.SatisDurumu = false;
                }

                else
                {
                    _newAlbum.SatisDurumu = true;
                }

                albumRepository.Ekle(_newAlbum);
                ListeGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Değerler boş bırakılamaz...Fiyat ve indirim oranı için sadece sayısal değer giriniz!");


            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }

        public void ListeGetir()
        {
            dgvPlak.DataSource = albumRepository.GetByAll();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListeGetir();

            var satisiDurmusAlbumler = db.Albums.Where(x => x.SatisDurumu == false).Select(x => new { x.AlbumAdi, x.Sanatci, x.SatisDurumu });
            dgvSatisYok.DataSource = satisiDurmusAlbumler.ToList();

            var satisiDevamEdenAlbumler = db.Albums.Where(x => x.SatisDurumu == true).Select(x => new { x.AlbumAdi, x.Sanatci, x.SatisDurumu });
            dgvSatisDevam.DataSource = satisiDevamEdenAlbumler.ToList();

            var sonEklenen10album = db.Albums.OrderByDescending(x => x.CreatedDate).Take(10).Select(x => new { x.AlbumAdi, x.Sanatci, x.CreatedDate });
            dgvSonOn.DataSource = sonEklenen10album.ToList();

            var ındirimliAlbumler = db.Albums.Where(x => x.IndirimOrani != 0 || x.IndirimOrani != null).OrderByDescending(x=>x.IndirimOrani).Select(x => new { x.AlbumAdi, x.Sanatci, x.IndirimOrani });

            dgvIndirim.DataSource = ındirimliAlbumler.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Guid _seciliID = (Guid)(dgvPlak.SelectedRows[0].Cells[6].Value);
            Album _silinecekAlbum = db.Albums.Find(_seciliID);
            albumRepository.Sil(_silinecekAlbum);

            ListeGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guid _seciliID = (Guid)(dgvPlak.SelectedRows[0].Cells[6].Value);
            Album _guncellenecekAlbum = db.Albums.Find(_seciliID);

            _guncellenecekAlbum.AlbumAdi = txtName.Text;
            _guncellenecekAlbum.Sanatci = txtSanatci.Text;
            _guncellenecekAlbum.CikisTarihi = dateTimePicker1.Value;


            _guncellenecekAlbum.CreatedDate = dateTimePicker1.Value;
            _guncellenecekAlbum.ModifiedDate = dateTimePicker1.Value;
            _guncellenecekAlbum.Fiyat = Convert.ToDecimal(txtPrice.Text);
            _guncellenecekAlbum.IndirimOrani = Convert.ToDecimal(txtIndirim.Text);

            if (rbBitti.Checked)
            {
                _guncellenecekAlbum.SatisDurumu = false;
            }

            else
            {
                _guncellenecekAlbum.SatisDurumu = true;
            }

     
            albumRepository.Guncelle(_guncellenecekAlbum);
            ListeGetir();
        }

        private void btnListGuncelle_Click(object sender, EventArgs e)
        {
            ListeGetir();

            var satisiDurmusAlbumler = db.Albums.Where(x => x.SatisDurumu == false).Select(x => new { x.AlbumAdi, x.Sanatci, x.SatisDurumu });
            dgvSatisYok.DataSource = satisiDurmusAlbumler.ToList();

            var satisiDevamEdenAlbumler = db.Albums.Where(x => x.SatisDurumu == true).Select(x => new { x.AlbumAdi, x.Sanatci, x.SatisDurumu });
            dgvSatisDevam.DataSource = satisiDevamEdenAlbumler.ToList();

            var sonEklenen10album = db.Albums.OrderByDescending(x => x.CreatedDate).Take(10).Select(x => new { x.AlbumAdi, x.Sanatci, x.CreatedDate });
            dgvSonOn.DataSource = sonEklenen10album.ToList();

            var ındirimliAlbumler = db.Albums.Where(x => x.IndirimOrani != 0 || x.IndirimOrani != null).OrderByDescending(x => x.IndirimOrani).Select(x => new { x.AlbumAdi, x.Sanatci, x.IndirimOrani });

            dgvIndirim.DataSource = ındirimliAlbumler.ToList();
        }


        public void TextDoldur()
        {
            Guid _seciliID = (Guid)(dgvPlak.SelectedRows[0].Cells[6].Value);
            Album _seciliAlbum = db.Albums.Find(_seciliID);
            txtName.Text = _seciliAlbum.AlbumAdi;
            txtSanatci.Text = _seciliAlbum.Sanatci;
            txtIndirim.Text = Convert.ToString(_seciliAlbum.IndirimOrani);
            txtPrice.Text = Convert.ToString(_seciliAlbum.Fiyat);
            if(_seciliAlbum.SatisDurumu == true)
            {
                rbDevam.Checked = true;
            }
            else
            {
                rbBitti.Checked = true;
            }

            dateTimePicker1.Value = _seciliAlbum.CikisTarihi;

        }

        private void btnTextDoldur_Click(object sender, EventArgs e)
        {
            TextDoldur();
        }
    }
}
