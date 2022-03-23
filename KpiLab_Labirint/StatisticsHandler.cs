using System;

namespace KpiLab_Labirint
{
    class BotStatisticsHandler
    {
        public BotStatisticsHandler(IBot MyBot)
        {
            botIterations = 0;
            botSteps = 0;
            MyBot.Step += (int len, int dir) => {
                BotSteps += len;
                BotIterations++;
            };
        }
        private int botIterations;
        private int botSteps;
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
}
