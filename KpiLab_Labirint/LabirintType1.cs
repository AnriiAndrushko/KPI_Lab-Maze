using System;
using System.Collections.Generic;

namespace KpiLab_Labirint
{
    class LabirintType1 : LabirintBase
    {
        public LabirintType1(int width, int height) : base(width, height)
        {
            labirintMap = GenerateLabirint(Height, Width);
        }

        private bool[,] GenerateLabirint(int height, int width)
        {
            bool[,] curMap = new bool[height*2, width*2];
            List<Tuple<int, int>> visited = new List<Tuple<int, int>>();
            Tuple<int, int> startPos = new Tuple<int, int>(rnd.Next(height)*2, 0);
            this.startPos = startPos;
            visited.Add(startPos);
            curMap[startPos.Item1, startPos.Item2] = true;
            while (visited.Count!=0)
            {
                if (visited.Count == 1)
                {
                    endPos = new Tuple<int, int>(visited[0].Item1, visited[0].Item2);
                }
                RecursBuild(visited, curMap);
            };
            return curMap;
        }

        private void RecursBuild(List<Tuple<int, int>> visited, bool[,] curMap)
        {
            int pickIndex = rnd.Next(visited.Count);
            Tuple<int, int> picked = visited[pickIndex];
            
            List<Tuple<int, int>> avaliable = new List<Tuple<int, int>>();
            if (picked.Item1 + 2 < Height * 2 && !curMap[picked.Item1 + 2, picked.Item2])
            {
                avaliable.Add(new Tuple<int, int>(2 , 0));
            }
            if (picked.Item1 - 2 >= 0 && !curMap[picked.Item1 - 2, picked.Item2])
            {
                avaliable.Add(new Tuple<int, int>(-2, 0));
            }
            if (picked.Item2 - 2 >= 0 && !curMap[picked.Item1, picked.Item2 - 2])
            {
                avaliable.Add(new Tuple<int, int>(0, -2));
            }
            if (picked.Item2 + 2 < Width * 2 && !curMap[picked.Item1, picked.Item2 + 2])
            {
                avaliable.Add(new Tuple<int, int>(0, 2));
            }
            if (avaliable.Count == 0)
            {
                visited.RemoveAt(pickIndex);
                return;
            }
            if (avaliable.Count == 1)
            {
                visited.RemoveAt(pickIndex);
            }
            pickIndex = rnd.Next(avaliable.Count);
            visited.Add(new Tuple<int, int>(picked.Item1 + avaliable[pickIndex].Item1,
                                            picked.Item2 + avaliable[pickIndex].Item2));
            curMap[picked.Item1 + avaliable[pickIndex].Item1,
                   picked.Item2 + avaliable[pickIndex].Item2] = true; //new cell
            curMap[picked.Item1 + avaliable[pickIndex].Item1 / 2,
                   picked.Item2 + avaliable[pickIndex].Item2 / 2] = true;//path to cell
        }
    }
}
