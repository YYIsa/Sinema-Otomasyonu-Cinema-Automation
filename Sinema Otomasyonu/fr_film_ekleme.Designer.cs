namespace NESNE_PROJE
{
    partial class fr_film_ekleme
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
            this.txt_afis = new System.Windows.Forms.Button();
            this.comb_seans = new System.Windows.Forms.ComboBox();
            this.comb_salon = new System.Windows.Forms.ComboBox();
            this.txt_film_adi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pc_afis = new System.Windows.Forms.PictureBox();
            this.txt_cıkıs = new System.Windows.Forms.Button();
            this.txt_anamenu = new System.Windows.Forms.Button();
            this.txt_film_ekle = new System.Windows.Forms.Button();
            this.comb_yönetmen = new System.Windows.Forms.ComboBox();
            this.comb_tür = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_afis)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_afis
            // 
            this.txt_afis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_afis.Location = new System.Drawing.Point(255, 194);
            this.txt_afis.Name = "txt_afis";
            this.txt_afis.Size = new System.Drawing.Size(182, 38);
            this.txt_afis.TabIndex = 29;
            this.txt_afis.Text = "EKLE";
            this.txt_afis.UseVisualStyleBackColor = true;
            this.txt_afis.Click += new System.EventHandler(this.txt_afis_Click);
            // 
            // comb_seans
            // 
            this.comb_seans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_seans.FormattingEnabled = true;
            this.comb_seans.Location = new System.Drawing.Point(255, 294);
            this.comb_seans.Name = "comb_seans";
            this.comb_seans.Size = new System.Drawing.Size(182, 24);
            this.comb_seans.TabIndex = 28;
            // 
            // comb_salon
            // 
            this.comb_salon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_salon.FormattingEnabled = true;
            this.comb_salon.Location = new System.Drawing.Point(255, 247);
            this.comb_salon.Name = "comb_salon";
            this.comb_salon.Size = new System.Drawing.Size(182, 24);
            this.comb_salon.TabIndex = 27;
            // 
            // txt_film_adi
            // 
            this.txt_film_adi.Location = new System.Drawing.Point(257, 72);
            this.txt_film_adi.Name = "txt_film_adi";
            this.txt_film_adi.Size = new System.Drawing.Size(180, 22);
            this.txt_film_adi.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Seans:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Salon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Afiş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Yönetmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Film Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Film Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Film Ekleme Paneli";
            // 
            // pc_afis
            // 
            this.pc_afis.Location = new System.Drawing.Point(461, 63);
            this.pc_afis.Name = "pc_afis";
            this.pc_afis.Size = new System.Drawing.Size(239, 263);
            this.pc_afis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_afis.TabIndex = 33;
            this.pc_afis.TabStop = false;
            // 
            // txt_cıkıs
            // 
            this.txt_cıkıs.Image = global::NESNE_PROJE.Properties.Resources.kapat;
            this.txt_cıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_cıkıs.Location = new System.Drawing.Point(432, 392);
            this.txt_cıkıs.Name = "txt_cıkıs";
            this.txt_cıkıs.Size = new System.Drawing.Size(268, 40);
            this.txt_cıkıs.TabIndex = 32;
            this.txt_cıkıs.Text = "Çıkış";
            this.txt_cıkıs.UseVisualStyleBackColor = true;
            this.txt_cıkıs.Click += new System.EventHandler(this.txt_cıkıs_Click);
            // 
            // txt_anamenu
            // 
            this.txt_anamenu.Image = global::NESNE_PROJE.Properties.Resources.duzenle;
            this.txt_anamenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_anamenu.Location = new System.Drawing.Point(106, 392);
            this.txt_anamenu.Name = "txt_anamenu";
            this.txt_anamenu.Size = new System.Drawing.Size(320, 40);
            this.txt_anamenu.TabIndex = 31;
            this.txt_anamenu.Text = "Anamenü";
            this.txt_anamenu.UseVisualStyleBackColor = true;
            this.txt_anamenu.Click += new System.EventHandler(this.txt_anamenu_Click);
            // 
            // txt_film_ekle
            // 
            this.txt_film_ekle.Image = global::NESNE_PROJE.Properties.Resources.save;
            this.txt_film_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_film_ekle.Location = new System.Drawing.Point(106, 346);
            this.txt_film_ekle.Name = "txt_film_ekle";
            this.txt_film_ekle.Size = new System.Drawing.Size(594, 40);
            this.txt_film_ekle.TabIndex = 30;
            this.txt_film_ekle.Text = "Film Ekle";
            this.txt_film_ekle.UseVisualStyleBackColor = true;
            this.txt_film_ekle.Click += new System.EventHandler(this.txt_film_ekle_Click);
            // 
            // comb_yönetmen
            // 
            this.comb_yönetmen.FormattingEnabled = true;
            this.comb_yönetmen.Location = new System.Drawing.Point(255, 157);
            this.comb_yönetmen.Name = "comb_yönetmen";
            this.comb_yönetmen.Size = new System.Drawing.Size(182, 24);
            this.comb_yönetmen.TabIndex = 34;
            // 
            // comb_tür
            // 
            this.comb_tür.FormattingEnabled = true;
            this.comb_tür.Location = new System.Drawing.Point(255, 115);
            this.comb_tür.Name = "comb_tür";
            this.comb_tür.Size = new System.Drawing.Size(182, 24);
            this.comb_tür.TabIndex = 34;
            // 
            // fr_film_ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 477);
            this.Controls.Add(this.comb_tür);
            this.Controls.Add(this.comb_yönetmen);
            this.Controls.Add(this.pc_afis);
            this.Controls.Add(this.txt_cıkıs);
            this.Controls.Add(this.txt_anamenu);
            this.Controls.Add(this.txt_film_ekle);
            this.Controls.Add(this.txt_afis);
            this.Controls.Add(this.comb_seans);
            this.Controls.Add(this.comb_salon);
            this.Controls.Add(this.txt_film_adi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fr_film_ekleme";
            this.Text = "Film Ekleme Paneli";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_afis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pc_afis;
        private System.Windows.Forms.Button txt_cıkıs;
        private System.Windows.Forms.Button txt_anamenu;
        private System.Windows.Forms.Button txt_film_ekle;
        private System.Windows.Forms.Button txt_afis;
        private System.Windows.Forms.ComboBox comb_seans;
        private System.Windows.Forms.ComboBox comb_salon;
        private System.Windows.Forms.TextBox txt_film_adi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_yönetmen;
        private System.Windows.Forms.ComboBox comb_tür;
    }
}