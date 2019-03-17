using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Bolge
    {
        //asker konum meretleri haraket edildiğinde konum değişebilir
        private int x_coor;
        private int y_coor;

        public int X
        {
            set
            {
                x_coor = value;
            }

            get
            {
                return x_coor;
            }
        }

        public int Y
        {
            set
            {
                y_coor = value;
            }

            get
            {
                return y_coor;
            }
        }


        // ..... //

    }
}
