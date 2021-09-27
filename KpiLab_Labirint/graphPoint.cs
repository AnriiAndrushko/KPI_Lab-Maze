//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace KpiLab_Labirint
{
    class GraphPoint
    {
        public GraphPoint UP { get; set; } = null;
        public GraphPoint DOWN { get; set; } = null;
        public GraphPoint LEFT { get; set; } = null;
        public GraphPoint RIGHT { get; set; } = null;

        private readonly int UpLegth = -1;
        private readonly int DownLength = -1;
        private readonly int LeftLength = -1;
        private readonly int RightLength = -1;

        GraphPoint(int upLegth = -1, int downLength = -1, int leftLength = -1, int rightLength = -1)
        {
            if (upLegth > 0)
            {
                UpLegth = upLegth;
            }
            if (downLength > 0)
            {
                DownLength = downLength;
            }
            if (leftLength > 0)
            {
                LeftLength = leftLength;
            }
            if (rightLength > 0)
            {
                RightLength = rightLength;
            }
        }
    }
}
