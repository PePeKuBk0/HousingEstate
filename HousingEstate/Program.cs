using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person martin = new Person("Martin","Holena",17);
            Console.WriteLine(martin.ToString());
            
            Flat piestanska = new Flat(24,100,4);
            Console.WriteLine(piestanska.ToString());

 
        }
    }
}
