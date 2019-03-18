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

        public List<Bolge> takimkonum = new List<Bolge>();

        public Takim(bool takimtype)//constructor
        {
            

            if (takimtype)
            {
                

                //this is horrible
                Bolge er0bolge = new Bolge();
                er0bolge.X = 0;
                er0bolge.Y = 1;
                takimkonum.Add(er0bolge);
                new Er(er0bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er1bolge = new Bolge();
                er1bolge.X = 1;
                er1bolge.Y = 1;
                takimkonum.Add(er1bolge);
                new Er(er1bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er2bolge = new Bolge();
                er2bolge.X = 2;
                er2bolge.Y = 1;
                takimkonum.Add(er2bolge);
                new Er(er2bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er3bolge = new Bolge();
                er3bolge.X = 3;
                er3bolge.Y = 1;
                takimkonum.Add(er3bolge);
                new Er(er3bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge teg0bolge = new Bolge();
                teg0bolge.X = 0;
                teg0bolge.Y = 0;
                takimkonum.Add(teg0bolge);
                new Tegmen(teg0bolge);

                Bolge teg1bolge = new Bolge();
                teg1bolge.X = 2;
                teg1bolge.Y = 0;
                takimkonum.Add(teg1bolge);
                new Tegmen(teg1bolge);

                Bolge yuzbolge = new Bolge();
                yuzbolge.X = 1;
                yuzbolge.Y = 0;
                takimkonum.Add(yuzbolge);
                new Yuzbasi(yuzbolge);
            }
            else
            {
                Bolge er0bolge = new Bolge();
                er0bolge.X = 11;
                er0bolge.Y = 13;
                takimkonum.Add(er0bolge);
                new Er(er0bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er1bolge = new Bolge();
                er1bolge.X = 12;
                er1bolge.Y = 13;
                takimkonum.Add(er1bolge);
                new Er(er1bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er2bolge = new Bolge();
                er2bolge.X = 13;
                er2bolge.Y = 13;
                takimkonum.Add(er2bolge);
                new Er(er2bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge er3bolge = new Bolge();
                er3bolge.X = 14;
                er3bolge.Y = 13;
                takimkonum.Add(er3bolge);
                new Er(er3bolge); // daha iyi bir çözüm yolu olabilirdi 

                Bolge teg0bolge = new Bolge();
                teg0bolge.X = 11;
                teg0bolge.Y = 14;
                takimkonum.Add(teg0bolge);
                new Tegmen(teg0bolge);

                Bolge teg1bolge = new Bolge();
                teg1bolge.X = 13;
                teg1bolge.Y = 14;
                takimkonum.Add(teg1bolge);
                new Tegmen(teg1bolge);

                Bolge yuzbolge = new Bolge();
                yuzbolge.X = 12;
                yuzbolge.Y = 14;
                takimkonum.Add(yuzbolge);
                new Yuzbasi(yuzbolge);
            }
        }



        // ..... //
    }
}
