using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telefonrehberi
{
    public class NumarayiDegis : Rehber
    {
        public void numarayiDegis()
        {
        guncelle:
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string isim = Console.ReadLine();
            int sayac = 0;
            foreach (var item in rehber)
            {
                if (item.Value.Contains(isim))
                {
                    Console.WriteLine("lütfen yeni numarasını giriniz:");
                    string numara = Console.ReadLine();
                    string isimNumara = item.Value;
                    rehber.Remove(item.Key);
                    rehber.Add(numara, isimNumara);
                    break;
                }
                else
                {
                    continue;
                }
                if (sayac == rehber.Count)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        Console.WriteLine("Çıkış yaptınız.");
                    }
                    else if (secim == "2")
                    {
                        goto guncelle;
                    }
                }
            }
            foreach (var item in rehber)
            {
                Console.WriteLine(item);
            }
        }
    }
}