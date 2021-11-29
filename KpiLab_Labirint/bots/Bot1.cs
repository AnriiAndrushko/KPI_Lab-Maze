using System;
using System.Collections.Generic;


namespace KpiLab_Labirint.bots
{
    class Bot1 : BotBase
    {

        public Bot1(){ }

        public override void MakeDecision(List<Tuple<int, int>>[] derection, int SizeArray)
        {
            Memory.Add(derection, SizeArray);
            for (int i = 0; i < SizeArray; i++)
            {
                for (int j = 0; j < derection[i].Count; j++)
                {
                    if (!Memory.Visit(i))
                    {
                        InvokeStep(derection[i][j].Item1, i);
                        Memory.GoTo(i);
                        GoBack.Push(derection[i][j].Item1, i);
                    }
                }
            }
            Tuple<int, int> back = GoBack.Pop();
            InvokeStep(back.Item1, (back.Item2 + 2) % 2);
            Memory.GoTo((back.Item2 + 2) % 2);
        }
/*
 1. derection[]-напрямок (0-верх, 1-вправо, 2-вниз...)
 2. derection[][]- номер вузла ---+---+--+
                                  1   2  3
 3.derection[][].item1 - довжина від вузла на якому знаходиться бот до відповідного за номером
 4.derection[][].item2 - що находиться в цьому вузлі
    {
        -1-вліво
        1-вправо
        0-перехрестя
        2-вихід
    }
 */
    }
}