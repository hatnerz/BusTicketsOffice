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
        public static List<Route> routes = new List<Route>();
        public static void Load(string fileName)
        {
            StreamReader? sr;
            try
            {
                sr = new StreamReader(fileName);
                string? toLoad = sr.ReadLine();
                if (toLoad != null)
                    AllRoutes.routes = JsonSerializer.Deserialize<List<Route>>(toLoad);
                else
                    MessageBox.Show("Сталася помилка при завантаженні файлу", "Помилка", MessageBoxButtons.OK);
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Сталася помилка при завантаженні файлу", "Помилка", MessageBoxButtons.OK);
            }
        }
        public static void Save(string fileName)
        {
            string toSave = JsonSerializer.Serialize(AllRoutes.routes);
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(toSave);
            sw.Close();
        }
        public static List<Route> FindRouteByCities(string departure, string destination, DateTime date)
        {
            List<Route> foundRoutes = new List<Route>();
            foreach (Route route in routes)
            {
                for (int i = 0; i<route.stops.Count; i++)
                {
                    if(route.stops[i].stopName == departure && route.stops[i].departure.ToShortDateString() == date.ToShortDateString())
                    {
                        for(int j = i+1; j<route.stops.Count; j++)
                        {
                            if (route.stops[j].stopName == destination)
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
            foreach (Route route in routes)
            {
                if (route.stops[0].departure.Date == date.Date)
                    correctRoutes.Add(route);
            }
            return correctRoutes;
        }
        public static List<Ticket> FindPassangerTicketsByNumber(string phoneNumber)
        {
            List<Ticket> correctTickets = new List<Ticket>();
            foreach(Route route in routes)
            {
                foreach(Ticket ticket in route.tickets)
                {
                    if(ticket.passangerPhoneNumber == phoneNumber)
                    {
                        correctTickets.Add(ticket);
                    }
                }
            }
            return (correctTickets);
        }
        public static bool deleteTicket(Ticket t)
        {
            foreach(Route route in routes)
            {
                foreach(Ticket ticket in route.tickets)
                {
                    if(ticket == t)
                    {
                        route.deleteTicket(t);
                        return true;
                    }
                        
                }
            }
            return false;
        }
        public static void deleteOutdatesRoutes()
        {
            DateTime now = DateTime.Now;
            for (int i = 0; i < routes.Count; i++)
            {
                if (routes[i].stops[0].departure < now)
                {
                    routes.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
