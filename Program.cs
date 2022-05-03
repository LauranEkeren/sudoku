using KillerDumb;
using Normal;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // KillerSudokuDumb killerSudokuDumb = new KillerSudokuDumb();
            // killerSudokuDumb.addArea(10, new List<int>(){0, 1, 9});
            // killerSudokuDumb.setSpace(0, 3);
            // killerSudokuDumb.setSpace(1, 2);
            // killerSudokuDumb.setSpace(9, 1);

            // Console.WriteLine(killerSudokuDumb.areas[0].Isvalid());

            DateTime startTime = DateTime.Now;
            // SUDOKU KILLER DUMB TRYOUT.
            KillerSudokuDumbMaker killerSudokuDumbMaker = new KillerSudokuDumbMaker();
            KillerSudokuDumb killerSudokuDumb = killerSudokuDumbMaker.sudokuOne();
            KillerSudokuDumbSolver killerSudokuDumbSolver = new KillerSudokuDumbSolver();

            killerSudokuDumb.printSudokuValues();
            killerSudokuDumb.printAreas();

            

            KillerSudokuDumb sudokuSolved = killerSudokuDumbSolver.startSolving(killerSudokuDumb);

            Console.WriteLine(sudokuSolved == null);
            
            killerSudokuDumb.printSudokuValues();
            sudokuSolved.printSudokuValues();

            DateTime endTime = DateTime.Now;

            Console.WriteLine("Start tijd:" + startTime);
            Console.Write("Eind tijd: " + endTime);

            
            // SUDOKU NORMAL DUMB TRYOUT.
            // SudokuMaker sudokuMaker = new SudokuMaker();
            // NormalSudoku sudoku = sudokuMaker.sudokuTwo();

            // sudoku.printSudokuValues();

            // SudokuSolver sudokuSolver = new SudokuSolver();
            // NormalSudoku solvedSudoku = sudokuSolver.startSolving(sudoku);
            // Console.WriteLine(solvedSudoku == null);
            // sudoku.printSudokuValues();
        }
    }
}