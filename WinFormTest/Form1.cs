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
            SimSpeed.Text = DrawTick.Interval.ToString();
            CellSize.Text = "10";


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
            if (isStarted&& newStep)
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

        private void SimSpeed_TextChanged(object sender, EventArgs e)
        {
            int ticks;
            if(Int32.TryParse(SimSpeed.Text, out ticks))
            {
                DrawTick.Interval = ticks;
            }
            
        }

        private void startGenerating_Click(object sender, EventArgs e)
        {
            int cellSize;
            Int32.TryParse(CellSize.Text, out cellSize);
            Sim = new MazeSimBuilder().newSimulation().
                         withLabirint(new LabirintType1(20, 20, rnd.Next())).
                         withBot(new Bot1()).
                         visualizeWith(ref test, true, cellSize).
                         build();
            Sim.GenerateMaze();
            Start_Btn.Enabled = true;
            isStarted = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            isStarted = !isStarted;
        }
    }
}