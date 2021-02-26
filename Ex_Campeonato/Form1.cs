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
    }
}
