using System.Data.SqlClient;


namespace Cafe_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HACıMUSTAFA\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");
        AnaMenü anaMenü = new AnaMenü();



        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string kullaniciSifre = textBox2.Text;
            SqlCommand komut = new SqlCommand("select * from  kullanicilar where kullaniciAdi = @pkullaniciAdi AND sifre =@pkullaniciSifre ", baglanti);
            komut.Parameters.AddWithValue("@pkullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@pkullaniciSifre", kullaniciSifre);

            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {


                this.Hide();//bu fromu gizler



                anaMenü.Show();


            }
            else
            {
                MessageBox.Show("KULLANICI ADINIZ VEYA ŞİFRENİZ YANLIŞ");
            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}