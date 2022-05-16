namespace KillerForward
{
    public class ForwardStackSolver
    {

        Stack<ForwardSpace> stack { get; set; }
        int position { get; set; }
        ForwardKillerSudoku sudoku { get; set; }
        List<ForwardSpace> spacesNotFilled {get; set;}

        public ForwardStackSolver(ForwardKillerSudoku sudoku)
        {
            this.stack = new Stack<ForwardSpace>();
            this.position = 0;
            this.sudoku = sudoku;
            this.spacesNotFilled = new List<ForwardSpace>();
        }


        public void startSolving()
        {            
            foreach (ForwardArea area in sudoku.areas){
                area.setAreaIfSizeIsOne();
                area.removePossibleNumberUpperStart();
                area.removePossibleNumberDoubleStart();
                area.removePossibleNumberLowerStart();
            }
            this.spacesNotFilled = sudoku.spaces.Where(x => x.getNumber != null).ToList();

            addNextEmptySpaceToStack();
        }

        public void addNextEmptySpaceToStack()
        {
            // als de stack groter is dan 80 stoppen we.
            while (stack.Count() < spacesNotFilled.Count())
            {
                // pak een space.
                ForwardSpace space = spacesNotFilled[stack.Count()];


                // Ga alle nummers af om de space te zetten.
                bool spaceSetted = false;
                for (int i = 1; i <= 9; i++)
                {
                    if (space.setNumber(i))
                    {
                        // als space past, plaats het op de stack.
                        spaceSetted = true;
                        stack.Push(space);
                        break;
                    }
                }
                // Als geen space kon. moeten we de vorige met 1 verhogen.
                if (!spaceSetted)
                {
                    // ga door totdat er een space verandert is.
                    bool spaceChanged = false;
                    while (!spaceChanged)
                    {
                        // Haal de space van de stack af.
                        ForwardSpace topSpace = stack.Pop();
                        int lowestPossible = topSpace.getNumber() + 1;
                        for (int i = lowestPossible; i <= 9; i++)
                        {
                            if (topSpace.setNumber(i))
                            {
                                // als space past plaatst het op de stack.
                                stack.Push(topSpace);
                                spaceChanged = true;
                                break;
                            }
                        }
                        if (!spaceChanged)
                        {
                            // if the space has not changed, put it back to 0;
                            topSpace.setNumber(0);
                        }
                    }

                }

            }
            sudoku.printSudokuValues();


        }
    }
}