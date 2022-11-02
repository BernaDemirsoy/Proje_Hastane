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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        //Ad-Soyad Çekme
        public string tc;
        Sqlbaglantisi bgl= new Sqlbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdsoyad.Text = dr[0] + "  " + dr[1];
            }
            bgl.baglanti().Close();

         //Rendevu Çekme
         DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular Where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar Branslar ", bgl.baglanti());
            SqlDataReader dr2= komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doktorları çekme
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }
        //Doktora ait aktif randevuları görüntüleme
        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='"+cmbbrans.Text+"'"+ "and RandevuDoktor='"+ cmbdoktor.Text+"' and RandevuDurum=0",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource=dt2;
        }

        private void lnkbilgileridüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgileriDuzenle frm= new FrmHastaBilgileriDuzenle();
            frm.tcno = lblTc.Text;
            frm.Show();
            
            
          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@r1,HastaSikayet=@r2 where Randevuid=@r3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@r1",lblTc.Text);
            komut3.Parameters.AddWithValue("@r2", rchsikayet.Text);
            komut3.Parameters.AddWithValue("@r3",txtId.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturulmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
