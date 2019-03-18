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
        }

        public override void Ates_et()
        {
            Console.WriteLine("totallynotaplaceholder");
        }

        public override void Bekle()
        {
            Console.WriteLine("yuz beklemede");
        }

        public override void HaraketEt()
        {
            Console.WriteLine("totallynotaplaceholder");
        }
    }
}
