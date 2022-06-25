using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Stop
    {
        public DateTime Departure { get; private set; }
        public string StopName { get; private set; }
        public float Price { get; private set; }
        public Stop (DateTime departure, string stopName, float price)
        {
            this.Departure = departure;
            this.StopName = stopName;
            this.Price = price;
        }
    }
}
