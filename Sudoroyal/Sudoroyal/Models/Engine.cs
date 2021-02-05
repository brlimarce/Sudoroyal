using IronPython.Hosting;

namespace Sudoroyal.Models
{
    /* -- Engine
     * To get the class from the Python files. */
    public class Engine
    {
        /* -- Methods
         * To get the executable Python file. */
        private dynamic getExecutable(string fileName)
        {
            var engine = Python.CreateEngine(); // To create the engine.
            dynamic executable = engine.ExecuteFile(fileName); // To get the executable file.
            return executable;
        }

        // To get the Board class.
        public dynamic getBoardClass()
        {
            dynamic executable = getExecutable("board.py");
            return executable.Board();
        }

        // To get the Files class.
        public dynamic getFileClass()
        {
            // To get the class.
            dynamic executable = getExecutable("files.py");
            return executable.Files();
        }
    }
}
