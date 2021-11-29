using System;
using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;

namespace KpiLab_Labirint
{
    class MainClass
    {
        static void Main()
        {
            LabirintBase lab1 = new LabirintType1(5, 5);
            //ConsoleDebugger test2 = new ConsoleDebugger(new LabirintType2(10, 15));
            //test2.PrintMaze();


            BotBase bot1 = new Bot1();
            ConsoleDebugger test1 = new ConsoleDebugger(lab1, bot1);
            BotFeeder feeder = new BotFeeder(lab1, bot1);
           
            feeder.StartSearching();


            //int x, y;
            //string number = Console.ReadLine();
            //x = Convert.ToInt32(number);
            //number = Console.ReadLine();
            //y = Convert.ToInt32(number);
            //feeder.DebugWays(x, y);
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
