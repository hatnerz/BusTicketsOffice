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
            StreamReader? sr = new StreamReader(fileName);
            try
            {
                string? toLoad = sr.ReadLine();
                if (toLoad != null)
                    AllPassangers.passangers = JsonSerializer.Deserialize<List<Passanger>>(toLoad);
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
        public static void addTicketToPassangerByNumber(string number, Route route, Stop departure, Stop destination, 
            int seatNumber, string firstName, string lastName, string patronymicName)
        {
            Passanger? p = getPassangerByPhoneNumber(number);
            if (p == null)
            {
                passangers.Add(new Passanger(number));
                p = passangers.Last();
            }
            route.addTicket(departure.stopName, destination.stopName, p, seatNumber, firstName, lastName, patronymicName);
        }
    }
}
