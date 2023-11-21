﻿/* Инфо

    * Паттерн Заместитель (Proxy) предоставляет объект-заместитель, который управляет доступом 
      к другому объекту. То есть создается объект-суррогат, который может выступать в роли 
      другого объекта и замещать его.

    * Когда использовать прокси?
    
        * Когда надо осуществлять взаимодействие по сети, а объект-проси должен имитировать 
          поведения объекта в другом адресном пространстве. Использование прокси позволяет 
          снизить накладные издержки при передачи данных через сеть. Подобная ситуация 
          еще называется удалённый заместитель (remote proxies)

        * Когда нужно управлять доступом к ресурсу, создание которого требует больших затрат. 
          Реальный объект создается только тогда, когда он действительно может понадобится, 
          а до этого все запросы к нему обрабатывает прокси-объект. Подобная ситуация еще 
          называется виртуальный заместитель (virtual proxies)

        * Когда необходимо разграничить доступ к вызываемому объекту в зависимости от прав 
          вызывающего объекта. Подобная ситуация еще называется защищающий заместитель 
          (protection proxies)

        * Когда нужно вести подсчет ссылок на объект или обеспечить потокобезопасную работу 
          с реальным объектом. Подобная ситуация называется "умные ссылки" (smart reference)

    * Рассмотрим применение паттерна. Допустим, мы взаимодействуем с базой данных 
      через Entity Framework. У нас есть модель и контекст данных класс Page.

    * Итак, здесь определен общий интерфейс IBook для реального объекта и для его прокси-класса. 
      Он определяет один метод GetPage() для получения страницы по номеру.

    * Реальный объект BookStore использует контекст данных для извлечения информации о странице 
      из базы данных. Действие же прокси-класса отличается. Прокси определяет дополнительный 
      объект - список pages. При получении страницы прокси сначала смотрит в этот список, 
      и если там страницы не окажется, то идет обращение к реальному объекту BookStore 
      и его методу. То есть фактически будет реализована функциональность кэша страниц.

    * Клиент, в роли которого в данном случае выступает класс Program, вообще не будет знать, 
      использует ли он функционал класса BookStore или его прокси.

    * В то же время паттерн Прокси имеет недостаток: поскольку иногда будет выполняться сначала 
      функционал прокси, а потом функционал реального объекта, например, если страницы не 
      окажется в списке-кэше, то это может привести к замедлению выполнения программы.
    
*/

using Proxy.Classes;
using Proxy.Interface;

class Program
{
    static void Main(string[] args)
    {
        using (IBook book = new BookStoreProxy())
        {
            // читаем первую страницу
            Page page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
            // читаем вторую страницу
            Page page2 = book.GetPage(2);
            Console.WriteLine(page2.Text);
            // возвращаемся на первую страницу    
            page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
        }

        Console.Read();
    }
}