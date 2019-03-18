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
        public bool alive;
        public UInt32 health;
        public String typeid;

        // ..... //

        //Abstract sınıfların implementasyonları çocuk sınıflarda gerçekleştirilmelidir.
        public abstract Bolge[,] HaraketEt(Bolge[,] harita);

        public abstract void Bekle();

        public abstract void Ates_et(Bolge[,] harita);

        // ..... //

    }
}
