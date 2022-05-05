namespace KillerForward {
    class ForwardSudokuSolver{
        
        public ForwardSudokuSolver(){

        }

        public ForwardKillerSudoku startSolving(ForwardKillerSudoku sudoku){
            Console.WriteLine("Start solving");

            return solveSudoku(sudoku, 0);
        }

         private ForwardKillerSudoku solveSudoku(ForwardKillerSudoku sudoku, int position){
            // Ga alle posities af. Zoekend welke nog niet gevuld is.
            while (position <= 80){
                // Pak de space van de huidige positie.
                ForwardSpace space = sudoku.getSpace(position);
                // Als de positie gevuld is, gaan we naar de volgende positie toe, anders doen we iets.
                if (space.getNumber() == 0){
                    // Check if we have possible numbers, if not we return null.
                    if (!space.isPossibleNumbersEmpty()){
                        // Use a counter to go through or possible numbers. 
                        int counter = 1;
                        while (counter <= 9){
                            // Check whether the counter is in our possible numbers.
                            if (space.getPossibleNumbers().Contains(counter)){
                                // Check whether space can be filled.
                                if (space.setNumber(counter)){
                                    // Check if area is valid .
                                    if (space.area.Isvalid()){
                                        ForwardKillerSudoku newSudoku = solveSudoku(sudoku, position + 1);
                                        // Als we een null terugkrijgen, moeten we nog wel al onze getallen in de huidige counter proberen, dus doen we niks.
                                        // Als we een sudoku terugkrijgen, is deze opgelost, dus geven we die omhoog door.
                                        if(newSudoku != null){
                                            return newSudoku;
                                        }
                                    }
                                }
                            }
                            // Increase while loop to escape someday.
                            space.setNumber(0);
                            counter ++;
                        }
                        // If no numbers are possible, this tree is wrong. Set the position back to zero and return null.
                        return null;
                    } 
                }
                // Increase position by one.
                position ++;
            }
            // Als we alle posities zijn afgegaan zouden we een gevulde sudoku moeten hebben.
            return sudoku;
        }

    }
}