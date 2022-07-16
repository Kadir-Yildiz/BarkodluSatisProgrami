using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }
        BarkodluDbEntities db = new BarkodluDbEntities();
        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupListele();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text!="")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupListele();
                tUrunGrupAd.Clear();
                MessageBox.Show("Ürün Grubu Eklendi!");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f!=null)
                {
                    f.GrupListele();
                }
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Ekleyiniz!");
            }
        }

        private void GrupListele()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            string grupAd = listUrunGrup.GetItemText(listUrunGrup.SelectedItem);
            UrunGrup urun = db.UrunGrup.Where(x => x.UrunGrupAd == grupAd).FirstOrDefault();
            db.UrunGrup.Remove(urun);
            db.SaveChanges();
            MessageBox.Show(grupAd + " Ürün Grubu Silindi!");
            GrupListele();
            fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
            if (f != null)
            {
                f.GrupListele();
            }
        }
    }
}
