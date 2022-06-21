using System.Collections.Generic;
using System.Drawing;
using KpiLab_Labirint.statistic;

namespace KpiLab_Labirint.visual
{
    public class WinFormVisual : VisualBase
    {
        private Queue<byte[,]> frames = new Queue<byte[,]>();
        private byte[,] curFrame;
        private readonly int cellSize;
        private readonly int shiftX;
        private readonly int shiftY;
        internal void DrawFrame(Graphics g)
        {
            if (frames.Count >= 1)
            {
                curFrame = frames.Dequeue();
            }
            if (curFrame == null) { return; }
            SolidBrush pen = new SolidBrush(Color.Red);

            for (int i = 0; i < curFrame.GetLength(0); i++)
            {
                for (int j = 0; j < curFrame.GetLength(1); j++)
                {
                    pen.Color = pickColor(curFrame[i,j]);
                    Rectangle cell = new Rectangle((i+1) * cellSize+shiftX, (j+1) * cellSize+shiftY, cellSize, cellSize);
                    g.FillRectangle(pen, cell);
                }
            }
            for (int j = 0; j <= curFrame.GetLength(0); j++)
            {
                pen.Color = Color.Black;
                Rectangle cell = new Rectangle(j * cellSize + shiftX, shiftY, cellSize, cellSize);
                g.FillRectangle(pen, cell);
            }
            for (int j = 0; j <= curFrame.GetLength(1); j++)
            {
                pen.Color = Color.Black;
                Rectangle cell = new Rectangle(shiftX, j * cellSize + shiftY, cellSize, cellSize);
                g.FillRectangle(pen, cell);
            }
        }
        // 0 = freeSpace
        // 1 = wall
        // 2 = start
        // 3 = finish
        // 4 = player
        private Color pickColor(int arrayNumber)
        {
            Color returnable = Color.White;
            switch (arrayNumber)
            {
                case 1:
                    returnable = Color.Black;
                    break;
                case 2:
                    returnable = Color.Green;
                    break;
                case 3:
                    returnable = Color.Blue;
                    break;
                case 4:
                    returnable = Color.Purple;
                    break;
            }
            return returnable;
        }
        internal override void Init(IMazeDataProvider inputData, IBot bot, BotStatisticsHandler botStats, MazeStatisticsHandler mazeStats, bool generatorLog = true)
        {
            base.Init(inputData, bot, botStats, mazeStats, generatorLog);
        }
        public WinFormVisual(int shiftX=20, int shiftY=10, int cellSize = 20) {
            this.shiftX = shiftX;
            this.shiftY = shiftY;
            this.cellSize = cellSize;
        }
        internal override void PrintMaze()
        {
            byte[,] newFrame = new byte[MyMaze.LabData.GetLength(0), MyMaze.LabData.GetLength(1)];

            for (int i = 0; i < MyMaze.LabData.GetLength(0); i++)
            {
                for (int j = 0; j < MyMaze.LabData.GetLength(1); j++)
                {
                    if (MyMaze.Start.Item1 == i && MyMaze.Start.Item2 == j)
                    {
                        newFrame[i, j] = 2;
                        continue;
                    }
                    if (MyMaze.End.Item1 == i && MyMaze.End.Item2 == j)
                    {
                        newFrame[i, j] = 3;
                        continue;
                    }
                    if (MyMaze.LabData[i, j])
                    {
                        newFrame[i, j] = 0;
                    }
                    else
                    {
                        newFrame[i, j] = 1;
                    }
                }
            }
            //Console.Write("\nThe number of iterations - " + MazeStats.GenerationSteps);
            frames.Enqueue(newFrame);
        }
        protected override void PrintStepOnMaze(int len, int dir)
        {
            if (dir == 0) { BotY -= len; }
            else if (dir == 1) { BotX += len; }
            else if (dir == 2) { BotY += len; }
            else if (dir == 3) { BotX -= len; }

            byte[,] newFrame = new byte[MyMaze.LabData.GetLength(0), MyMaze.LabData.GetLength(1)];

            for (int i = 0; i < MyMaze.LabData.GetLength(0); i++)
            {
                for (int j = 0; j < MyMaze.LabData.GetLength(1); j++)
                {
                    if (BotX == j && BotY == i)
                    {
                        newFrame[i, j] = 4;
                        continue;
                    }
                    if (MyMaze.Start.Item1 == i && MyMaze.Start.Item2 == j)
                    {
                        newFrame[i, j] = 2;
                        continue;
                    }
                    if (MyMaze.End.Item1 == i && MyMaze.End.Item2 == j)
                    {
                        newFrame[i, j] = 3;
                        continue;
                    }
                    if (MyMaze.LabData[i, j])
                    {
                        newFrame[i, j] = 0;
                    }
                    else
                    {
                        newFrame[i, j] = 1;
                    }
                }
            }
            frames.Enqueue(newFrame);
            //Console.Write("\nThe number of iterations - " + BotStats.BotIterations + "\nThe number of steps - " + BotStats.BotSteps + "\n");
        }

        internal override void PrintMazeGenerationStep(bool[,] lab)
        {
            byte[,] newFrame = new byte[lab.GetLength(0), lab.GetLength(1)];

            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j])
                    {
                        newFrame[i, j] = 0;
                        continue;
                    }
                    newFrame[i, j] = 1;
                }
            }
            frames.Enqueue(newFrame);

        }
    }
}
