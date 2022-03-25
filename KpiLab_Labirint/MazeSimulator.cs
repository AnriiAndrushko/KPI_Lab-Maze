using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;
using KpiLab_Labirint.visual;
using KpiLab_Labirint.statistic;
namespace KpiLab_Labirint
{
    public class MazeSimulator
    {
        protected private LabirintBase Labirint;// = new LabirintType1(10, 10, rnd.Next());
        protected private BotBase Bot;// = new Bot1();
        protected private BotStatisticsHandler BotStats;
        protected private MazeStatisticsHandler MazeStats;// = new BotStatisticsHandler(bot1);
        protected private VisualBase Visual;// = new ConsoleDebugger(lab1, bot1, stats);
        protected private BotFeeder Feeder;// = new BotFeeder(lab1, bot1);
        public void StartSimulation()
        {
            if (Labirint == null) {
                throw new System.Exception("USE CONSTRUCTOR!!!");
            }
            if (!Labirint.IsMazeGenerated)
            {
                Labirint.BeginMazeGeneration();
            }
            Feeder.StartSearching();
        }
        public void PrintMazeInfo()
        {
            if (Visual == null)
            {
                throw new System.Exception("You dont specify visual");
            }
            if (!Labirint.IsMazeGenerated)
            {
                Labirint.BeginMazeGeneration();
            }
            Visual.PrintMaze();
        }
    }
    public class MazeSimBuilder
    {
        public LabirintStep newSimulation()
        {
            return new Steps();
        }
        public MazeSimBuilder(){}
        public interface LabirintStep
        {
            BotStep withLabirint(LabirintBase labirintType);
        }
        public interface BotStep
        {
            VisualStep withBot(BotBase botType);
        }
        public interface VisualStep
        {
            BuildStep withoutGraphic();

            BuildStep visualizeWith(VisualBase visual, bool logGeneration = true);
        }

        public interface BuildStep
        {
            BuildStep visualizeWith(VisualBase visual, bool logGeneration = true);
            MazeSimulator build();
        }

        private class Steps : MazeSimulator, LabirintStep, BotStep, VisualStep, BuildStep
        {

            public BotStep withLabirint(LabirintBase labirintType)
            {
                Labirint = labirintType;
                MazeStats = new MazeStatisticsHandler(Labirint);
                return this;
            }

            public VisualStep withBot(BotBase botType)
            {
                Bot = botType;
                BotStats = new BotStatisticsHandler(Bot);
                return this;
            }

            public BuildStep withoutGraphic()
            {
                return this;
            }

            public BuildStep visualizeWith(VisualBase visual, bool logGeneration = true)
            {
                visual.Init(Labirint, Bot, BotStats, MazeStats, logGeneration);
                Visual = visual;
                return this;
            }
            public MazeSimulator build()
            {
                Feeder = new BotFeeder(Labirint, Bot, MazeStats);
                return this;
            }

        }
    }
}
