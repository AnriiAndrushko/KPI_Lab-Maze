using System;

namespace KpiLab_Labirint
{
    class ConsoleDebugger
    {
        readonly MazeData MyMaze;
        public ConsoleDebugger(IMazeDataProvider inputData)
        {
            MyMaze = inputData.GetData();
        }
        public void PrintMaze()
        {
            for (int i = 0; i < MyMaze.LabData.GetLength(0); i++)
            {
                for (int j = 0; j < MyMaze.LabData.GetLength(1); j++)
                {
                    if(MyMaze.Start.Item1 == i&& MyMaze.Start.Item2 == j)
                    {
                        Console.Write("S");
                        continue;
                    }
                    if (MyMaze.End.Item1 == i && MyMaze.End.Item2 == j)
                    {
                        Console.Write("F");
                        continue;
                    }
                    if (MyMaze.LabData[i, j])
                    {
                        Console.Write(" ");
                    }else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
