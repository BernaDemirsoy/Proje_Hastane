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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter dv = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            dv.Fill(dt2);
            dataGridView1.DataSource = dt2;


            SqlCommand komut1 = new SqlCommand("Select BransAd from Tbl_Branslar ", bgl.baglanti());
            IDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void bttnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4", mskdTc.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
           mskdTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
           txtsifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void bttnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", mskdTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silinmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btttnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut3.Parameters.AddWithValue("@d1", txtad.Text);
            komut3.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut3.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut3.Parameters.AddWithValue("@d4", mskdTc.Text);
            komut3.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
