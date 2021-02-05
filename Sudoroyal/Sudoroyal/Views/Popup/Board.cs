using System;
using System.Drawing;
using System.Windows.Forms;
using Sudoroyal.Models;

namespace Sudoroyal.Views.Popup
{
    public partial class Board : Form
    {
        // -- Model
        private GUI gui = new GUI();

        public Board()
        {
            InitializeComponent();
        }

        // -- Hover
        private void btnKing_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnKing, btnKingActive);
            lblKing.ForeColor = gui.getYellowColor(); // To change the color of the text.
        }

        private void btnQueen_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnQueen, btnQueenActive);
            lblQueen.ForeColor = gui.getYellowColor(); // To change the color of the text.
        }

        // -- Leave
        private void btnKingActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnKingActive, btnKing);
            lblKing.ForeColor = gui.getWhiteColor(); // To revert the color.
        }

        private void btnQueenActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnQueenActive, btnQueen);
            lblQueen.ForeColor = gui.getWhiteColor(); // To revert the color.
        }

        // -- Click
        private void btnKingActive_Click(object sender, EventArgs e)
        {
            new Warning().ShowDialog();
        }

        private void btnQueenActive_Click(object sender, EventArgs e)
        {
            new Warning().ShowDialog();
        }

        // -- Form Show
        private void Board_Shown(object sender, EventArgs e)
        {
            // To display the board size.
            Engine engine = new Engine();
            int boardSize = engine.getBoardClass().get_size();

            // To switch the states of the buttons.
            if (boardSize == 9)
            {
                // To make the icons visible.
                btnKingChosen.Visible = btnQueen.Visible = true;

                // To change the label colors.
                lblKing.ForeColor = gui.getYellowColor();
                lblQueen.ForeColor = gui.getWhiteColor();
            }
                
            else if (boardSize == 16)
            {
                // To make the icons visible.
                btnQueenChosen.Visible = btnKing.Visible = true;

                // To change the label colors.
                lblQueen.ForeColor = gui.getYellowColor();
                lblKing.ForeColor = gui.getWhiteColor();
            }
        }

        // -- Form Load
        private void Board_Load(object sender, EventArgs e)
        {
            gui.embedResource(Properties.Resources.GOTHAM_BLACK); // To embed the font resources.
            lblKing.Font = lblQueen.Font = gui.setFont(0, 14.0F); // To set the font.
        }

        // -- Form Close
        private void Board_FormClosed(object sender, FormClosedEventArgs e)
        {
            gui.changeViews(new Form[] { this, new Title() }, new bool[] { false, true });
        }
    }
}