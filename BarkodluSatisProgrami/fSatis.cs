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
    public partial class fSatis : Form
    {
        BarkodluDbEntities db = new BarkodluDbEntities();
        public fSatis()
        {
            InitializeComponent();
            Size = new Size(1400, 700);
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    tMiktar.Text = barkod;
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a => a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                        UrunGetirListele(urun, barkod, Convert.ToDouble(tMiktar.Text));
                    }
                    else
                    {
                        int onEk = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a => a.TeraziOnEk == onEk))
                        {
                            string teraziUrunNo = barkod.Substring(2, 5);
                            if (db.Urun.Any(a => a.Barkod == teraziUrunNo))
                            {
                                var urunTerazi = db.Urun.Where(a => a.Barkod == teraziUrunNo).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                UrunGetirListele(urunTerazi, teraziUrunNo, miktarkg);
                            }
                            else
                            {
                                Console.Beep(900, 2000);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(900, 2000);
                            MessageBox.Show("Normal Ürün Ekleme Sayfası");
                        }
                    }
                }
                gridSatisListesi.ClearSelection();
                GenelToplam();
            }
        }

        private void UrunGetirListele(Urun urun, string barkod, double miktar)
        {
            int satirSayisi = gridSatisListesi.Rows.Count;
            //double miktar = Convert.ToDouble(tMiktar.Text);
            bool eklenmisMi = false;
            if (satirSayisi > 0)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                        gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmisMi = true;
                    }
                }
            }
            if (!eklenmisMi)
            {
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirSayisi].Cells["Barkod"].Value = barkod;
                gridSatisListesi.Rows[satirSayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                gridSatisListesi.Rows[satirSayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                gridSatisListesi.Rows[satirSayisi].Cells["Birim"].Value = urun.Birim;
                gridSatisListesi.Rows[satirSayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                gridSatisListesi.Rows[satirSayisi].Cells["Miktar"].Value = miktar;
                gridSatisListesi.Rows[satirSayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                gridSatisListesi.Rows[satirSayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                gridSatisListesi.Rows[satirSayisi].Cells["KdvTutari"].Value = urun.KdvTutari;
            }
        }
        private void GenelToplam()
        {

            double toplam = 0;
            for (int i = 0; i < gridSatisListesi.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Toplam"].Value);
            }
            tGenelToplam.Text = toplam.ToString("C2");
            tBarkod.Clear();
            tBarkod.Focus();

        }

        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                gridSatisListesi.Rows.Remove(gridSatisListesi.CurrentRow);
                gridSatisListesi.ClearSelection();
                GenelToplam();
                tBarkod.Focus();
            }
        }

        private void HizliButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int butonId = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
            if (b.Text.ToString().StartsWith("-"))
            {
                fHizliButonUrunEkle f = new fHizliButonUrunEkle();
                f.lButonId.Text = butonId.ToString();
                f.ShowDialog();
            }
            else
            {

                var urunBarkod = db.HizliUrun.Where(a => a.Id == butonId).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.Urun.Where(a => a.Barkod == urunBarkod).FirstOrDefault();
                UrunGetirListele(urun, urunBarkod, Convert.ToDouble(tMiktar.Text));
                GenelToplam();
            }
        }
        private void fSatis_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
            ParaBirimleriniEkle();



        }

        private void ParaBirimleriniEkle()
        {
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");
        }

        private void HizliButonDoldur()
        {
            var hizliUrun = db.HizliUrun.ToList();
            foreach (var item in hizliUrun)
            {
                Button bH = this.Controls.Find("bH" + item.Id, true).FirstOrDefault() as Button;
                if (bH != null)
                {
                    double fiyat = Islemler.DoubleYap(item.Fiyat.ToString());
                    bH.Text = item.UrunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void bH_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;
                if (!b.Text.StartsWith("-"))
                {
                    int butonId = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + butonId.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonId = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonId);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("bH" + butonId, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tNumarator.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tNumarator.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (tNumarator.Text.Length > 0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                }
            }
            else
            {
                tNumarator.Text += b.Text;
            }
            
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text!="")
            {
                tMiktar.Text = tNumarator.Text;
                tNumarator.Clear();
                tBarkod.Clear();
                tBarkod.Focus();
            }
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text!="")
            {
                double sonuc = Islemler.DoubleYap(tNumarator.Text) - Islemler.DoubleYap(tGenelToplam.Text);
                tParaUstu.Text = sonuc.ToString("C2");
                tNumarator.Clear();
                tBarkod.Focus();
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                if (db.Urun.Any(a=>a.Barkod==tNumarator.Text))
                {
                    var urun = db.Urun.Where(a => a.Barkod == tNumarator.Text).FirstOrDefault();
                    UrunGetirListele(urun, tNumarator.Text, Convert.ToDouble(tMiktar.Text));
                    GenelToplam();
                    tNumarator.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    MessageBox.Show("Ürün ekleme sayfasını aç");
                }
            }
        }

        private void ParaUstuHesapla_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = Islemler.DoubleYap(b.Text) - Islemler.DoubleYap(tGenelToplam.Text);
            tParaUstu.Text = sonuc.ToString("C2");
        }
    }
}
