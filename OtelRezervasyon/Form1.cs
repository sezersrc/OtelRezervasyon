using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOdaOlustur_Click(object sender, EventArgs e)
        {
            FrmOdaEkle Frm = new FrmOdaEkle();
            Frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listdoldur();
        }

        private void listdoldur()
        {
            using (OtelRezDataEntities db = new OtelRezDataEntities())
            {
                LBLBosOda.Text = "Boş Oda Sayısı : " + db.TBLOdalar.Where(x => x.OdaDurumu == false).Count();

                LBLDoluOda.Text = "Dolu Oda Sayısı : " + db.TBLOdalar.Where(x => x.OdaDurumu == true).Count();
            }
            using (OtelRezDataEntities db = new OtelRezDataEntities())
            {
                OdaListview.Clear();
                // Oda Sayısı Alınıyor.
                int i = 0;
                foreach (var item in db.TBLOdalar)
                {
                    if (item.OdaDurumu == false)
                    {
                        OdaListview.Items.Add(item.OdaNo + " - " + item.OdaAdi);
                        OdaListview.Items[i].ImageKey = "BosOda.png";
                    }
                    else
                    {
                        OdaListview.Items.Add(item.OdaNo + " - " + item.OdaAdi);
                        OdaListview.Items[i].ImageKey = "DoluOda.png";
                    }
                    i++;
                }
            }
        }

        private void BtnOdaYenile_Click(object sender, EventArgs e)
        {
            DateTime BugununTarihi = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));

            using (OtelRezDataEntities db = new OtelRezDataEntities())
            {
                foreach (var item in db.TBLRezervasyon)
                {
                    if (item.GirisTarihi < BugununTarihi && item.CikisTarihi > BugununTarihi)
                    {
                        // Rezervasyon içindeki OdaID'yi alıyorum, TBLodalar tablomda arıyorum, sonra bulduğum satırı var değişkene gönderiyorum.
                        var odalar = db.TBLOdalar.Where(x => x.OdaNo == item.OdaID).FirstOrDefault();

                        // var değişkeni içerisindeki OdaID alıp TBLtablolarda içeriğini değiştiriyorum.
                        using (OtelRezDataEntities cb = new OtelRezDataEntities())
                        {
                            TBLOdalar o = cb.TBLOdalar.Find(odalar.OdaID);
                            o.OdaDurumu = true;
                            cb.SaveChanges();
                        }
                    }
                    else
                    {
                        // Rezervasyon içindeki OdaID'yi alıyorum, TBLodalar tablomda arıyorum, sonra bulduğum satırı var değişkene gönderiyorum.
                        var odalar = db.TBLOdalar.Where(x => x.OdaNo == item.OdaID).FirstOrDefault();

                        // var değişkeni içerisindeki OdaID alıp TBLtablolarda içeriğini değiştiriyorum.
                        using (OtelRezDataEntities cb = new OtelRezDataEntities())
                        {
                            TBLOdalar o = cb.TBLOdalar.Find(odalar.OdaID);
                            o.OdaDurumu = false;
                            cb.SaveChanges();
                        }
                    }
                }
            }
            listdoldur();
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle Frm = new FrmMusteriEkle();
            Frm.Show();
        }

        int OdaNo = 0;


        string SecilenOda = "";
        private void OdaListview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string OdaNumarası = OdaListview.SelectedItems[0].SubItems[0].Text.Substring(0, OdaListview.SelectedItems[0].Text.IndexOf("-"));

                OdaNo = Convert.ToInt32(OdaNumarası);
                SecilenOda = OdaListview.SelectedItems[0].SubItems[0].Text;
                LBLSecilen.Text = "Seçilen Oda : " + OdaListview.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void BtnOdaRez_Click(object sender, EventArgs e)
        {
            FrmRezervasyon Frm = new FrmRezervasyon();
            Frm.OdaAdi = SecilenOda;
            Frm.OdaNo = OdaNo;
            Frm.Show();
        }

        private void OdaListview_DoubleClick(object sender, EventArgs e)
        {
            int OdaNumarası = Convert.ToInt32(OdaListview.SelectedItems[0].SubItems[0].Text.Substring(0, OdaListview.SelectedItems[0].Text.IndexOf("-")));

            OtelRezDataEntities db = new OtelRezDataEntities();

            var Tablom = from oda in db.TBLOdalar
                         join rez in db.TBLRezervasyon
                         on oda.OdaNo equals rez.OdaID
                         where oda.OdaDurumu == true && rez.OdaID == OdaNumarası 
                         select new { rez.GirisTarihi, rez.CikisTarihi };

      





            if (Tablom.Count() > 0)
            {
                label1.Text = Convert.ToDateTime(Tablom.FirstOrDefault().GirisTarihi).ToString("dd-MM-yyyy") + " - " + Convert.ToDateTime(Tablom.FirstOrDefault().CikisTarihi).ToString("dd-MM-yyyy") + " Arasında Rezervasyonludur";
            }
            else
            {
                label1.Text = "Rezervasyon Yapılabilir";
            }


        }
    }
}
