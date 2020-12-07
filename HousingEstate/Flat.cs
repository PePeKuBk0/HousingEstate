using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        private List<Person> persones = new List<Person>();

        public List<Person> Persones { get; set; }

        private int flatNumber;
        private int area;
        private int numberOfRooms;

        public int FlatNumber { get; set; }
        public int Area { get; set; }
        public int NumberOfRooms { get; set; }

        public Flat(int flatNumber, int area, int numberOfRooms)
        {
            this.flatNumber = flatNumber;
            this.area = area;
            this.numberOfRooms = numberOfRooms;
        }
        public override string ToString()
        {
            return $"FlatNumber:{this.flatNumber} \narea:{this.area} \nnumberOfRooms:{this.numberOfRooms}";
        }
            
    }
}
