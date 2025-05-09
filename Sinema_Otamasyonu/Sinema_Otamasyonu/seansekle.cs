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
    public partial class seansekle : Form
    {
        public seansekle()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Seans_BilgileriTableAdapter filmseansi=new sinemaTableAdapters.Seans_BilgileriTableAdapter();

        string seans = "";
        private void RadioButtonSeciliyse()
        {
            if(radioButton1.Checked==true) seans=radioButton1.Text;
              else  if (radioButton2.Checked == true) seans = radioButton2.Text;
              else  if (radioButton3.Checked == true) seans = radioButton3.Text;
              else  if (radioButton4.Checked == true) seans = radioButton4.Text;
              else  if (radioButton5.Checked == true) seans = radioButton5.Text;
              else  if (radioButton6.Checked == true) seans = radioButton6.Text;
              else  if (radioButton7.Checked == true) seans = radioButton7.Text;
              else  if (radioButton8.Checked == true) seans = radioButton8.Text;
              else  if (radioButton9.Checked == true) seans = radioButton9.Text;
              else  if (radioButton10.Checked == true) seans = radioButton10.Text;
              else  if (radioButton11.Checked == true) seans = radioButton11.Text;
              else  if (radioButton12.Checked == true) seans = radioButton12.Text;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(seans!="")
            {
                RadioButtonSeciliyse();
                filmseansi.SeansEkleme(comboFilm.Text,comboSalon.Text,dateTimePicker1.Text,seans);
                MessageBox.Show("Seans Ekleme İşlemi Yapıldı","Kayıt");

            }
        }
    }
}
