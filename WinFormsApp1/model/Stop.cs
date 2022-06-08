using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Stop
    {
        public DateTime departure { get; private set; }
        public string stopName { get; private set; }
        public float price { get; private set; }
        public Stop(DateTime departure, string stopName, float price)
        {
            this.departure = departure;
            this.stopName = stopName;
            this.price = price;
        }
    }
}
