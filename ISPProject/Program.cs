
using System;
using System.Drawing;


public class Program
{
    public static void Main()
    {
        #region Printer
        BasicPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("Hi, My Name is Abu-Hahdoud");


        AdvancedPrinter advancedPrinter = new AdvancedPrinter();
        advancedPrinter.Print("Hi, My Name is Abu-Hahdoud");
        advancedPrinter.Scan();
        advancedPrinter.Fax();
        advancedPrinter.Copy();
        #endregion

        #region Device
        Smartphone smartphone = new Smartphone();
        Console.WriteLine("SmartPhone:");
        smartphone.MakeCall();
        smartphone.TakePhoto();
        smartphone.SendEmail();
        smartphone.UseGPS();

        Computer computer = new Computer();
        Console.WriteLine("\nComputer:");
        computer.SendEmail();




        Camera camera = new Camera();
        Console.WriteLine("\nCamera:");
        camera.TakePhoto();


        AdvancedCamera advancedCamera = new AdvancedCamera();
        Console.WriteLine("\nAdvanced Camera:");
        advancedCamera.TakePhoto();
        advancedCamera.SendEmail();

        #endregion

        #region Payment
        ICreditCardPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();
        // creditCardPayment.PayWithPayPal();
        // creditCardPayment.PayWithBitcoin ();

        IPayPalPayment payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();

        IBitCoinPayment payBitcoinPayment = new BitcoinPayment();
        payBitcoinPayment.PayWithBitcoin();
        #endregion

        Console.ReadKey();

    }
}
