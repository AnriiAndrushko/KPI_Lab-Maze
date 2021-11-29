using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiLab_Labirint.bots
{
    class WaysFinder
    {
        public static List<Tuple<int, int>>[] FindWay(bool[,] maze1, Tuple<int, int> start, Tuple<int, int> end, Tuple<int, int> dot)
        {
            int lenght = maze1.GetLength(0);
            int width = maze1.GetLength(1);

            bool[,] maze = new bool[lenght + 2, width + 2];

            for (int i = 0; i <= width + 1; i++)
            {
                maze[0, i] = false;
            }
            for (int i = 0; i <= lenght + 1; i++)
            {
                maze[i, 0] = false;
            }
            for (int i = 0; i <= width + 1; i++)
            {
                maze[lenght + 1, i] = false;
            }
            for (int i = 0; i <= lenght + 1; i++)
            {
                maze[i, width + 1] = false;
            }

            for (int i = 1; i <= lenght; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    maze[i, j] = maze1[i - 1, j - 1];
                }
            }

            List<Tuple<int, int>>[] ways = new List<Tuple<int, int>>[4];
            int line = dot.Item1;
            int column = dot.Item2;

            int up = line - 1;
            int right = column + 1;
            int down = line + 1;
            int left = column - 1;

            int counterUP = 1;
            int counterRight = 1;
            int counterDown = 1;
            int counterLeft = 1;

            for (int i = 0; i <= 3; i++)
            {
                ways[i] = new List<Tuple<int, int>>();
            }

            while (maze[up + 1, column + 1] != false) //UP
            {
                if ((maze[up + 1, column] == true) && (maze[up + 1, column + 2] == true))
                {
                    ways[0].Add(new Tuple<int, int>(counterUP, 0));
                }
                else if ((maze[up + 1, column] == true) && (maze[up + 1, column + 2] == false))
                {
                    ways[0].Add(new Tuple<int, int>(counterUP, -1));
                }
                else if ((maze[up + 1, column] == false) && (maze[up + 1, column + 2] == true))
                {
                    ways[0].Add(new Tuple<int, int>(counterUP, 1));
                }
                up--;
                counterUP++;
                if (up == end.Item1)
                {
                    ways[0].Add(new Tuple<int, int>(counterUP, 2));
                }
            }

            while (maze[line + 1, right + 1] != false) //Right
            {
                if ((maze[line, right + 1] == true) && (maze[line + 2, right + 1] == true))
                {
                    ways[1].Add(new Tuple<int, int>(counterRight, 0));
                }
                else if ((maze[line, right + 1] == true) && (maze[line + 2, right + 1] == false))
                {
                    ways[1].Add(new Tuple<int, int>(counterRight, -1));
                }
                else if ((maze[line, right + 1] == false) && (maze[line + 2, right + 1] == true))
                {
                    ways[1].Add(new Tuple<int, int>(counterRight, 1));
                }
                right++;
                counterRight++;
                if (right == end.Item2)
                {
                    ways[1].Add(new Tuple<int, int>(counterRight, 2));
                }
            }

            while (maze[down + 1, column + 1] != false) //Down
            {
                if ((maze[down + 1, column] == true) && (maze[down + 1, column + 2] == true))
                {
                    ways[2].Add(new Tuple<int, int>(counterDown, 0));
                }
                else if ((maze[down + 1, column] == true) && (maze[down + 1, column + 2] == false))
                {
                    ways[2].Add(new Tuple<int, int>(counterDown, 1));
                }
                else if ((maze[down + 1, column] == false) && (maze[down + 1, column + 2] == true))
                {
                    ways[2].Add(new Tuple<int, int>(counterDown, -1));
                }
                down++;
                counterDown++;
                if (down == end.Item1)
                {
                    ways[2].Add(new Tuple<int, int>(counterDown, 2));
                }
            }

            while (maze[line + 1, left + 1] != false) //Left
            {
                if ((maze[line, left + 1] == true) && (maze[line + 2, left + 1] == true))
                {
                    ways[3].Add(new Tuple<int, int>(counterLeft, 0));
                }
                else if ((maze[line, left + 1] == true) && (maze[line + 2, left + 1] == false))
                {
                    ways[3].Add(new Tuple<int, int>(counterLeft, 1));
                }
                else if ((maze[line, left + 1] == false) && (maze[line + 2, left + 1] == true))
                {
                    ways[3].Add(new Tuple<int, int>(counterLeft, -1));
                }
                left--;
                counterLeft++;
                if (left == end.Item2)
                {
                    ways[3].Add(new Tuple<int, int>(counterLeft, 2));
                }
            }

            return ways;
        }


    }
}
