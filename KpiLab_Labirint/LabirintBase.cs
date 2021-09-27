using System;

namespace KpiLab_Labirint
{
    abstract class LabirintBase : IMazeDataProvider
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

        public int[,] GetData()
        {
            int[,] result = new int[Height * 2, Width * 2];
            for (int i = 0; i < labirintMap.GetLength(0); i++)
            {
                for (int j = 0; j < labirintMap.GetLength(1); j++)
                {
                    if (startPos.Item1 == i && startPos.Item2 == j)
                    {
                        result[i, j] = 2;
                    }
                    else if (endPos.Item1 == i && endPos.Item2 == j)
                    {
                        result[i, j] = 3;
                    }
                    else if (labirintMap[i, j])
                    {
                        result[i, j] = 1;
                    }
                    else
                    {
                        result[i, j] = 0;
                    }

                }
            }

            return result;
        }

        protected bool[,] labirintMap;
        protected static Random rnd = new Random();
        protected Tuple<int, int> startPos;
        protected Tuple<int, int> endPos;
    }
}
