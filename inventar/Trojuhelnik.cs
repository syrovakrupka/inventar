using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace inventar
{
    class Trojuhelnik
    {
        public Rectangle rectic;
        public bool IsMovable;
        

        public Trojuhelnik(Rectangle rectic, bool movable)
        {
            this.rectic = rectic;
            this.IsMovable = movable;

        }



    }
}
