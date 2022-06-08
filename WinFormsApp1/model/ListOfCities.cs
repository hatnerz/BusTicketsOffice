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
            StreamReader? sr = new StreamReader(fileName);
            try
            {
                string? toLoad = sr.ReadLine();
                if (toLoad != null)
                    ListOfCities.cities = JsonSerializer.Deserialize<List<string>>(toLoad);
                else
                    MessageBox.Show("Сталася помилка при завантаженні файлу", "Помилка", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Сталася ggпомилка при завантаженні файлу", "Помилка", MessageBoxButtons.OK);
            }
            finally
            {
                sr.Close();
            }
        }
        public static void Save(string fileName)
        {
            string toSave = JsonSerializer.Serialize(ListOfCities.cities);
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(toSave);
            sw.Close();
        }
        static public void AddCity(string city)
        {
            cities.Add(city);
        }
    }
}
