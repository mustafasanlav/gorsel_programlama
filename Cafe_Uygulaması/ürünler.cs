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

namespace Cafe_Uygulaması
{
    public partial class ürünler : Form
    {
        public ürünler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HACıMUSTAFA\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");
        private void ürünler_Load(object sender, EventArgs e)
        {
            yenile();

        }
        private void yenile()
        {
            baglanti.Open();
            SqlCommand guncel = new SqlCommand("select * from urunler ", baglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(guncel);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        { //ekleme yapıldı
            string urunAdi = uruntext.Text;
            string katagori = katagoritext.Text;
            int fiyati = Convert.ToInt32(fiyattext.Text);
            string tarih = maskedTextBox1.Text;


            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into  urunler (urunAdi,kategoriAdi,fiyati,tarih) values (@purunAdi,@pkatagori,@pfiyati,@ptarih)", baglanti);

            ekle.Parameters.AddWithValue("@purunAdi", urunAdi);
            ekle.Parameters.AddWithValue("@pkatagori", katagori);
            ekle.Parameters.AddWithValue("@pfiyati", fiyati);
            ekle.Parameters.AddWithValue("@ptarih", tarih);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            temizle();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            var secilen = dataGridView1.CurrentRow.Cells["id"].Value;
            SqlCommand sil = new SqlCommand("delete from urunler where id=" + secilen, baglanti);

            sil.ExecuteNonQuery();
            baglanti.Close();
            yenile();

        }
        private void temizle()
        {
            uruntext.Text = string.Empty;
            katagoritext.Text = string.Empty;
            fiyattext.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;


        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            var secili = dataGridView1.CurrentRow.Cells["id"].Value; 

            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update urunler set urunAdi = @purunAdi , kategoriAdi = @pkategoriAdi, fiyati = @pfiyati, tarih = @ptarih where id = @pid ",baglanti);
            guncelle.Parameters.AddWithValue("@pid", secili);
            guncelle.Parameters.AddWithValue("@purunAdi", uruntext.Text);
            guncelle.Parameters.AddWithValue("@pkategoriAdi", katagoritext.Text);
            guncelle.Parameters.AddWithValue("@pfiyati", fiyattext.Text);
            guncelle.Parameters.AddWithValue("@ptarih", maskedTextBox1.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            temizle();
            

        }
    }
}
