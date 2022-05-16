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


            // FORWARD STACK SOLVER
            ForwardSudokuMaker sudokuMaker = new ForwardSudokuMaker();
            ForwardKillerSudoku sudoku = sudokuMaker.sudokuThree();

            ForwardStackSolver solver = new ForwardStackSolver(sudoku);
            solver.startSolving();
            sudoku.printSudokuValues();

            // FORWARD SUDOKU
            // ForwardSudokuMaker sudokuMaker = new ForwardSudokuMaker();
            // ForwardKillerSudoku sudoku = sudokuMaker.sudokuThree();

            // ForwardSudokuSolver sudokuSolver = new ForwardSudokuSolver();
            // sudokuSolver.startSolving(sudoku);
            // sudoku.printSudokuValues();
            
            
            // SUDOKU KILLER DUMB TRYOUT.
            // KillerSudokuDumbMaker killerSudokuDumbMaker = new KillerSudokuDumbMaker();
            // KillerSudokuDumb killerSudokuDumb = killerSudokuDumbMaker.sudokuThree();

            // KillerSudokuDumbSolver killerSudokuDumbSolver = new KillerSudokuDumbSolver();
            // KillerSudokuDumb sudokuSolved = killerSudokuDumbSolver.startSolving(killerSudokuDumb);

            DateTime endTime = DateTime.Now;
            Console.WriteLine("Start tijd:" + startTime);
            Console.Write("Eind tijd: " + endTime);
        }
    }
}