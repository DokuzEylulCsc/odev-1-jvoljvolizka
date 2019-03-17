using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } set { koordinat = value; } }
        public bool alive = true;
        public UInt32 health = 100;

        // ..... //

        //Abstract sınıfların implementasyonları çoçuk sınıflarda gerçekleştirilmelidir.
        public abstract void HaraketEt();

        public abstract void Bekle();

        public abstract void Ates_et();

        // ..... //

    }
}
