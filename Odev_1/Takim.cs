using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Takim
    {
        Asker[] birlik = new Asker[7];

        public Asker[] Birlik { get { return birlik; } set { birlik = value; } } 

        public List<Bolge> takimkonum = new List<Bolge>(); // why not use birlik ? this is stupid // well because i need to send some kind of bolge array to the map // but this is not an array this is a list ? // Shut up! don't use logic to me !

        public Takim(bool takimtype)//constructor istenilene gore haritanin karşı köşelerinde takım olustur konumlar hardcoded ama gelistirilebilir belki bool yerine bir int ile secim yapıp loop icine koyabilirdim uretimi 
        {
            

            if (takimtype)
            {
                

                //this is horrible
                Bolge er0bolge = new Bolge();
                er0bolge.X = 0;
                er0bolge.Y = 1;
                takimkonum.Add(er0bolge);
                birlik[0] =  new Er(er0bolge,"A"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er1bolge = new Bolge();
                er1bolge.X = 1;
                er1bolge.Y = 1;
                takimkonum.Add(er1bolge);
                birlik[1] = new Er(er1bolge, "A"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er2bolge = new Bolge();
                er2bolge.X = 2;
                er2bolge.Y = 1;
                takimkonum.Add(er2bolge);
                birlik[2] = new Er(er2bolge, "A"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er3bolge = new Bolge();
                er3bolge.X = 3;
                er3bolge.Y = 1;
                takimkonum.Add(er3bolge);
                birlik[3] = new Er(er3bolge, "A"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge teg0bolge = new Bolge();
                teg0bolge.X = 0;
                teg0bolge.Y = 0;
                takimkonum.Add(teg0bolge);
                birlik[4] = new Tegmen(teg0bolge, "A");

                Bolge teg1bolge = new Bolge();
                teg1bolge.X = 2;
                teg1bolge.Y = 0;
                takimkonum.Add(teg1bolge);
                birlik[5] = new Tegmen(teg1bolge, "A");

                Bolge yuzbolge = new Bolge();
                yuzbolge.X = 1;
                yuzbolge.Y = 0;
                takimkonum.Add(yuzbolge);
                birlik[6] = new Yuzbasi(yuzbolge, "B");
            }
            else
            {
                Bolge er0bolge = new Bolge();
                er0bolge.X = 12;
                er0bolge.Y = 14;
                takimkonum.Add(er0bolge);
                birlik[0] = new Er(er0bolge, "B"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er1bolge = new Bolge();
                er1bolge.X = 13;
                er1bolge.Y = 14;
                takimkonum.Add(er1bolge);
                birlik[1] = new Er(er1bolge, "B"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er2bolge = new Bolge();
                er2bolge.X = 14;
                er2bolge.Y = 14;
                takimkonum.Add(er2bolge);
                birlik[2] = new Er(er2bolge, "B"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er3bolge = new Bolge();
                er3bolge.X = 15;
                er3bolge.Y = 14;
                takimkonum.Add(er3bolge);
                birlik[3] = new Er(er3bolge, "B"); // daha iyi bir çözüm yolu olabilirdi 

                Bolge teg0bolge = new Bolge();
                teg0bolge.X = 13;
                teg0bolge.Y = 15;
                takimkonum.Add(teg0bolge);
                birlik[4] = new Tegmen(teg0bolge, "B");

                Bolge teg1bolge = new Bolge();
                teg1bolge.X = 15;
                teg1bolge.Y = 15;
                takimkonum.Add(teg1bolge);
                birlik[5] = new Tegmen(teg1bolge, "B");

                Bolge yuzbolge = new Bolge();
                yuzbolge.X = 14;
                yuzbolge.Y = 15;
                takimkonum.Add(yuzbolge);
                birlik[6] = new Yuzbasi(yuzbolge, "B");
            }
        }



        // ..... //
    }
}
