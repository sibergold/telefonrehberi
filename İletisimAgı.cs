using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telefonrehberi
{
    public class Rehber
    {
        public Dictionary<string, string> rehber = new Dictionary<string, string>();
        public Rehber()
        {
            rehber.Add("65413464", "Polat Alemdar");
            rehber.Add("24684385", "Memati Baş");
            rehber.Add("88443248", "Süleyman Çakır");
            rehber.Add("12454568", "Abdülhey Çoban");
            rehber.Add("21784681", "Hızır Çakırbeyli");
            rehber.Add("24684124", "Alparslan Çakırbeyli");


        }
         public void RehberArama(){
              foreach(var item in rehber){
                Console.WriteLine(item);
              }
         }
    
    }
}