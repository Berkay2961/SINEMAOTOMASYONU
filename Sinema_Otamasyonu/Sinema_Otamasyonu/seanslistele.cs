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
    public partial class seanslistele : Form
    {
        public seanslistele()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QT2PTBG\\SQLEXPRESS;Initial Catalog=Sinema_Bileti;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataTable  tablo=new DataTable();
        private void seansListesi(string sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void seanslistele_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            seansListesi("select*from seans_bilgileri where tarih like'" + dateTimePicker1.Text + "'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            seansListesi("select*from seans_bilgileri where tarih like'" + dateTimePicker1.Text + "'");
        }

        private void TumSeanslar_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            seansListesi("select*from seans_bilgileri");
        }
    
    }
}
