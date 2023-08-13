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
    public partial class Frm_Doktorgiriş : Form
    {
        public Frm_Doktorgiriş()
        {
            InitializeComponent();
        }
        sqlbağlantısı bgl = new sqlbağlantısı();

        private void button1_Click(object sender, EventArgs e)
        {
          SqlCommand komut = new SqlCommand(" select * from Tbl_Doktorlar where DoktorTC =@p1 and DoktorSifre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_Doktordetay fr = new Frm_Doktordetay();
                
                fr.TC = msktc.Text;
                fr.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             bgl.baglanti().Close();
        }
    }
}
