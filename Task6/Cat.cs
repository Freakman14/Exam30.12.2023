public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
    public void Greets()
    {
        System.Console.WriteLine("Meow");
    }
}