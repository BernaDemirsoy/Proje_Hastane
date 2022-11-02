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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl= new Sqlbaglantisi();

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource=dt;

        }

        private void bttnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void bttnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Delete from Tbl_Branslar where BransID=@b2",bgl.baglanti());
            komut1.Parameters.AddWithValue("@b2", txtbransID.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtbransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbransad.Text=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btttnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where BransID=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txtbransad.Text);
            komut2.Parameters.AddWithValue("@p2", txtbransID.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
