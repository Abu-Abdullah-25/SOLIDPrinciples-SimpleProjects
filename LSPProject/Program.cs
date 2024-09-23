using System;

public class Program
{
    public static void Main(string[] args)
    {
        #region Bird
        FlyingBird bird1 = new Eagle();
        bird1.Eat();
        bird1.Fly();


        Bird bird2 = new Ostrich();
        bird2.Eat();
        // bird2.Fly();  // Throws an exception, violating LSP

        #endregion

        #region Vehicle
        MotorVehicle vehicle1 = new Car();
        vehicle1.StartEngine();
        vehicle1.Drive();

        Vehicle vehicle2 = new Bicycle();

        vehicle2.Drive();        // Behaves as expected for a bicycle.

        #endregion

        #region Person
        Employee person1 = new Employee();
        person1.PaySalary();   
        person1.SendEmail();   

        Employee person2 = new Manager();
        person2.PaySalary();  
        person2.SendEmail();  

        Person person3 = new Student();
        person3.SendEmail();

        #endregion

        Console.ReadKey();

    }
}