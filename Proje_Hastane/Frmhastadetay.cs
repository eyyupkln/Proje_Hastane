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
    public partial class Frmhastadetay : Form
    {
        public Frmhastadetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbağlantısı bgl = new sqlbağlantısı();
        private void Frmhastadetay_Load(object sender, EventArgs e)
        {
            lblTC .Text = tc;

            // ad soyad çekme 
            SqlCommand komut = new SqlCommand("select hastaAd , hastaSoyad from Tbl_Hastalar where hastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut .ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();
            
            // randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Tbl_Randevular where hastaTC= " + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // branşları çekme 
            SqlCommand komut2 = new SqlCommand("Select BransAD from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.baglanti() .Close();

           

               
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBranş=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbranş.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
                
            }
            bgl .baglanti() .Close();
                
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Tbl_Randevular where RandevuBrans= '" + cmbbranş.Text + "'" + " and RandevuDoktor ='" + cmbdoktor.Text  + "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmbilgidüzenle fr = new Frmbilgidüzenle();
            fr.tcno = lblTC.Text;
            fr.Show();


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1 , HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", rtşikayet.Text);
            komut.Parameters .AddWithValue ("@p3",textBox1 .Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox .Show("Randevu Alındı","Uyarı",MessageBoxButtons.OK ,MessageBoxIcon.Warning );
        }
    }
}
