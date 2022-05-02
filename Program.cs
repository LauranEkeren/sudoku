using Normal;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SudokuMaker sudokuMaker = new SudokuMaker();
            NormalSudoku sudoku = sudokuMaker.sudokuTwo();

            sudoku.printSudokuValues();

            SudokuSolver sudokuSolver = new SudokuSolver();
            NormalSudoku solvedSudoku = sudokuSolver.startSolving(sudoku);
            Console.WriteLine(solvedSudoku == null);
            sudoku.printSudokuValues();
        }
    }
}