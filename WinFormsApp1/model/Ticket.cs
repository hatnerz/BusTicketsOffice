using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Ticket
    {
        private Route route;
        private float price;
        private int seatNumber;
        private Passanger passanger;
        private Stop departure;
        private Stop destination;
        public Ticket(Route route, float price, int seatNumber, Passanger passanger, Stop departure, Stop destination)
        {
            this.route = route;
            this.price = price;
            this.seatNumber = seatNumber;
            this.passanger = passanger;
            this.departure = departure;
            this.destination = destination;
        }
    }
}
