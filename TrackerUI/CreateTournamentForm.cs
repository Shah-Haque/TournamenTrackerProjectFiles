using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        /// <summary>
        /// Variables
        /// </summary>
        List<TeamModel> AvailableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> SelectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        /// <summary>
        /// This Wires up the selectteam dropdown and the Teams listbox
        /// </summary>
        private void WireUpLists()
        {
            SelectTeamDropdown.DataSource = null;
            SelectTeamDropdown.DataSource = AvailableTeams;
            SelectTeamDropdown.DisplayMember = "TeamName";

            TournamentTeamslistbox.DataSource = null;
            TournamentTeamslistbox.DataSource = SelectedTeams;
            TournamentTeamslistbox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }
        /// <summary>
        /// This Adds the team in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropdown.SelectedItem;

            if (t !=  null)
            {
                AvailableTeams.Remove(t);
                SelectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //calls the createprizeform
            CreatePrizeForm Frm = new CreatePrizeForm(this);
            Frm.Show();
        }

        //gets back from the form a prizemodel
        public void prizeComplete(PrizeModel model)
        {
            //take the prizemodel and put into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            SelectedTeams.Add(model);
            WireUpLists();
        }

        private void CreateNewTeamLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm Frm = new CreateTeamForm(this);
            Frm.Show();
        }

        private void RemoveSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel T = (TeamModel)TournamentTeamslistbox.SelectedItem;

            if (T != null)
            {
                SelectedTeams.Remove(T);
                AvailableTeams.Add(T);

                WireUpLists();
            }
        }

        private void RemoveSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel P = (PrizeModel)PrizesListBox.SelectedItem;

            if (P != null)
            {
                selectedPrizes.Remove(P);
             
                WireUpLists();
            }
        }

        private void Create_TournamentButton_Click(object sender, EventArgs e)
        {
            // Validate Data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(EntryFeeValue.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show
                    (
                         "You need to enter a valied entry fee",
                         "Invalid Fee", MessageBoxButtons.OK,
                          MessageBoxIcon.Error
                    );
                    return;
            }
            // this create a tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TournamentNameValue.Text;
            tm.EntryFee = fee;

            // Prizes that are selected from the PrizeModel will be added into the TournamentModel
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = SelectedTeams;

            //  Wire our matchups
           TournamentLogic.CreateRounds(tm);

            //  Order our list Randomly
            //  Check if it is big enough -  if not, add in byes - 2^2^2^2  -  2^4
            //  Create our First round of matchups
            //  create every round after that  -  8 matchups - 4 matchups -  2 matchups - 1 matchups

            // Creates a tournament entry
            // Creates all of the prizes entries
            // creates all of the team entries
           GlobalConfig.Connection.createTournament(tm);

           tm.AlertUsersToNewRound();

           TournnamentViewerForm frm = new TournnamentViewerForm(tm);
           frm.Show();
           this.Close();
        }
    }
}