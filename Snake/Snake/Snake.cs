using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        

        public Snake(Point tail, int lenght, Direction direction)
        {
            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)//Создаем точки, точная копия хвостовой точки
            {
                Point p = new Point( tail );
                p.Move(i, direction); //Эту точку сдвигаем по направлению директории
                pList.Add( p ); // И добавляем эту точку в список
            }
        }
    }
}
