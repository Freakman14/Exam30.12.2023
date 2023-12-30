public class Staff : Person
{
    private string school = "Maktabi 46";
    private double pay = 9.0;

    public Staff(string name, string address, string school, double pay) : base(name, address)
    {
        this.school = school;
        this.pay = pay;
    }
    public string GetSchool()
    {
        return school;
    }
    public void SetSchool(string school)
    {
        this.school = school;
    }
    public double GetPay()
    {
        return pay;
    }
    public void SetPay(double pay)
    {
        this.pay = pay;
    }
    public override string ToString()
    {
        return $"Staff [{base.ToString()}], [ school= {school}, pay= {pay}]";
    }
    public Staff() { }
}