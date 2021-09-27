using System;

namespace KpiLab_Labirint
{
    class ConsoleDebugger
    {
        readonly int[,] MyMaze;
        public ConsoleDebugger(IMazeDataProvider inputData)
        {
            MyMaze = inputData.GetData();
        }
        public void PrintMaze()
        {
            for (int i = 0; i < MyMaze.GetLength(0); i++)
            {
                for (int j = 0; j < MyMaze.GetLength(1); j++)
                {
                    if (MyMaze[i, j] == 0)
                    {
                        Console.Write("#");
                    }else if(MyMaze[i, j] == 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(MyMaze[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
