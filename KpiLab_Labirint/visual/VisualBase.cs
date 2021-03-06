using KpiLab_Labirint.statistic;
namespace KpiLab_Labirint.visual
{
    abstract public class VisualBase
    {
        protected private MazeData MyMaze;
        protected private IBot MyBot;
        protected private int BotX, BotY;
        protected private BotStatisticsHandler BotStats;
        protected private MazeStatisticsHandler MazeStats;
        protected private IMazeDataProvider MyMazeData;
        internal VisualBase() { }
        internal virtual void Init(IMazeDataProvider inputData, IBot bot, BotStatisticsHandler botStats, MazeStatisticsHandler mazeStats, bool generatorLog = true)
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
        internal void SetGeneratorLog(bool isOn)
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
        internal abstract void PrintMazeGenerationStep(bool[,] lab);
        internal abstract void PrintMaze();
        protected abstract void PrintStepOnMaze(int len, int dir);
    }
}
