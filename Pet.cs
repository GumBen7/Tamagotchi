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
        public virtual void Eat(Food food) {
            this._hunger += food.Health;
        }

        public abstract void Voice();

        public void TryToPlay() {
            if (_hunger < 5) {
                Console.WriteLine($"{this.TypeName} can't play");
            } else {
            this.Voice();
            this.Voice();
            this.Voice();
            }
        }
    }

    /*class StatusChecker {
        public void CheckStatus(Object stateInfo) {

        }
    }//*/
}