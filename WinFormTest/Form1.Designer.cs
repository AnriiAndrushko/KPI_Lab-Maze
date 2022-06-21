namespace WinFormTest
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DrawTick = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startGenerating = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.BotSelectionBox = new System.Windows.Forms.ComboBox();
            this.labirintType1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MazeSelectionBox = new System.Windows.Forms.ComboBox();
            this.MazeSizeBar = new System.Windows.Forms.TrackBar();
            this.SimSpeedBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.labirintType1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MazeSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimSpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawTick
            // 
            this.DrawTick.Enabled = true;
            this.DrawTick.Tick += new System.EventHandler(this.DrawTick_Tick);
            // 
            // Start_Btn
            // 
            this.Start_Btn.Enabled = false;
            this.Start_Btn.Location = new System.Drawing.Point(622, 292);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(166, 61);
            this.Start_Btn.TabIndex = 0;
            this.Start_Btn.Text = "Begin simulation";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simulation speed";
            // 
            // startGenerating
            // 
            this.startGenerating.Location = new System.Drawing.Point(622, 196);
            this.startGenerating.Name = "startGenerating";
            this.startGenerating.Size = new System.Drawing.Size(166, 61);
            this.startGenerating.TabIndex = 4;
            this.startGenerating.Text = "Begin generation";
            this.startGenerating.UseVisualStyleBackColor = true;
            this.startGenerating.Click += new System.EventHandler(this.startGenerating_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maze size";
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(724, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(53, 48);
            this.pause.TabIndex = 6;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // BotSelectionBox
            // 
            this.BotSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BotSelectionBox.Location = new System.Drawing.Point(656, 92);
            this.BotSelectionBox.Name = "BotSelectionBox";
            this.BotSelectionBox.Size = new System.Drawing.Size(121, 23);
            this.BotSelectionBox.TabIndex = 7;
            // 
            // labirintType1BindingSource
            // 
            this.labirintType1BindingSource.DataSource = typeof(KpiLab_Labirint.maze.LabirintType1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bot type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Maze type";
            // 
            // MazeSelectionBox
            // 
            this.MazeSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MazeSelectionBox.Location = new System.Drawing.Point(656, 148);
            this.MazeSelectionBox.Name = "MazeSelectionBox";
            this.MazeSelectionBox.Size = new System.Drawing.Size(121, 23);
            this.MazeSelectionBox.TabIndex = 9;
            // 
            // MazeSizeBar
            // 
            this.MazeSizeBar.Location = new System.Drawing.Point(673, 365);
            this.MazeSizeBar.Maximum = 30;
            this.MazeSizeBar.Minimum = 5;
            this.MazeSizeBar.Name = "MazeSizeBar";
            this.MazeSizeBar.Size = new System.Drawing.Size(104, 45);
            this.MazeSizeBar.TabIndex = 11;
            this.MazeSizeBar.Value = 5;
            // 
            // SimSpeedBar
            // 
            this.SimSpeedBar.Location = new System.Drawing.Point(673, 416);
            this.SimSpeedBar.Maximum = 500;
            this.SimSpeedBar.Minimum = 1;
            this.SimSpeedBar.Name = "SimSpeedBar";
            this.SimSpeedBar.Size = new System.Drawing.Size(104, 45);
            this.SimSpeedBar.TabIndex = 12;
            this.SimSpeedBar.Value = 500;
            this.SimSpeedBar.Scroll += new System.EventHandler(this.SimSpeedBar_Scroll);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SimSpeedBar);
            this.Controls.Add(this.MazeSizeBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MazeSelectionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotSelectionBox);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startGenerating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_Btn);
            this.Name = "MainWindow";
            this.Text = "Maze Test";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.labirintType1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MazeSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimSpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer DrawTick;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Start_Btn;
        private Label label1;
        private Button startGenerating;
        private Label label2;
        private Button pause;
        private ComboBox BotSelectionBox;
        private Label label4;
        private Label label3;
        private ComboBox MazeSelectionBox;
        private BindingSource labirintType1BindingSource;
        private TrackBar MazeSizeBar;
        private TrackBar SimSpeedBar;
    }
}