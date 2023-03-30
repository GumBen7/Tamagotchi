namespace Tamagotchi {
    class Cat : Pet {
        public override string TypeName => "cat";
        public override void Eat(Food food) { 
            base.Eat(food);
            Console.WriteLine($"cat eats {food.TypeName}. {food.Health} hp.");
        }
        public void Meow() => Console.WriteLine("meow! ");
        public override void Voice() {
            this.Meow();
        }
    }
}