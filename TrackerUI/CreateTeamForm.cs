using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        /// <summary>
        /// List of Private Variables
        /// </summary>
        private List<PersonModel> AvailableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> SelectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingform;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            //CreateSampleData();

            WireupLists();

            callingform = caller;
        }

        //Sample Data for team member dropdown for testing purposes
        private void CreateSampleData()
        {
            AvailableTeamMembers.Add(new PersonModel { FirstName = "Jonathan", LastName = "Joestar" });
            AvailableTeamMembers.Add(new PersonModel { FirstName = "Lebron", LastName = "Smith" });

            SelectedTeamMembers.Add(new PersonModel { FirstName = "Daniel", LastName = "Ahmed" });
            SelectedTeamMembers.Add(new PersonModel { FirstName = "James", LastName = "Whatson" });
        }


        //shows the full name of the members in the list box
        private void WireupLists()
        {
            //TODO - Look into a method of databinding properly

            SelectTeamMemberDropdown.DataSource = null;

            SelectTeamMemberDropdown.DataSource = AvailableTeamMembers;
            SelectTeamMemberDropdown.DisplayMember = "FullName";

            TeamMemberslistbox.DataSource = null;

            TeamMemberslistbox.DataSource = SelectedTeamMembers;
            TeamMemberslistbox.DisplayMember = "FullName";
        }

        //Creates a member for a team
        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            //takes the fields in the member form,
            //creates a record from the data collected from the form
            //once the data is colelcted the form will reset itself and will show blank fields.

            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = EmailValue.Text;
                p.TelephoneNumber = TelephoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                SelectedTeamMembers.Add(p);

                WireupLists();

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                TelephoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all fields.");
            }
        }

        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (EmailValue.Text.Length == 0)
            {
                return false;
            }

            if (TelephoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }


        //the Add Member button put the selected record from the
        //selected team member dropdown list
        //to the team member listbox 
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMemberDropdown.SelectedItem;

            if (p != null)
            {
                AvailableTeamMembers.Remove(p);
                SelectedTeamMembers.Add(p);

                WireupLists();
            }

        }

        //This button removes a selected a member of a team from the listbox
        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMemberslistbox.SelectedItem;

            if (p != null)
            {
                SelectedTeamMembers.Remove(p);
                AvailableTeamMembers.Add(p);

                WireupLists();
            }

        }

        //once a value is added in the team name value label and the user presses add member 
        //the form will refresh itself and the data will be saved into the database or Text file
        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = SelectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingform.TeamComplete(t);

            this.Close();         

        }
    }
}