public abstract class Animal
{
    private string name;

    public Animal(string name)
    {
        this.name = name;
    }
    public void Greets()
    {
        System.Console.WriteLine("Good");
    }
    public  Animal(){}
}