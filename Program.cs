namespace Tamagotchi {
    class Program {
        static void Main(string[] args) {
            Cat pushok = new Cat() {Name = "Pushok", Hunger = 5};
            pushok.Meow();
            Apple apple = new Apple {Health = 10};            
            Orange orange = new Orange {Health = 5};
            DoMeal(pushok, apple);
            DoMeal(pushok, apple);
            DoMeal(pushok, orange);
        }

        static void DoMeal(Cat cat, Food food) {
            cat.Eat(food);
        }
    }
}