using System.Text.Json;

namespace WinFormsApp1
{
    public partial class RouteChose : Form
    {
        public RouteChose()
        {
            InitializeComponent();
            AllRoutes.Load("routes.json");
            ListOfCities.Load("cities.json");
            AllPassangers.Load("passangers.json");
            departureBox.Items.AddRange(ListOfCities.cities.ToArray());
            destinationBox.Items.AddRange(ListOfCities.cities.ToArray());
            dateDepartureBox.MinDate = DateTime.Now;
            DateTime Max = DateTime.Now;
            dateDepartureBox.MaxDate = Max.AddMonths(1);
        }

        private void updateRoutes()
        {
            panelRoutes.Controls.Clear();
            Label infoText = new Label();
            infoText.AutoSize = true;
            if (departureBox.Text == "" || destinationBox.Text == "")
            {
                infoText.Text = "���� �����, ������� ����� ����������� �� ����� �����������.";
                panelRoutes.Controls.Add(infoText);
            }
            else if (departureBox.Text == destinationBox.Text)
            {
                infoText.Text = "������� ����������� �������� � �������� ��������. ����� ����� ������.";
                panelRoutes.Controls.Add(infoText);
            }
            else
            {
                List<Route> correctRoutes = AllRoutes.FindRouteByCities(departureBox.Text, destinationBox.Text, dateDepartureBox.Value);
                if (correctRoutes.Count == 0)
                {
                    infoText.Text = "����� �� �������� ��������� �� ������� ���� �� ��������.";
                    panelRoutes.Controls.Add(infoText);
                }
                else
                {
                    for (int i = 0; i < correctRoutes.Count; i++)
                    {
                        Label routeNumLabel = new Label();
                        routeNumLabel.Text = "���� � " + correctRoutes[i].routeNumber;
                        routeNumLabel.Location = new Point(27, 15);
                        routeNumLabel.AutoSize = true;

                        Stop departureStop = correctRoutes[i].findStopByStopName(departureBox.Text);
                        Stop destinationStop = correctRoutes[i].findStopByStopName(destinationBox.Text);

                        Label destinationLabel = new Label();
                        destinationLabel.Text = "��������:\n" + destinationStop.stopName + '\n' + destinationStop.departure;
                        destinationLabel.Location = new Point(545, 15);
                        destinationLabel.AutoSize = true;

                        Label departureLabel = new Label();
                        departureLabel.Text = "³����������:\n" + departureStop.stopName + '\n' + departureStop.departure;
                        departureLabel.Location = new Point(298, 15);
                        departureLabel.AutoSize = true;

                        Label emptySeatsLabel = new Label();
                        int startIndex = correctRoutes[i].findStopIndexByName(departureBox.Text);
                        int endIndex = correctRoutes[i].findStopIndexByName(destinationBox.Text);
                        emptySeatsLabel.Text = "ʳ������ ������ ����: " + correctRoutes[i].getFreeSeats(startIndex, endIndex).Count;
                        emptySeatsLabel.Location = new Point(27, 45);
                        emptySeatsLabel.AutoSize = true;

                        Button goTicketingButton = new Button();
                        goTicketingButton.Text = "������� �� ���������� ������";
                        goTicketingButton.Location = new Point(783, 45);
                        goTicketingButton.Size = new Size(206, 23);

                        RouteChoseEventArgs ev = new RouteChoseEventArgs(correctRoutes[i], departureStop, destinationStop);

                        Route tempRoute = correctRoutes[i];
                        void goTicketingButton_Click(object? sender, EventArgs e)
                        {
                            startTicketing(tempRoute, departureStop, destinationStop);
                        }

                        goTicketingButton.Click += goTicketingButton_Click;

                        Button detailInformationButton = new Button();
                        detailInformationButton.Text = "�������� ���������� ��� ����";
                        detailInformationButton.Location = new Point(783, 15);
                        detailInformationButton.Size = new Size(206, 23);

                        Panel availableRoutePanel = new Panel();
                        availableRoutePanel.Size = new Size(1020, 78);
                        availableRoutePanel.Location = new Point(12, i * 85 + 12);
                        availableRoutePanel.BorderStyle = BorderStyle.FixedSingle;
                        availableRoutePanel.Controls.Add(routeNumLabel);
                        availableRoutePanel.Controls.Add(destinationLabel);
                        availableRoutePanel.Controls.Add(departureLabel);
                        availableRoutePanel.Controls.Add(emptySeatsLabel);
                        availableRoutePanel.Controls.Add(goTicketingButton);
                        availableRoutePanel.Controls.Add(detailInformationButton);
                        panelRoutes.Controls.Add(availableRoutePanel);
                    }
                }
            }
        }
        private void findRoutesButton_Click(object sender, EventArgs e)
        {
            updateRoutes();   
        }

        private void startTicketing(Route route, Stop departure, Stop destination)
        {
            Ticketing f = new Ticketing(route, departure, destination);
            f.Show();
        }

        private void RouteChose_Activated(object sender, EventArgs e)
        {
            updateRoutes();
        }

        private void routeEditMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new RouteEditing();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void RouteChose_Load(object sender, EventArgs e)
        {

        }
    }
}