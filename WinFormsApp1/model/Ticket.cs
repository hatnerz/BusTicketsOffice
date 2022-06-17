using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WinFormsApp1
{
    public class Ticket
    {
        public float price { get; private set; }
        public int seatNumber { get; private set; }
        public string passangerPhoneNumber { get; private set; }
        public string departure { get; private set; }
        public string destination { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string patronymicName { get; private set; }

        public Ticket(float price, int seatNumber, string passangerPhoneNumber, 
            string departure, string destination, string firstName, string lastName, string patronymicName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymicName = patronymicName;
            this.price = price;
            this.seatNumber = seatNumber;
            this.passangerPhoneNumber = passangerPhoneNumber;
            this.departure = departure;
            this.destination = destination;
        }
    }
}
