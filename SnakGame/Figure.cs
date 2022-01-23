using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakGame
{

    class Figure
    {

        protected List<Point> pList;


        public void Drow()
    {
        foreach (Point p in pList)
        {
            p.draw();
        }
    }
        internal bool IsHit(Figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        internal bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}  
