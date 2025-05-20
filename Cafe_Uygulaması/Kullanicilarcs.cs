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
    public partial class Kullanicilarcs : Form
    {
        public Kullanicilarcs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HACıMUSTAFA\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");
        private void Kullanicilarcs_Load(object sender, EventArgs e)
        {
            yenile();
        }
        private void yenile()
        {
            // burada işlem yaptıktan sonra güncellemek için bir fonksyon oluşturduk 
            baglanti.Open();
            SqlCommand guncel = new SqlCommand("select * from kullanicilar ", baglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(guncel);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void temizle()
        {
            //texBoxları temizlemek için fonksyon  oluşturduk 
            adTexbox.Text = string.Empty;
            sifreTexbox.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;
        }


        private void ekleButton_Click(object sender, EventArgs e)
        {
            // burada ekleme işlemi yaptık 
            string ad = adTexbox.Text;
            string sifre = sifreTexbox.Text;
            string tarih = maskedTextBox1.Text;
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into kullanicilar(kullaniciAdi,sifre,tarih) values (@ad,@sifre,@tarih)", baglanti);
            ekle.Parameters.AddWithValue("@ad", ad);
            ekle.Parameters.AddWithValue("@sifre", sifre);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            temizle();
            

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            var secilen = dataGridView1.CurrentRow.Cells["id"].Value;
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from  kullanicilar where id=" + secilen, baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            yenile();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            var secili = dataGridView1.CurrentRow.Cells["id"].Value;
            baglanti.Open();
            SqlCommand updt = new SqlCommand("update kullanicilar set kullaniciAdi=@ad , sifre=@sifre , tarih=@tarih where id=@id", baglanti);
            updt.Parameters.AddWithValue("@id", secili);
            updt.Parameters.AddWithValue("@ad", adTexbox.Text);
            updt.Parameters.AddWithValue("@sifre", sifreTexbox.Text);
            updt.Parameters.AddWithValue("@tarih", maskedTextBox1.Text);
            updt.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            temizle();
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            string aranan = adTexbox.Text;
            SqlCommand arama = new SqlCommand("select * from kullanicilar where kullaniciAdi=@adi", baglanti);
            arama.Parameters.AddWithValue("@adi", aranan);
            baglanti.Open();


            SqlDataReader reader = arama.ExecuteReader();


            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
               
               

            }
            else
            {
                MessageBox.Show("Aradığınız Kullanıcı Bulunmamaktadır");
            }
            baglanti.Close();
            temizle();

            
        }
    }
}
