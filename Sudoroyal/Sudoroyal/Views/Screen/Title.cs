using System;
using System.Windows.Forms;
using Sudoroyal.Models;
using Sudoroyal.Views.Popup;

namespace Sudoroyal
{
    public partial class Title : Form
    {
        // -- Models
        private Engine engine = new Engine();
        private GUI gui = new GUI();

        public Title()
        {
            InitializeComponent();            
        }

        // -- Hover
        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnNew, btnNewActive);
        }

        private void btnContinue_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnContinue, btnContinueActive);
        }

        private void btnBoard_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnBoard, btnBoardActive);
        }


        // -- Leave
        private void btnNewActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnNewActive, btnNew);
        }

        private void btnContinueActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnContinueActive, btnContinue);
        }

        private void btnBoardActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnBoardActive, btnBoard);
        }

        // -- Click
        private void btnNewActive_Click(object sender, EventArgs e)
        {
            gui.getNewGame(this);
        }

        private void btnContinueActive_Click(object sender, EventArgs e)
        {
            // To go to the current game.
            gui.changeViews(new Form[] { this, gui.getBoard(engine.getBoardClass().get_size()) }, new bool[] { false, true });
        }

        private void btnBoardActive_Click(object sender, EventArgs e)
        {
            new Board().ShowDialog(); // To show the board popup.
            Hide(); // To hide the title screen.
        }

        // -- Form Show
        private void Title_Shown(object sender, EventArgs e)
        {
            // To check if the board game exists.
            if (engine.getFileClass().check_existing_game())
                gui.switchState(btnContinueDisabled, btnContinue);
            else
                gui.switchState(btnContinue, btnContinueDisabled);
        }

        // -- Form Close
        private void Title_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}