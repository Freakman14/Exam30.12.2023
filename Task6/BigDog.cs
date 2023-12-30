public class BigDog : Dog
{
    public BigDog(string name) : base(name)
    {
    }
    public void Greets()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void Greets(string dog)
    {
        base.Greets(dog);
        System.Console.WriteLine("Wooooooooooooooow");
    }
    // public  void Greets(string BigDog)
    // {
    //     System.Console.WriteLine();
    // }
}