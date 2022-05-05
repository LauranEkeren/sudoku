namespace KillerDumb{
    class KillerSudokuDumbSolver{

        public KillerSudokuDumbSolver(){

        }

        public KillerSudokuDumb startSolving(KillerSudokuDumb sudoku){
            Console.WriteLine("Start solving");

            return solveSudoku(sudoku, 0);
        }

         private KillerSudokuDumb solveSudoku(KillerSudokuDumb sudoku, int position){
            // Ga alle posities af, zoekend welke nog niet gevuld is.
            while (position <= 80){
                // Kijk of de positie gevuld is.
                if(sudoku.getSpace(position).getNumber() == 0){
                    // probeer de positie in te vullen, beginnend met 1.
                    int counter = 1;
                    while (counter <= 9){
                        // Vul positie.
                        sudoku.setSpace(position, counter);
                        // Als de sudoku valide is, maken we onze volgende boom. 
                        if(sudoku.isSudokuValid()){
                            KillerSudokuDumb copy = sudoku;
                            KillerSudokuDumb newSudoku = solveSudoku(copy, position + 1);
                            // Als we een null terugkrijgen, moeten we nog wel al onze getallen in de huidige counter proberen, dus doen we niks.

                            // Als we een sudoku terugkrijgen, is deze opgelost, dus geven we die omhoog door.
                            if(newSudoku != null){
                                return newSudoku;
                            }
                        }
                        // Als de sudoku niet valide is, proberen we het volgende getal in te vullen.
                        counter++;
                    }
                    // Als geen van alle getallen kunnen. Dan is deze boom fout. Zetten we 9 weer terug naar 0.
                    sudoku.setSpace(position, 0);
                    return null;

                }
                // Als de positie gevuld is, gaan we naar de volgende positie.
                position++;
            }
            // Als we alle posities zijn afgegaan, en geen positie kan gevuld worden. is de sudoku opgelost.
            return sudoku;
        }
    }
}