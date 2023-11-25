﻿/* Инфо
    
    * Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования, который позволяет 
      избежать жесткой привязки отправителя запроса к получателю. Все возможные обработчики запроса образуют 
      цепочку, а сам запрос перемещается по этой цепочке. Каждый объект в этой цепочке при получении запроса 
      выбирает, либо закончить обработку запроса, либо передать запрос на обработку следующему по цепочке объекту. 

    * Использование цепочки обязанностей дает нам следующие преимущества:

        * Ослабление связанности между объектами. Отправителю и получателю запроса ничего не известно друг о друге. 
          Клиенту неизветна цепочка объектов, какие именно объекты составляют ее, как запрос в ней передается.

        * В цепочку с легкостью можно добавлять новые типы объектов, которые реализуют общий интерфейс.

        * В то же время у паттерна есть недостаток: никто не гарантирует, что запрос в конечном счете будет 
          обработан. Если необходимого обработчика в цепочки не оказалось, то запрос просто выходит из цепочки 
          и остается необработанным.

        * Использование паттерна довольно часто встречается в нашей жизни. Достаточно распространена ситуация, 
          когда чиновники перекладывают друг на друга по цепочке выполнения какого-нибудь дела, и оно в конце 
          концов оказывается не выполненным. Или когда мы идем в поликлинику, но при этом точно не знаем характер 
          заболевания. В этом случае мы идем к терапевту, а он в зависимости от заболевания уже может либо сам лечить, 
          либо отправить на лечение другим специализированным врачам.

        * Рассмотрим конкретный пример. Допустим, необходимо послать человеку определенную сумму денег. 
          Однако мы точно не знаем, какой способ отправки может использоваться: банковский перевод, системы 
          перевода типа WesternUnion и Unistream или система онлайн-платежей PayPal. Нам просто надо внести 
          сумму, выбрать человека и нажать на кнопку. Подобная система может использоваться на сайтах фриланса, 
          где все отношения между исполнителями и заказчиками происходят опосредованно через функции системы и где 
          не надо знать точные данные получателя.
*/

using ChainOfResposibility.Classes;
using ChainOfResposibility.Classes.Base;

class Program
{
    static void Main(string[] args)
    {
        Receiver receiver = new Receiver(false, false, true);

        PaymentHandler bankPaymentHandler = new BankPaymentHandler();
        PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
        PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

        bankPaymentHandler.Successor = moneyPaymentHadler;
        paypalPaymentHandler.Successor = moneyPaymentHadler;
        moneyPaymentHadler.Successor = bankPaymentHandler;
        moneyPaymentHadler.Successor = paypalPaymentHandler;

        bankPaymentHandler.Handle(receiver);


        Console.Read();
    }
}