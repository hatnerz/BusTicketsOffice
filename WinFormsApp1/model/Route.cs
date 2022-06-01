using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Route
    {
        private List<Stop> stops;
        private int routeNumber;
        private List<Ticket> tickets;
        private int numberOfSeats;
        public Route (List<Stop> stops, int routeNumber, int numberOfSeats)
        {
            this.stops = stops;
            this.routeNumber = routeNumber;
            this.numberOfSeats = numberOfSeats;
            tickets = new List<Ticket>();
        }
    }
}
