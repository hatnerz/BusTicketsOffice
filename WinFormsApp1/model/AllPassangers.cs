using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WinFormsApp1
{
    public static class AllPassangers
    {
        public static List<Passanger> Passangers = new List<Passanger>();
        public static void Load(string fileName)
        {
            StreamReader? sr;
            try
            {
                sr = new StreamReader(fileName);
                string? toLoad = sr.ReadToEnd();
                if (toLoad != null)
                    AllPassangers.Passangers = JsonSerializer.Deserialize<List<Passanger>>(toLoad);
                else
                    MessageBox.Show(Constants.ErrorPassangers, Constants.ErrorHead, MessageBoxButtons.OK);
                sr.Close();
            }
            catch
            {
                MessageBox.Show(Constants.ErrorPassangers, Constants.ErrorHead, MessageBoxButtons.OK);
            }
        }
        public static void Save(string fileName)
        {
            if (!Directory.Exists(Constants.Directory))
                Directory.CreateDirectory(Constants.Directory);
            string toSave = JsonSerializer.Serialize(AllPassangers.Passangers);
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(toSave);
            sw.Close();
        }
        public static Passanger? GetPassangerByPhoneNumber(string phoneNumber)
        {
            foreach (Passanger p in Passangers)
            {
                if (p.PhoneNumber == phoneNumber)
                    return p; 
            }
            return null;
        }
        public static void AddTicketToPassangerByNumber(string number, Route route, string departure, string destination, 
            int seatNumber, string firstName, string lastName, string patronymicName)
        {
            Passanger? p = GetPassangerByPhoneNumber(number);
            if (p == null)
            {
                Passangers.Add(new Passanger(number));
                p = Passangers.Last();
            }
            route.AddTicket(departure, destination, number, seatNumber, firstName, lastName, patronymicName);
        }
    }
}
