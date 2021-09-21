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
    }
}
