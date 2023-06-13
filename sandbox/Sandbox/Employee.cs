// a parent class
public class Employee
{
    private float salary = 100f;
    private int _id;

    public virtual float CalculatePay()
    {
        return salary;
    }
}
public class HourlyEmployee : Employee
{
    private float rate = 9f;
    private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours; // pay is calculated differently
    }

}