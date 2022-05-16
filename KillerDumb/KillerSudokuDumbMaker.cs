namespace KillerDumb{
    class KillerSudokuDumbMaker{
        public KillerSudokuDumbMaker(){}

        public KillerSudokuDumb sudokuOne(){
            KillerSudokuDumb sudoku = new KillerSudokuDumb();
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

        public KillerSudokuDumb sudokuTwo(){
            KillerSudokuDumb sudoku = new KillerSudokuDumb();
            sudoku.addArea(24, new List<int>(){0, 1, 2, 3});
            sudoku.addArea(11, new List<int>(){4, 5});
            sudoku.addArea(18, new List<int>(){6, 7, 15, 16});
            sudoku.addArea(8, new List<int>(){8, 17});
            sudoku.addArea(14, new List<int>(){9, 10,11});
            sudoku.addArea(12, new List<int>(){12, 13, 21});
            sudoku.addArea(12, new List<int>(){14, 23, 32});
            sudoku.addArea(9, new List<int>(){18, 27, 36});
            sudoku.addArea(20, new List<int>(){19, 20, 29, 30});
            sudoku.addArea(13, new List<int>(){22, 31});
            sudoku.addArea(15, new List<int>(){24, 33, 42, 51});
            sudoku.addArea(10, new List<int>(){25, 26});
            sudoku.addArea(10, new List<int>(){28, 37});
            sudoku.addArea(12, new List<int>(){34, 35});
            sudoku.addArea(12, new List<int>(){38, 39});
            sudoku.addArea(18, new List<int>(){40, 41, 50});
            sudoku.addArea(15, new List<int>(){43, 44});
            sudoku.addArea(22, new List<int>(){45, 46, 54, 55});
            sudoku.addArea(12, new List<int>(){47, 56});
            sudoku.addArea(12, new List<int>(){48, 49, 58});
            sudoku.addArea(12, new List<int>(){52, 61, 62});
            sudoku.addArea(4, new List<int>(){53});
            sudoku.addArea(13, new List<int>(){57, 66, 65});
            sudoku.addArea(15, new List<int>(){59, 60});
            sudoku.addArea(13, new List<int>(){63, 64, 73});
            sudoku.addArea(9, new List<int>(){67, 68});
            sudoku.addArea(11, new List<int>(){69, 78});
            sudoku.addArea(13, new List<int>(){70, 71});
            sudoku.addArea(5, new List<int>(){72});
            sudoku.addArea(9, new List<int>(){74, 75});
            sudoku.addArea(13, new List<int>(){76, 77});
            sudoku.addArea(9, new List<int>(){79, 80});
            
            return sudoku;
        }

        public KillerSudokuDumb sudokuThree(){
            KillerSudokuDumb sudoku = new KillerSudokuDumb();

            sudoku.addArea(21, new List<int>(){0,1, 2});
            sudoku.addArea(10, new List<int>(){3, 12});
            sudoku.addArea(7, new List<int>(){4,13});
            sudoku.addArea(11, new List<int>(){5, 14});
            sudoku.addArea(22, new List<int>(){6, 7, 15, 16, 24});
            sudoku.addArea(10, new List<int>(){8, 17});
            sudoku.addArea(15, new List<int>(){9, 10, 18});
            sudoku.addArea(6, new List<int>(){11, 20});
            sudoku.addArea(23, new List<int>(){19, 28, 27, 36});
            sudoku.addArea(15, new List<int>(){21, 30});
            sudoku.addArea(11, new List<int>(){22, 23, 31});
            sudoku.addArea(19, new List<int>(){25, 26, 34});
            sudoku.addArea(13, new List<int>(){29, 38, 39});
            sudoku.addArea(5, new List<int>(){32, 33});
            sudoku.addArea(9, new List<int>(){35});
            sudoku.addArea(8, new List<int>(){37, 46});
            sudoku.addArea(14, new List<int>(){40, 41, 42});
            sudoku.addArea(12, new List<int>(){43, 44});
            sudoku.addArea(5, new List<int>(){45, 54});
            sudoku.addArea(19, new List<int>(){47, 48, 56, 57});
            sudoku.addArea(13, new List<int>(){49, 58});
            sudoku.addArea(9, new List<int>(){50, 51});
            sudoku.addArea(12, new List<int>(){52, 53});
            sudoku.addArea(24, new List<int>(){55, 64, 65});
            sudoku.addArea(13, new List<int>(){59, 68, 77});
            sudoku.addArea(20, new List<int>(){60, 69, 78});
            sudoku.addArea(3, new List<int>(){61});
            sudoku.addArea(9, new List<int>(){62, 71, 80});
            sudoku.addArea(8, new List<int>(){63, 72});
            sudoku.addArea(15, new List<int>(){66, 67, 76});
            sudoku.addArea(13, new List<int>(){70, 79});
            sudoku.addArea(11, new List<int>(){73, 74, 75});

            return sudoku;
        }

    }

 
}