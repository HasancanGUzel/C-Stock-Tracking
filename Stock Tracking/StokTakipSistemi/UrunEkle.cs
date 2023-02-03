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
    public partial class UrunEkle : Form
    {
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
        public string urununadi { get; set; }
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
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (texturun.Text != "" || textmarka.Text != "" || maskfiyat.Text != "" || textcesit.Text != "" || maskmiktar.Text != "")
            {
                SqlConnection cnn = openDBConnection();
                string query = "";
                query = "select count(*) as urunsayisi from Urun where UrunAdi = '" + texturun.Text + "'";

                SqlCommand com = new SqlCommand(query, cnn);

                int urunkontrol = 0;
                using (SqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string sayi = dr["urunsayisi"].ToString();
                            if (sayi != "")
                            {
                                urunkontrol = Convert.ToInt32(sayi);
                                if (urunkontrol > 0)
                                {
                                    MessageBox.Show("Ürün markette  vardır ürünü kontrol edip ürün bilgilerini güncelleyiniz!");
                                    return;
                                }
                            }


                        }
                    }

                }



                try
                {
                    string UrunAdi = texturun.Text;
                    string Marka = textmarka.Text;
                    double Fiyat = int.Parse(maskfiyat.Text);

                    string sonKulTarihi = datetarih.Value.ToString("yyyy-MM-dd");

                    string UrunCesit = textcesit.Text;
                    int StokMiktar = int.Parse(maskmiktar.Text);
                    query = "insert into Urun (UrunAdi,Marka,Fiyat,SonKulTarih,UrunCesit,StokMiktar) "
                         + "values ('" + UrunAdi + "','" + Marka + "'  ," + Fiyat + ", '" + sonKulTarihi + "','" + UrunCesit + "'," + StokMiktar + ")";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    Temizle();
                    UrunListele();
                    MessageBox.Show("Kayıt Başarılı");

                    closeDBConnection(cnn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt Başarısız:" + ex.ToString());
                    closeDBConnection(cnn);
                }
            }
            else
            {
                MessageBox.Show("Boş geçilemez");

            }
        }


        void Temizle()
        {
            texturun.Text = "";
            textmarka.Text = "";
            maskfiyat.Text = "";
            textcesit.Text = "";
            maskmiktar.Text = "";

        }

        void UrunListele()
        {
            SqlConnection cnn = openDBConnection();
            try
            {

                string query = "select Id,UrunAdi as 'Ürün Adı' ,Marka , Fiyat ,SonKulTarih as 'Son Kullanma Tarihi', UrunCesit as 'Ürün Çeşidi' , StokMiktar as 'Stok Miktarı' from Urun";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Urun");
                sda.Fill(dt);
                UrunListe.DataSource = dt.DefaultView;
                UrunListe.Columns[0].Visible = false;
                closeDBConnection(cnn);
            }
            catch (Exception ex)
            {
                closeDBConnection(cnn);
            }

        }

        private void btnurunara_Click(object sender, EventArgs e)
        {
            if (!araurun.Text.Equals(""))
            {
                string query = "";
                SqlConnection cnn = openDBConnection();

                query = "select Id,UrunAdi ,Marka , Fiyat ,SonKulTarih , UrunCesit  , StokMiktar  from Urun where UrunAdi = '" + araurun.Text + "'";

                SqlCommand com = new SqlCommand(query, cnn);


                using (SqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {


                            string adi = dr["UrunAdi"].ToString();
                            if (adi != "")
                            {
                                urununadi = dr["UrunAdi"].ToString();
                                texturun.Text = dr["UrunAdi"].ToString();
                                textmarka.Text = dr["Marka"].ToString();
                                maskfiyat.Text = dr["Fiyat"].ToString();

                                datetarih.Text = dr["SonKulTarih"].ToString();

                                textcesit.Text = dr["UrunCesit"].ToString();
                                maskmiktar.Text = dr["StokMiktar"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Ürün Bulunamadı !");
                            }

                        }
                    }

                }


                try
                {
                    query = "select Id,UrunAdi as 'Ürün Adı' ,Marka ,Fiyat ,SonKulTarih as 'Son Kullanma Tarihi', UrunCesit as 'Ürün Çeşidi' , StokMiktar as 'Stok Miktarı' from Urun Where UrunAdi=" + "'" + araurun.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Urun");
                    sda.Fill(dt);
                    UrunListe.DataSource = dt.DefaultView;
                    closeDBConnection(cnn);
                }
                catch (Exception ex)
                {
                    closeDBConnection(cnn);
                }
            }
            else
            {
                MessageBox.Show("Ürün Adı Giriniz !");
            }
        }

        private void btnmarkaara_Click(object sender, EventArgs e)
        {
            if (!aramarka.Text.Equals(""))
            {
                SqlConnection cnn = openDBConnection();
                try
                {
                    string query = "select Id,UrunAdi as 'Ürün Adı' ,Marka , SonKulTarih as 'Son Kullanma Tarihi', UrunCesit as 'Ürün Çeşidi' , StokMiktar as 'Stok Miktarı' from Urun Where Marka=" + "'" + aramarka.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Urun");
                    sda.Fill(dt);
                    UrunListe.DataSource = dt.DefaultView;
                    closeDBConnection(cnn);

                }
                catch (Exception ex)
                {
                    closeDBConnection(cnn);
                }
            }
            else
            {
                MessageBox.Show("Marka Adı Giriniz !");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!araurun.Text.Equals(""))
            {
                SqlConnection cnn = openDBConnection();
                try
                {
                    string query = "delete  from Urun Where UrunAdi=" + "'" + araurun.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarılı!");
                    araurun.Text = "";
                    UrunListele();
                    closeDBConnection(cnn);
                }
                catch (Exception ex)
                {
                    closeDBConnection(cnn);
                }
            }
            else
            {
                MessageBox.Show("Ürün Adı Giriniz !");
            }
        }

        private void btnkontrol_Click(object sender, EventArgs e)
        {

            DateTime sonKulTarihi = DateTime.Now;
            string tarih = sonKulTarihi.ToString("yyyy-MM-dd");
            SqlConnection cnn = openDBConnection();
            try
            {
                string query = "delete  from Urun Where  SonKulTarih <" + "'" + tarih + "'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Son Kullanma Tarihi Geçmiş Ürünler Silinmiştir!");
                araurun.Text = "";
                UrunListele();
                closeDBConnection(cnn);
            }
            catch (Exception ex)
            {
                closeDBConnection(cnn);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (texturun.Text != "" || textmarka.Text != "" || maskfiyat.Text != "" || textcesit.Text != "" || maskmiktar.Text != "")
            {
                SqlConnection cnn = openDBConnection();
                try
                {

                    string UrunAdi = texturun.Text;
                    string Marka = textmarka.Text;
                    double Fiyat = int.Parse(maskfiyat.Text);

                    string sonKulTarihi = datetarih.Value.ToString("yyyy-MM-dd");

                    string UrunCesit = textcesit.Text;
                    int StokMiktar = int.Parse(maskmiktar.Text);
                    string query = "update  Urun   set UrunAdi ='" + UrunAdi + "',Marka='" + Marka + "',Fiyat=" + Fiyat + ",SonKulTarih='" + sonKulTarihi + "',UrunCesit='" + UrunCesit + "',StokMiktar=" + StokMiktar + " where UrunAdi ='" + urununadi + "' ";


                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    Temizle();
                    UrunListele();
                    MessageBox.Show("Güncelleme Başarılı");

                    closeDBConnection(cnn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt Başarısız:" + ex.ToString());
                    closeDBConnection(cnn);
                }

            }
        }
    }
}
