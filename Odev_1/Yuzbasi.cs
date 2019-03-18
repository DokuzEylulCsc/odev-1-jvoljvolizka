using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Yuzbasi : Asker
    {
        // ..... //

        public Yuzbasi(Bolge koor)
        {
            this.alive = true;
            this.Koordinat = koor;
            this.health = 100;
            this.typeid = "Y";
        }

        public override void Ates_et(Bolge[,] harita)
        {
            Console.WriteLine("totallynotaplaceholder");
        }

        public override void Bekle()
        {
            Console.WriteLine("yuz beklemede");
        }

        public override Bolge[,] HaraketEt(Bolge[,] harita)
        {
            Console.WriteLine("totallynotaplaceholder");
            return harita;
        }
    }
}
