using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otamasyonu
{
    public partial class Filmekle : Form
    {
        public Filmekle()
        {
            InitializeComponent();
        }
        private void Filmekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.ShowDialog();
           
        }
        //  sinemaTableAdapters.Film_BilgileriTableAdapter film=new sinemaTableAdapters.Film_BilgileriTableAdapter();
        sinemaTableAdapters.Film_BilgileriTableAdapter film = new  sinemaTableAdapters.Film_BilgileriTableAdapter();
        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //    film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text, pictureBox1.ImageLocation);
                film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text, pictureBox2.ImageLocation);
                MessageBox.Show("Film Bilgileri Eklendi","Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu Film Daha Önce Eklendi!", "Uyarı");
            }
            //film.FilmEkleme(txtFilmAdi.Text,txtYonetmen.Text,comboFilmTuru.Text,txtSure.Text,dateTimePicker1.Text,txtYapimYili.Text,pictureBox1.ImageLocation);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            comboFilmTuru.Text = "";

        }

        private void btnAfisSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation=openFileDialog1.FileName;
        }

      
    }                                                               
}
