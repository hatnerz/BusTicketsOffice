using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Stop
    {
        private DateTime departure;
        private string stopName;
        private float price;
        
        public Stop(DateTime departure, string stopName, float price)
        {
            this.departure = departure;
            this.stopName = stopName;
            this.price = price;
        }
    }
}
