using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiLab_Labirint.bots
{
    class MazeTree
    {
        public NodeT current { get; private set; }
        public int Count { get; private set; }
        private bool height { get; set; }//бот переміщався зліво на право = 0, верх вниз = 1

        public MazeTree()
        {
            current = new NodeT(0);//0 - це НЕ перехрестя, а пустий нод
        }

        public void Add(List<Tuple<int, int>>[] derection, int SizeArray)
        {
            if (!current.visit)
            {
                if (Count > 0)
                    for (int i = 0; i < SizeArray; i++)
                        for (int j = 0; j < derection[i].Count; j++)
                        {
                            if (derection[i][j].Item2 >= 1 ||
                                derection[i][j].Item2 <= -1)
                            {
                                current.Add(derection[i][j].Item2, i, derection[i][j].Item1);
                            }
                            else
                            {
                                current.Add(0, i, derection[i][j].Item1);//0 - це НЕ перехрестя, а пустий нод
                            }
                            Count++;
                        }
                else
                {
                    int i;
                    if (height)// запамятовую ліво та право, тому що верх і низ уже в пам'яті
                    {
                        i = 1;
                    }
                    else
                    {
                        i = 0;
                    }
                    for (; i < SizeArray; i += 2)
                        for (int j = 0; j < derection[i].Count; j++)
                        {
                            if (derection[i][j].Item2 >= 1 ||
                                derection[i][j].Item2 <= -1)
                            {
                                current.Add(derection[i][j].Item2, i, derection[i][j].Item1);
                            }
                            else
                            {
                                current.Add(0, i, derection[i][j].Item1);//0 - це НЕ перехрестя, а пустий нод
                            }
                            Count++;
                        }
                }
            }
            else
            current.visit = true;
        }
 
        public void GoTo(int derection)
        {
            switch (derection)
            {
                case 0: 
                    current = current.Up.Item1;
                    height = true;
                    break;
                case 1:
                    current = current.Right.Item1;
                    height = false;
                    break;
                case 2:
                    current = current.Down.Item1;
                    height = true;
                    break;
                case 3:
                    current = current.Left.Item1;
                    height = false;
                    break;
                default:
                    break;
            }
        }

        public bool Visit(int derection)
        {
            switch (derection)
            {
                case 0:
                    return current.Up.Item1.visit;
                case 1:
                    return current.Right.Item1.visit;
                case 2:
                    return current.Down.Item1.visit;
                case 3:
                    return current.Left.Item1.visit;
                default:
                    return false;//тут треба помилку вивести по хорошому, а то потім ппц буде
            }
        }
    }
}
