namespace Tamagotchi {
    abstract class Pet {
        private int _hunger;
        //protected Timer _stateTimer;
        //protected StatusChecker _statusChecker;
        public string Name {init; get;}
        public int Hunger {
            init => this._hunger = value;
            get => this._hunger;
        }        
        public abstract string TypeName {get;}
        public abstract void Eat(Food food);
    }

    /*class StatusChecker {
        public void CheckStatus(Object stateInfo) {

        }
    }//*/
}