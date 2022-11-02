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
    public partial class FrmHastaBilgileriDuzenle : Form
    {
        public FrmHastaBilgileriDuzenle()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();

        public string tcno;

        private void FrmHastaBilgileriDuzenle_Load(object sender, EventArgs e)

        {
            mskdTC.Text = tcno;
            SqlCommand komut=new SqlCommand("Select * from Tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text=dr[2].ToString();
                mskdtelefon.Text=dr[4].ToString();
                txtsifre.Text=dr[5].ToString();
                comboBox1.Text=dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnbilgiguncelle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komutt = new SqlCommand("Update Tbl_Hastalar Set HastaAd=@p1,HastaSoyad=@p2,HastaTel=@p4,HastaSifre=@p5,HastaCinsiyet=@p6 where HastaTc=@p3", bgl.baglanti());
            komutt.Parameters.AddWithValue("@p1", txtad.Text);
            komutt.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutt.Parameters.AddWithValue("@p3", mskdTC.Text); 
            komutt.Parameters.AddWithValue("@p4", mskdtelefon.Text); 
            komutt.Parameters.AddWithValue("@p5", txtsifre.Text); 
            komutt.Parameters.AddWithValue("@p6", comboBox1.Text); 
            komutt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
    }
}
