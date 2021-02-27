using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Campeonato
{
    public partial class Form1 : Form
    {
        Championship championship = new Championship();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<Clube> clubes = new List<Clube>
            {
                new Clube("Sporting"),
                new Clube("Porto"),
                new Clube("Braga"),
                new Clube("Paços Ferreira"),
                new Clube("Benfica"),
                new Clube("Guimaraes"),
                new Clube("Moreirense"),
                new Clube("Santa Clara"),
                new Clube("Rio Ave"),
                new Clube("Belenenses"),
                new Clube("Nacional"),
                new Clube("Tondela"),
                new Clube("Portimonense"),
                new Clube("Gil Vicente"),
                new Clube("Farense"),
                new Clube("Famalicao"),
                new Clube("Boavista"),
                new Clube("Maritimo")
            };
            championship.SetTeams(clubes);
            championship.GenerateAllMatchWeek();
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            int numberOfGameWeeks = championship.GetNumberOfGameWeeks();
            for (int i = 0; i < numberOfGameWeeks; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                btn.Click += (sender, EventArgs)=> { populateWeekList(int.Parse(btn.Tag.ToString()) + 1); };
                btn.Text = "Week nº " + (i + 1);
                if (i< numberOfGameWeeks/2)
                {
                    btn.BackColor = Color.FromArgb(255, 255, 204);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(255, 153, 255);
                }
                WeekGamesContainer.Controls.Add(btn);
            }
        }

        private void populateWeekList(int weekNumber)
        {
            lstWeekGames.Items.Clear();
            List<Match> matches = championship.GetGamesFromMatchWeek(weekNumber);

            for (int i = 0; i < matches.Count; i++)
            {
                lstWeekGames.Items.Add(matches[i].homeTeam + " - " + matches[i].awayTeam);
            }
        }

        private void btnWeek1_Click(object sender, EventArgs e)
        {
            populateWeekList(1);
        }

        private void btnWeek2_Click(object sender, EventArgs e)
        {
            populateWeekList(2);
        }

        private void btnWeek3_Click(object sender, EventArgs e)
        {
            populateWeekList(3);
        }

        private void btnWeek4_Click(object sender, EventArgs e)
        {
            populateWeekList(4);
        }

        private void btnWeek17_Click(object sender, EventArgs e)
        {
            populateWeekList(17);
        }

        private void btnWeek18_Click(object sender, EventArgs e)
        {
            populateWeekList(18);
        }
    }
}
