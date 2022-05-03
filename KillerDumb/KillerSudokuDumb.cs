using Normal;

namespace KillerDumb{

    public class KillerSudokuDumb{

        public Square[] squares {get; set;}
        public Row[] rows {get; set;}
        public Column[] columns {get; set;}
        public Space[] spaces {get; set;}
        public List<Area> areas {get; set;}

// This gives us a normal Sudoku, One must add the Area's later.
        public KillerSudokuDumb()
        {
            this.squares = new Square[9];
            this.rows = new Row[9];
            this.columns = new Column[9];
            this.spaces = new Space[81];
            // areas is made here, one must fill it manually later.
            this.areas = new List<Area>();

            // Fill squares[] with Square.
            // Fill rows[] with Row.
            // Fill columns[] with Column.
            for (int i = 0; i <= 8; i++)
            {
                this.squares[i] = new Square(i);
                this.rows[i] = new Row(i);
                this.columns[i] = new Column(i);
            }

            // Create spaces and fill spaces, squares, rows, and columns with them.
            // Use count for position.
            int count = 0;
            // There are 0 to 80 positions in a sudoku.
            while (count <= 80)
            {
                // Create space.
                Space space = new Space(count);

                // Add space to spaces.
                spaces[count] = space;

                // Add space to relevant row.
                int rowNumber = count / 9;
                this.rows[rowNumber].spaces.Add(space);

                // Add space to relevant column.
                int columnNumber = count % 9;
                this.columns[columnNumber].spaces.Add(space);

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
                                this.squares[0].spaces.Add(space);
                                break; 

                            // Square is 1
                            case int m when (m <= 5):
                                this.squares[1].spaces.Add(space);
                                break;
                            
                            // Square is 2
                            default:
                                this.squares[2].spaces.Add(space);
                                break;
                        }
                        break;
                    // Square position is 3, 4, or 5
                    case int n when (n <= 5):
                        switch (columnNumber){
                            // Square is 3
                            case int m when (m <= 2):
                                this.squares[3].spaces.Add(space);
                                break; 

                            // Square is 4
                            case int m when (m <= 5):
                                this.squares[4].spaces.Add(space);
                                break;
                            
                            // Square is 5
                            default:
                                this.squares[5].spaces.Add(space);
                                break;
                        }                        

                        break;
                    // Square position is 6, 7, or 8
                    default:
                        switch (columnNumber){
                            // Square is 6
                            case int m when (m <= 2):
                                this.squares[6].spaces.Add(space);
                                break; 

                            // Square is 7
                            case int m when (m <= 5):
                                this.squares[7].spaces.Add(space);
                                break;
                            
                            // Square is 8
                            default:
                                this.squares[8].spaces.Add(space);
                                break;
                        }
                        break;
                }
                count++;
            }

        }

        public void addArea(int target, List<int> positions){
            Area area = new Area(target, positions, this);
            this.areas.Add(area);
        }
         
        public void setSpace(int position, int value){
            Space space = this.spaces[position];
            space.setNumber(value);
        }

        public Space getSpace(int position){
            return this.spaces[position];
        }

        public bool isSudokuValid(){
            // Check all squares.
            foreach(Square square in squares){
                if (!square.isValid()){
                    return false;
                }
            }
            // Check all columns.
            foreach(Column column in columns){
                if (!column.isValid()){
                    return false;
                }
            }
            // Check all rows.
            foreach(Row row in rows){
                if (!row.isValid()){
                    return false;
                }
            }
            // Check all Area's.
            foreach(Area area in areas){
                if (!area.Isvalid()){
                    return false;
                }
            }
            // if all are valid, we return true.
            return true;
        }



        public void printSudokuValues()
        {
            foreach (Row row in this.rows)
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
                    Console.Write("[" + row.spaces[i].getNumber() + "] ");
                }
                Console.Write("\n");
            }
        }

// For manually testing.
        public void printAreas(){
            for (int i = 0; i < this.areas.Count(); i++){
                Console.Write(areas[i].target + ": ");
                foreach (Space space in this.areas[i].spaces){
                    Console.Write("[" + space.getNumber() + "] ");
                }
                Console.Write("\n");
            }
        }

        public void printSudokuPositionRow(){
            foreach (Row row in this.rows)
            {
                Console.Write(row.position + ": ");
                foreach(Space space in row.spaces){
                    Console.Write("[" + space.position + "] ");
                }
                Console.Write("\n");
            }
        }
        public void printSudokuPositionColumn(){
            foreach (Column column in this.columns){
                Console.Write(column.position + ": ");
                foreach(Space space in column.spaces){
                    Console.Write("[" + space.position + "] ");
                }
                Console.Write("\n");
            }
        }

        public void printSudokuPositionSquare(){
            foreach (Square square in this.squares){
                Console.Write(square.position + ": ");
                foreach(Space space in square.spaces){
                    Console.Write("[" + space.position + "] ");    
                }
                Console.Write("\n");
            }
        }

    }
}