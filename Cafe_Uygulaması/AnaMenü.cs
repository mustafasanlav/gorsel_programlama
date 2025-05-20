using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Uygulaması
{
    public partial class AnaMenü : Form
    {
        public Form aktifForm;

        public AnaMenü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
        public void formAc(Form gelenForm)
        {

            if (aktifForm != null)
                aktifForm.Close();

            aktifForm = gelenForm;

            gelenForm.FormBorderStyle = FormBorderStyle.None;
            gelenForm.Dock = DockStyle.Fill;
            gelenForm.TopLevel = false;
            panel4.Controls.Add(gelenForm);
            gelenForm.BringToFront();
            gelenForm.Show();



        }
        private void AnaMenü_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAc(new adisyonlar());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formAc(new ürünler());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAc(new musteriler());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formAc(new Kullanicilarcs());
        }
    }
}
