namespace KillerForward {
    public class ForwardSpace {
        // TODO
        // Bijhouden welke mogelijke getallen hij kan hebben.
        
        private int number {get; set;}
        public int position {get;}
        private bool filled {get; set;}
        private List<int> possibleNumbers {get; set;}
        public ForwardRow? row {get; set;}
        public ForwardColumn? column {get; set;}
        public ForwardSquare? square {get; set;}
        public ForwardArea? area {get; set;}
        
        public ForwardSpace(int position){
            this.number = 0;
            this.position = position;
            this.filled = false;
            this.possibleNumbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};
        }

        public bool setNumber(int number){
            // If number is equal to the current number, nothing happens.
            int numberToChange = this.number;
            if (this.number == number){
                return true;
            }
            // If number gets set to 0 from another number, 
            // Number must be set to 0;
            // spaces must be added to everything else and this space.
            if (number == 0){
                this.number = 0;
                this.setPossibleNumberAll(numberToChange);
                return true;
            }
            // If number gets set to another number from 0, 
            // It must be checked.
            // Spaces must be removed from everything else.
            if (this.number == 0){
                // If we can't set number, we stop.
                if (!canSetNumber(number)){
                    return false;
                } else {
                    // Set number, remove everything else.
                    this.number = number;
                    this.removePossibleNumberOthers(number);
                    return true;
                }
            }
            // If number gets set from a number to another number.
            // Set this space to 0 first, so possible numbers get updated.
            this.setNumber(0);
            // If we can't set the number, we stop.
            if (!canSetNumber(number)){
                return false;
            } else {
                // Set number, remove everything else.
                this.number = number;
                this.removePossibleNumberOthers(number);
                return true;
            }
        }

        public void setPossibleNumberAll(int number){
            this.addPossibleNumber(number);
            this.row.addPossibleNumberToSpaces(number);
            this.column.addPossibleNumberToSpaces(number);
            this.square.addPossibleNumberToSpaces(number);
            this.area.addPossibleNumberToSpaces(number);
        }

        public void removePossibleNumberOthers(int number){
            this.row.removePossibleNumberFromSpaces(this, number);
            this.column.removePossibleNumberFromSpaces(this, number);
            this.square.removePossibleNumberFromSpaces(this, number);
            this.area.removePossibleNumberFromSpaces(this, number);
        }

        public bool canSetNumber(int number){
            // It must be checked wheter number is in our possible numbers.
            if (!this.possibleNumbers.Contains(number)){
                return false;
            }
            // check row.
            if (!this.row.canSpaceBeSetToNumber(this, number)){
                return false;
            }
            // check column.
            if (!this.column.canSpaceBeSetToNumber(this, number)){
                return false;
            }
            // check square.
            if (!this.square.canSpaceBeSetToNumber(this, number)){
                return false;
            }
            // check area.
            if (!this.area.canSpaceBeSetToNumber(this,number)){
                return false;
            }
            return true;
        }

        public int getNumber(){
            return this.number;
        }

        public bool isFilled(){
            return this.filled;
        }

        public List<int> getPossibleNumbers(){
            return this.possibleNumbers;
        }

        public void addPossibleNumber(int value){
            // Check whether the number is already possible.
            if (possibleNumbers.Contains(value)){
                return;
            } 
            // Check whether the number is possible in the row.
            foreach (ForwardSpace space in row.getSpaces()){
                if (space.number == value){
                return;
                }
            }
            // Check whether the number is possible in the area.
            foreach (ForwardSpace space in area.getSpaces()){
                if (space.number == value){
                return;
                }
            }
            // Check whether the number is possible in the square.
            foreach (ForwardSpace space in square.getSpaces()){
                if (space.number == value){
                return;
                }
            }
            // Check whether the number is possible in the column
            foreach (ForwardSpace space in column.getSpaces()){
                if (space.number == value){
                return;
                }
            }
            // If all are possible, add the number. Else do nothing.
            this.possibleNumbers.Add(value);
        }

        public void removePossibleNumber(int number){
            possibleNumbers.Remove(number);
        }

        public bool canNumberBeRemoved(int number){
            // If removing the number makes possible numbers empty, the number cannot be removed, and the function must return false.
            if (possibleNumbers.Count() == 1 && possibleNumbers.Contains(number)){
                return false;
            } else {
                // Else  return true.
                return true;
            }
        }

        public bool isPossibleNumbersEmpty(){
            return this.possibleNumbers.Count() == 0;
        }

        public string possibleNumbersToString(){
            string numbers = "";
            foreach(int number in possibleNumbers){
                numbers += number;
            }
            return numbers;
        }




    }
}

