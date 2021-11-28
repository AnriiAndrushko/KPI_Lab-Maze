using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using KpiLab_Labirint.bots;
using Stack = KpiLab_Labirint.bots.Stack;

namespace KpiLab_Labirint
{
    abstract class BotBase
    {
        protected MazeTree Memory = new MazeTree();
        protected Stack GoBack = new Stack();
        public abstract void MakeDecision(List<Tuple<int,int>>[] derection, int SizeArray);
    }
}
