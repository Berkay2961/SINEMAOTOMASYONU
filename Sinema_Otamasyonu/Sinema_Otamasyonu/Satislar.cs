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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Satis_BilgileriTableAdapter SatisListesi=new sinemaTableAdapters.Satis_BilgileriTableAdapter();
        private void Satislar_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = SatisListesi.TariheGöreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();

        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);

            }
            label1.Text = "Toplam Satış" + ucrettoplami + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SatisListesi.SatışListesi2();

            ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SatisListesi.TariheGöreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void Satislar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.ShowDialog();
        }
    }
}
