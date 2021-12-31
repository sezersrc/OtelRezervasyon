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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            using (OtelRezDataEntities db = new OtelRezDataEntities())
            {
                TBLMusteri m = new TBLMusteri();
                m.AdiSoyadi = TxtAdi.Text;
                m.telefon2 = TxtTelefon2.Text;
                m.Telefon = TxtTelefon1.Text;
                m.TCNO = TxtTcNo.Text;
                db.TBLMusteri.Add(m);
                db.SaveChanges();
                MessageBox.Show("Müşteri Eklendi.");
            }
        }
    }
}
