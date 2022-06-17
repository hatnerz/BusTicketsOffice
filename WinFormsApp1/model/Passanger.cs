using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Passanger
    {
        public string phoneNumber { get; private set; }
        public Passanger(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
