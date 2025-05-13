using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otamasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

      
       SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QT2PTBG\\SQLEXPRESS;Initial Catalog=Sinema_Bileti;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            Salonekle ekle = new Salonekle();


            ekle.Show();
            this.Hide();
        }


        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            Filmekle ekle = new Filmekle();
            ekle.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            seansekle ekle = new seansekle();
            ekle.Show();
            this.Hide();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            seanslistele ekle = new seanslistele();
            ekle.Show();
            this.Hide();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            Satislar ekle = new Satislar();
            ekle.Show();
            this.Hide();
        }


        int sayac = 0;
        private void FilmveSalonGetir(ComboBox combo,string sql1,string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString()); 
            }
            baglanti.Close();
         }
        private void FilmAfisiGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from film_bilgileri where filmadi='"+comboFilmAdi.SelectedItem+"'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                pictureBox2.ImageLocation = reader["resim"].ToString();
            }
            baglanti.Close();
        }
        private void Combo_Dolu_Koltuklar()
        {
            comboKoltukİptal.Items.Clear();
            comboKoltukİptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        comboKoltukİptal.Items.Add(item.Text);
                    }
                }
            }
        }
        private void YenidenRenklendir()
        {
            foreach(Control item in panel1.Controls)
            {
                if(item is Button)
                {
                    item.BackColor=Color.White; 
                }
            }
        }
        private void Veritabani_Dolu_Koltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from satis_bilgileri where filmadi='"+comboFilmAdi.SelectedItem+"'and salonadi='"+comboSalonAdi.Text+"'and tarih='"+comboFilmTarihi.SelectedItem+"'and saat='"+comboFilmSeansi.SelectedItem+"' ",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach(Control item in panel1.Controls)
                {
                    if(item is Button)
                    {
                        if (read["koltukno"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                        
                    }
                   
                }
            }
            baglanti.Close() ;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmveSalonGetir(comboFilmAdi,"select*from film_bilgileri", "filmadi");
            FilmveSalonGetir(comboSalonAdi, "select*from salon_bilgileri", "salonadi");


        }

        private void Boş_Koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 30, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
        Button b=(Button)sender;
         if(b.BackColor== Color.White)
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmAfisiGoster();
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }
        sinemaTableAdapters.Satis_BilgileriTableAdapter satis= new sinemaTableAdapters.Satis_BilgileriTableAdapter();
        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text!="")
            {
                try
                {
                    satis.Satış_Yap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeansi.Text, txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString());
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata oluştu!"+hata.Message, "Uyarı");

                } 
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!", "Uyarı");
            }
        }
        private void Film_Tarihi_Getir()
        {
            comboFilmTarihi.Text = "";
            comboFilmSeansi.Text = "";
            comboFilmTarihi.Items.Clear();
            comboFilmSeansi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
        }
        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
        }
    }
    }

