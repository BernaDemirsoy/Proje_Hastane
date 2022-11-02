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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();
        public string TC;
        // Sekreter Ad-Soyad TC Ekledik
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TC;
            SqlCommand komut=new SqlCommand("Select SekreterTC,SekreterAdsoyad from Tbl_Sekreterler where SekreterTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                lblTc.Text = TC;
                LblAdsoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

            //Branşlar Çekildi
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorlar Çekildi
            DataTable dt2= new DataTable();
            SqlDataAdapter dv = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            dv.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşları comboboxlara doldurma
            SqlCommand komut1 = new SqlCommand("Select BransAd from Tbl_Branslar ", bgl.baglanti());
            IDataReader dr1= komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r1", mskdtarih.Text);
            komut2.Parameters.AddWithValue("@r2", mskdsaat.Text);
            komut2.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komut2.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturulmuştur.");
            
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0]+" "+dr[1]);
            }
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand duy = new SqlCommand("insert into Tbl_Duyurular  (duyuru) values (@d1)", bgl.baglanti());
            duy.Parameters.AddWithValue("@d1", rchduyuruolustur.Text);
            duy.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyurunuz eklenmiştir.");
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fdp=new FrmDoktorPaneli();
            fdp.Show();

        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fdp=new FrmBransPaneli();
            fdp.Show();
            
        }

        private void btnrandevulistele_Click(object sender, EventArgs e)
        {
            FrmRandevuListele frd = new FrmRandevuListele();
            frd.Show();

          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyuru fd =new FrmDuyuru();
            fd.Show();
        }
    }
}
