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
            departure.DataSource = ListOfCities.cities;
            destination.DataSource = ListOfCities.cities;
            dateDeparture.MinDate = DateTime.Now;
            DateTime Max = DateTime.Now;
            dateDeparture.MaxDate = Max.AddMonths(1);
        }

        private void findRoutesButton_Click(object sender, EventArgs e)
        {

        }
    }
}