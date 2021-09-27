namespace KpiLab_Labirint
{
    class GraphData : IMazeDataProvider
    {
        readonly int[,] labData;
        readonly GraphPoint startPoint;
        GraphData(int[,] inputMaze)
        {
            //TODO from mass to graph
        }
        public int[,] GetData()
        {
            return labData;
        }
    }
}
