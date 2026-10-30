namespace NESNE_PROJE
{
    partial class fr_film_türü
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
            this.bt_sil = new System.Windows.Forms.Button();
            this.bt_güncelle = new System.Windows.Forms.Button();
            this.bt_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.dgv_tür = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tür)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_sil
            // 
            this.bt_sil.Location = new System.Drawing.Point(71, 256);
            this.bt_sil.Name = "bt_sil";
            this.bt_sil.Size = new System.Drawing.Size(110, 45);
            this.bt_sil.TabIndex = 10;
            this.bt_sil.Text = "Türü Sil";
            this.bt_sil.UseVisualStyleBackColor = true;
            this.bt_sil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // bt_güncelle
            // 
            this.bt_güncelle.Location = new System.Drawing.Point(131, 205);
            this.bt_güncelle.Name = "bt_güncelle";
            this.bt_güncelle.Size = new System.Drawing.Size(110, 45);
            this.bt_güncelle.TabIndex = 11;
            this.bt_güncelle.Text = "Türü Güncelle";
            this.bt_güncelle.UseVisualStyleBackColor = true;
            this.bt_güncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // bt_ekle
            // 
            this.bt_ekle.Location = new System.Drawing.Point(12, 205);
            this.bt_ekle.Name = "bt_ekle";
            this.bt_ekle.Size = new System.Drawing.Size(104, 45);
            this.bt_ekle.TabIndex = 12;
            this.bt_ekle.Text = "Tür Ekle";
            this.bt_ekle.UseVisualStyleBackColor = true;
            this.bt_ekle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(131, 177);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(115, 22);
            this.txt_ad.TabIndex = 6;
            // 
            // dgv_tür
            // 
            this.dgv_tür.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tür.Location = new System.Drawing.Point(261, 38);
            this.dgv_tür.Name = "dgv_tür";
            this.dgv_tür.RowHeadersWidth = 51;
            this.dgv_tür.RowTemplate.Height = 24;
            this.dgv_tür.Size = new System.Drawing.Size(527, 375);
            this.dgv_tür.TabIndex = 5;
            this.dgv_tür.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 10);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fr_film_türü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_sil);
            this.Controls.Add(this.bt_güncelle);
            this.Controls.Add(this.bt_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.dgv_tür);
            this.Name = "fr_film_türü";
            this.Text = "fr_film_türü";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tür)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_sil;
        private System.Windows.Forms.Button bt_güncelle;
        private System.Windows.Forms.Button bt_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.DataGridView dgv_tür;
        private System.Windows.Forms.Button button1;
    }
}