using System;

namespace KpiLab_Labirint.maze
{
    abstract class LabirintBase : IMazeDataProvider
    {
        protected readonly int Height;
        protected readonly int Width;

        protected LabirintBase(int height, int width, int seed)
        {
            rnd = new Random(seed);
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

        public MazeData GetData()
        {
            return new MazeData(labirintMap, startPos, endPos);
        }

        protected bool[,] labirintMap;
        protected Random rnd;
        protected Tuple<int, int> startPos;
        protected Tuple<int, int> endPos;
    }
}
