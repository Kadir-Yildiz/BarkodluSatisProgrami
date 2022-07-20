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
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        public void bGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dtBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dtBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db = new BarkodluDbEntities())
            {
                if (listFiltrelemeTuru.SelectedIndex == 0) //Tümünü Göster
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemOzet;

                    tSatisNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == false && x.Gelir == false).Sum(x => x.Nakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == false && x.Gelir == false).Sum(x => x.Kart)).ToString("C2");

                    tIadeNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    tIadeKart.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    tGelirNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemOzet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString("C2");

                    tGiderNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemOzet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satisTablosu = db.Satis.Local.ToBindingList();
                    double kdvTutariSatis = Islemler.DoubleYap(satisTablosu.Where(x => x.Iade == false).Sum(x => x.KdvTutari).ToString());
                    double kdvTutariIade = Islemler.DoubleYap(satisTablosu.Where(x => x.Iade == true).Sum(x => x.KdvTutari).ToString());
                    tKdvToplam.Text = (kdvTutariSatis - kdvTutariIade).ToString("C2");

                }
                else if (listFiltrelemeTuru.SelectedIndex == 1) // Satışlar
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gelir == false && x.Gider == false).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemOzet;
                }
                else if (listFiltrelemeTuru.SelectedIndex == 2) // İadeler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemOzet;
                }
                else if (listFiltrelemeTuru.SelectedIndex == 3) // Gelirler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemOzet;
                }
                else if (listFiltrelemeTuru.SelectedIndex == 4) // Giderler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemOzet;
                }

            }
            Islemler.GridDuzenle(gridListe);


            Cursor.Current = Cursors.Default;
        }

        private void fRapor_Load(object sender, EventArgs e)
        {
            listFiltrelemeTuru.SelectedIndex = 0;
            tKartKomisyon.Text ="%"+ Islemler.KartKomisyon().ToString();
            bGoster_Click(null, null);
        }

        private void gridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.GelirGider = "GELİR";
            f.Kullanici = lKullanici.Text;
            f.ShowDialog();
        }

        private void bGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.GelirGider = "GİDER";
            f.Kullanici = lKullanici.Text;
            f.ShowDialog();
        }
    }
}
