using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DetailInformation : Form
    {
        public DetailInformation(Route route, Stop departure, Stop destination, int freeSeat)
        {
            InitializeComponent();
            routeInfo.Text = route.StringInfo;
            freeSeats.Text = Convert.ToString(freeSeat);
            seatNumber.Text = Convert.ToString(route.NumberOfSeats);
            int depIndex = route.Stops.IndexOf(departure);
            int destIndex = route.Stops.IndexOf(destination);
            float curcentPrice = route.GetPrice(depIndex, destIndex);
            ticketPrice.Text = String.Format("{0:f2}", curcentPrice);
            for (int i = 0; i < route.Stops.Count; i++)
            {
                if (route.Stops[i] == departure)
                    stops.Text += "→  ";
                else if (route.Stops[i] == destination)
                    stops.Text += "←  ";
                else
                    stops.Text += "⦿  ";
                stops.Text += route.Stops[i].StopName;
                stops.Text += "   ";
                stops.Text += route.Stops[i].Departure;
                stops.Text += Environment.NewLine;
            }
        }
    }
}
