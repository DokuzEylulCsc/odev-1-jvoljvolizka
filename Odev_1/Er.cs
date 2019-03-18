using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker
    {

        // ..... //

        public Er(Bolge koor, String takim)
        {
            this.alive = true;
            this.Koordinat = koor;
            this.health = 100;
            this.typeid = "E";
            this.takimid = takim;
        }
        
                
        public override void Ates_et(Bolge[,] harita)
        {
            if (Koordinat.X + 1 != 15 && harita[Koordinat.X + 1, Koordinat.Y] != null && harita[Koordinat.X + 1, Koordinat.Y].asker.takimid != this.takimid)
            {
                int sal;
                Random rnd = new Random();
                int num = rnd.Next(3);
                if (num == 0)
                {
                    sal = 5;
                }
                else if (num == 1)
                {
                    sal = 10;
                }
                else
                {
                    sal = 15;
 
                }
                int newcan = harita[Koordinat.X + 1, Koordinat.Y].asker.health - sal;
                if (newcan < 0)
                {
                    Console.WriteLine(harita[Koordinat.X + 1, Koordinat.Y].asker.takimid + " takimindan " + harita[Koordinat.X + 1, Koordinat.Y].asker.typeid + " oldu" );
                    harita[Koordinat.X + 1, Koordinat.Y] = null;


                }
                else
                {
                    harita[Koordinat.X + 1, Koordinat.Y].asker.health = newcan;
                }
            }
            //Console.WriteLine("totallynotaplaceholder");
            
        }

        public override void Bekle()
        {
            Console.WriteLine("er beklemede");
            
        }

        public override Bolge[,] HaraketEt(Bolge[,] harita)
        {
            if (Koordinat.Y == 15 | Koordinat.Y == 0)
            {
                if(Koordinat.Y == 15)
                {
                    if ((Koordinat.X != 0 && harita[Koordinat.X - 1 , Koordinat.Y] == null) )
                    {
                        harita[Koordinat.X, Koordinat.Y] = null;
                        Koordinat.X = Koordinat.X - 1;
                        harita[Koordinat.X, Koordinat.Y] = Koordinat;
                        harita[Koordinat.X, Koordinat.Y].asker = this;
                        return harita;
                    }
                    else if (harita[Koordinat.X , Koordinat.Y - 1 ] == null)
                    {
                        harita[Koordinat.X, Koordinat.Y] = null;
                        Koordinat.Y = Koordinat.Y - 1 ;
                        harita[Koordinat.X, Koordinat.Y] = Koordinat;
                        harita[Koordinat.X, Koordinat.Y].asker = this;
                        return harita;
                    }
                }
                else if(Koordinat.Y == 0)
                {
                    if ((Koordinat.X != 15 && harita[Koordinat.X + 1, Koordinat.Y] == null) )
                    {
                        harita[Koordinat.X, Koordinat.Y] = null;
                        Koordinat.X = Koordinat.X + 1;
                        harita[Koordinat.X, Koordinat.Y] = Koordinat;
                        harita[Koordinat.X, Koordinat.Y].asker = this;
                        return harita;
                    }
                    else if (harita[Koordinat.X, Koordinat.Y + 1] == null)
                    {
                        harita[Koordinat.X, Koordinat.Y] = null;
                        Koordinat.Y = Koordinat.Y + 1;
                        harita[Koordinat.X, Koordinat.Y] = Koordinat;
                        harita[Koordinat.X, Koordinat.Y].asker = this;
                        return harita;
                    }
                }
            }
            else if (harita[Koordinat.X ,Koordinat.Y + 1] == null && harita[Koordinat.X, Koordinat.Y - 1] == null)
            {
                Random rnd = new Random();
                if(rnd.Next(2) == 1)
                {
                    harita[Koordinat.X, Koordinat.Y] = null;
                    Koordinat.Y = Koordinat.Y + 1;
                    harita[Koordinat.X, Koordinat.Y] = Koordinat;
                    harita[Koordinat.X, Koordinat.Y].asker = this;
                    return harita;
                }
                else
                {
                    harita[Koordinat.X, Koordinat.Y] = null;
                    Koordinat.Y = Koordinat.Y - 1;
                    harita[Koordinat.X, Koordinat.Y] = Koordinat;
                    harita[Koordinat.X, Koordinat.Y].asker = this;
                    return harita;
                }
            }

            else if (harita[Koordinat.X, Koordinat.Y + 1] == null)
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
            return harita;
            
           
        }
    }
}
