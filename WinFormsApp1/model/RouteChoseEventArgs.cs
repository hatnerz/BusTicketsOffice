using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class RouteChoseEventArgs : EventArgs
    {
        Route route;
        Stop departure;
        Stop destination;
        public RouteChoseEventArgs (Route route, Stop departure, Stop destination)
        {
            this.route = route;
            this.departure = departure;
            this.destination = destination;
        }
    }
}
