namespace Site_Ip_Adresi_Ögrenme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBilgisayar = new System.Windows.Forms.TextBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar Adı:";
            // 
            // textBilgisayar
            // 
            this.textBilgisayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBilgisayar.Location = new System.Drawing.Point(148, 27);
            this.textBilgisayar.Name = "textBilgisayar";
            this.textBilgisayar.Size = new System.Drawing.Size(284, 26);
            this.textBilgisayar.TabIndex = 1;
            // 
            // textAdres
            // 
            this.textAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdres.Location = new System.Drawing.Point(148, 59);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(284, 26);
            this.textAdres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ip Adresi:";
            // 
            // buttonBilgi
            // 
            this.buttonBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBilgi.Location = new System.Drawing.Point(86, 113);
            this.buttonBilgi.Name = "buttonBilgi";
            this.buttonBilgi.Size = new System.Drawing.Size(247, 53);
            this.buttonBilgi.TabIndex = 4;
            this.buttonBilgi.Text = "Bilgileri Göster";
            this.buttonBilgi.UseVisualStyleBackColor = true;
            this.buttonBilgi.Click += new System.EventHandler(this.buttonBilgi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(455, 178);
            this.Controls.Add(this.buttonBilgi);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBilgisayar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ip Adresi Ögren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBilgisayar;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBilgi;
    }
}

