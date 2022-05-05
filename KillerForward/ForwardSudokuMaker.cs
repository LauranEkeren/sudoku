namespace KillerForward {
    public class ForwardSudokuMaker {
        public ForwardSudokuMaker(){}

        public ForwardKillerSudoku sudokuOne(){
            ForwardKillerSudoku sudoku = new ForwardKillerSudoku();
            sudoku.addArea(19, new List<int>(){0, 1, 9});
            sudoku.addArea(11, new List<int>(){2, 11});
            sudoku.addArea(14, new List<int>(){3, 12});
            sudoku.addArea(9, new List<int>(){4, 5});
            sudoku.addArea(12, new List<int>(){6, 7, 16});
            sudoku.addArea(17, new List<int>(){8, 17, 26});
            sudoku.addArea(6, new List<int>(){10, 19});
            sudoku.addArea(14, new List<int>(){13, 22, 23});
            sudoku.addArea(9, new List<int>(){14, 15});
            sudoku.addArea(14, new List<int>(){18, 27});
            sudoku.addArea(8, new List<int>(){20, 21});
            sudoku.addArea(10, new List<int>(){24, 25});
            sudoku.addArea(18, new List<int>(){28, 29, 37, 46});
            sudoku.addArea(8, new List<int>(){30, 31});
            sudoku.addArea(16, new List<int>(){32, 33, 42});
            sudoku.addArea(14, new List<int>(){34, 43});
            sudoku.addArea(17, new List<int>(){35, 44, 53});
            sudoku.addArea(8, new List<int>(){36, 45});
            sudoku.addArea(6, new List<int>(){38});
            sudoku.addArea(10, new List<int>(){39, 48, 47});
            sudoku.addArea(12, new List<int>(){40, 41});
            sudoku.addArea(6, new List<int>(){49});
            sudoku.addArea(16, new List<int>(){50, 59, 60});
            sudoku.addArea(11, new List<int>(){51, 52, 61});
            sudoku.addArea(15, new List<int>(){54, 55, 56});
            sudoku.addArea(10, new List<int>(){57, 58});
            sudoku.addArea(9, new List<int>(){62, 71});
            sudoku.addArea(8, new List<int>(){63, 72});
            sudoku.addArea(28, new List<int>(){64, 65, 66, 74, 75});
            sudoku.addArea(13, new List<int>(){67, 76});
            sudoku.addArea(3, new List<int>(){68, 77});
            sudoku.addArea(12, new List<int>(){69, 78});
            sudoku.addArea(15, new List<int>(){70, 79, 80});
            sudoku.addArea(7, new List<int>(){73});
            return sudoku;
        }
    }
}