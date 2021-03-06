﻿using System;
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
            Console.SetBufferSize(120, 30); //Устанавливаем размер окна без скроллбара 

            //Создаем рамку
            HorLine upline = new HorLine(0, 118, 0, '+');
            HorLine downline = new HorLine(0, 118, 29, '+');
            downline.Draw();
            upline.Draw();
            
            Vert leftvline = new Vert(0, 29, 0, '+');
            Vert rightvline = new Vert(0, 29, 118, '+');
            rightvline.Draw();
            leftvline.Draw();

            //Точка
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 5, Direction.RIGHT); //Змейка длинной 5 сим
            snake.Draw();
            Console.ReadLine();
        }
    }
}
