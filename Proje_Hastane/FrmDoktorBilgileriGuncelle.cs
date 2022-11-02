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
    public partial class FrmDoktorBilgileriGuncelle : Form
    {
        public FrmDoktorBilgileriGuncelle()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl= new Sqlbaglantisi();
        public string TCno;
        private void FrmDoktorBilgileriGuncelle_Load(object sender, EventArgs e)
        {
            mskdTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TCno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnbilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1",txtad.Text);
            komut2.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut2.Parameters.AddWithValue("@d4", TCno);
            komut2.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();

        }
    }
}
