using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WinFormsApp1
{
    public static class ListOfCities
    {
        public static List<string> cities { get; private set; } = new List<string>();
        public static void Load(string fileName)
        {
            StreamReader? sr;
            try
            {
                sr = new StreamReader(fileName);
                string? toLoad = sr.ReadLine();
                if (toLoad != null)
                    ListOfCities.cities = JsonSerializer.Deserialize<List<string>>(toLoad);
                else
                    MessageBox.Show("Сталася помилка при завантаженні файлу)", "Помилка", MessageBoxButtons.OK);
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Сталася помилка при завантаженні файлу", "Помилка", MessageBoxButtons.OK);
            }
        }
        public static void Save(string fileName)
        {
            string toSave = JsonSerializer.Serialize(ListOfCities.cities);
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(toSave);
            sw.Close();
        }
        static public bool AddCity(string city)
        {
            bool flag = true;
            foreach (string c in cities)
            {
                if (c == city)
                {
                    flag = false;
                    break;
                }
            }

            if(flag == true)
                cities.Add(city);
            return flag;
        }
        static public void DeleteUnused()
        {
            bool flag = true;
            for (int i = 0; i < cities.Count; i++)
            {
                flag = true;
                foreach (Route route in AllRoutes.routes)
                {
                    foreach(Stop stop in route.stops)
                    {
                        if(cities[i]==stop.stopName)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == false)
                        break;
                }
                if (flag == true)
                {
                    cities.Remove(cities[i]);
                    i--;
                }
            }
        }
    }
}
