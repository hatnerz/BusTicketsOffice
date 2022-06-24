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
    public partial class LandingList : Form
    {
        public LandingList()
        {
            InitializeComponent();
            dateRoutePicker.MinDate = DateTime.Now;
            DateTime Max = DateTime.Now;
            dateRoutePicker.MaxDate = Max.AddMonths(1);
            routeChose.DisplayMember = "stringInfo";
            DateTime selectedDate = dateRoutePicker.Value;
            routeChose.Items.Clear();
            routeChose.Items.AddRange(AllRoutes.FindRoutesByDate(selectedDate).ToArray());
        }

        private void updateRouteChose()
        {
            DateTime selectedDate = dateRoutePicker.Value;
            routeChose.Items.Clear();
            routeChose.Items.AddRange(AllRoutes.FindRoutesByDate(selectedDate).ToArray());
        }

        private void dateRoutePicker_ValueChanged(object sender, EventArgs e)
        {
            updateRouteChose();
        }

        private void formListButton_Click(object sender, EventArgs e)
        {
            if (routeChose.Text == "")
                MessageBox.Show("Виберіть маршрут для формування посадкової відомості", Constants.ErrorHead, MessageBoxButtons.OK);
            else
            {
                List<Ticket> enter;
                List<Ticket> exit;
                Route selectedRoute = (Route)routeChose.SelectedItem;
                landingListTextBox.Clear();
                landingListTextBox.Text += selectedRoute.stringInfo;
                landingListTextBox.Text += Environment.NewLine;
                for (int i = 0; i < selectedRoute.stops.Count; i++)
                {
                    enter = selectedRoute.GetEnterPassangers(selectedRoute.stops[i].stopName);
                    exit = selectedRoute.GetExitPassangers(selectedRoute.stops[i].stopName);
                    landingListTextBox.Text += Environment.NewLine;
                    string tempStop = "◆ " + selectedRoute.stops[i].stopName + "  " +
                        selectedRoute.stops[i].departure;
                    landingListTextBox.Text += tempStop;
                    landingListTextBox.Text += Environment.NewLine;
                    for (int j = 0; j < exit.Count; j++)
                    {
                        string tempPassanger = "    -  Місце " + exit[j].seatNumber + "   " + exit[j].FullName;
                        landingListTextBox.Text += tempPassanger;
                        landingListTextBox.Text += Environment.NewLine;
                    }
                    for (int j = 0; j < enter.Count; j++)
                    {
                        string tempPassanger = "    +  Місце " + enter[j].seatNumber + "   " + enter[j].FullName + " (до " + enter[j].destination + ")";
                        landingListTextBox.Text += tempPassanger;
                        landingListTextBox.Text += Environment.NewLine;
                    }
                }
            }
        }
    }
}
