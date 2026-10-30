namespace NESNE_PROJE
{
    partial class fr_seans_ekle
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bt_cıkıs = new System.Windows.Forms.Button();
            this.bt_anamenu = new System.Windows.Forms.Button();
            this.txt_saati = new System.Windows.Forms.TextBox();
            this.txt_seans_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_seans_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(359, 174);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker.TabIndex = 29;
            // 
            // bt_cıkıs
            // 
            this.bt_cıkıs.Image = global::NESNE_PROJE.Properties.Resources.kapat;
            this.bt_cıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cıkıs.Location = new System.Drawing.Point(429, 329);
            this.bt_cıkıs.Name = "bt_cıkıs";
            this.bt_cıkıs.Size = new System.Drawing.Size(268, 40);
            this.bt_cıkıs.TabIndex = 28;
            this.bt_cıkıs.Text = "Çıkış";
            this.bt_cıkıs.UseVisualStyleBackColor = true;
            this.bt_cıkıs.Click += new System.EventHandler(this.bt_cıkıs_Click);
            // 
            // bt_anamenu
            // 
            this.bt_anamenu.Image = global::NESNE_PROJE.Properties.Resources.duzenle;
            this.bt_anamenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_anamenu.Location = new System.Drawing.Point(103, 329);
            this.bt_anamenu.Name = "bt_anamenu";
            this.bt_anamenu.Size = new System.Drawing.Size(320, 40);
            this.bt_anamenu.TabIndex = 27;
            this.bt_anamenu.Text = "Anamenü";
            this.bt_anamenu.UseVisualStyleBackColor = true;
            this.bt_anamenu.Click += new System.EventHandler(this.bt_anamenu_Click);
            // 
            // txt_saati
            // 
            this.txt_saati.Location = new System.Drawing.Point(359, 224);
            this.txt_saati.Name = "txt_saati";
            this.txt_saati.Size = new System.Drawing.Size(255, 22);
            this.txt_saati.TabIndex = 25;
            // 
            // txt_seans_adi
            // 
            this.txt_seans_adi.Location = new System.Drawing.Point(359, 128);
            this.txt_seans_adi.Name = "txt_seans_adi";
            this.txt_seans_adi.Size = new System.Drawing.Size(255, 22);
            this.txt_seans_adi.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Seans adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(262, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seans Ekleme Paneli";
            // 
            // bt_seans_ekle
            // 
            this.bt_seans_ekle.Image = global::NESNE_PROJE.Properties.Resources.save;
            this.bt_seans_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_seans_ekle.Location = new System.Drawing.Point(103, 283);
            this.bt_seans_ekle.Name = "bt_seans_ekle";
            this.bt_seans_ekle.Size = new System.Drawing.Size(594, 40);
            this.bt_seans_ekle.TabIndex = 26;
            this.bt_seans_ekle.Text = "Seans Ekle";
            this.bt_seans_ekle.UseVisualStyleBackColor = true;
            this.bt_seans_ekle.Click += new System.EventHandler(this.bt_seans_ekle_Click);
            // 
            // fr_seans_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 477);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.bt_cıkıs);
            this.Controls.Add(this.bt_anamenu);
            this.Controls.Add(this.bt_seans_ekle);
            this.Controls.Add(this.txt_saati);
            this.Controls.Add(this.txt_seans_adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fr_seans_ekle";
            this.Text = "Seans Ekleme Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button bt_cıkıs;
        private System.Windows.Forms.Button bt_anamenu;
        private System.Windows.Forms.Button bt_seans_ekle;
        private System.Windows.Forms.TextBox txt_saati;
        private System.Windows.Forms.TextBox txt_seans_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}