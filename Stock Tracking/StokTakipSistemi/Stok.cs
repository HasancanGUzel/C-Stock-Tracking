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

namespace StokTakipSistemi
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        private SqlConnection openDBConnection()
        {
            string connetionString = "Data Source=.;Initial Catalog=StokTakip;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            return cnn;
        }

        private void closeDBConnection(SqlConnection cnn)
        {
            try
            {
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not close connection ! ");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            stokliste();

        }

        void stokliste()
        {
            SqlConnection cnn = openDBConnection();
            try

            {
                string query = "";
                if (texturun.Text == "")
                {
                    query = "select Id,UrunAdi as 'Ürün Adı' ,Marka , Fiyat ,SonKulTarih as 'Son Kullanma Tarihi', UrunCesit as 'Ürün Çeşidi' , StokMiktar as 'Stok Miktarı' from Urun";
                }
                else
                {
                    query = "select Id,UrunAdi as 'Ürün Adı' ,Marka , Fiyat ,SonKulTarih as 'Son Kullanma Tarihi', UrunCesit as 'Ürün Çeşidi' , StokMiktar as 'Stok Miktarı' from Urun where UrunAdi = '" + texturun.Text + "'";
                }

                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Urun");
                sda.Fill(dt);
                gridstok.DataSource = dt.DefaultView;

                closeDBConnection(cnn);
            }
            catch (Exception ex)
            {
                closeDBConnection(cnn);
            }

        }

        private void Stok_Load(object sender, EventArgs e)
        {
            stokliste();
        }
    }
}
