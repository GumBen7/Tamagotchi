namespace Tamagotchi {
    class Cat : Pet {
        private int _hunger;
        public string Name {init; get;}
        public override int Hunger {
            init => this._hunger = value;
            get => this._hunger;
        }
        public void Meow() {
            Console.WriteLine("meow! ");
        }

        public override void Eat(Food food) {
            Console.WriteLine($"Cat eats {food.Name}. {food.Health} hp.");
        }
    }
}