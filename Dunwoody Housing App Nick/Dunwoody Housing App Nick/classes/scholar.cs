using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunwoody_Housing_App_Nick.classes
{
    class scholar : res 
    {
        public Double RoomBoard
        {
            get; set;
        }

    public scholar(string first, string last, int id, int room, int floor, double rent) : base(first, last, id, room, floor, rent)

        {
            this.first = first;
            this.last = last;
            this.id = id;
            this.room = room;
            this.floor = floor;
            this.rent = rent;

        }


    }
}



