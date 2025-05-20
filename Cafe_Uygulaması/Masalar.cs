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
    public partial class Masalar : Form
    {
        AnaMenü anaMenü = new AnaMenü();
        public Masalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            anaMenü.Show();
        }
    }
}
