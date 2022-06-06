using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Route
    {
        public List<Stop> stops { get; private set; }
        public int routeNumber { get; private set; }
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
