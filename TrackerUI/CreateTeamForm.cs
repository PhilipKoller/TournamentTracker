using System;
using TrackerLibrary.Models;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameTextBox.Text;
                p.LastName = lastNameTextBox.Text;
                p.EmailAddress = emailTextBox.Text;
                p.CellPhoneNumber = cellPhoneTextBox.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                cellPhoneTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameTextBox.Text.Length == 0)
            {
                return false;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                return false;
            }
            if (emailTextBox.Text.Length == 0)
            {
                return false;
            }
            if (cellPhoneTextBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {

        }
    }
}
