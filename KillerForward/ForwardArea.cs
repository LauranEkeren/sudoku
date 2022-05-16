namespace KillerForward {
    public class ForwardArea {
        // Logic for adding space and coupling this class to it.
        // Add possible number to its spaces.
        // Remove possible number from its spaces.
        // Check whether one of its spaces can be se to a number.
        // remove a few of the possible number using area logic.

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

        public ForwardArea(int target, List<ForwardSpace> spaces){
            this.target = target;
            this.spaces = spaces;
        }

        public void removePossibleNumberFromAll(int number){
            foreach (ForwardSpace space in spaces){
                space.removePossibleNumber(number);
            }
        }

        public void setAreaIfSizeIsOne(){
            if (this.spaces.Count() == 1){
                ForwardSpace space = this.spaces[0];
                space.setNumber(this.target);
                for (int i = 1; i <= 9; i++){
                    if (i != this.target){
                        space.removePossibleNumber(i);
                    }
                }
            }
            
        }

        public void removePossibleNumberUpperStart(){
            int highestPossible = 9;
            if (this.spaces.Count() == 2 && this.target <= 9){
                highestPossible = target - 1;
            } else if (this.spaces.Count() == 3 && this.target <= 11){
                highestPossible = target - 3;
            } else if (this.spaces.Count() == 4 && this.target <= 15){
                highestPossible = target - 4;
            } else if (this.spaces.Count() == 5 && this.target <= 18){
                highestPossible = target - 4;
            } 
            for (int i = 9; i > highestPossible; i--){
                this.removePossibleNumberFromAll(i);
            }

        }

        public void removePossibleNumberLowerStart(){
            int lowestPossible = 1;
            if (this.spaces.Count() == 2 && this.target >= 11){
                lowestPossible = this.target - 9;
            } else if (this.spaces.Count() == 3 && this.target >= 19){
                lowestPossible = this.target - 17;
            } else if (this.spaces.Count() == 4 && this.target >= 26){
                lowestPossible = this.target - 24;
            } else if (this.spaces.Count() == 5 && this.target >= 32){
                lowestPossible = this.target - 30;
            }
            
            for (int i = 1; i < lowestPossible; i++){
                    this.removePossibleNumberFromAll(i);
            }

        }

        public void removePossibleNumberDoubleStart(){
            if (this.spaces.Count() == 2 && this.target % 2 == 0){
                this.removePossibleNumberFromAll(this.target / 2);
            }
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
            // if (!(spaces.GroupBy(x => x.getNumber()).All(g => g.Count() == 1 || g.Key == 0))){
            //     return false;
            // }
            // Check whether all spaces still have a possible number to use.
            // foreach (ForwardSpace space in spaces){
            //     if (space.isPossibleNumbersEmpty()){
            //         return false;
            //     }
            // }
            return true;
        }

        public void addPossibleNumberToSpaces(int number){
            foreach (ForwardSpace space in spaces){
                space.addPossibleNumber(number);
            }
        }

        public void removePossibleNumberFromSpacesExceptGiven(ForwardSpace space, int number){
            // It should remove the number from all possiblespaces, except the space given.
            foreach (ForwardSpace currentspace in spaces){
                if (currentspace != space){
                    currentspace.removePossibleNumber(number);
                }
            }
        }

        public bool areaValidWithGivenList(List<int> numbers, int numberToSet, ForwardSpace spaceToSet){
            // update lijst met huidige numbers.
            int total = 0;
            bool filled = true;
            int numberToChangeFrom = spaceToSet.getNumber();
            for (int i = 0; i < numbers.Count(); i++){
                if (numbers[i] == numberToChangeFrom){
                    numbers[i] = numberToSet;
                    break;
                }
            }
            for (int i = 0; i < numbers.Count(); i++){
                total += numbers[i];
                if (numbers[i] == 0){
                    filled = false;
                }
            }
            // check for:
            // The total is above the target.
            if (total > this.target){
                return false;
            }
            // The total is equal to the target, but not all spaces are filled.
            if (total == this.target && !filled){
                return false;
            }
            // The total is below the target and all spaces are filled.
            if (total < target && filled){
                return false;
            }
            return true;
        }

        public bool canSpaceBeSetToNumber(ForwardSpace space, int number){
            //TODO: This does not check whether number follows the rule of the area.
            // Lijst met hudige getallen.
            List<int> newList = new List<int>();
            foreach (ForwardSpace spaceInList in this.spaces){
                newList.Add(spaceInList.getNumber());
            }
            if (!areaValidWithGivenList(newList, number, space)){
                return false;
            }

            // Check whether the space is in our area, otherwise we can't really do anyouthing about it.
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

        public void printPossibleNumbers(){
            foreach (ForwardSpace space in this.spaces){
                Console.Write("[");
                foreach (int number in space.getPossibleNumbers()){
                    Console.Write(number + ", ");
                }
                Console.Write("] \n");
            }
        }
    }
}