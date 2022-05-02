using Normal;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            NormalSudoku sudoku = new NormalSudoku();
            sudoku.addValue(40, 9);

            sudoku.printSudokuValues();
            


        }
    }
}