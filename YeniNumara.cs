using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telefonrehberi{
    public class YeniNumara:Rehber{
        public void ekle(){
            Console.WriteLine("Lütfen isim giriniz :");
            string isim=Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz :");
            string soyisim=Console.ReadLine();
            Console.WriteLine(" Lütfen telefon numarası giriniz :");
            string numara=Console.ReadLine();
            rehber.Add(numara,isim + soyisim);
            Console.WriteLine(isim + " "+ soyisim + "Rehbere eklendi.");
        }
    }
}