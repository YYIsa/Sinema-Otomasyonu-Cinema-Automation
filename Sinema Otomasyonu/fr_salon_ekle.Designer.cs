namespace NESNE_PROJE
{
    partial class fr_salon_ekle
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
            this.bt_cıkıs = new System.Windows.Forms.Button();
            this.bt_anamenu = new System.Windows.Forms.Button();
            this.txt_salon_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_salon_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cıkıs
            // 
            this.bt_cıkıs.Image = global::NESNE_PROJE.Properties.Resources.kapat;
            this.bt_cıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cıkıs.Location = new System.Drawing.Point(429, 297);
            this.bt_cıkıs.Name = "bt_cıkıs";
            this.bt_cıkıs.Size = new System.Drawing.Size(268, 40);
            this.bt_cıkıs.TabIndex = 24;
            this.bt_cıkıs.Text = "Çıkış";
            this.bt_cıkıs.UseVisualStyleBackColor = true;
            this.bt_cıkıs.Click += new System.EventHandler(this.bt_cıkıs_Click);
            // 
            // bt_anamenu
            // 
            this.bt_anamenu.Image = global::NESNE_PROJE.Properties.Resources.duzenle;
            this.bt_anamenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_anamenu.Location = new System.Drawing.Point(103, 297);
            this.bt_anamenu.Name = "bt_anamenu";
            this.bt_anamenu.Size = new System.Drawing.Size(320, 40);
            this.bt_anamenu.TabIndex = 23;
            this.bt_anamenu.Text = "Anamenü";
            this.bt_anamenu.UseVisualStyleBackColor = true;
            this.bt_anamenu.Click += new System.EventHandler(this.bt_anamenu_Click);
            // 
            // txt_salon_adi
            // 
            this.txt_salon_adi.Location = new System.Drawing.Point(408, 184);
            this.txt_salon_adi.Name = "txt_salon_adi";
            this.txt_salon_adi.Size = new System.Drawing.Size(180, 22);
            this.txt_salon_adi.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Salon Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(266, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Salon Ekleme Paneli";
            // 
            // bt_salon_ekle
            // 
            this.bt_salon_ekle.Image = global::NESNE_PROJE.Properties.Resources.save;
            this.bt_salon_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salon_ekle.Location = new System.Drawing.Point(103, 251);
            this.bt_salon_ekle.Name = "bt_salon_ekle";
            this.bt_salon_ekle.Size = new System.Drawing.Size(594, 40);
            this.bt_salon_ekle.TabIndex = 22;
            this.bt_salon_ekle.Text = "Salon Ekle";
            this.bt_salon_ekle.UseVisualStyleBackColor = true;
            this.bt_salon_ekle.Click += new System.EventHandler(this.bt_salon_ekle_Click);
            // 
            // fr_salon_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cıkıs);
            this.Controls.Add(this.bt_anamenu);
            this.Controls.Add(this.bt_salon_ekle);
            this.Controls.Add(this.txt_salon_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fr_salon_ekle";
            this.Text = "Salon Ekleme Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cıkıs;
        private System.Windows.Forms.Button bt_anamenu;
        private System.Windows.Forms.Button bt_salon_ekle;
        private System.Windows.Forms.TextBox txt_salon_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}