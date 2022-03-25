using System;
using System.Collections.Generic;
using KpiLab_Labirint.bots;
using Stack = KpiLab_Labirint.bots.Stack;

namespace KpiLab_Labirint 
{
    abstract public class BotBase : IBot
    {
        protected private MazeTree Memory = new MazeTree();
        protected private Stack GoBack = new Stack();
        protected private bool BotWentBack = false;

        internal Action<int, int> Step { get; private set; }

        event Action<int, int> IBot.Step
        {
            add { Step += value; }
            remove { Step -= value; }
        }

        protected private void InvokeStep(int len, int dir)
        {
            Step?.Invoke(len, dir);
        }

        protected internal abstract void MakeDecision(List<Tuple<int,int>>[] derection, int SizeArray = 4);

        void IBot.MakeDecision(List<Tuple<int, int>>[] derection, int SizeArray)
        {
            MakeDecision(derection, SizeArray);
        }
    }
}
