namespace OtelRezervasyon
{
    partial class FrmRezervasyon
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
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtSecilenOda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbMusteri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtGiris = new System.Windows.Forms.DateTimePicker();
            this.DtCikis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(38, 17);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Seçilen Oda : ";
            // 
            // TxtSecilenOda
            // 
            this.TxtSecilenOda.Enabled = false;
            this.TxtSecilenOda.Location = new System.Drawing.Point(141, 17);
            this.TxtSecilenOda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSecilenOda.Name = "TxtSecilenOda";
            this.TxtSecilenOda.Size = new System.Drawing.Size(214, 22);
            this.TxtSecilenOda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Seç :";
            // 
            // CbMusteri
            // 
            this.CbMusteri.FormattingEnabled = true;
            this.CbMusteri.Location = new System.Drawing.Point(141, 57);
            this.CbMusteri.Name = "CbMusteri";
            this.CbMusteri.Size = new System.Drawing.Size(214, 24);
            this.CbMusteri.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giriş Tarihi :";
            // 
            // DtGiris
            // 
            this.DtGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtGiris.Location = new System.Drawing.Point(141, 96);
            this.DtGiris.Name = "DtGiris";
            this.DtGiris.Size = new System.Drawing.Size(214, 22);
            this.DtGiris.TabIndex = 5;
            // 
            // DtCikis
            // 
            this.DtCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtCikis.Location = new System.Drawing.Point(141, 135);
            this.DtCikis.Name = "DtCikis";
            this.DtCikis.Size = new System.Drawing.Size(214, 22);
            this.DtCikis.TabIndex = 7;
            this.DtCikis.ValueChanged += new System.EventHandler(this.DtCikis_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Çıkış Tarihi :";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(141, 225);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(214, 42);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Rezervasyon Yap";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtUcret
            // 
            this.TxtUcret.Location = new System.Drawing.Point(141, 178);
            this.TxtUcret.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(214, 22);
            this.TxtUcret.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödenecek Ücret :";
            // 
            // LBLSonuc
            // 
            this.LBLSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBLSonuc.Location = new System.Drawing.Point(26, 288);
            this.LBLSonuc.Name = "LBLSonuc";
            this.LBLSonuc.Size = new System.Drawing.Size(374, 79);
            this.LBLSonuc.TabIndex = 11;
            this.LBLSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 383);
            this.Controls.Add(this.LBLSonuc);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.DtCikis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSecilenOda);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRezervasyon";
            this.Load += new System.EventHandler(this.FrmRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtSecilenOda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtGiris;
        private System.Windows.Forms.DateTimePicker DtCikis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLSonuc;
    }
}