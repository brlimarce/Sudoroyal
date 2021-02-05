using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoroyal.Views.Screen
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        // -- Timer Tick
        private void splashTick_Tick(object sender, EventArgs e)
        {
            splashTick.Stop(); // To stop the timer.
            Close(); // To close the splash screen and redirect to the title screen.
        }
    }
}
