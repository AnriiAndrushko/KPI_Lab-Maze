using System;

namespace KpiLab_Labirint
{
    class ConsoleDebugger : VisualBase
    {
        public override void Init(IMazeDataProvider inputData, IBot bot, BotStatisticsHandler stats)
        {
            base.Init(inputData, bot, stats);
        }
        public ConsoleDebugger() { }
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
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        protected override void PrintStepOnMaze(int len, int dir)
        {
                 if (dir == 0) { BotY -= len; }
            else if (dir == 1) { BotX += len; }
            else if (dir == 2) { BotY += len; }
            else if (dir == 3) { BotX -= len; }


            for (int i = 0; i < MyMaze.LabData.GetLength(0); i++)
            {
                for (int j = 0; j < MyMaze.LabData.GetLength(1); j++)
                {
                    if(BotX == j&& BotY == i)
                    {
                        Console.Write((char)11);
                        continue;
                    }
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
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("\nThe number of iterations - " + stats.BotIterations + "\nThe number of steps - " + stats.BotSteps + "\n");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
