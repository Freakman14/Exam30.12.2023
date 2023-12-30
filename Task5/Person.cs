public class Person
{
    private string name="Fill";
    private string address="Firdavsi";


    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
    public string GetName()
    {
        return name;
    }
    public string GetAddress()
    {
        return address;
    }
    public void SetAddress(string address)
    {
        this.address = address;
    }
    public override string ToString()
    {
        return $"Person [Name= {name}, address= {address}]";
    }

    public Person(){}
}