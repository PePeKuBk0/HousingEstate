using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person("Jakub","Venetianer",16);
            Console.WriteLine(A.ToString());
            
            Flat B = new Flat(24,100,4);
            Console.WriteLine(B.ToString());
        }
    }
}
