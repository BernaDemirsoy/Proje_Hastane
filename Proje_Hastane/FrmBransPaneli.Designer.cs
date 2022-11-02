namespace Proje_Hastane
{
    partial class FrmBransPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBransPaneli));
            this.btttnguncelle = new System.Windows.Forms.Button();
            this.bttnsil = new System.Windows.Forms.Button();
            this.bttnekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbransad = new System.Windows.Forms.TextBox();
            this.txtbransID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btttnguncelle
            // 
            this.btttnguncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btttnguncelle.Location = new System.Drawing.Point(94, 235);
            this.btttnguncelle.Name = "btttnguncelle";
            this.btttnguncelle.Size = new System.Drawing.Size(136, 53);
            this.btttnguncelle.TabIndex = 27;
            this.btttnguncelle.Text = "Güncelle";
            this.btttnguncelle.UseVisualStyleBackColor = false;
            this.btttnguncelle.Click += new System.EventHandler(this.btttnguncelle_Click);
            // 
            // bttnsil
            // 
            this.bttnsil.BackColor = System.Drawing.Color.LightCoral;
            this.bttnsil.Location = new System.Drawing.Point(166, 157);
            this.bttnsil.Name = "bttnsil";
            this.bttnsil.Size = new System.Drawing.Size(136, 53);
            this.bttnsil.TabIndex = 26;
            this.bttnsil.Text = "Sil";
            this.bttnsil.UseVisualStyleBackColor = false;
            this.bttnsil.Click += new System.EventHandler(this.bttnsil_Click);
            // 
            // bttnekle
            // 
            this.bttnekle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttnekle.Location = new System.Drawing.Point(24, 157);
            this.bttnekle.Name = "bttnekle";
            this.bttnekle.Size = new System.Drawing.Size(136, 53);
            this.bttnekle.TabIndex = 25;
            this.bttnekle.Text = "Ekle";
            this.bttnekle.UseVisualStyleBackColor = false;
            this.bttnekle.Click += new System.EventHandler(this.bttnekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 250);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtbransad
            // 
            this.txtbransad.Location = new System.Drawing.Point(118, 93);
            this.txtbransad.Name = "txtbransad";
            this.txtbransad.Size = new System.Drawing.Size(169, 32);
            this.txtbransad.TabIndex = 20;
            // 
            // txtbransID
            // 
            this.txtbransID.Location = new System.Drawing.Point(121, 55);
            this.txtbransID.Name = "txtbransID";
            this.txtbransID.Size = new System.Drawing.Size(169, 32);
            this.txtbransID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Branş Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Branş ID:";
            // 
            // FrmBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(828, 296);
            this.Controls.Add(this.btttnguncelle);
            this.Controls.Add(this.bttnsil);
            this.Controls.Add(this.bttnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbransad);
            this.Controls.Add(this.txtbransID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBransPaneli";
            this.Text = "Brans Paneli";
            this.Load += new System.EventHandler(this.FrmBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btttnguncelle;
        private System.Windows.Forms.Button bttnsil;
        private System.Windows.Forms.Button bttnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbransad;
        private System.Windows.Forms.TextBox txtbransID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}