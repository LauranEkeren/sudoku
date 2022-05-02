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

        public bool isValid(){
            return spaces.GroupBy(x => x.getNumber()).All(g => g.Count() == 1 || g.Key == 0);
        }


    }
}