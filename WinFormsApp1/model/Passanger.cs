using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Passanger
    {
        private string firstName;
        private string lastName;
        private int phoneNumber;
        private List<Ticket> tickets;
        public Passanger(string firstName, string lastName, int phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            tickets = new List<Ticket>();
        }
    }
}
