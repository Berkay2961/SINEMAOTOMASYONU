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
    public partial class Salonekle : Form
    {
        public Salonekle()
        {
            InitializeComponent();
        }

        private void Salonekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa anasayfa= new Anasayfa();
            anasayfa.ShowDialog();
        }
        sinemaTableAdapters.Salon_BilgileriTableAdapter salon=new sinemaTableAdapters.Salon_BilgileriTableAdapter();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(txtSalonAdi.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception )
            {

                MessageBox.Show("Aynı Salon Daha Önce Eklendi!","Uyarı");
            }
            txtSalonAdi.Text = "";
        }

     

    }
}
