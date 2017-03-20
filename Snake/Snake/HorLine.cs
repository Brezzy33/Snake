using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorLine
    {
        List<Point> pList;

        public HorLine( int xLeft, int xRight, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = xLeft; y <= xRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
