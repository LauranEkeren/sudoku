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


    }
}
