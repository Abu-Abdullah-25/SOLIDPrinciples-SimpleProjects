public class Car : MotorVehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started...");
    }

    public override void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}
