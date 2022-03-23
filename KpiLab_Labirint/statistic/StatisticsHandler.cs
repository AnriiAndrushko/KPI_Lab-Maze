using System;
using KpiLab_Labirint.maze;

namespace KpiLab_Labirint.statistic
{
    class BotStatisticsHandler
    {
        private int botIterations;
        private int botSteps;
        public BotStatisticsHandler(IBot bot)
        {
            botIterations = 0;
            botSteps = 0;
            bot.Step += (int len, int dir) => {
                BotSteps += len;
                BotIterations++;
            };
        }
        public int BotIterations {
            get { return botIterations; }
            set { if (value != botIterations+1) { throw new Exception(); } else { botIterations = value; } }
        }
        public int BotSteps
        {
            get { return botSteps; }
            set { if (value <= botSteps) { throw new Exception(); } else { botSteps = value; } }
        }
    }
    class MazeStatisticsHandler
    {
        private int generationSteps = 0;
        public event Action<bool[,]> GeneratorStep;
        public event Action GenerationFinished;
        public void GenerateStepMap(bool[,] lab)
        {
            GeneratorStep?.Invoke(lab);
        }
        public MazeStatisticsHandler(LabirintBase labirint)
        {
            labirint.BuildStep += GenerateStepMap;
            labirint.MazeGenerated += (int steps) => { generationSteps = steps; GenerationFinished?.Invoke(); };
        }
        public int GenerationSteps
        {
            get { return generationSteps; }
            set { if (value <= generationSteps) { throw new Exception(); } else { generationSteps = value; } }
        }
    }
}
