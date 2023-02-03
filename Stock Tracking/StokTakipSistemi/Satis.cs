using System;
using System.Collections;
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
    public partial class Satis : Form
    {
        ArrayList urunler = new ArrayList();

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
        public Satis()
        {
            InitializeComponent();
        }

        private bool nonNumberEntered = false;


        private void btnara_Click(object sender, EventArgs e)
        {
            if (!texturun.Text.Equals(""))
            {
                string urun = texturun.Text;
                SqlConnection cnn = openDBConnection();
                string query = "Select Fiyat from Urun Where UrunAdi = '" + urun + "'";

                SqlCommand com = new SqlCommand(query, cnn);
                string fiyat = "";
                using (SqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            fiyat = dr["Fiyat"].ToString();
                        }
                    }

                }
                if (fiyat != "")
                {
                    urunler.Add(texturun.Text);
                    listurun.Items.Add(texturun.Text + "-" + fiyat);


                    texturun.Clear();
                    lblfiyat.Text = fiyat;
                    MessageBox.Show("İptal Etmek için (i)  fiş kesmek için (f) tuşuna baısnız !");
                    nonNumberEntered = true;

                }
                else
                {
                    MessageBox.Show("Girilen Ürün Markette Bulunmamaktadır !");
                }
            }
            else
            {
                MessageBox.Show("Ürün Adı Giriniz !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void texturun_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

        }

        private void texturun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            { e.Handled = true; }
        }

        private void Satis_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (nonNumberEntered == true)
            {


                if (e.KeyCode == Keys.F)
                {
                    if (urunler.Count != 0)
                    {


                        SqlConnection cnn = openDBConnection();
                        string urunadi = "";
                        string stokbilgi = "";
                        double toplamfiyat = 0;
                        string satistarihi = DateTime.Now.Date.ToString("yyyy-MM-dd");
                        int durum = 1;
                        for (int i = 0; i < urunler.Count; i++)
                        {
                            urunadi = urunler[i].ToString();
                            string query1 = "Select Fiyat , StokMiktar from Urun Where UrunAdi = '" + urunadi + "'";

                            SqlCommand com = new SqlCommand(query1, cnn);
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

                            string query = "insert into Satis (UrunAdi,Fiyat,SatisTarihi,Durum) "
                                + "values ('" + urunadi + "','" + fiyat + "','" + satistarihi + "','" + durum + "')";
                            SqlCommand cmd = new SqlCommand(query, cnn);
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();

                            int stok = Convert.ToInt32(stokbilgi) - 1;
                            string query3 = "update Urun set Stokmiktar='" + stok + "' Where UrunAdi= '" + urunadi + "'";
                            SqlCommand cmd1 = new SqlCommand(query3, cnn);
                            cmd1.CommandType = CommandType.Text;
                            cmd1.ExecuteNonQuery();
                            toplamfiyat = toplamfiyat + Convert.ToInt32(fiyat);

                        }
                        closeDBConnection(cnn);
                        nonNumberEntered = false;
                        
                        MessageBox.Show("Toplam " + toplamfiyat + "  TL tutarında satış gerçekleşmiştir.");
                        listurun.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Sepette ürün bulunmamaktadır.");
                    }
                }
                else if (e.KeyCode == Keys.Oem7)
                {
                    listurun.Clear();
                    nonNumberEntered = false;

                }
            }
          
        }
    }
}
