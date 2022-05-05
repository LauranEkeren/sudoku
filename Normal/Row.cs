using System.Collections;

namespace Normal
{
    public class Row
    {
        public List<Space> spaces {get; set;}
        public int position {get; set;}

        public Row(int position){
            this.spaces = new List<Space>();
            this.position = position;
        }

        public bool isValid(){
            return spaces.GroupBy(x => x.getNumber()).All(g => g.Count() == 1 || g.Key == 0);
        }
    }
}
