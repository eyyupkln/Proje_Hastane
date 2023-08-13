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
    public partial class Frm_Sekreterdetay : Form
    {
        public Frm_Sekreterdetay()
        {
            InitializeComponent();
        }
        public string tcnumara;
        sqlbağlantısı bgl = new sqlbağlantısı();

        private void Frm_Sekreterdetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tcnumara;

            // ad soyad 

            SqlCommand komut1 = new SqlCommand(" select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lblTC .Text);
            SqlDataReader dr1 = komut1.ExecuteReader(); 
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }

            bgl.baglanti().Close();

            // branşları datagride aktarma 

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select BransAD from Tbl_Branslar ", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // doktorları listeye aktarma 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' , DoktorBranş from Tbl_Doktorlar", bgl.baglanti());
             da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("select BransAD from Tbl_Branslar ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.baglanti() .Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand(" insert into Tbl_Randevular (RandevuTarih,RandevuSaat, RandevuBrans ,RandevuDoktor) values (@r1,@r2,@r3,@r4)  ", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbranş.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text );
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Kaydedildi");

        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();


            SqlCommand komut = new SqlCommand("select DoktorAd , DoktorSoyad from Tbl_Doktorlar where DoktorBranş=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbbranş.Text);
            SqlDataReader dr  = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);


            }
            bgl.baglanti().Close();
        }

        private void btnduyuruoluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rtduyuru.Text);
                komut.ExecuteNonQuery();

            bgl.baglanti() .Close();
            MessageBox.Show(" Duyuru Oluşturuldu");

        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            Frmdoktorpaneli drp = new Frmdoktorpaneli();
            drp.Show();
        }

        private void btnbranşpaneli_Click(object sender, EventArgs e)
        {
            Frmbranş frb = new Frmbranş();
            frb.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            Frmrandevulistesi frb = new Frmrandevulistesi();
            frb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Duyurlar fr = new Frm_Duyurlar();
            fr.Show();
        }
    }
}
