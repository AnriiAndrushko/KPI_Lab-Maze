using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiLab_Labirint
{
    class LabirintBase
    {
        protected readonly int Height;
        protected readonly int Width;

        protected LabirintBase(int height, int width)
        {
            if (height < 5)
            {
                Height = 5;
            }
            else
            {
                Height = height;
            }
            if (width < 5)
            {
                Width = 5;
            }
            else
            {
                Width = width;
            }
        }
        protected bool[,] labirintMap;
        protected static Random rnd = new Random();
        protected Tuple<int, int> startPos;
        protected Tuple<int, int> endPos;


        public void PrintLabirint()
        {
            if (labirintMap == null) { return; }
            for (int i = 0; i < Height * 2; i++)
            {
                for (int j = 0; j < Width * 2; j++)
                {
                    if (startPos.Item1 == i && startPos.Item2 == j)
                    {
                        Console.Write("1");
                        continue;
                    }
                    if (endPos.Item1 == i && endPos.Item2 == j)
                    {
                        Console.Write("2");
                        continue;
                    }
                    if (labirintMap[i, j])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
