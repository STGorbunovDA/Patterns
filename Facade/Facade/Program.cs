﻿/* Инфо

    * Фасад (Facade) представляет шаблон проектирования, который позволяет скрыть сложность 
      системы с помощью предоставления упрощенного интерфейса для взаимодействия с ней.

    * Когда использовать фасад?
    
    * Когда имеется сложная система, и необходимо упростить с ней работу. Фасад позволит 
      определить одну точку взаимодействия между клиентом и системой.

    * Когда надо уменьшить количество зависимостей между клиентом и сложной системой. 
      Фасадные объекты позволяют отделить, изолировать компоненты системы от клиента 
      и развивать и работать с ними независимо.

    * Когда нужно определить подсистемы компонентов в сложной системе. Создание фасадов 
      для компонентов каждой отдельной подсистемы позволит упростить взаимодействие между 
      ними и повысить их независимость друг от друга.

    * Рассмотрим применение паттерна в реальной задаче. Думаю, большинство программистов 
      согласятся со мной, что писать в Visual Studio код одно удовольствие по сравнению 
      с тем, как писался код ранее до появления интегрированных сред разработки. 
      Мы просто пишем код, нажимаем на кнопку и все - приложение готово. В данном случае 
      интегрированная среда разработки представляет собой фасад, который скрывает всю сложность 
      процесса компиляции и запуска приложения. Теперь опишем этот фасад в программе на C#:
*/

using Facade.Classes;

class Program
{
    static void Main(string[] args)
    {
        TextEditor textEditor = new TextEditor();
        Compiller compiller = new Compiller();
        CLR clr = new CLR();

        VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

        Programmer programmer = new Programmer();
        programmer.CreateApplication(ide);

        Console.Read();
    }
}