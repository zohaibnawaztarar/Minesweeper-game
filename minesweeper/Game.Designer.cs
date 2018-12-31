namespace Minesweeper
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameProgress = new System.Windows.Forms.ProgressBar();
            this.score = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remainingFlags = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.secondsBox = new System.Windows.Forms.TextBox();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameProgress
            // 
            this.gameProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameProgress.Location = new System.Drawing.Point(0, 1870);
            this.gameProgress.Margin = new System.Windows.Forms.Padding(7);
            this.gameProgress.MarqueeAnimationSpeed = 0;
            this.gameProgress.Name = "gameProgress";
            this.gameProgress.Size = new System.Drawing.Size(2035, 51);
            this.gameProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.gameProgress.TabIndex = 0;
            this.gameProgress.Click += new System.EventHandler(this.gameProgress_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Black;
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(29, 76);
            this.score.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(152, 57);
            this.score.TabIndex = 1;
            this.score.Text = "Score";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // heightBox
            // 
            this.heightBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.heightBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.heightBox.Location = new System.Drawing.Point(717, 76);
            this.heightBox.Margin = new System.Windows.Forms.Padding(7);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(76, 35);
            this.heightBox.TabIndex = 2;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // widthBox
            // 
            this.widthBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.widthBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.widthBox.Location = new System.Drawing.Point(717, 150);
            this.widthBox.Margin = new System.Windows.Forms.Padding(7);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(76, 35);
            this.widthBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(603, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(603, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width";
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(1123, 134);
            this.Play.Margin = new System.Windows.Forms.Padding(7);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(553, 65);
            this.Play.TabIndex = 6;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // difficulty
            // 
            this.difficulty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.ForeColor = System.Drawing.SystemColors.InfoText;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.difficulty.Location = new System.Drawing.Point(1399, 78);
            this.difficulty.Margin = new System.Windows.Forms.Padding(7);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(277, 37);
            this.difficulty.TabIndex = 11;
            this.difficulty.SelectedIndexChanged += new System.EventHandler(this.difficulty_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1125, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Difficulty Level:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(815, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "min. 5 - max. 25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(815, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "min. 5 - max. 40";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // remainingFlags
            // 
            this.remainingFlags.AutoSize = true;
            this.remainingFlags.BackColor = System.Drawing.Color.Black;
            this.remainingFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainingFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingFlags.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remainingFlags.Location = new System.Drawing.Point(283, 76);
            this.remainingFlags.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.remainingFlags.Name = "remainingFlags";
            this.remainingFlags.Size = new System.Drawing.Size(143, 57);
            this.remainingFlags.TabIndex = 15;
            this.remainingFlags.Text = "Flags";
            this.remainingFlags.Click += new System.EventHandler(this.remainingFlags_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // secondsBox
            // 
            this.secondsBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.secondsBox.Enabled = false;
            this.secondsBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.secondsBox.Location = new System.Drawing.Point(362, 161);
            this.secondsBox.Margin = new System.Windows.Forms.Padding(7);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(48, 35);
            this.secondsBox.TabIndex = 16;
            this.secondsBox.TextChanged += new System.EventHandler(this.secondsBox_TextChanged);
            // 
            // minutesBox
            // 
            this.minutesBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.minutesBox.Enabled = false;
            this.minutesBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.minutesBox.Location = new System.Drawing.Point(283, 161);
            this.minutesBox.Margin = new System.Windows.Forms.Padding(7);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(48, 35);
            this.minutesBox.TabIndex = 17;
            this.minutesBox.TextChanged += new System.EventHandler(this.minutesBox_TextChanged);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Black;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(29, 146);
            this.time.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(132, 57);
            this.time.TabIndex = 18;
            this.time.Text = "Time";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(334, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Minesweeper.Properties.Resources.topbg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2064, 166);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2035, 45);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(102, 41);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToStartToolStripMenuItem,
            this.howToPlayToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 41);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToStartToolStripMenuItem
            // 
            this.howToStartToolStripMenuItem.Name = "howToStartToolStripMenuItem";
            this.howToStartToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.howToStartToolStripMenuItem.Text = "How to start";
            this.howToStartToolStripMenuItem.Click += new System.EventHandler(this.howToStartToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(71, 41);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(1693, 137);
            this.restartBtn.Margin = new System.Windows.Forms.Padding(7);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(326, 62);
            this.restartBtn.TabIndex = 22;
            this.restartBtn.Text = "Restart";
            this.restartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(1693, 62);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(7);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(326, 62);
            this.quitBtn.TabIndex = 23;
            this.quitBtn.Text = "Quit";
            this.quitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2035, 1921);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.remainingFlags);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.gameProgress);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(2063, 2000);
            this.MinimumSize = new System.Drawing.Size(2063, 1464);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar gameProgress;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label remainingFlags;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox secondsBox;
        private System.Windows.Forms.TextBox minutesBox;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.ToolStripMenuItem howToStartToolStripMenuItem;
    }
}