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
            this.SimSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CellSize = new System.Windows.Forms.TextBox();
            this.startGenerating = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
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
            this.Start_Btn.Text = "Начать симуляцию";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // SimSpeed
            // 
            this.SimSpeed.CausesValidation = false;
            this.SimSpeed.Location = new System.Drawing.Point(656, 416);
            this.SimSpeed.MaxLength = 5;
            this.SimSpeed.Name = "SimSpeed";
            this.SimSpeed.Size = new System.Drawing.Size(132, 23);
            this.SimSpeed.TabIndex = 1;
            this.SimSpeed.TextChanged += new System.EventHandler(this.SimSpeed_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Скорость симуляции (мс)";
            // 
            // CellSize
            // 
            this.CellSize.Location = new System.Drawing.Point(656, 387);
            this.CellSize.Name = "CellSize";
            this.CellSize.Size = new System.Drawing.Size(132, 23);
            this.CellSize.TabIndex = 3;
            // 
            // startGenerating
            // 
            this.startGenerating.Location = new System.Drawing.Point(622, 196);
            this.startGenerating.Name = "startGenerating";
            this.startGenerating.Size = new System.Drawing.Size(166, 61);
            this.startGenerating.TabIndex = 4;
            this.startGenerating.Text = "Начать генерацию";
            this.startGenerating.UseVisualStyleBackColor = true;
            this.startGenerating.Click += new System.EventHandler(this.startGenerating_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размер клеток";
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(735, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(53, 48);
            this.pause.TabIndex = 6;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startGenerating);
            this.Controls.Add(this.CellSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimSpeed);
            this.Controls.Add(this.Start_Btn);
            this.Name = "MainWindow";
            this.Text = "Maze Test";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer DrawTick;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Start_Btn;
        private TextBox SimSpeed;
        private Label label1;
        private TextBox CellSize;
        private Button startGenerating;
        private Label label2;
        private Button pause;
    }
}