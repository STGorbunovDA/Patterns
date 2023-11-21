﻿/* Инфо

    * Декоратор (Decorator) представляет структурный шаблон проектирования, который позволяет 
      динамически подключать к объекту дополнительную функциональность.

    * Для определения нового функционала в классах нередко используется наследование. 
      Декораторы же предоставляет наследованию более гибкую альтернативу, поскольку 
      позволяют динамически в процессе выполнения определять новые возможности у объектов.

    * Когда следует использовать декораторы?
    
    * Когда надо динамически добавлять к объекту новые функциональные возможности. 
      При этом данные возможности могут быть сняты с объекта

    * Когда применение наследования неприемлемо. Например, если нам надо определить 
      множество различных функциональностей и для каждой функциональности наследовать 
      отдельный класс, то структура классов может очень сильно разрастись. 
      Еще больше она может разрастись, если нам необходимо создать классы, реализующие 
      все возможные сочетания добавляемых функциональностей.

    * Рассмотрим пример. Допустим, у нас есть пиццерия, которая готовит различные типы 
      пицц с различными добавками. Есть итальянская, болгарская пиццы. К ним могут добавляться 
      помидоры, сыр и т.д. И в зависимости от типа пицц и комбинаций добавок пицца может иметь 
      разную стоимость. Теперь посмотрим, как это изобразить в программе на C#:
*/

using Decorator.Clasees;

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza1 = new ItalianPizza();
        pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
        Console.WriteLine("Название: {0}", pizza1.Name);
        Console.WriteLine("Цена: {0}", pizza1.GetCost());

        Pizza pizza2 = new ItalianPizza();
        pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
        Console.WriteLine("Название: {0}", pizza2.Name);
        Console.WriteLine("Цена: {0}", pizza2.GetCost());

        Pizza pizza3 = new BulgerianPizza();
        pizza3 = new TomatoPizza(pizza3);
        pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
        Console.WriteLine("Название: {0}", pizza3.Name);
        Console.WriteLine("Цена: {0}", pizza3.GetCost());

        Console.ReadLine();
    }
}