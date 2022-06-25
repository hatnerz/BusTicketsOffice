using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WinFormsApp1
{
    public static class AllRoutes
    {
        public static List<Route> Routes = new List<Route>();
        public static void Load(string fileName)
        {
            StreamReader? sr;
            try
            {
                sr = new StreamReader(fileName);
                string? toLoad = sr.ReadToEnd();
                if (toLoad != null)
                    AllRoutes.Routes = JsonSerializer.Deserialize<List<Route>>(toLoad);
                else
                    MessageBox.Show(Constants.ErrorRoutes, Constants.ErrorHead, MessageBoxButtons.OK);
                sr.Close();
            }
            catch
            {
                MessageBox.Show(Constants.ErrorRoutes, Constants.ErrorHead, MessageBoxButtons.OK);
            }
        }
        public static void Save(string fileName)
        {
            if (!Directory.Exists(Constants.Directory))
                Directory.CreateDirectory(Constants.Directory);
            string toSave = JsonSerializer.Serialize(AllRoutes.Routes);
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(toSave);
            sw.Close();
        }
        public static List<Route> FindRouteByCities(string departure, string destination, DateTime date)
        {
            List<Route> foundRoutes = new List<Route>();
            foreach (Route route in Routes)
            {
                for (int i = 0; i<route.Stops.Count; i++)
                {
                    if(route.Stops[i].StopName == departure && route.Stops[i].Departure.ToShortDateString() == date.ToShortDateString())
                    {
                        for(int j = i+1; j<route.Stops.Count; j++)
                        {
                            if (route.Stops[j].StopName == destination)
                            {
                                foundRoutes.Add(route);
                                break;
                            }
                        }
                        
                    }
                }
            }
            return foundRoutes;
        }
        public static List<Route> FindRoutesByDate(DateTime date)
        {
            List<Route> correctRoutes = new List<Route>();
            foreach (Route route in Routes)
            {
                if (route.Stops[0].Departure.Date == date.Date)
                    correctRoutes.Add(route);
            }
            return correctRoutes;
        }
        public static List<Ticket> FindPassangerTicketsByNumber(string phoneNumber)
        {
            List<Ticket> correctTickets = new List<Ticket>();
            foreach(Route route in Routes)
            {
                foreach(Ticket ticket in route.Tickets)
                {
                    if(ticket.PassangerPhoneNumber == phoneNumber)
                    {
                        correctTickets.Add(ticket);
                    }
                }
            }
            return (correctTickets);
        }
        public static bool DeleteTicket(Ticket t)
        {
            foreach(Route route in Routes)
            {
                foreach(Ticket ticket in route.Tickets)
                {
                    if(ticket == t)
                    {
                        route.DeleteTicket(t);
                        return true;
                    }
                        
                }
            }
            return false;
        }
        public static void DeleteOutdatesRoutes()
        {
            DateTime now = DateTime.Now;
            for (int i = 0; i < Routes.Count; i++)
            {
                if (Routes[i].Stops[0].Departure < now)
                {
                    Routes.RemoveAt(i);
                    i--;
                }
            }
        }
        
        public static List<Route> SortByDepartureDate(List<Route> routes)
        {
            Route temp;
            for(int i = 0; i < routes.Count; i++)
            {
                for(int j = 0; j < routes.Count-1-i; j++)
                {
                    if(routes[j].Stops[0].Departure > routes[j+1].Stops[0].Departure)
                    {
                        temp = routes[j];
                        routes[j] = routes[j+1];
                        routes[j+1] = temp;
                    }
                }
            }
            return routes;
        }

    }
}
