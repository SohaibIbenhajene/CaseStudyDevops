using CaseStudy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devops_CaseStudy_Sohaib
{
    public partial class Form1 : Form
    {
        Point startLocation;
        int countDown;
        int lives;
        string player;
        string difficultyLevel;

        public Form1(int startlives, string username, string level)
        {
            InitializeComponent();
            lives = startlives;
            difficultyLevel = level;
            player = username;
            InitializeGame();
        }

        private void InitializeGame()
        {
            GameTimer.Start();
            startLocation = new Point(140, 217);
            Cursor.Position = PointToScreen(startLocation);
            countDown = 0;
            lblTimer.Text = "Time: " + countDown.ToString();
            lblLives.Text = "Lives: " + lives.ToString();
            lblUserName.Text = "Player: " + player.Trim();
            lblLevel.Text = "Level: " + difficultyLevel.Trim();
            countDown++;
        }

        private void LabyrinthWall_MouseEnter(object sender, EventArgs e)
        {
            startLocation = new Point(140, 217);
            Cursor.Position = PointToScreen(startLocation);
            lives--;
            lblLives.Text = "Lives: " + lives.ToString();
            if (lives <= 0)
            {
                GameTimer.Stop();
                MessageBox.Show("You lose!", "Game Lost");
                Application.Exit();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Time: " + countDown.ToString();
            countDown++;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            GameTimer.Stop();
            MessageBox.Show("You win!", "Game Won");
            Result result = new Result(player, difficultyLevel, countDown);
            result.Show();
            this.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
