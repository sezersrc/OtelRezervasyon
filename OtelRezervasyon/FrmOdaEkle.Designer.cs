namespace OtelRezervasyon
{
    partial class FrmOdaEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOdaAdi = new System.Windows.Forms.TextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOzellik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Adı :";
            // 
            // TxtOdaAdi
            // 
            this.TxtOdaAdi.Location = new System.Drawing.Point(103, 15);
            this.TxtOdaAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtOdaAdi.Name = "TxtOdaAdi";
            this.TxtOdaAdi.Size = new System.Drawing.Size(235, 22);
            this.TxtOdaAdi.TabIndex = 1;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Location = new System.Drawing.Point(103, 56);
            this.TxtOdaNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(235, 22);
            this.TxtOdaNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oda No :";
            // 
            // TxtOzellik
            // 
            this.TxtOzellik.Location = new System.Drawing.Point(103, 98);
            this.TxtOzellik.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOzellik.Multiline = true;
            this.TxtOzellik.Name = "TxtOzellik";
            this.TxtOzellik.Size = new System.Drawing.Size(235, 146);
            this.TxtOzellik.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Özellik :";
            // 
            // TxtUcret
            // 
            this.TxtUcret.Location = new System.Drawing.Point(103, 262);
            this.TxtUcret.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(235, 22);
            this.TxtUcret.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oda Ücreti :";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(103, 308);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(235, 35);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Yeni Oda Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FrmOdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 370);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOzellik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOdaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOdaAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOdaEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOdaAdi;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOzellik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEkle;
    }
}