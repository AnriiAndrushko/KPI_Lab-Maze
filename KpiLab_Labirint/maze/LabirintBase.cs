using System;

namespace KpiLab_Labirint.maze
{
    abstract public class LabirintBase : IMazeDataProvider
    {
        protected internal readonly int Height;
        protected internal readonly int Width;
        protected private int steps;
        internal event Action<bool[,]> BuildStep;
        internal event Action<int> MazeGenerated;
        protected bool isMazeGenerated;
        internal bool IsMazeGenerated {get { return isMazeGenerated; } }
        internal void InvokeBuildStep(bool[,] map)
        {
            BuildStep?.Invoke(map);
        }
        internal void InvokeMazeGenerated(int stepsCount)
        {
            MazeGenerated?.Invoke(stepsCount);
            isMazeGenerated = true;
        }
        abstract internal void BeginMazeGeneration();
        internal int Steps { get { return steps; }}
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

        MazeData IMazeDataProvider.GetData()
        {
            return new MazeData(labirintMap, startPos, endPos);
        }

        protected internal bool[,] labirintMap;
        protected internal Random rnd;
        protected internal Tuple<int, int> startPos;
        protected internal Tuple<int, int> endPos;
    }
}
