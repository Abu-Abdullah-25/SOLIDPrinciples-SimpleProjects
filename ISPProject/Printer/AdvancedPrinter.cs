public class AdvancedPrinter : IAdvancedPrinter
{
    public void Print(string content)
    {
        Console.WriteLine($"Printing: {content}");
    }

    public void Scan()
    {
        Console.WriteLine($"Scanning..");
    }

    public void Fax()
    {
        Console.WriteLine($"Faxing...");
    }

    public void Copy()
    {
        Console.WriteLine($"Copying...");
    }
}
