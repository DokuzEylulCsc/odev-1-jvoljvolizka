using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker
    {

        // ..... //

        public Er(Bolge koor)
        {
            this.alive = true;
            this.Koordinat = koor;
            this.health = 100;
            this.typeid = "E";
        }
        
                
        public override void Ates_et(Bolge[,] harita)
        {
            Console.WriteLine("totallynotaplaceholder");
            
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
                else 
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
            Console.WriteLine(this.Koordinat.X);
            return harita;
            
           
        }
    }
}
