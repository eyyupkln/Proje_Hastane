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

namespace Proje_Hastane
{
    public partial class Frm_Sekretergiriş : Form
    {
        public Frm_Sekretergiriş()
        {
            InitializeComponent();
        }
        sqlbağlantısı bgl = new sqlbağlantısı();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" select * from Tbl_Sekreter where SekreterTC=@p1 and  SekreterSifre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_Sekreterdetay fr = new Frm_Sekreterdetay();
                fr.tcnumara=msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.baglanti().Close();
        }

        
    }
}
