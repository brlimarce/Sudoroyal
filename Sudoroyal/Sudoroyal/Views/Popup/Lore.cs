using System.Windows.Forms;
using Sudoroyal.Models;

namespace Sudoroyal.Views.Popup
{
    public partial class Lore : Form
    {
        // -- Models
        private Engine engine = new Engine();
        private GUI gui = new GUI();

        public Lore()
        {
            InitializeComponent();
        }

        // -- Hover
        private void btnAccept_MouseHover(object sender, System.EventArgs e)
        {
            gui.switchState(btnAccept, btnAcceptActive);
        }

        // -- Leave
        private void btnAcceptActive_MouseLeave(object sender, System.EventArgs e)
        {
            gui.switchState(btnAcceptActive, btnAccept);
        }

        // -- Click
        private void btnAcceptActive_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}