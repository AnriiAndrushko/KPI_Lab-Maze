using System;
using System.Collections.Generic;

namespace KpiLab_Labirint
{
    internal interface IBot
    {
        event Action<int, int> Step;
        void MakeDecision(List<Tuple<int, int>>[] derection, int SizeArray = 4);
    }
}
