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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();
      

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DoktorTC,DoktorSifre from Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdTC.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fd= new FrmDoktorDetay();
                fd.TC=mskdTC.Text;
                fd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen şifrenizi veya TC nizi tekrar kontrol ederek giriş yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
