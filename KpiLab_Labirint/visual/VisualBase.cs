using KpiLab_Labirint.statistic;
namespace KpiLab_Labirint.visual
{
    abstract class VisualBase
    {
        protected MazeData MyMaze;
        protected IBot MyBot;
        protected int BotX, BotY;
        protected BotStatisticsHandler BotStats;
        protected MazeStatisticsHandler MazeStats;
        protected IMazeDataProvider MyMazeData;
        public VisualBase() { }
        public virtual void Init(IMazeDataProvider inputData, IBot bot, BotStatisticsHandler botStats, MazeStatisticsHandler mazeStats, bool generatorLog = true)
        {
            MyMazeData = inputData;
            MyBot = bot;

            MyBot.Step += PrintStepOnMaze;
            BotStats = botStats;
            MazeStats = mazeStats;
            SetGeneratorLog(generatorLog);
            MazeStats.GenerationFinished += InitSecondaryData;
        }
        private void InitSecondaryData()
        {
            MyMaze = MyMazeData.GetData();
            BotX = MyMaze.Start.Item2;
            BotY = MyMaze.Start.Item1;
        }
        public void SetGeneratorLog(bool isOn)
        {
            if (isOn)
            {
                MazeStats.GeneratorStep += PrintMazeGenerationStep;
            }
            else
            {
                MazeStats.GeneratorStep -= PrintMazeGenerationStep;
            }
        }
        public abstract void PrintMazeGenerationStep(bool[,] lab);
        public abstract void PrintMaze();
        protected abstract void PrintStepOnMaze(int len, int dir);
    }
}
