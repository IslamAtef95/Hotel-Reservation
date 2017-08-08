using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    public class Room
    {
        public int roomno { get; set; }
        public bool reserved;

        public Room()
        {
            reserved = false;
        }
    }
}

