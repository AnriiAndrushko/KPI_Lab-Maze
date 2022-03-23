using System;

namespace KpiLab_Labirint.maze
{
    abstract class LabirintBase : IMazeDataProvider
    {
        protected readonly int Height;
        protected readonly int Width;
        protected int steps;
        public event Action<bool[,]> BuildStep;
        public event Action<int> MazeGenerated;
        protected bool isMazeGenerated;
        public bool IsMazeGenerated {get { return isMazeGenerated; } }
        public void InvokeBuildStep(bool[,] map)
        {
            BuildStep?.Invoke(map);
        }
        public void InvokeMazeGenerated(int stepsCount)
        {
            MazeGenerated?.Invoke(stepsCount);
            isMazeGenerated = true;
        }
        abstract public void BeginMazeGeneration();
        public int Steps { get { return steps; }}
        protected LabirintBase(int height, int width, int seed)
        {
            isMazeGenerated = false;
            steps = 0;
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
