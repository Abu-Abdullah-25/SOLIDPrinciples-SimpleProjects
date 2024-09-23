public class Student : Person
{

    // Override SendEmail for students
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to a student...");
    }
}
