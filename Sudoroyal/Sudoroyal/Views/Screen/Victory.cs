using System;
using System.Windows.Forms;
using Sudoroyal.Models;

namespace Sudoroyal.Views.Popup
{
    public partial class Victory : Form
    {
        // -- Models
        private Engine engine = new Engine();
        private GUI gui = new GUI();

        public Victory()
        {
            InitializeComponent();
        }

        // -- Hover
        private void btnTry_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnTry, btnTryActive);
        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnMenu, btnMenuActive);
        }

        // -- Leave
        private void btnTryActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnTryActive, btnTry);
        }

        private void btnMenuActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnMenuActive, btnMenu);
        }

        // -- Click
        private void btnTryActive_Click(object sender, EventArgs e)
        {
            // To go back to the game proper.
            gui.getNewGame(this);
        }

        private void btnMenuActive_Click(object sender, EventArgs e)
        {
            // To reset the current game file.
            engine.getFileClass().reset_game(engine.getBoardClass().get_size());

            // To display the title screen.
            gui.changeViews(new Form[] { this, new Title() }, new bool[] { false, true });
        }
    }
}
