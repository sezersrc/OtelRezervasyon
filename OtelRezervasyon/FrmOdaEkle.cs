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
    public partial class FrmOdaEkle : Form
    {
        public FrmOdaEkle()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            using (OtelRezDataEntities db = new OtelRezDataEntities())
            {
                TBLOdalar o = new TBLOdalar();
                o.OdaAdi = TxtOdaAdi.Text;
                o.OdaDurumu = false;
                o.OdaNo = Convert.ToInt32(TxtOdaNo.Text);
                o.Ozellik = TxtOzellik.Text;
                o.Ucret = Convert.ToDecimal(TxtUcret.Text);
                db.TBLOdalar.Add(o);
                db.SaveChanges();
                MessageBox.Show("Oda Eklendi.");
            }
        }
    }
}
