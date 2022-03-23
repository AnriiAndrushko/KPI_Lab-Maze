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
        public VisualBase() { }
        public virtual void Init(IMazeDataProvider inputData, IBot bot, BotStatisticsHandler botStats, MazeStatisticsHandler mazeStats)
        {
            MyMaze = inputData.GetData();
            MyBot = bot;
            BotX = MyMaze.Start.Item2;
            BotY = MyMaze.Start.Item1;
            MyBot.Step += PrintStepOnMaze;
            BotStats = botStats;
            MazeStats = mazeStats;
        }
        public abstract void PrintMaze();
        protected abstract void PrintStepOnMaze(int len, int dir);
    }
}
