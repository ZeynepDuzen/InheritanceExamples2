using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Bilgisayar : ElektronikEsya
    {
        public BilgisayarTipi BilgisayarTipi { get; set; }
        public IslemciTipi IslemciTipi { get; set; }
        public short Hafiza { get; set; } // GB 
        public double EkranBoyutu { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public string SuSogutmali=> SuSogutmaliMi ? "Var" : "Yok"; //readonly property
        public string Kategori // readonly
        {
            get
            {
                if ((IslemciTipi == IslemciTipi.i7 || IslemciTipi == IslemciTipi.i9) && Hafiza >= 16)
                    return "Oyun Bilgisayari";
                return "Is Bilgisayari";
            }
        } 
    }
}
