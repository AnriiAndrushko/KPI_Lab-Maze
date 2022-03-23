using System;
using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;

namespace KpiLab_Labirint
{
    class MainClass
    {
        static void Main()
        {
            MazeSimulator Sim = new MazeSimBuilder().newBuilder().withLabirint(new LabirintType1(10, 10)).withBot(new Bot1()).visualizeWith(new ConsoleDebugger()).build();
            Sim.StartSimulation();
            //Random rnd = new Random();
            //LabirintBase lab1 = new LabirintType1(10, 10, rnd.Next());


            //BotBase bot1 = new Bot1();
            //BotStatisticsHandler stats = new BotStatisticsHandler(bot1);
            //ConsoleDebugger test1 = new ConsoleDebugger(lab1, bot1, stats);
            //BotFeeder feeder = new BotFeeder(lab1, bot1);

            //feeder.StartSearching();


            ////int x, y;
            ////string number = Console.ReadLine();
            ////x = Convert.ToInt32(number);
            ////number = Console.ReadLine();
            ////y = Convert.ToInt32(number);
            ////feeder.DebugWays(x, y);
            //Console.ReadKey();
            //Console.Clear();
            //Main();
        }
    }
}
