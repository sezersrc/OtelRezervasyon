namespace OtelRezervasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oDAİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOdaOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOdaListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMusteriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMusteriListe = new System.Windows.Forms.ToolStripMenuItem();
            this.rEZERVASYONİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRezOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRezListele = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OdaListview = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnOdaBosalt = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOdaRez = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOdaYenile = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LBLSecilen = new System.Windows.Forms.Label();
            this.LBLDoluOda = new System.Windows.Forms.Label();
            this.LBLBosOda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oDAİŞLEMLERİToolStripMenuItem,
            this.mÜŞTERİİŞLEMLERİToolStripMenuItem,
            this.rEZERVASYONİŞLEMLERİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oDAİŞLEMLERİToolStripMenuItem
            // 
            this.oDAİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOdaOlustur,
            this.BtnOdaListe});
            this.oDAİŞLEMLERİToolStripMenuItem.Name = "oDAİŞLEMLERİToolStripMenuItem";
            this.oDAİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.oDAİŞLEMLERİToolStripMenuItem.Text = "ODA İŞLEMLERİ";
            // 
            // BtnOdaOlustur
            // 
            this.BtnOdaOlustur.Name = "BtnOdaOlustur";
            this.BtnOdaOlustur.Size = new System.Drawing.Size(152, 22);
            this.BtnOdaOlustur.Text = "ODA OLUŞTUR";
            this.BtnOdaOlustur.Click += new System.EventHandler(this.BtnOdaOlustur_Click);
            // 
            // BtnOdaListe
            // 
            this.BtnOdaListe.Name = "BtnOdaListe";
            this.BtnOdaListe.Size = new System.Drawing.Size(152, 22);
            this.BtnOdaListe.Text = "ODA LİSTELE";
            // 
            // mÜŞTERİİŞLEMLERİToolStripMenuItem
            // 
            this.mÜŞTERİİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMusteriEkle,
            this.BtnMusteriListe});
            this.mÜŞTERİİŞLEMLERİToolStripMenuItem.Name = "mÜŞTERİİŞLEMLERİToolStripMenuItem";
            this.mÜŞTERİİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.mÜŞTERİİŞLEMLERİToolStripMenuItem.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(163, 22);
            this.BtnMusteriEkle.Text = "MÜŞTERİ EKLE";
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // BtnMusteriListe
            // 
            this.BtnMusteriListe.Name = "BtnMusteriListe";
            this.BtnMusteriListe.Size = new System.Drawing.Size(163, 22);
            this.BtnMusteriListe.Text = "MÜŞTERİ LİSTELE";
            // 
            // rEZERVASYONİŞLEMLERİToolStripMenuItem
            // 
            this.rEZERVASYONİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRezOlustur,
            this.BtnRezListele});
            this.rEZERVASYONİŞLEMLERİToolStripMenuItem.Name = "rEZERVASYONİŞLEMLERİToolStripMenuItem";
            this.rEZERVASYONİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.rEZERVASYONİŞLEMLERİToolStripMenuItem.Text = "REZERVASYON İŞLEMLERİ";
            // 
            // BtnRezOlustur
            // 
            this.BtnRezOlustur.Name = "BtnRezOlustur";
            this.BtnRezOlustur.Size = new System.Drawing.Size(205, 22);
            this.BtnRezOlustur.Text = "REZERVASYON OLUŞTUR";
            // 
            // BtnRezListele
            // 
            this.BtnRezListele.Name = "BtnRezListele";
            this.BtnRezListele.Size = new System.Drawing.Size(205, 22);
            this.BtnRezListele.Text = "REZERVASYON LİSTELE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OdaListview);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1612, 802);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ODA LİSTESİ";
            // 
            // OdaListview
            // 
            this.OdaListview.ContextMenuStrip = this.contextMenuStrip1;
            this.OdaListview.HideSelection = false;
            this.OdaListview.LargeImageList = this.ımageList1;
            this.OdaListview.Location = new System.Drawing.Point(9, 25);
            this.OdaListview.Margin = new System.Windows.Forms.Padding(4);
            this.OdaListview.Name = "OdaListview";
            this.OdaListview.Size = new System.Drawing.Size(1593, 715);
            this.OdaListview.TabIndex = 0;
            this.OdaListview.UseCompatibleStateImageBehavior = false;
            this.OdaListview.DoubleClick += new System.EventHandler(this.OdaListview_DoubleClick);
            this.OdaListview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OdaListview_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOdaBosalt,
            this.BtnOdaRez,
            this.BtnOdaYenile});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 70);
            // 
            // BtnOdaBosalt
            // 
            this.BtnOdaBosalt.Name = "BtnOdaBosalt";
            this.BtnOdaBosalt.Size = new System.Drawing.Size(198, 22);
            this.BtnOdaBosalt.Text = "Odayı Boşalt";
            // 
            // BtnOdaRez
            // 
            this.BtnOdaRez.Name = "BtnOdaRez";
            this.BtnOdaRez.Size = new System.Drawing.Size(198, 22);
            this.BtnOdaRez.Text = "Odaya Rezervasyon Yap";
            this.BtnOdaRez.Click += new System.EventHandler(this.BtnOdaRez_Click);
            // 
            // BtnOdaYenile
            // 
            this.BtnOdaYenile.Name = "BtnOdaYenile";
            this.BtnOdaYenile.Size = new System.Drawing.Size(198, 22);
            this.BtnOdaYenile.Text = "Odaları Yenile";
            this.BtnOdaYenile.Click += new System.EventHandler(this.BtnOdaYenile_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "BosOda.png");
            this.ımageList1.Images.SetKeyName(1, "DoluOda.png");
            // 
            // LBLSecilen
            // 
            this.LBLSecilen.AutoSize = true;
            this.LBLSecilen.BackColor = System.Drawing.Color.Teal;
            this.LBLSecilen.ForeColor = System.Drawing.SystemColors.Control;
            this.LBLSecilen.Location = new System.Drawing.Point(648, 2);
            this.LBLSecilen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLSecilen.Name = "LBLSecilen";
            this.LBLSecilen.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.LBLSecilen.Size = new System.Drawing.Size(117, 22);
            this.LBLSecilen.TabIndex = 3;
            this.LBLSecilen.Text = "Oda Seçilmedi";
            // 
            // LBLDoluOda
            // 
            this.LBLDoluOda.AutoSize = true;
            this.LBLDoluOda.BackColor = System.Drawing.Color.Teal;
            this.LBLDoluOda.ForeColor = System.Drawing.SystemColors.Control;
            this.LBLDoluOda.Location = new System.Drawing.Point(1041, 1);
            this.LBLDoluOda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDoluOda.Name = "LBLDoluOda";
            this.LBLDoluOda.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.LBLDoluOda.Size = new System.Drawing.Size(20, 22);
            this.LBLDoluOda.TabIndex = 4;
            // 
            // LBLBosOda
            // 
            this.LBLBosOda.AutoSize = true;
            this.LBLBosOda.BackColor = System.Drawing.Color.RoyalBlue;
            this.LBLBosOda.ForeColor = System.Drawing.SystemColors.Control;
            this.LBLBosOda.Location = new System.Drawing.Point(1289, 1);
            this.LBLBosOda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLBosOda.Name = "LBLBosOda";
            this.LBLBosOda.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.LBLBosOda.Size = new System.Drawing.Size(20, 22);
            this.LBLBosOda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 751);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(1595, 40);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 850);
            this.Controls.Add(this.LBLBosOda);
            this.Controls.Add(this.LBLDoluOda);
            this.Controls.Add(this.LBLSecilen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oDAİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnMusteriEkle;
        private System.Windows.Forms.ToolStripMenuItem BtnMusteriListe;
        private System.Windows.Forms.ToolStripMenuItem rEZERVASYONİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnRezOlustur;
        private System.Windows.Forms.ToolStripMenuItem BtnRezListele;
        private System.Windows.Forms.ToolStripMenuItem BtnOdaOlustur;
        private System.Windows.Forms.ToolStripMenuItem BtnOdaListe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView OdaListview;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnOdaBosalt;
        private System.Windows.Forms.ToolStripMenuItem BtnOdaRez;
        private System.Windows.Forms.ToolStripMenuItem BtnOdaYenile;
        private System.Windows.Forms.Label LBLSecilen;
        private System.Windows.Forms.Label LBLDoluOda;
        private System.Windows.Forms.Label LBLBosOda;
        private System.Windows.Forms.Label label1;
    }
}

