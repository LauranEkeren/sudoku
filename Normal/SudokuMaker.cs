namespace Normal {
    class SudokuMaker {
        public SudokuMaker(){}

        public NormalSudoku sudokuOne(){
            NormalSudoku sudoku = new NormalSudoku();
            sudoku.setSpace(40, 9);
            return sudoku;
        }

        public NormalSudoku sudokuTwo(){
            NormalSudoku sudoku = new NormalSudoku();
            sudoku.setSpace(2, 3);
            sudoku.setSpace(9, 6);
            sudoku.setSpace(10, 4);
            sudoku.setSpace(13, 1);
            sudoku.setSpace(21, 5);
            sudoku.setSpace(15, 7);
            sudoku.setSpace(26, 8);
            sudoku.setSpace(29, 2);
            sudoku.setSpace(38, 1);
            sudoku.setSpace(45, 9);
            sudoku.setSpace(46, 3);
            sudoku.setSpace(31, 9);
            sudoku.setSpace(50, 8);
            sudoku.setSpace(42, 3);
            sudoku.setSpace(53, 7);
            sudoku.setSpace(54, 7);
            sudoku.setSpace(55, 9);
            sudoku.setSpace(72, 2);
            sudoku.setSpace(58, 6);
            sudoku.setSpace(68, 1);
            sudoku.setSpace(60, 4);
            sudoku.setSpace(70, 6);
            return sudoku;
        }
    }
}