namespace KillerForward{
    public class ForwardRow{
        private List<ForwardSpace> spaces {get; set;}
        public int position {get; set;}

        public ForwardRow(int position){
            this.spaces = new List<ForwardSpace>();
            this.position = position;
        }

        public void addSpace(ForwardSpace space){
            this.spaces.Add(space);
            space.row = this;
        }

        public bool isValid(){
            // TOREMOVE: This should always return true, try later.
            // Check whether a number is only used once, except for 0.
            if (!(spaces.GroupBy(x => x.getNumber()).All(g => g.Count() == 1 || g.Key == 0))){
                return false;
            }
            // Check whether all spaces still have a possible number to use.
            foreach (ForwardSpace space in spaces){
                if (space.isPossibleNumbersEmpty()){
                    return false;
                }
            }
            // If it is valid, return true;
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