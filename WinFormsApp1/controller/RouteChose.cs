namespace WinFormsApp1
{
    public partial class RouteChose : Form
    {
        public RouteChose()
        {
            InitializeComponent();
            ListOfCities.AddCity("Kyiv");
            ListOfCities.AddCity("Kharkiv");
            ListOfCities.AddCity("Dnipro");
            ListOfCities.AddCity("Lviv");
            Stop first = new Stop(new DateTime(2022, 06, 01, 15, 40, 00), ListOfCities.cities[0], 45f);
            Stop second = new Stop(new DateTime(2022, 06, 01, 16, 20, 00), ListOfCities.cities[1], 42.8f);
            Stop third = new Stop(new DateTime(2022, 06, 01, 17, 00, 00), ListOfCities.cities[2], 47.5f);
            List<Stop> all_stops_route1 = new List<Stop>();
            all_stops_route1.Add(first);
            all_stops_route1.Add(second);
            all_stops_route1.Add(third);
            Route temp = new Route(all_stops_route1, 423, 50);
            AllRoutes.routes.Add(temp);
            departureBox.Items.AddRange(ListOfCities.cities.ToArray());
            destinationBox.Items.AddRange(ListOfCities.cities.ToArray());
            dateDepartureBox.MinDate = DateTime.Now;
            DateTime Max = DateTime.Now;
            dateDepartureBox.MaxDate = Max.AddMonths(1);
        }

        private void findRoutesButton_Click(object sender, EventArgs e)
        {
            if (departureBox.Text == destinationBox.Text)
            {

            }
            else if (departureBox.Text == "" || destinationBox.Text == "")
            {
                
            }
            else
            {
                List<Route> correctRoutes = AllRoutes.FindRouteByCities(departureBox.Text, destinationBox.Text, dateDepartureBox.Value);
                if(correctRoutes.Count == 0)
                {

                }
                else
                {
                    for(int i = 0; i< correctRoutes.Count; i++)
                    {
                        Label routeNumLabel = new Label();
                        routeNumLabel.Text = "Πειρ Ή " + correctRoutes[i].routeNumber;
                        routeNumLabel.Location = new Point(10, 10);
                        //panelRoutes.Controls.Add()
                    }
                }
            }
            
        }
    }
}