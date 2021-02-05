using System;
using System.Windows.Forms;
using Sudoroyal.Models;

namespace Sudoroyal.Views.Popup
{
    public partial class Warning : Form
    {
        // -- Model
        private GUI gui = new GUI();

        public Warning()
        {
            InitializeComponent();
        }

        // -- Hover
        private void btnSwitch_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnSwitch, btnSwitchActive);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnCancel, btnCancelActive);
        }

        // -- Leave
        private void btnSwitchActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnSwitchActive, btnSwitch);
        }

        private void btnCancelActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnCancelActive, btnCancel);
        }

        // -- Click
        private void btnSwitchActive_Click(object sender, EventArgs e)
        {
            // -- Declaration
            Engine engine = new Engine();
            dynamic boardClass = engine.getBoardClass(); // To get the class from the Python file.


            boardClass.change_size(boardClass.get_size()); // To change the board size.
            closeBoardPopups(); // To close both board and warning popups.
        }

        private void btnCancelActive_Click(object sender, EventArgs e)
        {
            closeBoardPopups();
        }

        // To close warning and board popups.
        private void closeBoardPopups()
        {
            // To hide the two modals.
            Hide(); // To hide the warning popup.
            ((Board)Application.OpenForms["Board"]).Hide(); // '(Board)Applicant.OpenForms["Board"]' finds the opened board popup.

            // To show the title screen.
            new Title().Show();
        }
    }
}