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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllLines("Player.txt", new string[] { txtPlayerName.Text });
            txtPlayerName.Text = "";
            MessageBox.Show("New player added");
            ShowPlayerData();
          
        }
        void ShowPlayerData()
        {
              
            lstPlayer.Items.Clear(); 
            foreach (string line in File.ReadLines(@"Player.txt", Encoding.UTF8))
            {
                // process the line
                lstPlayer.Items.Add(line);
            }
            lstPlayer.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSubmitTeams_Click(object sender, EventArgs e)
        {
            {
                File.AppendAllLines("Player.txt", new string[] { txtTeamsName.Text });
                txtTeamsName.Text = "";
                MessageBox.Show("New player added");
                ShowPlayerData();

            }
            void ShowPlayerData()
            {

                lstTeams.Items.Clear();
                foreach (string line in File.ReadLines(@"Player.txt", Encoding.UTF8))
                {
                    // process the line
                    lstTeams.Items.Add(line);
                }
                lstTeams.Show();
            }
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            score scr = new score();
            scr.Show();
        }
    } 
}
