namespace Sudoku
{
    class Space
    {
        public int number {get; set;}
        public int position {get; set;}
        // Misschien nodig?
        // public Row? row {get; set;}
        // public Column? column {get; set;}
        // public Square? square {get; set;}

        public Space(int position){
            this.number = 0;
            this.position = position;
        }


    }
}
