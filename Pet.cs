namespace Tamagotchi {
    abstract class Pet {
        public abstract int Hunger {init; get;}
        public abstract void Eat(Food food);
    }
}