namespace Tamagotchi {
    class Cat {
        private int _hunger;
        public string Name {init; get;}
        public int Hunger {
            init => this._hunger = value;
            get => this._hunger;
        }
        public void Meow() {
            Console.WriteLine("meow! ");
        }

        public void Eat(Food food) {
            Console.WriteLine($"Cat eats {food.Name}. {food.Health} hp.");
        }
    }
}