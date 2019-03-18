using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Örnek olması açısında iskelet kod hazır olarak verilmiştir. İmplementasyonunuz bunun üzerinden gerçekleştiriniz.
            */
            //please why...
            Ermeydani meydan = new Ermeydani();
            Console.WriteLine("---------------------------------");
            meydan.haritaciz();
            
            int i = 0;
            while(i != 6)
            {
                meydan.takim1.Birlik[i].HaraketEt(meydan.Harita);
                meydan.haritaciz();
                i = i + 1;
            }


            Console.ReadLine();


            
        }
    }
}
