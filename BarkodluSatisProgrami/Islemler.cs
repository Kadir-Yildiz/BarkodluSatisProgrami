﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatisProgrami
{
    static class Islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger,System.Globalization.NumberStyles.Currency,CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return sonuc;
        }
    }
}
