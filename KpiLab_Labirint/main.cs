using System;
using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;

namespace KpiLab_Labirint
{
    class MainClass
    {
        static void Main()
        {
            ConsoleDebugger test1 = new ConsoleDebugger(new LabirintType1(10, 15));
            test1.PrintMaze();
            ConsoleDebugger test2 = new ConsoleDebugger(new LabirintType2(10, 15));
            test2.PrintMaze();

            Console.ReadKey();
            Console.Clear();
            Main();

            BotBase bot1 = new Bot1();
        }
    }
}
