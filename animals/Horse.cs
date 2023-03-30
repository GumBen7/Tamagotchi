namespace Tamagotchi {
    class Horse : Animal
    {
        public override string TypeName => "horse";
        public void Neigh() => Console.WriteLine("neigh!");
        public override void Voice() {
            throw new NotImplementedException();
        }
    }
}