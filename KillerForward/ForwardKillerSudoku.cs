namespace KillerForward{
    public class ForwardKillerSudoku{
        public ForwardSquare[] squares {get; set;}
        public ForwardRow[] rows {get; set;}
        public ForwardColumn[] columns {get; set;}
        public ForwardSpace[] spaces {get; set;}
        public List<ForwardArea> areas {get; set;}

        // This gives us a normal Sudoku, One must add the Area's later.
        public ForwardKillerSudoku(){
            this.squares = new ForwardSquare[9];
            this.rows = new ForwardRow[9];
            this.columns = new ForwardColumn[9];
            this.spaces = new ForwardSpace[81];
            // areas is made here, one must fill it manually later.
            this.areas = new List<ForwardArea>();

            // Fill squares[] with Square.
            // Fill rows[] with Row.
            // Fill columns[] with Column.
            for (int i = 0; i <= 8; i++)
            {
                this.squares[i] = new ForwardSquare(i);
                this.rows[i] = new ForwardRow(i);
                this.columns[i] = new ForwardColumn(i);
            }

            // Create spaces and fill spaces, squares, rows, and columns with them.
            // Use count for position.
            int count = 0;
            // There are 0 to 80 positions in a sudoku.
            while (count <= 80)
            {
                // Create space.
                ForwardSpace space = new ForwardSpace(count);

                // Add space to spaces.
                spaces[count] = space;

                // Add space to relevant row.
                int rowNumber = count / 9;
                this.rows[rowNumber].addSpace(space);

                // Add space to relevant column.
                int columnNumber = count % 9;
                this.columns[columnNumber].addSpace(space);

                // Add space to relevant square.
                // Squares go from left to right, then up to down. so like this 
                // 0 1 2
                // 3 4 5
                // 6 7 8
                switch (rowNumber){
                    // Square position is 0, 1, or 2.
                    case int n when (n <= 2):
                        switch (columnNumber){
                            // Square is 0
                            case int m when (m <= 2):
                                this.squares[0].addSpace(space);
                                break; 

                            // Square is 1
                            case int m when (m <= 5):
                                this.squares[1].addSpace(space);
                                break;
                            
                            // Square is 2
                            default:
                                this.squares[2].addSpace(space);
                                break;
                        }
                        break;
                    // Square position is 3, 4, or 5
                    case int n when (n <= 5):
                        switch (columnNumber){
                            // Square is 3
                            case int m when (m <= 2):
                                this.squares[3].addSpace(space);
                                break; 

                            // Square is 4
                            case int m when (m <= 5):
                                this.squares[4].addSpace(space);
                                break;
                            
                            // Square is 5
                            default:
                                this.squares[5].addSpace(space);
                                break;
                        }                        

                        break;
                    // Square position is 6, 7, or 8
                    default:
                        switch (columnNumber){
                            // Square is 6
                            case int m when (m <= 2):
                                this.squares[6].addSpace(space);
                                break; 

                            // Square is 7
                            case int m when (m <= 5):
                                this.squares[7].addSpace(space);
                                break;
                            
                            // Square is 8
                            default:
                                this.squares[8].addSpace(space);
                                break;
                        }
                        break;
                }
                count++;
            }
        }
        
        public void addArea(int target, List<int> positions){
            ForwardArea area = new ForwardArea(target, positions, this);
            this.areas.Add(area);
        }

        public ForwardSpace getSpace(int position){
            return this.spaces[position];
        }

        public void printSudokuValues()
        {
            foreach (ForwardRow row in this.rows)
            {
                if (row.position % 3 == 0){
                    Console.WriteLine("   --------------------------------------------");
                }
                Console.Write(row.position + ": ");
                for (int i = 0; i <= 8; i++)
                {
                    if(i % 3 == 0){
                        Console.Write("| ");
                    }
                    Console.Write("[" + row.getSpaces()[i].getNumber() + "] ");
                }
                Console.Write("\n");
            }
        }

// For manually testing.
        public void printAreas(){
            for (int i = 0; i < this.areas.Count(); i++){
                Console.Write(areas[i].target + ": ");
                foreach (ForwardSpace space in this.areas[i].spaces){
                    Console.Write("[" + space.getNumber() + "] ");
                }
                Console.Write("\n");
            }
        }

        public void printSudokuPositionRow(){
            foreach (ForwardRow row in this.rows)
            {
                Console.Write(row.position + ": ");
                foreach(ForwardSpace space in row.getSpaces()){
                    Console.Write("[" + space.position + "] ");
                }
                Console.Write("\n");
            }
        }
        public void printSudokuPositionColumn(){
            foreach (ForwardColumn column in this.columns){
                Console.Write(column.position + ": ");
                foreach(ForwardSpace space in column.getSpaces()){
                    Console.Write("[" + space.position + "] ");
                }
                Console.Write("\n");
            }
        }

        public void printSudokuPositionSquare(){
            foreach (ForwardSquare square in this.squares){
                Console.Write(square.position + ": ");
                foreach(ForwardSpace space in square.getSpaces()){
                    Console.Write("[" + space.position + "] ");    
                }
                Console.Write("\n");
            }
        }
    }
}