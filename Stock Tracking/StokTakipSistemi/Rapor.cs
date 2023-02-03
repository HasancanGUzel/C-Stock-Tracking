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
    public partial class Rapor : Form
    {
        public Rapor()
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
            SqlConnection cnn = openDBConnection();
            try
            {
                string iadetarihi = DateTime.Now.Date.ToString("yyyy-MM-dd");
                string query = "";
              query = "select UrunAdi as 'Ürün Adı' , Fiyat ,SatisTarihi as 'İade Tarihi'  from Satis where durum =0";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Urun");
                sda.Fill(dt);
                raporlist.DataSource = dt.DefaultView;
            

                query = "Select count(*) as count from satis Where SatisTarihi='" + iadetarihi + "' and durum =0 ";

                SqlCommand com = new SqlCommand(query, cnn);

                string iadesayisi = "";
                using (SqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            iadesayisi = dr["count"].ToString();
                        }
                    }

                }
                lblbilgi.Text = "Bugün toplam " + iadesayisi + " iade aldınız";
                closeDBConnection(cnn);
            }
            catch (Exception ex)
            {
                closeDBConnection(cnn);
            }
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = openDBConnection();
            try
            {
                string islemtarihi = DateTime.Now.Date.ToString("yyyy-MM-dd");
                lblbilgi.Text = "";
                string query = "";
                query = "select UrunAdi as 'Ürün Adı' , Fiyat ,SatisTarihi as 'Satış Tarihi'  from Satis where durum =1";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Urun");
                sda.Fill(dt);
                raporlist.DataSource = dt.DefaultView;
                query = "Select count(*) as count from satis Where SatisTarihi='" + islemtarihi + "'";

                SqlCommand com = new SqlCommand(query, cnn);

                string islemsayisi = "";
                using (SqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            islemsayisi = dr["count"].ToString();
                        }
                    }

                }
                lblbilgi.Text = "Bugün toplam " + islemsayisi + " müşteriye hizmet verdiniz";


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

        private void button1_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.Date.ToString("yyyy-MM-dd");
            SqlConnection cnn = openDBConnection();
            string query = "";            
            query = "select sum(fiyat) as iade   from Satis where durum =0  and SatisTarihi='" + tarih + "'";

            SqlCommand com = new SqlCommand(query, cnn);

            int iadetutarı = 0;
            using (SqlDataReader dr = com.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string sayi = dr["iade"].ToString();
                        if(sayi != "")
                        {
                            iadetutarı = Convert.ToInt32(sayi);
                        }
                        else
                        {
                            iadetutarı = 0;
                        }
                       
                    }
                }

            }

            query = "select sum(fiyat) as satis   from Satis where durum =1  and SatisTarihi='" + tarih + "'";

            SqlCommand com1 = new SqlCommand(query, cnn);

            int satistutarı =0;
            using (SqlDataReader dr = com1.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        satistutarı =Convert.ToInt32(dr["satis"].ToString());
                    }
                }

            }
            query = "select UrunAdi as 'Ürün Adı' , Fiyat ,SatisTarihi as 'İşlem  Tarihi' ,case when durum = 0 then 'İADE' else 'SATIŞ' end as Durum from Satis where  SatisTarihi='" + tarih + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Urun");
            sda.Fill(dt);
            raporlist.DataSource = dt.DefaultView;

            if (iadetutarı > satistutarı)
            {
                lblbilgi.Text = "Bugün Zarardasınız. Günlük Cironuz : "+ (iadetutarı+satistutarı)+" TL";
            }
            else
            {
                lblbilgi.Text = "Bugün Kardasınız .Günlük Cironuz : " + (iadetutarı + satistutarı) + " TL";
            }

            



        }
    }
}
