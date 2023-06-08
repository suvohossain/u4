using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class score : Form
    {
        public score()
        {
            InitializeComponent();
        }

        private void txtTeam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTeamScore_Click(object sender, EventArgs e)
        {
            {
                int eventscore1;
                int eventscore2;
                int eventscore3;
                int eventscore4;
                int TotalScore = 0;

                eventscore1 = Convert.ToInt32(txtScore1.Text);
                eventscore2 = Convert.ToInt32(txtScore2.Text);
                eventscore3 = Convert.ToInt32(txtScore3.Text);
                eventscore4 = Convert.ToInt32(txtScore4.Text);

                TotalScore = eventscore1 + eventscore2 + eventscore3 + eventscore4;
                lblTotalScore.Text = Convert.ToString(TotalScore);

                File.AppendAllLines("TeamScore.txt", new string[] { txtTeam.Text + " : " + lblTotalScore.Text });

                MessageBox.Show("Total Team Score is added");
                ShowTeamScoreData();

            }

            void ShowTeamScoreData()
            {
                lstTeamScore.Items.Clear();
                foreach (string line in File.ReadLines(@"TeamScore.txt", Encoding.UTF8))
                {
                    // process the line
                    lstTeamScore.Items.Add(line);
                }
                lstTeamScore.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
