using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telefonrehberi{
    public class RehberListesi:Rehber{
         public void listele(){
            foreach (var item in rehber)
            {
                Console.WriteLine("İsim-Soyisim:"+item.Value);
                Console.WriteLine("Telefon Numarası:"+item.Key);
            }
       
         }

    }

}