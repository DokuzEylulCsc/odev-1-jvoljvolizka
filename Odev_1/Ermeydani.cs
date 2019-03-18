using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Ermeydani
    {
        public Bolge[,] Harita { get; set; } = new Bolge[16, 16];

        public Ermeydani()
        {
            Takim takim1 = new Takim(true);
            Takim takim2 = new Takim(false);

            Console.WriteLine(takim1.takimkonum[0].X);
            Console.WriteLine(takim2.takimkonum[0].X);

        }

        // ..... //
    }
}
