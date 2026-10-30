namespace NESNE_PROJE
{
    partial class fr_seans_secme
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
            this.dgv_seans = new System.Windows.Forms.DataGridView();
            this.bt_seans_sec = new System.Windows.Forms.Button();
            this.txt_seans = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_yonetmen = new System.Windows.Forms.TextBox();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.txt_salon = new System.Windows.Forms.TextBox();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.bt_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_seans
            // 
            this.dgv_seans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seans.Location = new System.Drawing.Point(34, 184);
            this.dgv_seans.Name = "dgv_seans";
            this.dgv_seans.RowHeadersWidth = 51;
            this.dgv_seans.RowTemplate.Height = 24;
            this.dgv_seans.Size = new System.Drawing.Size(754, 254);
            this.dgv_seans.TabIndex = 0;
            this.dgv_seans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_seans_CellClick);
            // 
            // bt_seans_sec
            // 
            this.bt_seans_sec.Location = new System.Drawing.Point(34, 129);
            this.bt_seans_sec.Name = "bt_seans_sec";
            this.bt_seans_sec.Size = new System.Drawing.Size(377, 49);
            this.bt_seans_sec.TabIndex = 1;
            this.bt_seans_sec.Text = "Seansı Seç";
            this.bt_seans_sec.UseVisualStyleBackColor = true;
            this.bt_seans_sec.Click += new System.EventHandler(this.bt_seans_sec_Click_1);
            // 
            // txt_seans
            // 
            this.txt_seans.Location = new System.Drawing.Point(458, 94);
            this.txt_seans.Name = "txt_seans";
            this.txt_seans.Size = new System.Drawing.Size(100, 22);
            this.txt_seans.TabIndex = 2;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(34, 94);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 22);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_yonetmen
            // 
            this.txt_yonetmen.Location = new System.Drawing.Point(246, 94);
            this.txt_yonetmen.Name = "txt_yonetmen";
            this.txt_yonetmen.Size = new System.Drawing.Size(100, 22);
            this.txt_yonetmen.TabIndex = 2;
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(140, 94);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(100, 22);
            this.txt_tur.TabIndex = 2;
            // 
            // txt_salon
            // 
            this.txt_salon.Location = new System.Drawing.Point(352, 94);
            this.txt_salon.Name = "txt_salon";
            this.txt_salon.Size = new System.Drawing.Size(100, 22);
            this.txt_salon.TabIndex = 2;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(564, 94);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(100, 22);
            this.txt_tarih.TabIndex = 2;
            // 
            // txt_saat
            // 
            this.txt_saat.Location = new System.Drawing.Point(670, 94);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(100, 22);
            this.txt_saat.TabIndex = 2;
            // 
            // bt_guncelle
            // 
            this.bt_guncelle.Location = new System.Drawing.Point(411, 129);
            this.bt_guncelle.Name = "bt_guncelle";
            this.bt_guncelle.Size = new System.Drawing.Size(377, 49);
            this.bt_guncelle.TabIndex = 1;
            this.bt_guncelle.Text = "Seansı Güncelle";
            this.bt_guncelle.UseVisualStyleBackColor = true;
            this.bt_guncelle.Click += new System.EventHandler(this.bt_guncelle_Click);
            // 
            // fr_seans_secme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.txt_salon);
            this.Controls.Add(this.txt_yonetmen);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_saat);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.txt_seans);
            this.Controls.Add(this.bt_guncelle);
            this.Controls.Add(this.bt_seans_sec);
            this.Controls.Add(this.dgv_seans);
            this.Name = "fr_seans_secme";
            this.Text = "Seans Seçme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_seans;
        private System.Windows.Forms.Button bt_seans_sec;
        private System.Windows.Forms.TextBox txt_seans;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_yonetmen;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.TextBox txt_salon;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.TextBox txt_saat;
        private System.Windows.Forms.Button bt_guncelle;
    }
}