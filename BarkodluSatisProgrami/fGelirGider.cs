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
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }

        public string GelirGider { get; set; }
        public string Kullanici { get; set; }
        private void fGelirGider_Load(object sender, EventArgs e)
        {
            lGelirGider.Text = GelirGider + " İŞLEMİ YAPILIYOR";
        }

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.SelectedIndex==0)
            {
                tNakit.Enabled = true;
                tKart.Enabled = false;
            }
            else if (cmbOdemeTuru.SelectedIndex == 1)
            {
                tNakit.Enabled = false;
                tKart.Enabled = true;
            }
            else if (cmbOdemeTuru.SelectedIndex == 2)
            {
                tNakit.Enabled = true;
                tKart.Enabled = true;
            }
            tNakit.Text = "0";
            tKart.Text = "0";
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.Text!="")
            {
                if (tNakit.Text != "" && tKart.Text != "" )
                {
                    if (tNakit.Text == "0" && tKart.Text == "0")
                    {
                        MessageBox.Show("Lütfen Gelir veya Gider Miktarını Giriniz!");
                        return;
                    }
                    else
                    {
                        using (var db = new BarkodluDbEntities())
                        {
                            IslemOzet io = new IslemOzet();
                            io.IslemNo = 0;
                            io.Iade = false;
                            io.OdemeSekli = cmbOdemeTuru.Text;
                            io.Nakit = Islemler.DoubleYap(tNakit.Text);
                            io.Kart = Islemler.DoubleYap(tKart.Text);
                            if (GelirGider == "GELİR")
                            {
                                io.Gelir = true;
                                io.Gider = false;
                            }
                            else
                            {
                                io.Gelir = false;
                                io.Gider = true;
                            }
                            io.AlisFiyatToplam = 0;
                            io.Aciklama = GelirGider + " - İşlemi " + tAciklama.Text;
                            io.Tarih = dtTarih.Value;
                            io.Kullanici = Kullanici;
                            db.IslemOzet.Add(io);
                            db.SaveChanges();
                            MessageBox.Show(GelirGider + " İşlemi Kaydedildi!");
                            tNakit.Text = "0";
                            tKart.Text = "0";
                            tAciklama.Clear();
                            cmbOdemeTuru.Text = "";
                            fRapor f = (fRapor)Application.OpenForms["fRapor"];
                            if (f != null)
                            {
                                f.bGoster_Click(null, null);
                            }
                            this.Hide();
                        }
                        
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen Ödeme Türünü Seçiniz!");
            }
        }
    }
}
