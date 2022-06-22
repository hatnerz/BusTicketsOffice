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
        public static List<Passanger> passangers = new List<Passanger>();
        public static void Load(string fileName)
        {
            StreamReader? sr;
            try
            {
                sr = new StreamReader(fileName);
                string? toLoad = sr.ReadLine();
                if (toLoad != null)
                    AllPassangers.passangers = JsonSerializer.Deserialize<List<Passanger>>(toLoad);
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
            string toSave = JsonSerializer.Serialize(AllPassangers.passangers);
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(toSave);
            sw.Close();
        }
        public static Passanger? getPassangerByPhoneNumber(string phoneNumber)
        {
            foreach (Passanger p in passangers)
            {
                if (p.phoneNumber == phoneNumber)
                    return p; 
            }
            return null;
        }
        public static void addTicketToPassangerByNumber(string number, Route route, string departure, string destination, 
            int seatNumber, string firstName, string lastName, string patronymicName)
        {
            Passanger? p = getPassangerByPhoneNumber(number);
            if (p == null)
            {
                passangers.Add(new Passanger(number));
                p = passangers.Last();
            }
            route.addTicket(departure, destination, number, seatNumber, firstName, lastName, patronymicName);
        }
    }
}
