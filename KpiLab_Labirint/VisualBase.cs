namespace KpiLab_Labirint
{
    abstract class VisualBase
    {
        protected MazeData MyMaze;
        protected IBot MyBot;
        protected int BotX, BotY;
        protected BotStatisticsHandler stats;
        public VisualBase() { }
        public virtual void Init(IMazeDataProvider inputData, IBot bot, BotStatisticsHandler stats)
        {
            MyMaze = inputData.GetData();
            MyBot = bot;
            BotX = MyMaze.Start.Item2;
            BotY = MyMaze.Start.Item1;
            MyBot.Step += PrintStepOnMaze;
            this.stats = stats;
        }
        protected abstract void PrintStepOnMaze(int len, int dir);
    }
}
