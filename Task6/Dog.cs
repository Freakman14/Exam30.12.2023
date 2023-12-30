public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    public void Greets()
    {
        System.Console.WriteLine("Woof");
    }
    public virtual void Greets(string dog)
    {
        System.Console.WriteLine("Wooooooooof");
    }
}