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
            if (Koordinat.X + 1 != 15 && harita[Koordinat.X + 2, Koordinat.Y] != null && harita[Koordinat.X + 2, Koordinat.Y].asker.takimid != this.takimid)
            {
                int sal;
                Random rnd = new Random();
                int num = rnd.Next(3);
                if (num == 0)
                {
                    sal = 10;
                }
                else if (num == 1)
                {
                    sal = 20;
                }
                else
                {
                    sal = 25;

                }
                int newcan = harita[Koordinat.X + 2, Koordinat.Y].asker.health - sal;
                if (newcan < 0)
                {
                    Console.WriteLine(harita[Koordinat.X + 2, Koordinat.Y].asker.takimid + " takimindan " + harita[Koordinat.X + 2, Koordinat.Y].asker.typeid + " oldu");
                    harita[Koordinat.X + 2, Koordinat.Y] = null;


                }
                else
                {
                    harita[Koordinat.X + 2, Koordinat.Y].asker.health = newcan;
                }
            }

            else if (Koordinat.Y + 2 != 15 && harita[Koordinat.X, Koordinat.Y + 2] != null && harita[Koordinat.X, Koordinat.Y + 2].asker.takimid != this.takimid)
            {
                int sal;
                Random rnd = new Random();
                int num = rnd.Next(3);
                if (num == 0)
                {
                    sal = 10;
                }
                else if (num == 1)
                {
                    sal = 20;
                }
                else
                {
                    sal = 25;

                }
                int newcan = harita[Koordinat.X, Koordinat.Y + 2].asker.health - sal;
                if (newcan < 0)
                {
                    Console.WriteLine(harita[Koordinat.X, Koordinat.Y + 2].asker.takimid + " takimindan " + harita[Koordinat.X, Koordinat.Y + 2].asker.typeid + " oldu");
                    harita[Koordinat.X, Koordinat.Y + 2] = null;

                }
                else
                {
                    harita[Koordinat.X, Koordinat.Y + 2].asker.health = newcan;
                }
            }
            else if (Koordinat.X - 2 != 0 && harita[Koordinat.X - 2, Koordinat.Y] != null && harita[Koordinat.X - 2, Koordinat.Y].asker.takimid != this.takimid)
            {
                int sal;
                Random rnd = new Random();
                int num = rnd.Next(3);
                if (num == 0)
                {
                    sal = 10;
                }
                else if (num == 1)
                {
                    sal = 20;
                }
                else
                {
                    sal = 25;

                }
                int newcan = harita[Koordinat.X - 2, Koordinat.Y].asker.health - sal;
                if (newcan < 0)
                {
                    Console.WriteLine(harita[Koordinat.X - 2, Koordinat.Y].asker.takimid + " takimindan " + harita[Koordinat.X - 2, Koordinat.Y].asker.typeid + " oldu");
                    harita[Koordinat.X - 2, Koordinat.Y] = null;


                }
                else
                {
                    harita[Koordinat.X - 2, Koordinat.Y].asker.health = newcan;
                }
            }

            else if (Koordinat.Y - 2 != 15 && harita[Koordinat.X, Koordinat.Y - 2] != null && harita[Koordinat.X, Koordinat.Y - 2].asker.takimid != this.takimid)
            {
                int sal;
                Random rnd = new Random();
                int num = rnd.Next(3);
                if (num == 0)
                {
                    sal = 10;
                }
                else if (num == 1)
                {
                    sal = 20;
                }
                else
                {
                    sal = 25;

                }
                int newcan = harita[Koordinat.X, Koordinat.Y - 2].asker.health - sal;
                if (newcan < 0)
                {
                    Console.WriteLine(harita[Koordinat.X, Koordinat.Y - 2].asker.takimid + " takimindan " + harita[Koordinat.X, Koordinat.Y - 2].asker.typeid + " oldu");
                    harita[Koordinat.X, Koordinat.Y - 2] = null;

                }
                else
                {
                    harita[Koordinat.X, Koordinat.Y - 2].asker.health = newcan;
                }
            }
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

