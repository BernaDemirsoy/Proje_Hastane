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
    public partial class FrmUyeKayıt : Form
    {
        public FrmUyeKayıt()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC, HastaTel, HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskdTC.Text);
            komut.Parameters.AddWithValue("@p4", mskdtelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıdınız tamamlanmıştır. Şifreniz:"+ txtsifre.Text,"Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
    }
}
