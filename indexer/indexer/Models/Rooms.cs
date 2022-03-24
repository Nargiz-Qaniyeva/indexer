using System;
using System.Collections.Generic;
using System.Text;

namespace indexer.Models
{
    internal class Rooms
    {
        public int Id { get; set; }
        static  int IdCounter=0;
        public Rooms()
        {
            Id = ++IdCounter;
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable(bool no)
        {
            bool defalt = true;
            if (true)
            {
                return true ;
            }
            else
            {
                return false;
            }
        }
        public Rooms(string name, int price, int personcapacity)
        {
            this.Name = name;
            this.Price = price;
            this.PersonCapacity = personcapacity;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}+ Name:{Name}+ Price:{Price}+PersonCapacity:{PersonCapacity}");
        }
        public override string ToString()
        {
            
            return "Room:"+Id+ " "+ Name+ " "+ Price+ " "+ PersonCapacity;
        }

        public static implicit operator Rooms(Room v)
        {
            throw new NotImplementedException();
        }
    }
}
