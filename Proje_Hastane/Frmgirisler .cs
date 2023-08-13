using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnhastagirişi_Click(object sender, EventArgs e)
        {
            Frmhastagiris fr = new Frmhastagiris();
            fr.Show();
            this.Hide ();
        }

        private void btndoktorgirişi_Click(object sender, EventArgs e)
        {
            Frm_Doktorgiriş fr = new Frm_Doktorgiriş();
            fr.Show();
            this.Hide ();
        }

        private void btnsekretergirişi_Click(object sender, EventArgs e)
        {
            Frm_Sekretergiriş fr = new Frm_Sekretergiriş();
            fr.Show();
            this.Hide ();
        }
    }
}
