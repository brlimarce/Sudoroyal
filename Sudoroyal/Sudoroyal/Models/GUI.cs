using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Sudoroyal.Views.Popup;
using Sudoroyal.Views.Screen;

namespace Sudoroyal.Models
{
    /* -- GUI
     * To manipulate the components of each screen and modal. */
    public class GUI
    {
        // -- Properties
        private Engine engine = new Engine();
        private string lastInput { get; set; }
        private Control activeControl { get; set; } // To set the focus of the text box.

        // Colors
        private Color errorColor = Color.FromArgb(255, 58, 47);
        private Color presetColor = Color.FromArgb(136, 48, 78);
        private Color inputColor = Color.FromArgb(82, 37, 70);

        private Color whiteColor = Color.FromArgb(254, 254, 254);
        private Color yellowColor = Color.FromArgb(255, 201, 60);

        // Fonts
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr firstFont, uint secondFont, IntPtr pointer, [In] ref uint pcFonts);
        private static PrivateFontCollection fonts = new PrivateFontCollection();

        /* -- Methods
         * To get the white color. */
        public Color getWhiteColor()
        {
            return whiteColor;
        }

        // To get the yellow color.
        public Color getYellowColor()
        {
            return yellowColor;
        }

        // To embed the resource.
        public void embedResource(byte[] directory)
        {
            // Store the font's file's directory into bytes
            byte[] data = directory;

            // Creates an unsafe memory block for the font data
            IntPtr fontPtr = Marshal.AllocCoTaskMem(data.Length);

            // Copies the bytes to the unsafe memory block
            Marshal.Copy(data, 0, fontPtr, data.Length);

            // Initializes a uint - This is used for long bytes of data.
            uint placeholder = 0;

            // Adds the bytes and font data into the memory
            fonts.AddMemoryFont(fontPtr, directory.Length);

            /* Adds the bytes and font data to the system and clears the font data
             * The bytes of the data is passed on to the placeholder. */
            AddFontMemResourceEx(fontPtr, (uint)directory.Length, IntPtr.Zero, ref placeholder);
        }

        // To set the font style.
        public Font setFont(int index, float size)
        {
            Font font = new Font(fonts.Families[index], size); // Creates a new font with an assigned size
            return font; // Returns the value in 'Font'
        }

        // To switch the component state.
        public void switchState(PictureBox oldState, PictureBox newState)
        {
            // To change the visibility of the controls.
            oldState.Hide();
            newState.Show();
        }

        // To change the visibility of each view.
        public void changeViews(Form[] views, bool[] states)
        {
            // To show or hide each view.
            for (int i = 0; i < views.Length; i++)
            {
                if (states[i])
                    views[i].Show();
                else
                    views[i].Hide();
            }
        }

        // To get the board page, depending on the size of the board.
        public Form getBoard(int boardSize)
        {
            // To get the board view.
            Form board = new Form();

            // To get the board page.
            if (boardSize == 9)
                board = new King9();
            if (boardSize == 16)
                board = new Queen16();
            return board;
        }

        /* To convert a Python list to a C# array.
         * For the default game proper. */
        public string[] getRowArray(string boardFile, string boardType, int rowIndex)
        {
            // To get the board class.
            dynamic boardClass = engine.getBoardClass();

            // To convert the wrapper into a C# list.
            IList<object> row = (IList<object>)boardClass.get_row(boardFile, boardType, rowIndex); // Python wrapper.
            List<string> rowList = new List<string>(); // C# list.

            // To append each object from the wrapper to the list.
            foreach (object cell in row)
                rowList.Add(cell.ToString());
            return rowList.ToArray(); // To return an array.
        }

        // For the list of errors.
        public string[] getRowArray(string boardType, int boardSize, string rowCell, string colCell)
        {
            // To get the board class.
            dynamic boardClass = engine.getBoardClass();

            // To convert the wrapper into a C# list.
            IList<object> row = (IList<object>)boardClass.check_board(boardType, boardSize, rowCell, colCell); // Python wrapper.
            List<string> rowList = new List<string>(); // C# list.

            // To append each object from the wrapper to the list.
            foreach (object cell in row)
                rowList.Add(cell.ToString());
            return rowList.ToArray(); // To return an array.
        }

