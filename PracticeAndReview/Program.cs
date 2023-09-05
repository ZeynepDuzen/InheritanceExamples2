using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Marka = "Asus",
                Model = "ROG",
                SeriNo = "AR123",
                UretimTarihi = DateTime.Parse("17.03.2023 14:35:44", new CultureInfo("tr-TR")),
                BilgisayarTipi = BilgisayarTipi.Dizustu,
                IslemciTipi = IslemciTipi.i7,
                Hafiza = 16,
                EkranBoyutu = 27,
                SuSogutmaliMi = true
                
            };

            Console.WriteLine("Marka : " + bilgisayar.Marka);
            Console.WriteLine("Model : " + bilgisayar.Model);
            Console.WriteLine("SeriNo : " + bilgisayar.SeriNo);
            Console.WriteLine("UretimTarihi : " + bilgisayar.UretimTarihi);
            Console.WriteLine("BilgisayarTipi : " + bilgisayar.BilgisayarTipi +"-"+ (int)bilgisayar.BilgisayarTipi);
            Console.WriteLine("IslemciTipi : " + bilgisayar.IslemciTipi +"-"+ (int)bilgisayar.IslemciTipi);
            Console.WriteLine("Hafiza : " + bilgisayar.Hafiza +" "+ "GB");
            Console.WriteLine("EkranBoyutu : " + bilgisayar.EkranBoyutu + " " + "inc");
            Console.WriteLine("SuSogutmaliMi : " + bilgisayar.SuSogutmali);
            Console.WriteLine("Kategori : " + bilgisayar.Kategori);
            Console.WriteLine();


            EvSinemaSistemi evSinemaSistemi = new EvSinemaSistemi();

            evSinemaSistemi.Marka = "Bose";
            evSinemaSistemi.Model = "LifeStyle 650";
            evSinemaSistemi.SeriNo = "BL650";
            evSinemaSistemi.UretimTarihi = DateTime.Parse("17.01.2023 16:50:55", new CultureInfo("tr-TR"));
            evSinemaSistemi.HoparlorSayisi = 6;
            evSinemaSistemi.Guc = 180;

            Console.WriteLine("Marka : " + evSinemaSistemi.Marka);
            Console.WriteLine("Model : " + evSinemaSistemi.Model);
            Console.WriteLine("SeriNo : " + evSinemaSistemi.SeriNo);
            Console.WriteLine("UretimTarihi : " + evSinemaSistemi.UretimTarihi);
            Console.WriteLine("HoparlorSayisi : " + evSinemaSistemi.HoparlorSayisi);
            Console.WriteLine("Guc : " + evSinemaSistemi.Guc + " " + "watt");
           






            Console.Read();
        }
    }
}
