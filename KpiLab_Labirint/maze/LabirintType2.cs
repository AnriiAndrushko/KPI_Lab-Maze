﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace KpiLab_Labirint
{
    class LabirintType2 : LabirintBase
    {
        public LabirintType2(int width, int height) : base(width, height)
        {
            labirintMap = GenerateLabirint(Height, Width);
        }


        private bool[,] GenerateLabirint(int height, int width)
        {
            bool[,] curMap = new bool[height * 2, width * 2];
            Tuple<int, int> startPos = new Tuple<int, int>(rnd.Next(height) * 2, 0);
            LinkedList<Tuple<int, int>> path = new LinkedList<Tuple<int, int>>();
            this.startPos = startPos;
            curMap[startPos.Item1, startPos.Item2] = true;
            path.AddLast(startPos);
            endPos = new Tuple<int, int>(-1, -1);
            RecursBuild(curMap, path);

            return curMap;
        }

        private void RecursBuild(bool[,] curMap, LinkedList<Tuple<int, int>> path)
        {
            if (path.Count == 0)
            {
                return;
            }
            List<Tuple<int, int>> avaliable = new List<Tuple<int, int>>();
            if (path.Last().Item1 + 2 < Height * 2 && !curMap[path.Last().Item1 + 2, path.Last().Item2])
            {
                avaliable.Add(new Tuple<int, int>(2, 0));
            }
            if (path.Last().Item1 - 2 >= 0 && !curMap[path.Last().Item1 - 2, path.Last().Item2])
            {
                avaliable.Add(new Tuple<int, int>(-2, 0));
            }
            if (path.Last().Item2 - 2 >= 0 && !curMap[path.Last().Item1, path.Last().Item2 - 2])
            {
                avaliable.Add(new Tuple<int, int>(0, -2));
            }
            if (path.Last().Item2 + 2 < Width * 2 && !curMap[path.Last().Item1, path.Last().Item2 + 2])
            {
                avaliable.Add(new Tuple<int, int>(0, 2));
            }
            if (avaliable.Count == 0)
            {
                if (endPos.Item1==-1&&endPos.Item2==-1)
                {
                    endPos = path.Last();
                }
                path.Remove(path.Last());
                RecursBuild(curMap, path);
                return;
            }
            int pickIndex = rnd.Next(avaliable.Count);
            Tuple<int, int> newCell = new Tuple<int, int>(path.Last().Item1 + avaliable[pickIndex].Item1,
                                                          path.Last().Item2 + avaliable[pickIndex].Item2);
            curMap[newCell.Item1, newCell.Item2] = true; //new cell
            curMap[path.Last().Item1 + avaliable[pickIndex].Item1 / 2,
                   path.Last().Item2 + avaliable[pickIndex].Item2 / 2] = true;//path to cell
            path.AddLast(newCell);
            RecursBuild(curMap, path);
        }
    }
}