        // To display the board in the game.
        public void displayBoard(Form form, bool isCurrent)
        {
            /* -- Declaration
             * Python classes */
            dynamic boardClass = engine.getBoardClass();
            dynamic fileClass = engine.getFileClass();

            // Board properties
            int boardSize = boardClass.get_size();
            string boardType = boardClass.get_type();

            // Filename
            string fileName = String.Empty;

            // To set the file path.
            if (isCurrent)
                fileName = fileClass.current_game_file;
            else
                fileName = fileClass.get_board_file(boardSize);

            // To embed the font resources.
            embedResource(Properties.Resources.GOTHAM_BLACK);

            // To display the board row by row.
            for (int i = 0; i < boardSize; i++)
            {
                // To get the row.
                string[] rowArray = getRowArray(fileName, boardType, i);
                for (int j = 0; j < boardSize; j++)
                {
                    // To get the specific cell.
                    char rowCell = (char)(i + boardClass.lower_bound);
                    char colCell = (char)(j + boardClass.lower_bound);
                    string cellName = rowCell.ToString() + colCell.ToString();

                    // To format the searched control.
                    TextBox tbxCell = form.Controls.Find(cellName, true).FirstOrDefault() as TextBox;
                    tbxCell.Name = rowCell.ToString() + boardClass.split_fi + colCell.ToString();

                    // To set the font based on board size.
                    if (boardSize == 9)
                        tbxCell.Font = setFont(0, 24.0F);
                    else if (boardSize == 16)
                        tbxCell.Font = setFont(0, 15.0F);

                    // To split the element.
                    string[] element = rowArray[j].Split(boardClass.split_fi.ToCharArray()[0]);

                    // To format the text box, depending on the element's FI.
                    if (element[0] == boardClass.preset_fi)
                    {
                        tbxCell.Text = element[1]; // To display the value.
                        tbxCell.ReadOnly = true; // To make the text box inaccessible.
                        tbxCell.Cursor = Cursors.Default; // To change the cursor to an arrow.

                        // To format the text box's colors.
                        tbxCell.BackColor = presetColor;
                        tbxCell.ForeColor = whiteColor;
                    }

                    else
                    {
                        // To check if the element isn't blank.
                        if (element[0] == boardClass.error_fi || element[0] == boardClass.input_fi)
                        {
                            // To display the value.
                            tbxCell.Text = element[1];

                            // To format the text box's colors.
                            if (element[0] == boardClass.input_fi)
                            {
                                tbxCell.BackColor = whiteColor;
                                tbxCell.ForeColor = inputColor;
                            }

                            else
                            {
                                tbxCell.BackColor = errorColor;
                                tbxCell.ForeColor = whiteColor;
                            }
                        }

                        else
                        {
                            // To format the colors.
                            tbxCell.BackColor = whiteColor;
                            tbxCell.ForeColor = inputColor;
                        }

                        // To add event listeners.
                        tbxCell.GotFocus += new EventHandler(setLastInput);
                        tbxCell.Leave += new EventHandler(getLastInput);
                        tbxCell.TextChanged += new EventHandler(checkInput);
                    }

                    // To set the text box as the active control if it is blank.
                    if (activeControl == null && tbxCell.Text == String.Empty)
                        activeControl = tbxCell;
                }
            }

            // To set the text box focus on the blank.
            form.ActiveControl = (Control)activeControl;
        }

        /* -- Event Listeners
         * To get the last input from the text box. */
        private void getLastInput(object sender, EventArgs e)
        {
            TextBox tbxCell = (TextBox)sender;
            tbxCell.Text = lastInput;
        }

        // To set the last input from the previous text box.
        private void setLastInput(object sender, EventArgs e)
        {
            TextBox tbxCell = (TextBox)sender;
            lastInput = tbxCell.Text;
        }

        // To check if the input is distinct.
        private void checkInput(object sender, EventArgs e)
        {
            /* -- Declaration
             * Python classes */
            dynamic boardClass = engine.getBoardClass();
            dynamic fileClass = engine.getFileClass();

            // Board properties
            int boardSize = boardClass.get_size();
            string boardType = boardClass.get_type();

            // To find the text box and form.
            TextBox tbxAnswer = (TextBox)sender;
            string tbxAnswerName = tbxAnswer.Name;

            Form form = tbxAnswer.FindForm();

            // To validate the input.
            if (boardClass.validate_input(tbxAnswer.Text, boardSize) == false)
                tbxAnswer.Text = lastInput;
            else
            {
                // To switch the current cell with the user input.
                string[] cell = tbxAnswerName.Split(boardClass.split_fi.ToCharArray()[0]);
                fileClass.change_cell(tbxAnswer.Text, cell[0], cell[1]);

                // To get the list of cells with errors.
                string[] errorArray = getRowArray(boardType, boardSize, cell[0], cell[1]);

                // To check if the user has won.
                if (errorArray.Length <= 0)
                {
                    // To check if the solution is valid.
                    bool isSolved = boardClass.validate_solution(boardType, boardSize);
                    if (isSolved)
                    {
                        form.Hide(); // To hide the current form.
                        new Victory().Show();
                    }
                }

                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        // To get a specific cell.
                        char rowCell = (char)(i + boardClass.lower_bound);
                        char colCell = (char)(j + boardClass.lower_bound);
                        string cellName = rowCell.ToString() + boardClass.split_fi + colCell.ToString();

                        // To format the searched control.
                        TextBox tbxCell = form.Controls.Find(cellName, true).FirstOrDefault() as TextBox;

                        // To check if the text box is a part of the cells with errors.
                        if (errorArray.Contains(tbxCell.Name))
                        {
                            // To format the colors.
                            tbxCell.BackColor = errorColor;
                            tbxCell.ForeColor = whiteColor;
                        }

                        else
                        {
                            // To revert the color.
                            if (tbxCell.BackColor == errorColor)
                            {
                                tbxCell.BackColor = whiteColor;
                                tbxCell.ForeColor = inputColor;
                            }
                        }
                    }
                }

                // To set the last input if the text box is not empty.
                if (tbxAnswer.Text != String.Empty || tbxAnswer.Text != "")
                    setLastInput(sender, e);
            }
        }

        // To get a new game.
        public void getNewGame(Form form)
        {
            /* -- Declaration
             * Models */
            dynamic boardClass = engine.getBoardClass();
            dynamic fileClass = engine.getFileClass();

            // Board Properties
            int boardSize = boardClass.get_size();
            string boardType = boardClass.generate_type(boardClass.get_type());

            // To save the data in the current game file.
            fileClass.save_game(boardClass.get_board(fileClass.get_board_file(boardSize), boardType), boardType, boardSize);

            // To go to the game proper.
            changeViews(new Form[] { form, getBoard(boardSize) }, new bool[] { false, true });
        }
    }
}