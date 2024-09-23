public class Manager : Employee
{
    // Override PaySalary for managers
    public override void PaySalary()
    {
        Console.WriteLine("Paying salary to a manager...");
    }

    // Override SendEmail for managers
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to a manager...");
    }
}
