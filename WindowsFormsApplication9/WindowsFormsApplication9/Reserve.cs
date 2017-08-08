using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    public class Reserve
    {
        public string name { get; set; }
        public DateTime Checkin;
        public DateTime Checkout;
        public Room room = new Room();
        public int num { get; set; }
        
    }
}
