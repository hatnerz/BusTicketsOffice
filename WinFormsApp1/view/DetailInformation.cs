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
            routeInfo.Text = route.stringInfo;
            freeSeats.Text = Convert.ToString(freeSeat);
            seatNumber.Text = Convert.ToString(route.numberOfSeats);
            int depIndex = route.stops.IndexOf(departure);
            int destIndex = route.stops.IndexOf(destination);
            float curcentPrice = route.getPrice(depIndex, destIndex);
            ticketPrice.Text = String.Format("{0:f2}", curcentPrice);
            for (int i = 0; i < route.stops.Count; i++)
            {
                if (route.stops[i] == departure)
                    stops.Text += "→  ";
                else if (route.stops[i] == destination)
                    stops.Text += "←  ";
                else
                    stops.Text += "⦿  ";
                stops.Text += route.stops[i].stopName;
                stops.Text += "   ";
                stops.Text += route.stops[i].departure;
                stops.Text += Environment.NewLine;
            }
        }
    }
}
