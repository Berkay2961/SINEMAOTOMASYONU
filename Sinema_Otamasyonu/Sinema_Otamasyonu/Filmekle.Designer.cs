namespace Sinema_Otamasyonu
{
    partial class Filmekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmekle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtYapimYili = new System.Windows.Forms.TextBox();
            this.comboFilmTuru = new System.Windows.Forms.ComboBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnAfisSec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(139, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Film Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(141, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(141, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yapım Yılı";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(243, 106);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(121, 22);
            this.txtFilmAdi.TabIndex = 6;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(243, 140);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(121, 22);
            this.txtYonetmen.TabIndex = 7;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(243, 205);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(121, 22);
            this.txtSure.TabIndex = 8;
            // 
            // txtYapimYili
            // 
            this.txtYapimYili.Location = new System.Drawing.Point(245, 243);
            this.txtYapimYili.Name = "txtYapimYili";
            this.txtYapimYili.Size = new System.Drawing.Size(119, 22);
            this.txtYapimYili.TabIndex = 9;
            // 
            // comboFilmTuru
            // 
            this.comboFilmTuru.FormattingEnabled = true;
            this.comboFilmTuru.Location = new System.Drawing.Point(243, 172);
            this.comboFilmTuru.Name = "comboFilmTuru";
            this.comboFilmTuru.Size = new System.Drawing.Size(121, 24);
            this.comboFilmTuru.TabIndex = 10;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.Location = new System.Drawing.Point(253, 321);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(111, 45);
            this.btnFilmEkle.TabIndex = 11;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnAfisSec
            // 
            this.btnAfisSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAfisSec.Location = new System.Drawing.Point(484, 321);
            this.btnAfisSec.Name = "btnAfisSec";
            this.btnAfisSec.Size = new System.Drawing.Size(112, 45);
            this.btnAfisSec.TabIndex = 12;
            this.btnAfisSec.Text = "Afiş Seç";
            this.btnAfisSec.UseVisualStyleBackColor = true;
            this.btnAfisSec.Click += new System.EventHandler(this.btnAfisSec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(415, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 202);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(142, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tarih";
            // 
            // Filmekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAfisSec);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.comboFilmTuru);
            this.Controls.Add(this.txtYapimYili);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Filmekle";
            this.Text = "BERKAY SİNEMA SALONLARI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filmekle_FormClosing);
        
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtYapimYili;
        private System.Windows.Forms.ComboBox comboFilmTuru;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnAfisSec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}