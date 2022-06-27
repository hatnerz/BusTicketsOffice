namespace WinFormsApp1
{
    public class Route
    {
        public List<Stop> Stops { get; private set; }
        public int RouteNumber { get; private set; }
        public List<Ticket> Tickets { get; set; }
        public int NumberOfSeats { get; private set; }
        private bool[,] occupiedSeats { get; set; }
        public string StringInfo
        {
            get
            {
                string rez = Convert.ToString(RouteNumber);
                rez += " ";
                rez += Stops[0].StopName;
                rez += " - ";
                rez += Stops.Last().StopName;
                return rez;
            }
        }
        public bool[] OccupiedSeatsSerialize
        {
            get
            {
                bool[] temp = new bool[occupiedSeats.Length];
                int index = 0;
                for (int i = 0; i < NumberOfSeats; i++)
                {
                    for (int j = 0; j < Stops.Count; j++)
                    {
                        temp[index++] = occupiedSeats[i, j];
                    }
                }
                return temp;
            }
            set
            {
                int index = 0;
                for (int i = 0; i < NumberOfSeats; i++)
                {
                    for (int j = 0; j < Stops.Count; j++)
                    {
                        occupiedSeats[i, j] = value[index++];
                    }
                }
            }
        }
        public Route(List<Stop> stops, int routeNumber, int numberOfSeats)
        {
            this.Stops = stops;
            this.RouteNumber = routeNumber;
            this.NumberOfSeats = numberOfSeats;
            Tickets = new List<Ticket>();
            occupiedSeats = new bool[numberOfSeats, stops.Count];
        }
        public Stop FindStopByStopName(string stopName)
        {
            foreach (Stop stop in Stops)
            {
                if (stop.StopName == stopName)
                    return stop;
            }
            return Stops[Stops.Count - 1];
        }

        public int FindStopIndexByName(string stopName)
        {
            for (int i = 0; i < Stops.Count; i++)
            {
                if (Stops[i].StopName == stopName)
                    return i;
            }
            return -1;
        }
        public void AddTicket(string departure, string destination, string phoneNumber, int seatNumber,
            string firstName, string lastName, string patronymicName)
        {
            int startIndex = FindStopIndexByName(departure);
            int endIndex = FindStopIndexByName(destination);
            float price = 0;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                price += Stops[i].Price;
            }
            Ticket temp = new Ticket(this.StringInfo, price, seatNumber, phoneNumber, departure, destination,
                firstName, lastName, patronymicName);
            Tickets.Add(temp);
            for (int i = startIndex; i < endIndex; i++)
            {
                occupiedSeats[seatNumber - 1, i] = true;
            }
        }
        public void DeleteTicket(Ticket t)
        {
            int departureIndex = FindStopIndexByName(t.Departure);
            int destinationIndex = FindStopIndexByName(t.Destination);
            for (int i = departureIndex; i < destinationIndex; i++)
                occupiedSeats[t.SeatNumber - 1, i] = false;
            Tickets.Remove(t);
        }

        public List<int> GetFreeSeats(int startIndex, int endIndex)
        {
            List<int> freeSeats = new List<int>();
            bool correct = true;
            for (int i = 0; i < NumberOfSeats; i++)
            {
                correct = true;
                for (int j = startIndex; j < endIndex; j++)
                {
                    if (occupiedSeats[i, j] == true)
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    freeSeats.Add(i + 1);
                }
            }
            return freeSeats;
        }
        public float GetPrice(int departureIndex, int destinationIndex)
        {
            float sumPrice = 0;
            try
            {
                for (int i = departureIndex + 1; i <= destinationIndex; i++)
                    sumPrice += Stops[i].Price;
            }
            catch
            {
                return -1;
            }
            return sumPrice;
        }

        public List<Ticket> GetEnterPassangers(string stopName)
        {
            List<Ticket> temp = new List<Ticket>();
            for (int i = 0; i < Tickets.Count; i++)
            {
                if (Tickets[i].Departure == stopName)
                    temp.Add(Tickets[i]);
            }
            return temp;
        }

        public List<Ticket> GetExitPassangers(string stopName)
        {
            List<Ticket> temp = new List<Ticket>();
            for (int i = 0; i < Tickets.Count; i++)
            {
                if (Tickets[i].Destination == stopName)
                    temp.Add(Tickets[i]);
            }
            return temp;
        }
    }
}
