using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void bAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using (var db = new BarkodluDbEntities())
            {
                if (cmbIslemTuru.Text!="")
                {
                    string urunGrubu = cmbUrunGrubu.Text;
                    if (cmbIslemTuru.SelectedIndex==0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urunGrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz!");
                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urunGrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen İşlem Türü Seçiniz!");
                }
                
            }
            Islemler.GridDuzenle(gridListe);
        }

        BarkodluDbEntities dbx = new BarkodluDbEntities();
        private void fStok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            
                string urunAd = tUrunAra.Text;
                using (var db = new BarkodluDbEntities())
                {
                    if (cmbIslemTuru.SelectedIndex==0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunAd)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunAd)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                }
            Islemler.GridDuzenle(gridListe);
        }

        private void rdTumu_CheckedChanged(object sender, EventArgs e)
        {
            cmbUrunGrubu.Enabled = false;
        }

        private void rdUrunGrubunaGore_CheckedChanged(object sender, EventArgs e)
        {
            cmbUrunGrubu.Enabled=true;
        }

        private void cmbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex == 0)
            {
                dateBaslangic.Enabled = false;
                dateBitis.Enabled = false;
            }
            else if (cmbIslemTuru.SelectedIndex == 1)
            {
                dateBaslangic.Enabled = true;
                dateBitis.Enabled = true;
            }
        }
    }
}
