using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telefonrehberi{
    public class RehberdeAra:Rehber{
 public void Arama(){
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string secim = Console.ReadLine();
       if(secim=="1"){
         Console.WriteLine("Lütfen aramak istediğiniz kişinin isim veya soyismini giriniz:");
                string isimSoyisim = Console.ReadLine();
                foreach (var item in rehber){
                    if(item.Value.Contains(isimSoyisim)){
                        Console.WriteLine("İsim-Soyisim:" + item.Value);
                        Console.WriteLine("Telefon Numarası:" + item.Key);
                        break;
                    }
                else {
                  continue;
                }
                
                }

       }
         else if(secim=="2"){
            Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
                string numara = Console.ReadLine();
            foreach(var item in rehber){
                if(item.Value.Contains(numara)){
                    Console.WriteLine("İsim-Soyisim:" + item.Value);
                    Console.WriteLine("Telefon Numarası:" + item.Key);
                }
             else{
                continue;
             }
            }
         
         
         
         
         
         
         
         
         
         
         
         
         
         }
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 }
    }
}
