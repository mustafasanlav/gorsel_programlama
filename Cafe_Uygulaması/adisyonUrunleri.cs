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
    public partial class adisyonUrunleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=HACıMUSTAFA\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");
        public int adisyonId;
        public adisyonUrunleri(int adisyonGelenId)
        {
            InitializeComponent();
            adisyonId = adisyonGelenId;
        }




        private void adisyonUrunleri_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from adisyonUrunleri where adisyon_id = " + adisyonId, baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) // Don't assume we have any rows.
            {
                int ord = reader.GetOrdinal("col_1");

            }


        }
    }
}
