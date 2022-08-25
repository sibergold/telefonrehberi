using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telefonrehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
         string secim= Console.ReadLine();
       switch(secim)
        {   case "1" :
            YeniNumara yeniNumara= new YeniNumara();
           yeniNumara.ekle();
           yeniNumara.RehberArama();
           break;
           case "2" :
              NumaraSil numaraSil=new NumaraSil();
              numaraSil.sil();
          break;
          case "3" :
          NumarayiDegis numarayiDegis=new NumarayiDegis();
          numarayiDegis.numarayiDegis();
          break;
          case "4":
          RehberListesi rehberListesi=new RehberListesi();
          rehberListesi.listele(); 
          break;
        case "5":
        RehberdeAra rehberdeAra=new RehberdeAra();
        rehberdeAra.Arama();
        break;
      }
             Console.ReadLine();
    }
    }
}       

        
        
       









