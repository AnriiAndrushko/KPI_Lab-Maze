using System;
using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;
using KpiLab_Labirint.visual;

namespace KpiLab_Labirint
{
    class MainClass
    {
        static void Main()
        {
            Random rnd = new Random();
            MazeSimulator Sim = new MazeSimBuilder().newSimulation().
                                                     withLabirint(new LabirintType1(10, 10, rnd.Next())).
                                                     withBot(new Bot1()).
                                                     visualizeWith(new ConsoleDebugger()).
                                                     build();
            Sim.PrintMazeInfo();
            //Sim.StartSimulation();
            Console.WriteLine("Done");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
