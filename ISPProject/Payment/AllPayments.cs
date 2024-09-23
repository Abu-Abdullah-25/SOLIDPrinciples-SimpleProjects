public class AllPayments : ICreditCardPayment, IPayPalPayment, IBitCoinPayment
{
    public void PayWithBitcoin()
    {
        throw new NotImplementedException();
    }

    public void PayWithPayPal()
    {
        throw new NotImplementedException();
    }

    void ICreditCardPayment.PayWithCreditCard()
    {
        throw new NotImplementedException();
    }
}
