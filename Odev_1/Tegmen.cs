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
        }

        public override void Ates_et()
        {
            Console.WriteLine("totallynotaplaceholder");
            //throw new NotImplementedException();
        }

        public override void Bekle()
        {
            Console.WriteLine("totallynotaplaceholder");
            // throw new NotImplementedException();
        }

        public override void HaraketEt()
        {
            Console.WriteLine("totallynotaplaceholder");
            // throw new NotImplementedException();
        }
    }
}
