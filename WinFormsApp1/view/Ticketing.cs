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
    public partial class Ticketing : Form
    {
        public Stop departure;
        public Stop destination;
        public Route route;
        public Ticketing(Route route, Stop departure, Stop destination)
        {
            InitializeComponent();
            this.route = route;
            this.destination = destination;
            this.departure = departure;
            routeNumberLabel.Text = "Рейс №" + route.RouteNumber + " (" + route.Stops[0].StopName + " - " + route.Stops.Last().StopName + ")";
            destinationLabel.Text = "Прибуття: " + destination.StopName + " " + destination.Departure;
            departureLabel.Text = "Відправлення: " + departure.StopName + " " + departure.Departure;
            int depIndex = route.Stops.IndexOf(departure);
            int destIndex = route.Stops.IndexOf(destination);
            float curcentPrice = route.GetPrice(depIndex, destIndex);
            priceLabel.Text = "Вартість квитку: " + String.Format("{0:f2}", curcentPrice);
            int[] temp = route.GetFreeSeats(depIndex, destIndex).ToArray();
            seatCombo.DataSource = temp;
        }

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            if (phoneMaskTextBox.Text.Length!=17 || firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" || patronymicNameTextBox.Text == "" || seatCombo.Text == "")
                MessageBox.Show("Введіть усі необхідні дані", Constants.ErrorHead, MessageBoxButtons.OK);
            else
            {
                string phone = phoneMaskTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string patronymicName = patronymicNameTextBox.Text;
                int seat = Convert.ToInt32(seatCombo.Text);
                AllPassangers.AddTicketToPassangerByNumber(phone, route, departure.StopName, destination.StopName, seat, firstName, lastName, patronymicName);
                MessageBox.Show("Квиток успішно придбано", Constants.SuccessHead, MessageBoxButtons.OK);
                AllPassangers.Save(Constants.PathPassangers);
                AllRoutes.Save(Constants.PathRoutes);
                this.Close();
            }
        }
    }
}
