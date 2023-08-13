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
    public partial class Frmbilgidüzenle : Form
    {
        public Frmbilgidüzenle()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbağlantısı bgl= new sqlbağlantısı();
        private void Frmbilgidüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where  hastaTC=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad .Text = dr[2].ToString();
                msktelefon .Text = dr[4].ToString();
                txtsifre .Text = dr[5].ToString();
                cmbcinsiyet .Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set hastaAd=@p1, hastaSoyad=@p2, hastaTelefon=@p3,hastaSifre=@p4, hastaCinsiyet=@p5 where hastaTC=@p6 ", bgl.baglanti());
               
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3",msktelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2 .ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
