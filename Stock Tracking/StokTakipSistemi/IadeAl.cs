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
    public partial class IadeAl : Form
    {
        public IadeAl()
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
        private void btniade_Click(object sender, EventArgs e)
        {
            if (textiade.Text != "")
            {
                SqlConnection cnn = openDBConnection();
                string urunadi = textiade.Text;
                string stokbilgi = "";
                double toplamfiyat = 0;
                string iadetarihi = DateTime.Now.Date.ToString("yyyy-MM-dd");
                string query = "";
                query = "Select Fiyat , StokMiktar from Urun Where UrunAdi = '" + urunadi + "'";

                SqlCommand com = new SqlCommand(query, cnn);
                string fiyat = "";
                using (SqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            fiyat = dr["Fiyat"].ToString();
                            stokbilgi = dr["StokMiktar"].ToString();
                        }
                    }

                }
                int stok = Convert.ToInt32(stokbilgi) + 1;
                query = "update Urun set Stokmiktar='" + stok + "' Where UrunAdi= '" + urunadi + "'";
                SqlCommand cmd1 = new SqlCommand(query, cnn);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                toplamfiyat = toplamfiyat + Convert.ToInt32(fiyat);

                query = "update top(1) Satis set durum=0 ,SatisTarihi='" + iadetarihi + "'  Where UrunAdi= '" + urunadi + "' and durum <>0 ";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();



                closeDBConnection(cnn);
                MessageBox.Show("Toplam " + toplamfiyat + "  TL tutarında iade  gerçekleşmiştir.");
            }
            else
            {
                MessageBox.Show("Ürün giriniz");

            }

        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
