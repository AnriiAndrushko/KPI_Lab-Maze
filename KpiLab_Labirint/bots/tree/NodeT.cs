using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiLab_Labirint.bots
{
    class NodeT
    {
        public int Data { get; set; }
        public bool visit { get; set; }
        public Tuple<NodeT, int> Left { get; set; } //Item 1 - Node; Item 2 - length
        public Tuple<NodeT, int> Right { get; set; }//Item 1 - Node; Item 2 - length
        public Tuple<NodeT, int > Down { get; set; }//Item 1 - Node; Item 2 - length
        public Tuple<NodeT, int > Up { get; set; }  //Item 1 - Node; Item 2 - length

        public NodeT(int data)
        {
            Data = data;
        }
        public void Add(int data, int direction, int length)
        {
            var node = new NodeT(data);
            switch (direction)
            {
                case 0:
                    if (Up == null)
                    {
                        Up = new Tuple<NodeT, int>(node, length);
                        Up.Item1.Down = new Tuple<NodeT, int>(this, length);
                    }
                    else
                    {
                        length -= Up.Item2;
                        Up.Item1.Add(data, direction, length);
                    }
                    break;
                case 1:
                    if (Right == null)
                    {
                        Right = new Tuple<NodeT, int>(node, length);
                        Right.Item1.Left = new Tuple<NodeT, int>(this, length);
                    }
                    else
                    {
                        length -= Right.Item2;
                        Right.Item1.Add(data, direction, length);
                    }
                    break;
                case 2:
                    if (Down == null)
                    {
                        Down = new Tuple<NodeT, int>(node, length);
                        Down.Item1.Up = new Tuple<NodeT, int>(this, length);
                    }
                    else
                    {
                        length -= Down.Item2;
                        Down.Item1.Add(data, direction, length);
                    }
                    break;
                case 3:
                    if (Left == null)
                    {
                        Left = new Tuple<NodeT, int>(node, length);
                        Left.Item1.Right = new Tuple<NodeT, int>(this, length);
                    }
                    else
                    {
                        length -= Left.Item2;
                        Left.Item1.Add(data, direction, length);
                    }
                    break;
                default:
                    break;
            }
        }
    }

}
