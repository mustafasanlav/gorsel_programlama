using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Cafe_Uygulaması
{
    public partial class adisyonlar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=HACıMUSTAFA\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");
        public adisyonlar()
        {
            InitializeComponent();
        }

        private void adisyonlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select adisyonlar.*, musteriler.adi, musteriler.soyadi from adisyonlar, musteriler where adisyonlar.musteri_id = musteriler.id ", baglanti);

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                // veritabanındaki kayıtlara tek tek ulaşmak için 



                ListViewItem item = new ListViewItem(reader["adi"] + " " + reader["soyadi"]);
                item.SubItems.Add(reader["tarih"].ToString());
                item.SubItems.Add(reader["ucret"].ToString());
                item.SubItems.Add(reader["odendi_mi"].ToString());
                item.SubItems.Add(reader["musteri_id"].ToString());

                item.ImageIndex = 0;



                listView1.Items.Add(item);
            }
            baglanti.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
                
                if (listView1.SelectedItems.Count == 0)
                return;

                int adisyonId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text.ToString());

                baglanti.Open();
                SqlCommand listele = new SqlCommand("Select * from adisyonUrunleri where adisyon_id = " + adisyonId + 1, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(listele);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                baglanti.Close();
                panel1.Visible = true;
                panel1.BringToFront(); 
           



        }
        public void formAc(Form gelenForm)
        {

            AnaMenü form1 = new AnaMenü();
            gelenForm.FormBorderStyle = FormBorderStyle.None;
            gelenForm.Dock = DockStyle.Fill;
            gelenForm.TopLevel = false;
            form1.panel4.Controls.Add(gelenForm);
            gelenForm.BringToFront();
            gelenForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
