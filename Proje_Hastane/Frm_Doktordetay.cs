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
    public partial class Frm_Doktordetay : Form
    {
        public Frm_Doktordetay()
        {
            InitializeComponent();
        }
        sqlbağlantısı bgl= new sqlbağlantısı();
        public string TC;
        private void Frm_Doktordetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            // doktor ad soyad 
            SqlCommand komut = new SqlCommand("select DoktorAd , DoktorSoyad from Tbl_Doktorlar where DoktorTC= @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Tbl_Randevular where RandevuDoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            Frm_Doktorbilgidüzenle fr = new Frm_Doktorbilgidüzenle();
            fr.TCNO =lblTC .Text ;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurlar fr = new Frm_Duyurlar();
            fr.Show() ;
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application .Exit ();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rtşikayet .Text =dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
