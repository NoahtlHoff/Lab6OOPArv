namespace Lab6OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize the animals, test a few methods, use makeSound method on all of them
            Fish fish1 = new Fish(_eyeColor: "Svarta", _color: "Orange", _isCute: true, _isPredator: false);
            fish1.drink();
            fish1.makeSound();
            fish1.Eat();
            Console.WriteLine();

            Cat cat1 = new Cat();
            cat1.drink();
            cat1.makeSound();
            cat1.Eat();
            Console.WriteLine();

            Bird bird1 = new Bird();
            bird1.makeSound();

            Werewolf werewolf1 = new Werewolf();
            werewolf1.makeSound();

            Dragon dragon1 = new Dragon();
            dragon1.makeSound();

            FantasyCreature fantasycreature1 = new FantasyCreature();
            fantasycreature1.makeSound();






        }
    }
}
