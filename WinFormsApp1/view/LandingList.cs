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
                landingListTextBox.Text += selectedRoute.StringInfo;
                landingListTextBox.Text += Environment.NewLine;
                for (int i = 0; i < selectedRoute.Stops.Count; i++)
                {
                    enter = selectedRoute.GetEnterPassangers(selectedRoute.Stops[i].StopName);
                    exit = selectedRoute.GetExitPassangers(selectedRoute.Stops[i].StopName);
                    landingListTextBox.Text += Environment.NewLine;
                    string tempStop = "◆ " + selectedRoute.Stops[i].StopName + "  " +
                        selectedRoute.Stops[i].Departure;
                    landingListTextBox.Text += tempStop;
                    landingListTextBox.Text += Environment.NewLine;
                    for (int j = 0; j < exit.Count; j++)
                    {
                        string tempPassanger = "    -  Місце " + exit[j].SeatNumber + "   " + exit[j].FullName;
                        landingListTextBox.Text += tempPassanger;
                        landingListTextBox.Text += Environment.NewLine;
                    }
                    for (int j = 0; j < enter.Count; j++)
                    {
                        string tempPassanger = "    +  Місце " + enter[j].SeatNumber + "   " + enter[j].FullName + " (до " + enter[j].Destination + ")";
                        landingListTextBox.Text += tempPassanger;
                        landingListTextBox.Text += Environment.NewLine;
                    }
                }
            }
        }
    }
}
