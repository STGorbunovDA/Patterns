using ChainOfResposibility.Classes.Base;

namespace ChainOfResposibility.Classes;

class PayPalPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.PayPalTransfer)
            Console.WriteLine("Выполняем перевод через PayPal");
        else if (Successor != null)
            Successor.Handle(receiver);
    }
}
