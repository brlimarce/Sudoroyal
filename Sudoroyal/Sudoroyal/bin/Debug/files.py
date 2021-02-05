""" ** Files **
    To handle the data inside the files. """
import board # To get the board properties from the game.

class Files():
    """ ** Properties **
        To get the file path and current game. """
    __dir = "..//..//..//..//files//"
    __current_game_file = "current-game.txt"
    __current_game_path = __dir + __current_game_file

    """ ** Methods **
        -- Getters
        To get the file directory. """
    @property
    def dir(self):
        return self.__dir
    
    # To get the current game filename.
    @property
    def current_game_file(self):
        return self.__current_game_file

    # To get the file path of the current game file.
    @property
    def current_game_path(self):
        return self.__current_game_path

    """ -- Current Game
        To save the current game. """
    def save_game(self, board, board_type, board_size):
        # To open a file for writing.
        file_writer = open(self.__current_game_path, "w")

        # To write the data in the file.
        file_writer.write("{0}\n{1}\n".format(board_size, board_type)) # For board size and type.
        for row in board: # For every row in the board.
            file_writer.write(",".join(row) + "\n") # To separate each cell by a comma.
        file_writer.close()

    # To check if a current game exists.
    def check_existing_game(self):
        file_reader = open(self.__current_game_path, "r") # To open a file for reading.
        file_reader.readline() # To skip a line (board size).

        # To get the board type, which is an indicator.
        board_type = file_reader.readline()[0:-1] # To cut the newline character.
        file_reader.close()

        # To check if the board type exists.
        if board_type == "":
            return False
        return True

    # To switch the cell with a user's input.
    def change_cell(self, element, row_cell, col_cell):
        # To instantiate a board class.
        board_class = board.Board()

        # To convert the ASCII values.
        row_index, col_index = board_class.convert_cell(row_cell), board_class.convert_cell(col_cell)

        # To get the board from the current game file.
        file_reader = open(self.__current_game_path, "r")
        sudoku_board = [line[0:-1] for line in file_reader.readlines()]
        file_reader.close()

        # To change the file indicator.
        row = sudoku_board[row_index + 2].split(",") # The 2 lines are reserved for the board type and size.
        if element.isdigit(): # To check if the element is a number.
            row[col_index] = board_class.input_fi + ":" + element
        sudoku_board[row_index + 2] = ",".join(row) # To modify the old row.

        # To write the data in the file.
        file_writer = open(self.__current_game_path, "w")
        file_writer.writelines("\n".join(sudoku_board) + "\n") # To write the entire board.
        file_writer.close()

        return row_index

    # To reset the game.
    def reset_game(self, board_size):
        file_writer = open(self.__current_game_path, "w")
        file_writer.write(str(board_size) + "\n") # To write the board size (stringified).
        file_writer.close()

    """ -- Others
        To get the board file. """
    def get_board_file(self, board_size):
        return str(board_size) + "x" + str(board_size) + ".txt"
