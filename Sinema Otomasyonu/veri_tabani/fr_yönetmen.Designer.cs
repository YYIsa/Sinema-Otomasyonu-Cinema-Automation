namespace NESNE_PROJE
{
    partial class fr_yönetmen
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
            this.bt_tabloekleme = new System.Windows.Forms.Button();
            this.dgv_yönetmen = new System.Windows.Forms.DataGridView();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_ekle = new System.Windows.Forms.Button();
            this.bt_güncelle = new System.Windows.Forms.Button();
            this.bt_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yönetmen)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_tabloekleme
            // 
            this.bt_tabloekleme.Location = new System.Drawing.Point(889, 491);
            this.bt_tabloekleme.Name = "bt_tabloekleme";
            this.bt_tabloekleme.Size = new System.Drawing.Size(75, 23);
            this.bt_tabloekleme.TabIndex = 0;
            this.bt_tabloekleme.Text = "tablo ekleme";
            this.bt_tabloekleme.UseVisualStyleBackColor = true;
            this.bt_tabloekleme.Click += new System.EventHandler(this.bt_tabloekleme_Click);
            // 
            // dgv_yönetmen
            // 
            this.dgv_yönetmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yönetmen.Location = new System.Drawing.Point(261, 36);
            this.dgv_yönetmen.Name = "dgv_yönetmen";
            this.dgv_yönetmen.RowHeadersWidth = 51;
            this.dgv_yönetmen.RowTemplate.Height = 24;
            this.dgv_yönetmen.Size = new System.Drawing.Size(527, 375);
            this.dgv_yönetmen.TabIndex = 1;
            this.dgv_yönetmen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_yönetmen_CellClick);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(131, 177);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(115, 22);
            this.txt_soyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(131, 135);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(115, 22);
            this.txt_ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            // 
            // bt_ekle
            // 
            this.bt_ekle.Location = new System.Drawing.Point(12, 235);
            this.bt_ekle.Name = "bt_ekle";
            this.bt_ekle.Size = new System.Drawing.Size(104, 45);
            this.bt_ekle.TabIndex = 4;
            this.bt_ekle.Text = "Yönetmen Ekle";
            this.bt_ekle.UseVisualStyleBackColor = true;
            this.bt_ekle.Click += new System.EventHandler(this.bt_ekle_Click);
            // 
            // bt_güncelle
            // 
            this.bt_güncelle.Location = new System.Drawing.Point(131, 235);
            this.bt_güncelle.Name = "bt_güncelle";
            this.bt_güncelle.Size = new System.Drawing.Size(110, 45);
            this.bt_güncelle.TabIndex = 4;
            this.bt_güncelle.Text = "Yönetmeni Güncelle";
            this.bt_güncelle.UseVisualStyleBackColor = true;
            this.bt_güncelle.Click += new System.EventHandler(this.bt_güncelle_Click);
            // 
            // bt_sil
            // 
            this.bt_sil.Location = new System.Drawing.Point(71, 286);
            this.bt_sil.Name = "bt_sil";
            this.bt_sil.Size = new System.Drawing.Size(110, 45);
            this.bt_sil.TabIndex = 4;
            this.bt_sil.Text = "Yönetmeni Sil";
            this.bt_sil.UseVisualStyleBackColor = true;
            this.bt_sil.Click += new System.EventHandler(this.bt_sil_Click);
            // 
            // fr_yönetmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 464);
            this.Controls.Add(this.bt_sil);
            this.Controls.Add(this.bt_güncelle);
            this.Controls.Add(this.bt_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.dgv_yönetmen);
            this.Controls.Add(this.bt_tabloekleme);
            this.Name = "fr_yönetmen";
            this.Text = "fr_yönetmen";
            this.Load += new System.EventHandler(this.fr_yönetmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yönetmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_tabloekleme;
        private System.Windows.Forms.DataGridView dgv_yönetmen;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_ekle;
        private System.Windows.Forms.Button bt_güncelle;
        private System.Windows.Forms.Button bt_sil;
    }
}