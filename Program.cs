using KillerDumb;
using KillerForward;
using Normal;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime startTime = DateTime.Now;

            ForwardSudokuMaker sudokuMaker = new ForwardSudokuMaker();
            ForwardKillerSudoku sudoku = sudokuMaker.sudokuOne();
            ForwardSudokuSolver sudokuSolver = new ForwardSudokuSolver();



            

            sudokuSolver.startSolving(sudoku);
            
            sudoku.printSudokuValues();

            
            
            // SUDOKU KILLER DUMB TRYOUT.
            // KillerSudokuDumbMaker killerSudokuDumbMaker = new KillerSudokuDumbMaker();
            // KillerSudokuDumb killerSudokuDumb = killerSudokuDumbMaker.sudokuOne();
            // KillerSudokuDumbSolver killerSudokuDumbSolver = new KillerSudokuDumbSolver();
            // KillerSudokuDumb sudokuSolved = killerSudokuDumbSolver.startSolving(killerSudokuDumb);
            // Console.WriteLine(sudokuSolved == null);
            // killerSudokuDumb.printSudokuValues();
            // sudokuSolved.printSudokuValues();
            
            // SUDOKU NORMAL DUMB TRYOUT.
            // SudokuMaker sudokuMaker = new SudokuMaker();
            // NormalSudoku sudoku = sudokuMaker.sudokuTwo();
            // sudoku.printSudokuValues();
            // SudokuSolver sudokuSolver = new SudokuSolver();
            // NormalSudoku solvedSudoku = sudokuSolver.startSolving(sudoku);
            // Console.WriteLine(solvedSudoku == null);
            // sudoku.printSudokuValues();

            DateTime endTime = DateTime.Now;
            Console.WriteLine("Start tijd:" + startTime);
            Console.Write("Eind tijd: " + endTime);
        }
    }
}