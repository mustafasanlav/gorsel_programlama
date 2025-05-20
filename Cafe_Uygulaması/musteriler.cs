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
    public partial class musteriler : Form
    {

        public musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HACıMUSTAFA\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");
        private void yenile()
        {
            baglanti.Open();
            SqlCommand guncel = new SqlCommand("select * from musteriler ", baglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(guncel);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void temizle()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;
        }

        private void musteriler_Load(object sender, EventArgs e)
        {
            yenile();

        }


        private void ekleButton_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string soyadi = textBox2.Text;
            string tanim = textBox3.Text;
            string tarih = maskedTextBox1.Text;
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into musteriler(adi,soyadi,tanimlama,tarih) values (@adi,@soyadi,@tanim,@tarih)", baglanti);
            ekle.Parameters.AddWithValue("@adi", adi);
            ekle.Parameters.AddWithValue("@soyadi", soyadi);
            ekle.Parameters.AddWithValue("@tanim", tanim);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            temizle();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            var secilen = dataGridView1.CurrentRow.Cells["id"].Value;
            SqlCommand sil = new SqlCommand("delete from musteriler where id=" + secilen, baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            yenile();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string soyadi = textBox2.Text;
            string tanim = textBox3.Text;
            string tarih = maskedTextBox1.Text;
            baglanti.Open();
            var secilen = dataGridView1.CurrentRow.Cells["id"].Value;
            SqlCommand degistir = new SqlCommand("update musteriler set  adi=@adi , soyadi=@soyadi , tanimlama=@unvan , tarih=@tarih where id=@id ", baglanti);
            degistir.Parameters.AddWithValue("@id", secilen);
            degistir.Parameters.AddWithValue("@adi", adi);
            degistir.Parameters.AddWithValue("@soyadi", soyadi);
            degistir.Parameters.AddWithValue("@unvan", tanim);
            degistir.Parameters.AddWithValue("@tarih", tarih);
            degistir.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            temizle();

        }
    }
}
