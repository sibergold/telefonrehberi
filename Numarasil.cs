using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telefonrehberi{
     public class NumaraSil:Rehber{
           public void sil(){
            sil:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string isimSoyisim = Console.ReadLine();
            int boyut = 0;
           foreach(var item in rehber){
            if(item.Value.Contains(isimSoyisim)){
               Console.WriteLine("isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
               string secenek=Console.ReadLine();
               if(secenek=="y"){
               
                rehber.Remove(item.Key);
            Console.WriteLine(item.Value + "silindi.");
            break;}
            else if(secenek=="n"){
                break;
            }
            }
           else{
            boyut++;
            break;
           }

         if (boyut == rehber.Count)
                {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                }
               string secim=Console.ReadLine();
               if(secim=="1"){
                  Console.WriteLine("Çıkış yaptınız."); 
               }
            else if(secim=="2"){
           goto sil;
            }



            }
           foreach (var item in rehber)
            {
                Console.WriteLine(item);
            }
           
           }
     }
}