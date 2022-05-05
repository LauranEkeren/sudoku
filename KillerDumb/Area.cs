using Normal;

namespace KillerDumb{

    public class Area {
        public List<Space> spaces {get; set;}
        public int target {get; set;}

        public Area(int target, List<int> positions, KillerSudokuDumb killerSudokuDumb){
            this.spaces = new List<Space>();
            this.target = target;
            //Fill spaces with relevent spaces, using positions and given killerSudoku.
            foreach (int position in positions){
                this.spaces.Add(killerSudokuDumb.getSpace(position));
            }
        }

        public bool Isvalid(){
            int total = 0;
            bool allSpacesFilled = true;
            foreach(Space space in spaces){
                int number = space.getNumber();
                if (number == 0){
                    allSpacesFilled = false;
                } else {
                    total += number;
                }
            }
            // The total is above the target.
            if (total > target){
                return false;
            }
            // The total is equal to the target, but not all spaces are filled.
            if (total == target && !allSpacesFilled){
                return false;
            }
            // The total is below the target and all spaces are filled.
            if (total < target && allSpacesFilled){
                return false;
            }
            // The same number appears multiple times, except 0.
            if (!(spaces.GroupBy(x => x.getNumber()).All(g => g.Count() == 1 || g.Key == 0))){
                return false;
            }
            return true;
        }
    }
}
