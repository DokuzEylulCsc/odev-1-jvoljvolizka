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
        public int health;
        public String typeid;
        public String takimid;

        // ..... //

        //Abstract sınıfların implementasyonları çocuk sınıflarda gerçekleştirilmelidir.
        public abstract Bolge[,] HaraketEt(Bolge[,] harita);

        public abstract void Bekle();

        public abstract void Ates_et(Bolge[,] harita);

        // ..... //

    }
}
