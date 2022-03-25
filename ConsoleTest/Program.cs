using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;
using KpiLab_Labirint.visual;
using KpiLab_Labirint;

Random rnd = new Random();
MazeSimulator Sim = new MazeSimBuilder().newSimulation().
                                         withLabirint(new LabirintType2(10, 10, rnd.Next())).
                                         withBot(new Bot1()).
                                         visualizeWith(new ConsoleDebugger(), true).
                                         build();
Sim.PrintMazeInfo();
Sim.StartSimulation();
Console.WriteLine("Done");
Console.ReadKey();