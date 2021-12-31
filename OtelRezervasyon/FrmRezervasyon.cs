using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon
{
    public partial class FrmRezervasyon : Form
    {
        public string OdaAdi { get; set; }
        public int OdaNo { get; set; }
        public FrmRezervasyon()
        {
            InitializeComponent();
        }

        private void FrmRezervasyon_Load(object sender, EventArgs e)
        {
            using (OtelRezDataEntities db = new OtelRezDataEntities())
            {
                CbMusteri.ValueMember = "MusteriID"; //Combobax'ta Görünmeyen Kısım
                CbMusteri.DisplayMember = "AdiSoyadi"; // Combobax Görünen Kısım
                CbMusteri.DataSource = db.TBLMusteri.ToList();
                TxtSecilenOda.Text = OdaAdi;

            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            OtelRezDataEntities db = new OtelRezDataEntities();
            DateTime GirisTarihi = Convert.ToDateTime(DtGiris.Text);
            DateTime CikisiTarihi = Convert.ToDateTime(DtCikis.Text);

            if (db.TBLRezervasyon.Any(x => x.GirisTarihi >= GirisTarihi && x.CikisTarihi <= CikisiTarihi && x.OdaID == OdaNo))
            {
                MessageBox.Show("Bu Tarihler Arazında Bu Oda Rezerversyonlu.");
            }
            else
            {
                TBLRezervasyon r = new TBLRezervasyon();
                r.CikisTarihi = CikisiTarihi;
                r.GirisTarihi = GirisTarihi;
                r.OdaID = OdaNo;
                r.MusteriID = Convert.ToInt32(CbMusteri.SelectedValue.ToString());
                r.Ucret = Convert.ToDecimal(TxtUcret.Text.Replace("₺", ""));
                db.TBLRezervasyon.Add(r);
                db.SaveChanges();

                LBLSonuc.Text = GirisTarihi.ToString("dd-MM-yyyy") + " - " + CikisiTarihi.ToString("dd-MM-yyyy") + " Tarihleri Arasında Rezervasyonunuz Yapıldı";

            }
        }

        private void DtCikis_ValueChanged(object sender, EventArgs e)
        {
            if (DtGiris.Text != null && DtCikis.Text != null)
            {
                DateTime GirisTarihi = Convert.ToDateTime(DtGiris.Text);
                DateTime CikisiTarihi = Convert.ToDateTime(DtCikis.Text);

                int GunSayi = Convert.ToInt32((CikisiTarihi - GirisTarihi).TotalDays);

                OtelRezDataEntities db = new OtelRezDataEntities();

                var OtelBilgi = db.TBLOdalar.Where(x => x.OdaNo == OdaNo).FirstOrDefault();

                TxtUcret.Text = (Convert.ToDecimal(OtelBilgi.Ucret * GunSayi)).ToString("C");
                LBLSonuc.Text = "Günlük Oda Ücreti : " + (Convert.ToDecimal(OtelBilgi.Ucret)).ToString("C");

            }
        }
    }
}
