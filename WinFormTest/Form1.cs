using KpiLab_Labirint.bots;
using KpiLab_Labirint.maze;
using KpiLab_Labirint.visual;
using KpiLab_Labirint;
namespace WinFormTest
{
    public partial class MainWindow : Form
    {
        Random rnd = new Random();
        event Action<Graphics> test;
        MazeSimulator Sim;
        bool isStarted = false;
        bool newStep = false;

        public MainWindow()
        {
            InitializeComponent();
            SimSpeedBar.Value = DrawTick.Interval;

            BotSelectionBox.Items.AddRange(new string[] { "Left hand rule" });
            BotSelectionBox.Text = BotSelectionBox.Items[0].ToString();                
            MazeSelectionBox.Items.AddRange(new string[] { "Type1","Type2" });
            MazeSelectionBox.Text = MazeSelectionBox.Items[0].ToString();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }

        private void DrawTick_Tick(object sender, EventArgs e)
        {
            if (isStarted) { this.Invalidate();
                newStep = true;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isStarted && newStep)
            {
                newStep = false;
                test?.Invoke(e.Graphics);
            }
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            isStarted = true;
            Sim.StartSimulation();
        }

        private void startGenerating_Click(object sender, EventArgs e)
        {
            if (test!=null)
            {
                test = null; //to free memory from previous run 
            }
            int winSizeMagicNumber = 220;
            int mazeSize = MazeSizeBar.Value;
            int drawSize = (winSizeMagicNumber / (mazeSize+1));

            LabirintBase selectedMaze = MazeSelectionBox.SelectedIndex switch
            {
                0 => new LabirintType1(mazeSize, mazeSize, rnd.Next()),
                1 => new LabirintType2(mazeSize, mazeSize, rnd.Next()),
                _ => new LabirintType1(mazeSize, mazeSize, rnd.Next())
            };

            BotBase selectedBot = BotSelectionBox.SelectedIndex switch
            {
                0 => new Bot1(),
                _ => new Bot1()
            };
  
            Sim = new MazeSimBuilder().newSimulation().
                         withLabirint(selectedMaze).
                         withBot(selectedBot).
                         visualizeWith(ref test, true, drawSize).
                         build();
            Sim.GenerateMaze();
            Start_Btn.Enabled = true;
            isStarted = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            isStarted = !isStarted;
        }

        private void SimSpeedBar_Scroll(object sender, EventArgs e)
        {
            DrawTick.Interval = SimSpeedBar.Maximum - SimSpeedBar.Value + SimSpeedBar.Minimum;
        }
    }
}