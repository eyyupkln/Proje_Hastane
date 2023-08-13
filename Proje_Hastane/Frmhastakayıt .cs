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
    public partial class Frmuyekayıt : Form
    {
        public Frmuyekayıt()
        {
            InitializeComponent();
        }
        sqlbağlantısı bgl = new sqlbağlantısı();
        private void btnkayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (hastaAd, hastaSoyad,hastaTC,hastaTelefon,hastaSifre,hastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5",txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Geçekleşmiştir Şifreniz: "+ txtsifre.Text, "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information );
        }
    }
}
