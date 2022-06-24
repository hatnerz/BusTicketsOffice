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
        private RouteChose senderForm;
        public RouteEditing(RouteChose sender)
        {
            senderForm = sender;
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

        private void deleteRouteButton_Click(object sender, EventArgs e)
        {
            if (routeChose.Text == "")
                MessageBox.Show("Виберіть маршрут для видалення", Constants.ErrorHead, MessageBoxButtons.OK);
            else
            {
                AllRoutes.routes.Remove((Route)routeChose.SelectedItem);
                updateRouteChose();
                AllRoutes.Save(Constants.PathRoutes);
                MessageBox.Show("Операція успішна", Constants.SuccessHead, MessageBoxButtons.OK);
            }
        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int routeNumber = (int)routeNumberAdd.Value;
                int seatNumber = (int)seatNumberAdd.Value;
                string strStopsInfo = stopsInfoAdd.Text;
                string[] stopsInfo = strStopsInfo.Split('\n');
                if (stopsInfo.Length == 1)
                    throw new Exception();
                List<Stop> temp = new List<Stop>(stopsInfo.Length);
                for (int i = 0; i < stopsInfo.Length; i++)
                {
                    string[] stopInfo = stopsInfo[i].Split(' ');
                    string stopName = stopInfo[0];
                    ListOfCities.AddCity(stopName);
                    DateTime departure = Convert.ToDateTime(stopInfo[1] + " " + stopInfo[2]);
                    float price = float.Parse(stopInfo[3]);
                    temp.Add(new Stop(departure, stopName, price));
                }
                for (int i = 1; i < stopsInfo.Length; i++)
                {
                    if (temp[i].departure <= temp[i - 1].departure)
                        throw new Exception();
                }
                AllRoutes.routes.Add(new Route(temp, routeNumber, seatNumber));
                updateRouteChose();
                MessageBox.Show("Маршрут успішно додано", Constants.SuccessHead, MessageBoxButtons.OK);
                AllRoutes.Save(Constants.PathRoutes);
                ListOfCities.Save(Constants.PathCities);
            }
            catch
            {
                MessageBox.Show("Перевірте правильність введення даних", Constants.ErrorHead, MessageBoxButtons.OK);
            }
            
        }

        private void deleteUnused_Click(object sender, EventArgs e)
        {
            ListOfCities.DeleteUnused();
            ListOfCities.Save(Constants.PathCities);
            MessageBox.Show("Операція успішна", Constants.SuccessHead, MessageBoxButtons.OK);
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            if (cityName.Text.Length == 0)
                MessageBox.Show("Введіть назву зупинки", Constants.ErrorHead, MessageBoxButtons.OK);
            else
            {
                if (ListOfCities.AddCity(cityName.Text) == true)
                    MessageBox.Show("Назву зупинки успішно додано", Constants.SuccessHead, MessageBoxButtons.OK);
                else
                    MessageBox.Show("Зупинка з такою назвою вже є у списку", Constants.ErrorHead, MessageBoxButtons.OK);
            }
            ListOfCities.Save(Constants.PathCities);
        }

        private void RouteEditing_FormClosed(object sender, FormClosedEventArgs e)
        {
            senderForm.updateCitiesChose();
        }
    }
}
