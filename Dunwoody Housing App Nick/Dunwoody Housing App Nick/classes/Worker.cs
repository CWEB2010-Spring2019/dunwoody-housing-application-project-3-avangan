using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunwoody_Housing_App_Nick.classes
{
 class  Worker :res 

   {
        
     public Worker(string first, string last, int id, int room, int floor, double rent) : base(first, last, id, room, floor, rent)

        {
            this.first = first;
            this.last = last;
            this.id = id;
            this.room = room;
            this.floor = floor;
            this.rent = rent;

        }

        public override string ToString()
        {
            return String.Format("Name" + first + " last " + last + " Floor " + floor);
        }

    }
}


