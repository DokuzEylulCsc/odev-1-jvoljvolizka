using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        // ..... //

        public Tegmen(Bolge koor, String takim)
        {
            this.alive = true;
            this.Koordinat = koor;
            this.health = 100;
            this.typeid = "T";
            this.takimid = takim;
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

            if ( (Koordinat.Y + 1 != 15 && harita[Koordinat.X, Koordinat.Y + 1] == null) | (Koordinat.X - 1 != 0 && harita[Koordinat.X, Koordinat.Y - 1] == null) |(Koordinat.X + 1 != 15 && harita[Koordinat.X + 1, Koordinat.Y] == null) | (Koordinat.Y - 1 != 0 && harita[Koordinat.X - 1, Koordinat.Y] == null))
            {

                if (harita[Koordinat.X, Koordinat.Y + 1] == null)
                {
                    harita[Koordinat.X, Koordinat.Y] = null;
                    Koordinat.Y = Koordinat.Y + 1;
                    harita[Koordinat.X, Koordinat.Y] = Koordinat;
                    harita[Koordinat.X, Koordinat.Y].asker = this;
                    return harita;
                }
                else if (harita[Koordinat.X, Koordinat.Y - 1] == null)
                {
                    harita[Koordinat.X, Koordinat.Y] = null;
                    Koordinat.Y = Koordinat.Y - 1;
                    harita[Koordinat.X, Koordinat.Y] = Koordinat;
                    harita[Koordinat.X, Koordinat.Y].asker = this;
                    return harita;
                }
                else if (harita[Koordinat.X + 1, Koordinat.Y] == null)
                {
                    harita[Koordinat.X, Koordinat.Y] = null;
                    Koordinat.X = Koordinat.X + 1;
                    harita[Koordinat.X, Koordinat.Y] = Koordinat;
                    harita[Koordinat.X, Koordinat.Y].asker = this;
                    return harita;
                }
                else if (harita[Koordinat.X - 1, Koordinat.Y] == null)
                {
                    harita[Koordinat.X, Koordinat.Y] = null;
                    Koordinat.X = Koordinat.X - 1;
                    harita[Koordinat.X, Koordinat.Y] = Koordinat;
                    harita[Koordinat.X, Koordinat.Y].asker = this;
                    return harita;
                }
            }


            return harita;


        }

            
        }
    }

