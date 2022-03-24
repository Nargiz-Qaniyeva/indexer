using System;
using System.Collections.Generic;
using System.Text;

namespace indexer.Models
{
    public class Hotel
    {
        public int name;
        public Rooms[] room;
        public Hotel(int length)
        {
            room = new Rooms[length];
        }
        public Hotel()
        {
            this.name = name;
        }
        //public Nullable<int> MakeReservation;

        public Rooms this[int index]
        {
            get 
            {
                if (index <= room.Length)
                {
                    return room[index];
                }
                throw new Exception();
            }
            set 
            {
                if(index <= room.Length)
                {
                    room[index] = value;
                    return;
                }
                throw new Exception();
            }
        }
     
    }
    
}
