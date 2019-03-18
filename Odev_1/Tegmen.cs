using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        // ..... //

        public Tegmen(Bolge koor)
        {
            this.alive = true;
            this.Koordinat = koor;
            this.health = 100;
            this.typeid = "T";
        }

        public override void Ates_et(Bolge[,] harita)
        {
            Console.WriteLine("totallynotaplaceholder");
            //throw new NotImplementedException();
        }

        public override void Bekle()
        {
            Console.WriteLine("teg beklemede");
            // throw new NotImplementedException();
        }

        public override Bolge[,] HaraketEt(Bolge[,] harita)
        {
            Console.WriteLine("totallynotaplaceholder");
            return harita;
            // throw new NotImplementedException();
        }
    }
}
