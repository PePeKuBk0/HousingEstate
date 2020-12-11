using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person martin = new Person("Jakub","Venetianer",16);
            Console.WriteLine(martin.ToString());
            
            Flat piestanska = new Flat(24,100,4);
            Console.WriteLine(piestanska.ToString());

            Person matej = new Person("pista","zavodsky",15);
            piestanska.AddHabitant(matej);
            piestanska.AddHabitant(martin);
            
        }
    }
}
