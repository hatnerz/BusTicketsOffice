using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WinFormsApp1
{
    public class Route
    {
        public List<Stop> stops { get; private set; }
        public int routeNumber { get; private set; }
        //[JsonInclude]
        public List<Ticket> tickets { get; set; }
        public int numberOfSeats { get; private set; }
        private bool[,] occupiedSeats { get; set; }
        public string stringInfo
        {
            get {
                string rez = Convert.ToString(routeNumber);
                rez += " ";
                rez += stops[0].stopName;
                rez += " - ";
                rez += stops.Last().stopName;
                return rez;
            }
        }
        public bool[] occupiedSeatsSerialize
        {
            get
            {
                bool[] temp = new bool[occupiedSeats.Length];
                int index = 0;
                for(int i = 0; i<numberOfSeats; i++)
                {
                    for(int j = 0; j<stops.Count; j++)
                    {
                        temp[index++] = occupiedSeats[i, j];
                    }
                }
                return temp;
            }
            set
            {
                int index = 0;
                for (int i = 0; i < numberOfSeats; i++)
                {
                    for (int j = 0; j < stops.Count; j++)
                    {
                        occupiedSeats[i, j] = value[index++];
                    }
                }
            }
        }
        public Route (List<Stop> stops, int routeNumber, int numberOfSeats)
        {
            this.stops = stops;
            this.routeNumber = routeNumber;
            this.numberOfSeats = numberOfSeats;
            tickets = new List<Ticket>();
            occupiedSeats = new bool[numberOfSeats,stops.Count];
        }
        public Stop findStopByStopName(string stopName)
        {
            foreach (Stop stop in stops)
            {
                if(stop.stopName == stopName)
                    return stop;
            }
            return stops[stops.Count-1];
        }
        
        public int findStopIndexByName(string stopName)
        {
            for(int i = 0; i< stops.Count; i++)
            {
                if (stops[i].stopName == stopName)
                    return i;
            }
            return -1;
        }
        public void addTicket(string departure, string destination, string phoneNumber, int seatNumber,
            string firstName, string lastName, string patronymicName)
        {
            int startIndex = findStopIndexByName(departure);
            int endIndex = findStopIndexByName(destination);
            float price = 0;
            for(int i = startIndex+1; i <= endIndex; i++)
            {
                price += stops[i].price;
            }
            Ticket temp = new Ticket(price, seatNumber, phoneNumber, departure, destination,
                firstName, lastName, patronymicName);
            tickets.Add(temp);
            for (int i = startIndex; i < endIndex; i++)
            {
                occupiedSeats[seatNumber, i] = true;
            }
        }

        public List<int> getFreeSeats(int startIndex, int endIndex)
        {
            List<int> freeSeats = new List<int>();
            bool correct = true;
            for(int i = 0; i < numberOfSeats; i++)
            {
                correct = true;
                for(int j = startIndex; j < endIndex; j++)
                {
                    if (occupiedSeats[i, j] == true)
                    {
                        correct = false;
                        break;
                    }
                }
                if(correct)
                {
                    freeSeats.Add(i+1);
                }
            }
            return freeSeats;
        }
        public float getPrice(int departureIndex, int destinationIndex)
        {
            float sumPrice = 0;
            try
            {
                for (int i = departureIndex + 1; i <= destinationIndex; i++)
                    sumPrice += stops[i].price;
            }
            catch
            {
                return -1;
            }
            return sumPrice;
        }
    }
}
