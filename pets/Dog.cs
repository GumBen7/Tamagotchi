namespace Tamagotchi {
    class Dog : Pet {
        public override string TypeName => "cat";
        public override void Eat(Food food) =>
            Console.WriteLine($"Dog eats {food.TypeName}. {food.Health} hp.");
        public void Woof() => Console.WriteLine("woof! ");
    }
}