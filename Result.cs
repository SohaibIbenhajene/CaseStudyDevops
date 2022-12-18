using Devops_CaseStudy_Sohaib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy
{
    public partial class Result : Form
    {
        public Result(string username, string level, int time)
        {
            InitializeComponent();
            lblUserName.Text = "Player: " + username;
            lblLevel.Text = "Level: " + level;
            lblTime.Text = "Time: " + time.ToString();

            using (SQLiteConnection conn = Program.CreateConnection())
            {
                Program.InsertData(conn, username, level, time);
                conn.Close();
            }
        }

        private void Result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Result_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = Program.CreateConnection())
            {
                lblUserNameEasy.Text = "Player: " + Program.ReadPlayer(conn, "Easy");
                lblTimeEasy.Text = "Time: " + Program.ReadTime(conn, "Easy");
                lblUserNameMedium.Text = "Player: " + Program.ReadPlayer(conn, "Medium");
                lblTimeMedium.Text = "Time: " + Program.ReadTime(conn, "Medium");
                lblUserNameHard.Text = "Player: " + Program.ReadPlayer(conn, "Hard");
                lblTimeHard.Text = "Time: " + Program.ReadTime(conn, "Hard");
                conn.Close();
            }
        }
    }
}
