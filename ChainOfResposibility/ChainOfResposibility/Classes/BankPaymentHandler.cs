using ChainOfResposibility.Classes.Base;

namespace ChainOfResposibility.Classes;

class BankPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.BankTransfer)
            Console.WriteLine("Выполняем банковский перевод");
        else if (Successor != null)
            Successor.Handle(receiver);
    }
}
