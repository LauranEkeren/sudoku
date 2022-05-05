namespace KillerForward {
    public class ForwardArea {
        // Logic for adding space and coupling this class to it.
        // Add possible number to its spaces.
        // Remove possible number from its spaces.
        // Check whether one of its spaces can be se to a number.
        //TODO: immediatly remove a few of the possible number using area logic.

        public List<ForwardSpace> spaces {get; set;}
        public int target {get; set;}

        public ForwardArea(int target, List<int> positions, ForwardKillerSudoku killerSudokuDumb){
            this.spaces = new List<ForwardSpace>();
            this.target = target;
            // Fill spaces with relevent spaces, using positions and given killerSudoku.
            foreach (int position in positions){
                this.addSpace(killerSudokuDumb.getSpace(position));
            }
        }

        public void removePossibleNumber(int number){
            foreach (ForwardSpace space in spaces){
                space.removePossibleNumber(number);
            }
        }

        public void removePossibleNumberUpperStart(){
            //TODO
        }

        public void removePossibleNumberLowerStart(){
                        //TODO

        }

        public void removePossibleNumberDoubleStart(){
            //TODO
        }

        public void addSpace(ForwardSpace space){
            this.spaces.Add(space);
            space.area = this;
        }

        public bool Isvalid(){
            int total = 0;
            bool allSpacesFilled = true;
            foreach(ForwardSpace space in spaces){
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
            // Check whether all spaces still have a possible number to use.
            foreach (ForwardSpace space in spaces){
                if (space.isPossibleNumbersEmpty()){
                    return false;
                }
            }
            return true;
        }

        public void addPossibleNumberToSpaces(int number){
            foreach (ForwardSpace space in spaces){
                space.addPossibleNumber(number);
            }
        }

        public void removePossibleNumberFromSpaces(ForwardSpace space, int number){
            // It should remove the number from all possiblespaces, except the space given.
            foreach (ForwardSpace currentspace in spaces){
                if (currentspace != space){
                    currentspace.removePossibleNumber(number);
                }
            }
        }

        public bool canSpaceBeSetToNumber(ForwardSpace space, int number){
            //TODO: This does not check whether number follows the rule of the area.
            // Check whether the space is in our row, otherwise we can't really do anyouthing about it.
            if (!spaces.Contains(space)){
                return false;
            }
            // Check for each space except the one given if the number can be removed .
            foreach (ForwardSpace currentSpace in spaces){
                if (currentSpace != space && !currentSpace.canNumberBeRemoved(number)) {
                    return false;
                }
            }
            return true;
        }

        public List<ForwardSpace> getSpaces(){
            return this.spaces;
        }
    }
}