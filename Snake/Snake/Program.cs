using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            

            HorLine upline = new HorLine(0, 78, 0, '+');
            HorLine downline = new HorLine(0, 78, 24, '+');
            downline.Draw();
            upline.Draw();

            Vert leftvline = new Vert(0, 24, 0, '+');
            Vert rightvline = new Vert(0, 24, 78, '+');
            rightvline.Draw();
            leftvline.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadLine();
            
        }
    }
}
