using System;
using System.Linq;
using System.Windows.Forms;
using Sudoroyal.Models;
using Sudoroyal.Views.Popup;

namespace Sudoroyal.Views.Screen
{
    public partial class King9 : Form
    {
        // -- Models
        private Engine engine = new Engine();
        private GUI gui = new GUI();

        public King9()
        {
            InitializeComponent();
        }

        // -- Hover
        private void btnGameMenu_MouseHover(object sender, EventArgs e)
        {
            // To make the icons visible.
            gui.switchState(btnGameMenu, btnGameMenuActive);
            lblGameMenu.Visible = true;
        }

        private void btnQuit_MouseHover(object sender, EventArgs e)
        {
            // To make the icons visible.
            gui.switchState(btnQuit, btnQuitActive);
            lblQuit.Visible = true;
        }

        private void btnLore_MouseHover(object sender, EventArgs e)
        {
            // To make the icons visible.
            gui.switchState(btnLore, btnLoreActive);
            lblLore.Visible = true;
        }

        // -- Leave
        private void btnGameMenuActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnGameMenuActive, btnGameMenu);
            lblGameMenu.Visible = false;
        }

        private void btnQuitActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnQuitActive, btnQuit);
            lblQuit.Visible = false;
        }

        private void btnLoreActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnLoreActive, btnLore);
            lblLore.Visible = false;
        }

        // -- Click
        private void btnGameMenuActive_Click(object sender, EventArgs e)
        {
            // To display the title screen and progress modal.
            gui.changeViews(new Form[] { this, new Title() }, new bool[] { false, true });
            new ProgressMenu().ShowDialog();
        }

        private void btnQuitActive_Click(object sender, EventArgs e)
        {
            new ProgressQuit().ShowDialog();
        }

        private void btnLoreActive_Click(object sender, EventArgs e)
        {
            new Lore().ShowDialog();
        }

        // -- Form Show
        private void King9_Shown(object sender, EventArgs e)
        {
            // To check if the current game exists.
            if (engine.getFileClass().check_existing_game())
                gui.displayBoard(this, true);
            else
                gui.displayBoard(this, false);
        }

        // -- Form Close
        private void King9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // To exit the game.
        }

        // -- Timer Tick
        private void loadingTick_Tick(object sender, EventArgs e)
        {
            loadingControl.Hide(); // To hide the loading screen.
        }
    }
}