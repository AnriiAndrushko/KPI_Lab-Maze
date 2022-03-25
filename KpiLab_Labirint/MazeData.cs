using System;

namespace KpiLab_Labirint
{
    internal class MazeData
    {
        public bool[,] LabData { get; }
        public Tuple<int, int> Start { get; }
        public Tuple<int, int> End { get; }
        public MazeData(bool[,] inputMaze, Tuple<int, int> start, Tuple<int, int> end)
        {
            LabData = inputMaze;
            this.Start = start;
            this.End = end;
        }

    }
}