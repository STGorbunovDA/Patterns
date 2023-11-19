﻿/* Инфо

    * Например, мы делаем игру, где пользователь должен управлять некими супергероями, при этом каждый супергерой 
      имеет определенное оружие и определенную модель передвижения. Различные супергерои могут определяться 
      комплексом признаков. Например, эльф может летать и должен стрелять из арбалета, другой супергерой 
      должен бегать и управлять мечом. Таким образом, получается, что сущность оружия и модель передвижения 
      являются взаимосвязанными и используются в комплексе. То есть имеется один из доводов в пользу 
      использования абстрактной фабрики.

    * И кроме того, наша задача при проектировании игры абстрагировать создание супергероев от самого класса 
      супергероя, чтобы создать более гибкую архитектуру. И для этого применим абстрактную фабрику:
*/

using AbstractFactory.Classes;

class Program
{
    static void Main(string[] args)
    {
        Hero elf = new Hero(new ElfFactory());
        elf.Hit();
        elf.Run();

        Hero voin = new Hero(new VoinFactory());
        voin.Hit();
        voin.Run();

        Console.ReadLine();
    }
}