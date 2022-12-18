﻿using System;
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
    public partial class Form2 : Form
    {
        Difficulty difficultyEasy = new Easy();
        Difficulty difficultyMedium = new Medium();
        Difficulty difficultyHard = new Hard();

        public Form2()
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
                Form1 f1 = new Form1(difficultyEasy.lives);
                f1.UserName = txtUserName.Text;
                f1.LevelName = difficultyEasy.level;
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
                Form1 f1 = new Form1(difficultyMedium.lives);
                f1.UserName = txtUserName.Text;
                f1.LevelName = difficultyMedium.level;
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
                Form1 f1 = new Form1(difficultyHard.lives);
                f1.UserName = txtUserName.Text;
                f1.LevelName = difficultyHard.level;
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
