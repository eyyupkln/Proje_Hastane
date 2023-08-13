﻿using System;
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
    public partial class Frm_Doktorbilgidüzenle : Form
    {
        public Frm_Doktorbilgidüzenle()
        {
            InitializeComponent();
        }
        sqlbağlantısı bgl=new sqlbağlantısı();
        public string TCNO;
        private void Frm_Doktorbilgidüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCNO; 

            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC =@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad .Text = dr[1].ToString();
                txtsoyad .Text = dr[2].ToString();
                cmbbranş .Text = dr[3].ToString();  
                txtsifre .Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd =@p1,DoktorSoyad=@p2,DoktorBranş=@p3,DoktorSifre =@p4 where DoktorTC =@p5  ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
