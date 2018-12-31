/*
 C# Array Game

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Minesweeper
{
    public partial class Game : Form
    {

        Button[,] btn = new Button[41, 41];
        int[,] btn_prop = new int[41, 41];
        int[,] saved_btn_prop = new int[41, 41];
        Point coord;

        bool firstPlay = true;
        bool gameover = false;

        //Time in minutes and seconds.
        int seconds = 0;
        int minutes = 0;

        //Points that are around
        int[] dx8 = { 1, 0, -1, 0, 1, -1, -1, 1 };
        int[] dy8 = { 0, 1, 0, -1, 1, -1, 1, -1 };

        //Table aspect
        int start_x, start_y;
        int height, width;
        
        //Game variables
        int mines;
        int flag_value = 10; //saves the number of flag
        int gameDifficulty;
        int flags;

        //Button sizes and distance between them
        int buttonSize = 20;
        int distance_between = 20;

        //difficulty levels coeeficents used to determine the number of mines to put in each level.
        double easyCoef = 0.1f;
        double mediumCoef = 0.2f;
        double hardCoef = 0.3f; 

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        // This funtion sets the tile images like numbers and mines
        void set_ButtonImage(int x, int y)
        {
            btn[x, y].Enabled = false;
            btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;

            if (gameover && btn_prop[x,y] == flag_value)
                btn_prop[x, y] = saved_btn_prop[x, y];

            // stops the timer if game is stopped/over
            if (gameover)
                timer.Stop();
            
            switch (btn_prop[x, y])
            {
                case 0:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.blank;
                    EmptySpace(x, y);
                    break;

                case 1:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._1;
                    break;

                case 2:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._2;
                    break;

                case 3:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._3;
                    break;

                case 4:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._4;
                    break;

                case 5:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._5;
                    break;

                case 6:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._6;
                    break;

                case 7:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._7;
                    break;

                case 8:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._8;
                    break;

                case -1:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.bmb;
                    if(!gameover)
                    GameOver(); // call for game over funtion
                    break;
            }
            
        }

        int isPointOnMap(int x, int y)
        {
            if (x < 1 || x > width || y < 1 || y > height)
                return 0;
            return 1;
        }

        void EmptySpace(int x, int y)
        {
            if(btn_prop[x,y] == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    int cx = x + dx8[i];
                    int cy = y + dy8[i];

                    if (isPointOnMap(cx, cy) == 1)
                        if (btn[cx, cy].Enabled == true && btn_prop[cx, cy] != -1 && !gameover)
                        {
                            gameProgress.Value++;
                            score.Text = "Score: " + gameProgress.Value.ToString();
                            set_ButtonImage(cx, cy);
                        }
                }
            }    
        }

        void Discover_Map()
        {
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn[i, j].Enabled == true)
                    {
                        set_ButtonImage(i, j);
                    }
        }

        // this funtion decides when the game is over and shows a game over message box
        void GameOver()
        {
            gameover = true;
            Discover_Map();
            MessageBox.Show("Game Over! Please click restart button to play again"); 
        }

        // This funtion checks if user clicks on flag
        void Check_FlagWin()
        {
            bool win = true;

            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn_prop[i, j] == -1)
                        win = false;

            if (win)
            {
                WinGame();
            }
        }

        // when user wins the game
        void WinGame()
        {
            gameover = true;
            Discover_Map();
            gameProgress.Value = 0;
            MessageBox.Show("Congrats you Won!");
        }

        // checks if user won the game
        void Check_ClickWin()
        {
            bool win = true;
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn[i,j].Enabled == true && saved_btn_prop[i,j] != -1)
                        win = false;

            if (win)
            {
                WinGame();
            }
        }

        // this funtion turn the tile when clicked / Event handler for when tile is clicked on board*/
        private void OneClick(object sender, EventArgs e)
        {
            coord = ((Button)sender).Location;
            int x = (coord.X - start_x) / buttonSize;
            int y = (coord.Y - start_y) / buttonSize;

            if (btn_prop[x, y] != flag_value)
            {

                ((Button)sender).Enabled = false;
                ((Button)sender).Text = "";

                ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;

                if (btn_prop[x, y] != -1 && !gameover)
                {
                    gameProgress.Value++;
                    score.Text = "Score: " + gameProgress.Value.ToString();
                    Check_ClickWin();
                }

                set_ButtonImage(x, y);
            }    
        }

        // Decides how many mines to put around the numbers 
        int MinesAround(int x, int y)
        {
            int score = 0;
            for(int i = 0; i < 8; i++)
            {
                int cx = x + dx8[i];
                int cy = y + dy8[i];

                if (isPointOnMap(cx, cy) == 1 && btn_prop[cx, cy] == -1)
                    score++;
            }
            return score;
        }

        // Grid
        void SetMapNumbers(int x, int y)
        {
            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                    if (btn_prop[i, j] != -1)
                    {
                        btn_prop[i, j] = MinesAround(i, j);
                        saved_btn_prop[i, j] = MinesAround(i, j);
                    }
        }

        // Event handler for when tile is right clicked on board*/
        private void RightClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                coord = ((Button)sender).Location;
                int x = (coord.X - start_x) / buttonSize;
                int y = (coord.Y - start_y) / buttonSize;

                if (btn_prop[x, y] != flag_value && flags > 0)
                {
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.flag;
                    btn_prop[x, y] = flag_value;
                    flags--;
                    Check_FlagWin();
                }
                else
                    if (btn_prop[x, y] == flag_value)
                    {
                        btn_prop[x, y] = saved_btn_prop[x, y];
                        btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                        btn[x, y].BackgroundImage = null;
                        flags++;
                    }

                remainingFlags.Text = "Flags: " + flags;
            }
        }
                    
        void CreateButtons(int x, int y)
        {
            for(int i = 1; i <= x; i++)
                for(int j = 1; j <= y; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(i * buttonSize + start_x, j * buttonSize + start_y, distance_between, distance_between);
                    btn[i, j].Click += new EventHandler(OneClick);
                    btn[i, j].MouseUp += new MouseEventHandler(RightClick);
                    btn_prop[i, j] = 0;
                    saved_btn_prop[i, j] = 0;
                    btn[i, j].TabStop = false;
                    Controls.Add(btn[i, j]);
                }
        }

        void GenerateMap(int x, int y, int mines)
        {
            Random rand = new Random();
            List<int> coordx = new List<int>();
            List<int> coordy = new List<int>();

            while(mines > 0)
            {
                coordx.Clear();
                coordy.Clear();

                for (int i = 1; i <= x; i++)
                    for (int j = 1; j <= y; j++)
                        if(btn_prop[i,j] != -1)
                        {
                            coordx.Add(i);
                            coordy.Add(j);
                        }

                int randNum = rand.Next(0, coordx.Count);
                btn_prop[coordx[randNum], coordy[randNum]] = -1;
                saved_btn_prop[coordx[randNum], coordy[randNum]] = -1;
                mines--;
            }
        }

        void StartGame()
        {
            // play background music in loop
            SoundPlayer audio = new SoundPlayer(Minesweeper.Properties.Resources.bgmusic); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();

            // selection of diffculty level based on users choice
            switch (difficulty.Text) 
            {
                case "Easy":
                    mines = (int)(height * width * easyCoef); // percentage of mines based on total number of grids
                    break;

                case "Medium":
                    mines = (int)(height * width * mediumCoef);
                    break;

                case "Hard":
                    mines = (int)(height * width * hardCoef);
                    break;
            }

            flags = mines;
            gameover = false;

            gameProgress.Value = 0;
            gameProgress.Maximum = height * width - mines;

            timer.Start(); // starts the timer as soon as game starts
            seconds = 0;
            minutes = 0;

            remainingFlags.Text = "Flags: " + flags;
            score.Text = "Score: " + 0;

            if(firstPlay)
                CreateButtons(width, height);

            GenerateMap(width, height, mines);
            SetMapNumbers(width, height);
            
        }

        // This funtion resets the grid in game.
        void ResetGame(int x, int y)
        {
            for(int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                {
                    btn[i, j].Enabled = true;
                    btn[i, j].Text = "";
                    btn[i, j].BackgroundImage = null;
                    btn_prop[i, j] = 0;
                    saved_btn_prop[i, j] = 0;
                }
        }

        // This funtion allows to catch wrong input values and give warning to the user
        void Warnings(int id)
        {
            switch (id)
            {
                case 1:
                    MessageBox.Show("Empty Fields! please add width height and select difficulty level");
                    break;
                case 2:
                    MessageBox.Show("Wrong Input! please input numbers only");
                    break;

            }
        }

        bool hasLetters(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!Char.IsDigit(s, i))
                    return true;

            return false;
        }

        // This funtion check if the fields on game menu are correct if not then it shows warning message.
        bool CorrectFields()
        {
            bool result = true;

            if (heightBox.Text == "" || widthBox.Text == "" || difficulty.Text == "")
            {
                Warnings(1);
                result = false;
            }
            else
            if (heightBox.Text != "" && widthBox.Text != "" && difficulty.Text != "")
            {
                if (hasLetters(heightBox.Text) || hasLetters(widthBox.Text))
                {
                    Warnings(2);
                    result = false;
                }
            }

            return result;
        }

        /* This funtion allows us to set custom height and width of tiles/grid
         * Limits the maximum and minimum number of columns and rows.
         */
        void SetDimensions()
        {
            height = int.Parse(heightBox.Text);
            width = int.Parse(widthBox.Text);
            // makes sure that maximum height/rows is 25
            if (height > 25)
                height = 25;
            else
                if (height < 5)
                    height = 5; // makes sure that minimum number of rows are 5
            // makes sure that maximum columns are 40
            if (width > 40)
                width = 40;
            else
                if (width < 5)
                    width = 5; // makes sure that minimum number of columns are 5

            heightBox.Text = height.ToString();
            widthBox.Text = width.ToString();

        }

        // This funtion add margin to table 
        void TableMargins(int x, int y)
        {
            start_x = (this.Size.Width - (width + 2) * distance_between) / 2; // horizontal
            start_y = (this.Size.Height - (height + 2) * distance_between) / 2; // vertical
        }

        // background photo on top game menu
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // This funtion restarts the game from start at any point in game when we click the restart button
        private void restartBtn_Click(object sender, EventArgs e)
        {
            if (CorrectFields())
            {

                SetDimensions(); // calls for SetDimensions method 
                TableMargins(height, width);

                if (firstPlay)
                {
                    StartGame();
                    firstPlay = false;

                    widthBox.Enabled = false;
                    heightBox.Enabled = false;
                }
                else
                    if (!firstPlay)
                {
                    ResetGame(width, height);
                    StartGame();
                }
            }
        }

        // Label for Difficulty level
        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        // This funtion quits the game window when user clicks on Quit button in game menu
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This funtion quits the game window when user clicks on Exit button on top menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This funtion shows about information when user clicks on about button on menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Minesweeper created in C# by Sarah Small & Zohaib Tarar", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This funtion shows game rules when user clicks on help/rules button
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("============= Difficulty Level =============" + "\n\n Basic = 10% Mines \n\n Intermediate = 20% Mines \n\n Advanced = 30% Mines", "Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This funtion shows instructions on how to play game when user clicks on help/how to play button
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Click any square on the playing field.You can uncover a square by clicking it." +
                "If you uncover a mine, you lose the game. If a number appears on a square, it indicates how many mines " +
                "are in the eight squares that surround the numbered one.", "How to Play", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

        // This funtion shows instructions on how to start game when user clicks on help/how to start button
        private void howToStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("1. First enter the number of columns and rows you want in height and width field.\n\n" +
                "2. Select the difficulty level from drop down menu \n\n" +
                "3. Click Play button", "How to Start", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Dropdown menu for difficulty level
        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Score label
        private void score_Click(object sender, EventArgs e)
        {

        }

        // Time label
        private void time_Click(object sender, EventArgs e)
        {

        }

        // minutes box for time
        private void minutesBox_TextChanged(object sender, EventArgs e)
        {

        }

        // seconds box for time
        private void secondsBox_TextChanged(object sender, EventArgs e)
        {

        }

        // remainign flags label
        private void remainingFlags_Click(object sender, EventArgs e)
        {

        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {

        }

        // max label for width 
        private void label7_Click(object sender, EventArgs e)
        {

        }

        // game progress bar at bottom
        private void gameProgress_Click(object sender, EventArgs e)
        {

        }

        // This funtion runs when someone click button on play button
        private void Play_Click(object sender, EventArgs e)
        {

            if (CorrectFields())
            {

                SetDimensions();
                TableMargins(height, width);

                if (firstPlay)
                {
                    StartGame(); // call for StartGame funtion
                    firstPlay = false;

                    widthBox.Enabled = false;
                    heightBox.Enabled = false;
                }
                else
                    if (!firstPlay)
                    {
                        ResetGame(width, height); // calls for resetGame funtion
                        StartGame();
                    }
            }

        }

        // this funtion starts the timer
        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            // shows minutes and seconds in their boxes
            secondsBox.Text = seconds.ToString();
            minutesBox.Text = minutes.ToString();
        }

    }
}
