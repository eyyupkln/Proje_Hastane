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
    public partial class Frm_Duyurlar : Form
    {
        public Frm_Duyurlar()
        {
            InitializeComponent();
        }
        sqlbağlantısı bgl = new sqlbağlantısı();
        private void Frm_Duyurlar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from  tbl_duyurular ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1 .DataSource = dt;
        }
    }
}
