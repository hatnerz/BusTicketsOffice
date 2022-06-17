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
            routeNumberLabel.Text = "Рейс №" + route.routeNumber + " (" + route.stops[0].stopName + " " + route.stops.Last().stopName + ")";
            destinationLabel.Text = "Прибуття: " + destination.stopName + " " + destination.departure;
            departureLabel.Text = "Відправлення: " + departure.stopName + " " + departure.departure;
            int depIndex = route.stops.IndexOf(departure);
            int destIndex = route.stops.IndexOf(destination);
            float curcentPrice = route.getPrice(depIndex, destIndex);
            priceLabel.Text = "Вартість квитку: " + curcentPrice;
            int[] temp = route.getFreeSeats(depIndex, destIndex).ToArray();
            seatCombo.DataSource = temp;
        }

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            if (phoneMaskTextBox.Text.Length!=17 || firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" || patronymicNameTextBox.Text == "" || seatCombo.Text == "")
                MessageBox.Show("Введіть усі необхідні дані", "Помилка", MessageBoxButtons.OK);
            else
            {
                string phone = phoneMaskTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string patronymicName = patronymicNameTextBox.Text;
                int seat = Convert.ToInt32(seatCombo.Text)-1;
                AllPassangers.addTicketToPassangerByNumber(phone, route, departure.stopName, destination.stopName, seat, firstName, lastName, patronymicName);
                MessageBox.Show("Квиток успішно придбано", "Успіх", MessageBoxButtons.OK);
                AllPassangers.Save("passangers.json");
                this.Close();
            }
        }
    }
}
