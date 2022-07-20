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
    public partial class fDetayGoster : Form
    {
        public fDetayGoster()
        {
            InitializeComponent();
        }
        public int IslemNo { get; set; }
        private void fDetayGoster_Load(object sender, EventArgs e)
        {
            lIslemNo.Text = "İşlem No : " + IslemNo.ToString();
            using (var db=new BarkodluDbEntities())
            {
                gridListe.DataSource = db.Satis.Select(s=> new {s.IslemNo, s.UrunAd, s.UrunGrup,s.Miktar, s.Toplam}).Where(x=> x.IslemNo == IslemNo).ToList();
                Islemler.GridDuzenle(gridListe);
            }
        }
    }
}
