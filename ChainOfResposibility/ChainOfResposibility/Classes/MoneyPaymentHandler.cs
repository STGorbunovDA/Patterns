using ChainOfResposibility.Classes.Base;

namespace ChainOfResposibility.Classes;

// переводы с помощью системы денежных переводов
class MoneyPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.MoneyTransfer)
            Console.WriteLine("Выполняем перевод через системы денежных переводов");
        else if (Successor != null)
            Successor.Handle(receiver);
    }
}
