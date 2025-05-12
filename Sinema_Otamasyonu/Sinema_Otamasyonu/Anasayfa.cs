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

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor= Color.White;
                    btn.Location = new Point(j * 30 + 30, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);

                }
            }
        }

    
    }
    }

