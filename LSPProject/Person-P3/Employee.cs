public class Employee : Person
{
    // Override PaySalary for employees
    public virtual void PaySalary()
    {
        Console.WriteLine("Paying salary to an employee...");
    }

    // Override SendEmail for employees
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to an employee...");
    }
}
