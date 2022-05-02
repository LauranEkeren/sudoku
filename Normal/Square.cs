namespace Normal
{
    public class Square
    {
        public List<Space> spaces;
        public int position;

        public Square(int position){
            this.spaces = new List<Space>();
            this.position = position;

        }


    }
}
                // if (rowNumber <= 2)
                // {
                //     // It is square 0, 1 or 2.
                //     if (columnNumber <= 2)
                //     {
                //         // It is square 0.
                //         this.squares[0].spaces.Add(space);
                //     }
                //     else if (columnNumber <= 5)
                //     {
                //         // It is square 1
                //         this.squares[1].spaces.Add(space);
                //     }
                //     else
                //     {
                //         // It is square 2.
                //         this.squares[2].spaces.Add(space);
                //     }
                // }
                // else if (rowNumber <= 5)
                // {
                //     // It is square 3, 4 or 5.
                //     if (columnNumber <= 2)
                //     {
                //         // It is square 3.
                //         this.squares[3].spaces.Add(space);
                //     }
                //     else if (columnNumber <= 5)
                //     {
                //         // It is square 4
                //         this.squares[4].spaces.Add(space);
                //     }
                //     else
                //     {
                //         // It is square 5.
                //         this.squares[5].spaces.Add(space);
                //     }
                // }
                // else
                // {
                //     if (columnNumber <= 2)
                //     {
                //         // It is square 6.
                //         this.squares[6].spaces.Add(space);
                //     }
                //     else if (columnNumber <= 5)
                //     {
                //         // It is square 7
                //         this.squares[7].spaces.Add(space);
                //     }
                //     else
                //     {
                //         // It is square 8.
                //         this.squares[8].spaces.Add(space);
                //     }
                // }