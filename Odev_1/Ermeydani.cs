using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Ermeydani
    {
        public Bolge[,] Harita { get; set; } = new Bolge[16, 16];
        public Takim takim1;
        public Takim takim2;

        public Ermeydani()
        {
            takim1 = new Takim(true);
            takim2 = new Takim(false);
            int z = 0;

            foreach (Bolge i in takim1.takimkonum) {
                Harita[i.X, i.Y] = i;
                Harita[i.X, i.Y].asker = takim1.Birlik[z];
                z = z + 1;
            }
            z = 0;
            foreach (Bolge i in takim2.takimkonum)
            {
                Harita[i.X, i.Y] = i;
                Harita[i.X, i.Y].asker = takim2.Birlik[z];
                z = z + 1;
            }

            foreach (Bolge t in Harita)
            {
                if (t != null && t.asker != null)
                {
                    t.asker.Bekle();
                }
            }

           // Console.WriteLine(takim1.Birlik[0].Koordinat.X);
           // Console.WriteLine(takim2.Birlik[0].Koordinat.X);

        }

        public void haritaciz()
        {

            int rowLength = Harita.GetLength(0);
            int colLength = Harita.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (Harita[j,i] != null && Harita[j,i].asker != null)
                    {

                        Console.Write("{0} ", Harita[j, i].asker.typeid);
                    }

                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        // ..... //
    }
}
