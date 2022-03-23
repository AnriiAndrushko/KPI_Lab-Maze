using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;

namespace KpiLab_Labirint
{
    class MazeSimulator
    {
        protected LabirintBase Labirint;// = new LabirintType1(10, 10, rnd.Next());
        protected BotBase Bot;// = new Bot1();
        protected BotStatisticsHandler Stats;// = new BotStatisticsHandler(bot1);
        protected VisualBase Visual;// = new ConsoleDebugger(lab1, bot1, stats);
        protected BotFeeder Feeder;// = new BotFeeder(lab1, bot1);
        public void StartSimulation()
        {
            Feeder.StartSearching();
        }
    }
    class MazeSimBuilder
    {
        public LabirintStep newBuilder()
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

            BuildStep visualizeWith(VisualBase visual);
        }

        public interface BuildStep
        {
            MazeSimulator build();
        }

        private class Steps : MazeSimulator, LabirintStep, BotStep, VisualStep, BuildStep
        {
            //LabirintBase Labirint;// = new LabirintType1(10, 10, rnd.Next());
            //BotBase Bot;// = new Bot1();
            //BotStatisticsHandler Stats;// = new BotStatisticsHandler(bot1);
            //VisualBase Visual;// = new ConsoleDebugger(lab1, bot1, stats);
            //BotFeeder Feeder;// = new BotFeeder(lab1, bot1);

            public BotStep withLabirint(LabirintBase labirintType)
            {
                Labirint = labirintType;
                return this;
            }

            public VisualStep withBot(BotBase botType)
            {
                Bot = botType;
                Stats = new BotStatisticsHandler(Bot);
                return this;
            }

            public BuildStep withoutGraphic()
            {
                return this;
            }

            public BuildStep visualizeWith(VisualBase visual)
            {
                visual.Init(Labirint, Bot, Stats);
                Visual = visual;
                Feeder = new BotFeeder(Labirint, Bot);
                return this;
            }
            public MazeSimulator build()
            {
                return this;
            }

        }
    }
}
