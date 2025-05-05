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
    }
}
