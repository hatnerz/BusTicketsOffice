namespace WinFormsApp1
{
    public class Ticket
    {
        public string RouteInfo { get; private set; }
        public float Price { get; private set; }
        public int SeatNumber { get; private set; }
        public string PassangerPhoneNumber { get; private set; }
        public string Departure { get; private set; }
        public string Destination { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PatronymicName { get; private set; }
        public string FullName
        {
            get { return FirstName + " " + LastName + " " + PatronymicName; }
        }

        public Ticket(string routeInfo, float price, int seatNumber, string passangerPhoneNumber,
            string departure, string destination, string firstName, string lastName, string patronymicName)
        {
            this.RouteInfo = routeInfo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PatronymicName = patronymicName;
            this.Price = price;
            this.SeatNumber = seatNumber;
            this.PassangerPhoneNumber = passangerPhoneNumber;
            this.Departure = departure;
            this.Destination = destination;
        }
    }
}
