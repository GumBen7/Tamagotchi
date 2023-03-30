namespace Tamagotchi {
    abstract class Animal {
        private int _hunger;
        public int Hunger {
            init => this._hunger = value;
            get => this._hunger;
        }
        public string Name { init; get; }        
        public abstract string TypeName { get; }
        public abstract void Voice();
        public virtual void Eat(Food food) {
            this._hunger += food.Health;
        }
    }
}