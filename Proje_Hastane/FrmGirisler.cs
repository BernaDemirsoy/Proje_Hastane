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

        private void btnhasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHasta=new FrmHastaGiris();
            frmHasta.Show();
            this.Hide();
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmdoktor =new FrmDoktorGiris();
            frmdoktor.Show();
            this.Hide();
        }

        private void btnsekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frmSekreter=new FrmSekreterGiris();   
            frmSekreter.Show();
            this.Hide();
        }
    }
}
