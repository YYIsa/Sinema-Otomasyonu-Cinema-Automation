namespace NESNE_PROJE
{
    partial class fr_main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.bt_salon = new System.Windows.Forms.Button();
            this.bt_seanslara_bak = new System.Windows.Forms.Button();
            this.bt_seans = new System.Windows.Forms.Button();
            this.bt_film = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_yönetmen = new System.Windows.Forms.Button();
            this.bt_film_turu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_salon
            // 
            this.bt_salon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_salon.Image = global::NESNE_PROJE.Properties.Resources.salonekle;
            this.bt_salon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salon.Location = new System.Drawing.Point(417, 356);
            this.bt_salon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_salon.Name = "bt_salon";
            this.bt_salon.Size = new System.Drawing.Size(167, 85);
            this.bt_salon.TabIndex = 8;
            this.bt_salon.Text = "Salon Ekle";
            this.bt_salon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salon.UseVisualStyleBackColor = true;
            this.bt_salon.Click += new System.EventHandler(this.bt_salon_Click);
            // 
            // bt_seanslara_bak
            // 
            this.bt_seanslara_bak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_seanslara_bak.Image = global::NESNE_PROJE.Properties.Resources.indir1;
            this.bt_seanslara_bak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_seanslara_bak.Location = new System.Drawing.Point(592, 354);
            this.bt_seanslara_bak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_seanslara_bak.Name = "bt_seanslara_bak";
            this.bt_seanslara_bak.Size = new System.Drawing.Size(212, 86);
            this.bt_seanslara_bak.TabIndex = 7;
            this.bt_seanslara_bak.Text = "    Seanslara Bak";
            this.bt_seanslara_bak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_seanslara_bak.UseVisualStyleBackColor = true;
            this.bt_seanslara_bak.Click += new System.EventHandler(this.bt_seanslara_bak_Click);
            // 
            // bt_seans
            // 
            this.bt_seans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_seans.Image = global::NESNE_PROJE.Properties.Resources.seans;
            this.bt_seans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_seans.Location = new System.Drawing.Point(219, 356);
            this.bt_seans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_seans.Name = "bt_seans";
            this.bt_seans.Size = new System.Drawing.Size(172, 85);
            this.bt_seans.TabIndex = 7;
            this.bt_seans.Text = "Seans Ekle";
            this.bt_seans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_seans.UseVisualStyleBackColor = true;
            this.bt_seans.Click += new System.EventHandler(this.bt_seans_Click);
            // 
            // bt_film
            // 
            this.bt_film.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_film.Image = global::NESNE_PROJE.Properties.Resources.movie48;
            this.bt_film.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_film.Location = new System.Drawing.Point(15, 356);
            this.bt_film.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_film.Name = "bt_film";
            this.bt_film.Size = new System.Drawing.Size(163, 85);
            this.bt_film.TabIndex = 6;
            this.bt_film.Text = "    Film Ekle";
            this.bt_film.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_film.UseVisualStyleBackColor = true;
            this.bt_film.Click += new System.EventHandler(this.bt_film_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NESNE_PROJE.Properties.Resources.otomasyonlogo;
            this.pictureBox1.Location = new System.Drawing.Point(119, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 330);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bt_yönetmen
            // 
            this.bt_yönetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_yönetmen.Image = global::NESNE_PROJE.Properties.Resources.seans;
            this.bt_yönetmen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_yönetmen.Location = new System.Drawing.Point(219, 451);
            this.bt_yönetmen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_yönetmen.Name = "bt_yönetmen";
            this.bt_yönetmen.Size = new System.Drawing.Size(172, 85);
            this.bt_yönetmen.TabIndex = 7;
            this.bt_yönetmen.Text = "Yönetmen Ekle";
            this.bt_yönetmen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_yönetmen.UseVisualStyleBackColor = true;
            this.bt_yönetmen.Click += new System.EventHandler(this.bt_yönetmen_Click);
            // 
            // bt_film_turu
            // 
            this.bt_film_turu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_film_turu.Image = global::NESNE_PROJE.Properties.Resources.seans;
            this.bt_film_turu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_film_turu.Location = new System.Drawing.Point(417, 451);
            this.bt_film_turu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_film_turu.Name = "bt_film_turu";
            this.bt_film_turu.Size = new System.Drawing.Size(172, 85);
            this.bt_film_turu.TabIndex = 7;
            this.bt_film_turu.Text = "Film Türü Ekle";
            this.bt_film_turu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_film_turu.UseVisualStyleBackColor = true;
            this.bt_film_turu.Click += new System.EventHandler(this.bt_film_turu_Click);
            // 
            // fr_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_salon);
            this.Controls.Add(this.bt_seanslara_bak);
            this.Controls.Add(this.bt_film_turu);
            this.Controls.Add(this.bt_yönetmen);
            this.Controls.Add(this.bt_seans);
            this.Controls.Add(this.bt_film);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fr_main";
            this.Text = " <   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_salon;
        private System.Windows.Forms.Button bt_seans;
        private System.Windows.Forms.Button bt_film;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_seanslara_bak;
        private System.Windows.Forms.Button bt_yönetmen;
        private System.Windows.Forms.Button bt_film_turu;
    }
}

