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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string TC;
        Sqlbaglantisi bgl= new Sqlbaglantisi();

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TC;
            SqlCommand komut = new SqlCommand("Select DoktorAD,DoktorSoyAd,DoktorTC from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+LblAdsoyad.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyuru fx = new FrmDuyuru();
            fx.Show();
        }

        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgileriGuncelle fdg = new FrmDoktorBilgileriGuncelle();
            fdg.TCno = lblTc.Text;
            fdg.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchrandevudetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
