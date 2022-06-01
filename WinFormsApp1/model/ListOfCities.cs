using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class ListOfCities
    {
        static public List<string> cities { get; private set; } = new List<string>();
        static public void Initialize()
        {
            cities = new List<string>();
        }
        static public void AddCity(string city)
        {
            cities.Add(city);
        }
    }
}
