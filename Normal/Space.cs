namespace Normal
{
    public class Space
    {
        private int number {get; set;}
        public int position {get;}
        private bool isFilled {get; set;}



        public Space(int position){
            this.number = 0;
            this.position = position;
            this.isFilled = false;
            // this.possibleNumbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};
        }

        public void setNumber(int number){
            if (number == 0){
                this.isFilled = false;
            } else {
                this.isFilled = true;
            }
            this.number = number;
        }

        public int getNumber(){
            return this.number;
        }


    }
}
