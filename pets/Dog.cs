namespace Tamagotchi {
    class Dog : Pet {
        public override string TypeName => "dog";
        public override void Eat(Food food) {
            base.Eat(food);
            Console.WriteLine($"dog eats {food.TypeName}. {food.Health} hp.");
        }
        public void Woof() => Console.WriteLine("woof! ");

        public override void Voice() {
            this.Woof();
        }

    }
}