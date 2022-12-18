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
    public partial class Start : Form
    {
        Difficulty difficultyEasy = new Easy();
        Difficulty difficultyMedium = new Medium();
        Difficulty difficultyHard = new Hard();

        public Start()
        {
            InitializeComponent();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                Game f1 = new Game(difficultyEasy.lives, txtUserName.Text, difficultyEasy.level);
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have to enter a name to play the game!", "Choose a name!");
            }
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                Game f1 = new Game(difficultyMedium.lives, txtUserName.Text, difficultyMedium.level);
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have to enter a name to play the game!", "Choose a name!");
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                Game f1 = new Game(difficultyHard.lives, txtUserName.Text, difficultyHard.level);
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have to enter a name to play the game!", "Choose a name!");
            }
        }
    }
}
