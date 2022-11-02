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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdTC.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if(dr.Read()) //sorgulama yaptığımız için while yerine if kullandık
            {
                FrmSekreterDetay frm= new FrmSekreterDetay();
                frm.TC = mskdTC.Text;
                frm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Lütfen TC'nizi veya şifrenizi doğru bir şekilde tekrar giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
