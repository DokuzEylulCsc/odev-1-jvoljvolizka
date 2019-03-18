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

            Ermeydani meydan = new Ermeydani();
            Console.WriteLine("---------------------------------");
            meydan.haritaciz();
            

            while(true)
            {
                meydan.takim1.Birlik[3].HaraketEt(meydan.Harita);
                Console.WriteLine(" " + meydan.takim1.Birlik[3].Koordinat.X + " " + meydan.takim1.Birlik[3].Koordinat.Y);
            }
            
        }
    }
}
