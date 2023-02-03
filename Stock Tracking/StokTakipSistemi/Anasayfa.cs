using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle urun = new UrunEkle();
            urun.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Satis sat = new Satis();
            sat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IadeAl iade = new IadeAl();
            iade.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rapor r = new Rapor();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stok s = new Stok();
            s.Show();
            this.Hide();
        }
    }
}
