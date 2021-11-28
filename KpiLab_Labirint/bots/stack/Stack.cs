using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiLab_Labirint.bots
{
    public class Stack
    {
        private List<Tuple<int, int>> Items = new List<Tuple<int, int>>();//first - length, second - derection 
        public int Count => Items.Count;

        public void Push(int length, int derection)
        {
            Tuple<int, int> tmp = new Tuple<int, int>(length, derection);
            Items.Add(tmp);
        }

        public Tuple<int, int> Pop()
        {
            if (Count > 0)
            {
                return Items.LastOrDefault();
            }
            else
            {
                Tuple<int, int> tmp = new Tuple<int, int>(0, 0);
                return tmp;
            }
        }
    }
}
