namespace Tamagotchi {
    class Cat : Pet {
        public Cat(){
            }// => this._stateTimer = new Timer(this._statusChecker.CheckStatus, 1000, 1000);
        public override string TypeName => "cat";
        public override void Eat(Food food) =>
            Console.WriteLine($"Cat eats {food.TypeName}. {food.Health} hp.");
        public void Meow() => Console.WriteLine("meow! ");
    }
}