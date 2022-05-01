namespace Sudoku
{
    class Column
    {

        public List<Space> spaces;
        public int position;

        public Column(int position){
            this.spaces = new List<Space>();
            this.position = position;
        }


    }
}
