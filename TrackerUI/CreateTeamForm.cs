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
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
           
        }
        private bool ValidateForm()
        {
            if (firstNameTextBox.Text == "")
            {
                return false;
            }
            if (lastNameTextBox.Text == "")
            {
                return false;
            }
            if (emailTextBox.Text == "")
            {
                return false;
            }
            if (cellPhoneTextBox.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
