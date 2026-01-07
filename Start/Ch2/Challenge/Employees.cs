// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee {
    public Employee() {}

    // YOUR CODE GOES HERE
    public required int ID { get; init;}
    public required string Department { get; set;}
    public required string FullName { get; set;}

    public override string ToString() => $"{ID}:{FullName}, {Department} ";

    public virtual void AdjustPay(decimal percentage)
    {
        Console.WriteLine("Going to be overridden");
    }
}

public class HourlyEmployee : Employee
{
    public decimal PayRate { get; set;}

    public override void AdjustPay(decimal percentage)
    {
        PayRate += PayRate * (percentage / 100);
    }

}

public class SalariedEmployee : Employee
{
    public decimal Salary { get; set;}

    public override void AdjustPay(decimal percentage)
    {
        Salary += Salary * (percentage / 100);
    }
}
// DEFINE OTHER CLASSES HERE
