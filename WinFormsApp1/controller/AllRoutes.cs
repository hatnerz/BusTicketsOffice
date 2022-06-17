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
            StreamReader? sr = new StreamReader(fileName);
            try
            {
                string? toLoad = sr.ReadLine();
                if (toLoad != null)
                    AllRoutes.routes = JsonSerializer.Deserialize<List<Route>>(toLoad);
                else
                    MessageBox.Show("Сталася помилка при завантаженні файлу", "Помилка", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Сталася помилка при завантаженні файлу", "Помилка", MessageBoxButtons.OK);
            }
            finally
            {
                sr.Close();
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
    }
}
