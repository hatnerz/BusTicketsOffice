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
    public partial class RouteEditing : Form
    {
        public RouteEditing()
        {
            InitializeComponent();
            dateRoutePicker.MinDate = DateTime.Now;
            DateTime Max = DateTime.Now;
            dateRoutePicker.MaxDate = Max.AddMonths(1);
            routeChose.DisplayMember = "stringInfo";
            DateTime selectedDate = dateRoutePicker.Value;
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

        private void deleteRouteButton_Click(object sender, EventArgs e)
        {
            if (routeChose.Text == "")
                MessageBox.Show("Виберіть маршрут для видалення", "Помилка", MessageBoxButtons.OK);
            else
            {
                AllRoutes.routes.Remove((Route)routeChose.SelectedItem);
                updateRouteChose();
            }
        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            int routeNumber = (int)routeNumberAdd.Value;
            int seatNumber = (int)seatNumberAdd.Value;
            string strStopsInfo = stopsInfoAdd.Text;
            string[] stopsInfo = strStopsInfo.Split('\n');
            List<Stop> temp = new List<Stop>(stopsInfo.Length);
            for (int i = 0; i<stopsInfo.Length; i++)
            {
                string[] stopInfo = stopsInfo[i].Split(' ');
                string stopName = stopInfo[0];
                ListOfCities.AddCity(stopName);
                DateTime departure = Convert.ToDateTime(stopInfo[1] + " " + stopInfo[2]);
                float price = float.Parse(stopInfo[3]);
                temp.Add(new Stop(departure, stopName, price));
            }
            AllRoutes.routes.Add(new Route(temp, routeNumber, seatNumber));
            updateRouteChose();
        }

        private void routeChoseMenuItem_Click(object sender, EventArgs e)
        {
            AllRoutes.Save("routes.json");
            ListOfCities.Save("cities.json");
            Program.Context.MainForm = new RouteChose();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}
