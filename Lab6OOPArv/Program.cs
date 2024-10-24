namespace Lab6OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish fish1 = new Fish(_eyeColor: "Svarta", _color: "Orange", _isCute: true, _isPredator: false);
            fish1.drink();
            fish1.makeSound();
            fish1.Eat();
            Console.WriteLine(fish1.name);


 
        }
    }
}
