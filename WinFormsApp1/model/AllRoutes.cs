using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class AllRoutes
    {
        public static List<Route> routes = new List<Route>();
        public static void Initialize(string fileName)
        {
            // Загрузка из файла
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
    }
}
