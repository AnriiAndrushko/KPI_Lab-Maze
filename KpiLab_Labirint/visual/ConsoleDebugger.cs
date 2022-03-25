using System;
using KpiLab_Labirint.statistic;

namespace KpiLab_Labirint.visual
{
    public class ConsoleDebugger : VisualBase
    {
        internal override void Init(IMazeDataProvider inputData, IBot bot, BotStatisticsHandler botStats, MazeStatisticsHandler mazeStats, bool generatorLog = true)
        {
            base.Init(inputData, bot, botStats, mazeStats, generatorLog);
        }
        public ConsoleDebugger() { }
        internal override void PrintMaze()
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
            Console.Write("\nThe number of iterations - " + MazeStats.GenerationSteps);
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
            Console.Write("\nThe number of iterations - " + BotStats.BotIterations + "\nThe number of steps - " + BotStats.BotSteps + "\n");
            Console.ReadKey();
            Console.WriteLine();
        }

        internal override void PrintMazeGenerationStep(bool[,] lab)
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j])
                    {
                        Console.Write(" ");
                        continue;
                    }
                    Console.Write("0");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
