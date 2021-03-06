namespace Normal
{
    public class Column
    {

        public List<Space> spaces;
        public int position;

        public Column(int position){
            this.spaces = new List<Space>();
            this.position = position;
        }

        public bool isValid(){
            return spaces.GroupBy(x => x.getNumber()).All(g => g.Count() == 1 || g.Key == 0);
        }
    }
}
