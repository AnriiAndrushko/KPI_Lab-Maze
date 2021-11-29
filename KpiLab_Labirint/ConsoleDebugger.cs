using System;

namespace KpiLab_Labirint
{
    class ConsoleDebugger
    {
        readonly MazeData MyMaze;
        readonly IBot MyBot;
        private int BotX, BotY;
        public ConsoleDebugger(IMazeDataProvider inputData, IBot bot)
         {
            MyMaze = inputData.GetData();
            MyBot = bot;
            BotX = MyMaze.Start.Item2;
            BotY = MyMaze.Start.Item1;
            MyBot.Step += PrintStepOnMaze;
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
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        private void PrintStepOnMaze(int len, int dir)
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
                        Console.Write("B");
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
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}
