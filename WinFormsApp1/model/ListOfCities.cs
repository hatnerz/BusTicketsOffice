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
        public static List<string> Cities { get; private set; } = new List<string>();
        public static void Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader? sr;
                try
                {
                    sr = new StreamReader(fileName);
                    string? toLoad = sr.ReadToEnd();
                    if (toLoad != null)
                    {
                        List<string>? temp = JsonSerializer.Deserialize<List<string>>(toLoad);
                        if (temp != null)
                            ListOfCities.Cities = temp;

                    }
                    else
                        MessageBox.Show(Constants.ErrorCities, Constants.ErrorHead, MessageBoxButtons.OK);
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show(Constants.ErrorCities, Constants.ErrorHead, MessageBoxButtons.OK);
                }
            }
        }
        public static void Save(string fileName)
        {
            if (!Directory.Exists(Constants.Directory))
                Directory.CreateDirectory(Constants.Directory);
            string toSave = JsonSerializer.Serialize(ListOfCities.Cities);
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(toSave);
            sw.Close();
        }
        static public bool AddCity(string city)
        {
            bool flag = true;
            foreach (string c in Cities)
            {
                if (c == city)
                {
                    flag = false;
                    break;
                }
            }

            if(flag == true)
                Cities.Add(city);
            return flag;
        }
        static public void DeleteUnused()
        {
            bool flag = true;
            for (int i = 0; i < Cities.Count; i++)
            {
                flag = true;
                foreach (Route route in AllRoutes.Routes)
                {
                    foreach(Stop stop in route.Stops)
                    {
                        if(Cities[i]==stop.StopName)
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
                    Cities.Remove(Cities[i]);
                    i--;
                }
            }
        }
    }
}
