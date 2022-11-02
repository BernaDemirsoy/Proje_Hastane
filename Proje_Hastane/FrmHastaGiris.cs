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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();
        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           FrmUyeKayıt frmuye =new FrmUyeKayıt();
            frmuye.Show();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar Where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdTC.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frm= new FrmHastaDetay();
                frm.tc=mskdTC.Text;
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı bir TC kimlik numarası veya şifre girdiniz. Lütfen Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void FrmHastaGiris_show(object sender, EventArgs e)
        {
            mskdTC.Focus();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
