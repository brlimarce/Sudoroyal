""" ** Board **
    To handle the properties and board itself. """
import files # To handle the files in the game.

class Board():
    """ ** Properties **
        To set the file indicators for the GUI. """
    __preset_fi = "*" # For inaccessible numbers in the board.
    __input_fi = "**" # For user input.
    __error_fi = "-" # For input that have an error.
    __split_fi = ":" # For the split between FI and the element.

    # To set the upper and lower bounds for board types.
    __lower_bound = 65 # This is the default ASCII value for 'A'.
    __upper_bound = 67 # This is the default ASCII value for 'C'.

    """ ** Methods **
        -- Getters
        To get the file indicator for inaccessible cells. """
    @property
    def preset_fi(self):
        return self.__preset_fi

    # To get the file indicator for user input.
    @property
    def input_fi(self):
        return self.__input_fi

    # To get the file indicator for user input with errors.
    @property
    def error_fi(self):
        return self.__error_fi

    # To get the file indicator for splitting.
    @property
    def split_fi(self):
        return self.__split_fi

    """ -- Bounds
        To get the lower bound. """
    @property
    def lower_bound(self):
        return self.__lower_bound

    # To get the upper bound.
    @property
    def upper_bound(self):
        return self.__upper_bound

    """ -- Board Size
        # To get the board size. """
    def get_size(self):
        # To instantiate a file class.
        file_class = files.Files()

        file_reader = open(file_class.current_game_path, "r") # To open a file for reading.
        board_size = int(file_reader.readline()[0:-1]) # To get the first line of the file.
        file_reader.close()

        return board_size

    # To change the board size.
    def change_size(self, board_size):
        # To instantiate a file class.
        file_class = files.Files()

        # To switch the board size.
        if board_size == 9:
            board_size = 16
        else:
            board_size = 9
        file_class.reset_game(board_size) # To reset the current game file.

    """ -- Board Type
        To generate a new board type. The default value is A. """
    def generate_type(self, board_type):
        # To get the ASCII value.
        board_type_value = ord(board_type)

        # If the board type value falls within the range.
        if board_type_value + 1 >= self.__lower_bound and board_type_value + 1 <= self.__upper_bound:
            return chr(board_type_value + 1) # To convert the value into a character.
        else:
            return chr(self.__lower_bound) # To return the default value.

    # To get the type in the current game file.
    def get_type(self):
        # To instantiate a file class.
        file_class = files.Files()

        # To open a file for reading.
        file_reader = open(file_class.current_game_path, "r")
        file_reader.readline() # To skip a line.

        # To get the board type.
        board_type = file_reader.readline()[0:-1]
        file_reader.close()

        # To replace the null value with the default.
        if board_type == "":
            return chr(self.__upper_bound) # To replace with 'C'.
        return board_type

    """ -- Board
        # To get the Sudoku board from any file. """
    def get_board(self, board_file, board_type):
        # -- Declaration
        board = []
        is_type_found = False # Flag to detect if a board type is found.
        file_class = files.Files() # To instantiate a file class.

        # To open a file for reading.
        file_reader = open(file_class.dir + board_file, "r")

        # To extract the data from the file.
        for line in file_reader:
            # To cut the newline character.
            line = line[0:-1]

            # To find the board type.
            if line == board_type:
                is_type_found = True
            else:
                # To check if the board type has already been found.
                if is_type_found:
                    # To check if the entire board is already extracted.
                    if len(line) == 1 and line != board_type:
                        break
                    else:
                        row = line.split(",")
                        board.append(row)
        file_reader.close()
        return board

    # To get the row of a board.
    def get_row(self, board_file, board_type, row_index):
        board = self.get_board(board_file, board_type)
        return board[row_index]

    """ -- Sudoku Validation
        To check if the board is solved. """
    def validate_solution(self, board_type, board_size):
        # To instantiate a file class.
        file_class = files.Files()

        # To get the board.
        board = self.get_board(file_class.current_game_file, board_type)

        # To check if every element in each row has no error file indicator.
        for i in range(0, board_size):
            for j in range(0, board_size):
                # To get the file indicator.
                file_indicator = board[i][j].split(self.__split_fi)[0]

                # To check for error FI or blank inputs.
                if file_indicator == self.__error_fi or "*" not in file_indicator:
                    return False
        return True

    # To check the entire board.
    def check_board(self, board_type, board_size, row_cell, col_cell):
        # -- Declaration
        file_class = files.Files() # To instantiate a file class.
        board = self.get_board(file_class.current_game_file, board_type) # To get the board.
        row_index, col_index = self.convert_cell(row_cell), self.convert_cell(col_cell) # To get the row and column indices.

        # To get the square region.
        region_width = self.get_region_width(board_size) # To get the size of a square.
        row_start, col_start = self.get_region_start(row_index, board_size), self.get_region_start(col_index, board_size) # To get the region's starting indices.

        # To get the vicinity of the user input (row, column, and square).
        scope = {}
        for row in range(0, board_size):
            if row == row_index: # To get the row.
                for col in range(0, board_size):
                    scope[chr(row + self.__lower_bound) + self.__split_fi + chr(col + self.__lower_bound)] = board[row][col]
            elif row >= row_start and row <= (row_start + region_width - 1): # To get the square region.
                for col in range(col_start, col_start + region_width):
                    scope[chr(row + self.__lower_bound) + self.__split_fi + chr(col + self.__lower_bound)] = board[row][col]
            else: # To get the column.
                scope[chr(row + self.__lower_bound) + self.__split_fi + chr(col_index + self.__lower_bound)] = board[row][col_index]

        # To check every element in the scope.
        for cell in scope.keys():
            element_cell = cell.split(self.__split_fi) # To split the row and column indices.
            element = scope[cell].split(self.__split_fi) # To split the FI and value.

            if element[0] == self.__error_fi or element[0] == self.__input_fi: # To check if the FI is not preset nor blank input.
                is_distinct = True # Flag to check if the element is distinct.
                row_index, col_index = self.convert_cell(element_cell[0]), self.convert_cell(element_cell[1])
                row_start, col_start = self.get_region_start(row_index, board_size), self.get_region_start(col_index, board_size)

                # To validate the element within its vicinity (row, column, and square).
                validation = [self.check_duplicates(element[1], [i.split(self.__split_fi)[1] for i in board[row_index]]), self.check_duplicates(element[1], [board[i][col_index].split(self.__split_fi)[1] for i in range(0, board_size)]), self.check_duplicates(element[1], [board[i][j].split(self.__split_fi)[1] for i in range(row_start, row_start + region_width) for j in range(col_start, col_start + region_width)])]
                for validate_index in range(0, len(validation)):
                    if validation[validate_index]: # If the element is not distinct.
                        is_distinct = False
                        break

                # To change the file indicator.
                if is_distinct:
                    new_fi = self.__input_fi
                else:
                    new_fi = self.__error_fi
                board[row_index][col_index] = new_fi + self.__split_fi + element[1]
        file_class.save_game(board, board_type, board_size) # To save the game.
        return [chr(i + self.__lower_bound) + self.__split_fi + chr(j + self.__lower_bound) for i in range(0, board_size) for j in range(0, board_size) if board[i][j].split(self.__split_fi)[0] == self.__error_fi]

    # To look for duplicates of a given element.
    def check_duplicates (self, element, board_set):
        return board_set.count(element) >= 2

    """ -- Box Region
        To get the region width. """
    def get_region_width(self, board_size):
        if board_size == 9:
            return 3
        elif board_size == 16:
            return 4

    # To get the starting index of the region.
    def get_region_start(self, cell_index, board_size):
        # -- Declaration
        region_width = self.get_region_width(board_size)
        starting_index = 0 # To get the starting index of the region.

        # To create the region indices.
        region_indices = []
        for index in range(0, region_width):
            region_indices.append(index)

        # To get the starting index.
        for i in range(0, len(region_indices)):
            if region_indices[i] == region_indices[len(region_indices) - 1]: # If the index is equal to the last index.
                starting_index = region_indices[i] * region_width
                break
            elif cell_index >= region_indices[i] * region_width and cell_index < region_indices[i + 1] * region_width:
                starting_index = region_indices[i] * region_width
                break
        return starting_index

    """ -- Others
        To get the index of a cell by converting ASCII to a numerical value. """
    def convert_cell(self, cell):
        return ord(cell) - self.__lower_bound # 65 is the default ASCII value for 'A'.

    # To validate the input.
    def validate_input(self, input, board_size):
        try:
            if input == None or input == "": # If the input is blank, do not raise an exception.
                return True
            else:
                element = int(input) # To try to parse the input into an integer.
                if not (element >= 1 and element <= board_size): # To check if the element doesn't fall within the range.
                    raise Exception()
                return True
        except:
            return False
