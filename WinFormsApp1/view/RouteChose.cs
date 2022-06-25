using System.Text.Json;

namespace WinFormsApp1
{
    public partial class RouteChose : Form
    {
        public RouteChose()
        {
            Font = new Font(Font.Name, 9f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
            AllRoutes.Load(Constants.PathRoutes);
            ListOfCities.Load(Constants.PathCities);
            AllPassangers.Load(Constants.PathPassangers);
            AllRoutes.DeleteOutdatesRoutes();
            AllRoutes.Save(Constants.PathRoutes);
            AllPassangers.Save(Constants.PathPassangers);
            ListOfCities.Save(Constants.PathCities);
            updateCitiesChose();
            dateDepartureBox.MinDate = DateTime.Now;
            DateTime Max = DateTime.Now;
            dateDepartureBox.MaxDate = Max.AddMonths(1);
        }

        public void updateCitiesChose()
        {
            departureBox.Items.Clear();
            destinationBox.Items.Clear();
            departureBox.Items.AddRange(ListOfCities.Cities.ToArray());
            destinationBox.Items.AddRange(ListOfCities.Cities.ToArray());
        }

        private void updateRoutes()
        {
            panelRoutes.Controls.Clear();
            Label infoText = new Label();
            infoText.AutoSize = true;
            if (departureBox.Text == "" || destinationBox.Text == "")
            {
                infoText.Text = "Будь ласка, виберіть пункт відправлення та пункт призначення.";
                panelRoutes.Controls.Add(infoText);
            }
            else if (departureBox.Text == destinationBox.Text)
            {
                infoText.Text = "Станція відправлення збігається зі станцією прибуття. Змініть умови пошуку.";
                panelRoutes.Controls.Add(infoText);
            }
            else
            {
                List<Route> correctRoutes = AllRoutes.FindRouteByCities(departureBox.Text, destinationBox.Text, dateDepartureBox.Value);
                AllRoutes.SortByDepartureDate(correctRoutes);
                if (correctRoutes.Count == 0)
                {
                    infoText.Text = "Рейсів за вказаним напрямком на вказану дату не знайдено.";
                    panelRoutes.Controls.Add(infoText);
                }
                else
                {
                    for (int i = 0; i < correctRoutes.Count; i++)
                    {
                        Panel availableRoutePanel = new Panel();
                        if (i == 0)
                        {
                            Label nearest = new Label();
                            nearest.Text = "Найближчий";
                            nearest.Location = new Point(0, 0);
                            nearest.AutoSize = true;
                            availableRoutePanel.Controls.Add(nearest);
                        }

                        Label routeNumLabel = new Label();
                        routeNumLabel.Text = "Рейс № " + correctRoutes[i].RouteNumber;
                        routeNumLabel.Location = new Point(27, 15);
                        routeNumLabel.AutoSize = true;

                        Stop departureStop = correctRoutes[i].FindStopByStopName(departureBox.Text);
                        Stop destinationStop = correctRoutes[i].FindStopByStopName(destinationBox.Text);

                        Label destinationLabel = new Label();
                        destinationLabel.Text = "Прибуття:\n" + destinationStop.StopName + '\n' + destinationStop.Departure;
                        destinationLabel.Location = new Point(545, 15);
                        destinationLabel.AutoSize = true;

                        Label departureLabel = new Label();
                        departureLabel.Text = "Відправлення:\n" + departureStop.StopName + '\n' + departureStop.Departure;
                        departureLabel.Location = new Point(298, 15);
                        departureLabel.AutoSize = true;

                        Label emptySeatsLabel = new Label();
                        int startIndex = correctRoutes[i].FindStopIndexByName(departureBox.Text);
                        int endIndex = correctRoutes[i].FindStopIndexByName(destinationBox.Text);
                        int freeSeats = correctRoutes[i].GetFreeSeats(startIndex, endIndex).Count;
                        emptySeatsLabel.Text = "Кількість вільних місць: " + Convert.ToString(freeSeats);
                        emptySeatsLabel.Location = new Point(27, 45);
                        emptySeatsLabel.AutoSize = true;

                        Button goTicketingButton = new Button();
                        goTicketingButton.Text = "Перейти до оформлення квитку";
                        goTicketingButton.Location = new Point(783, 45);
                        goTicketingButton.Size = new Size(206, 23);
                        Route tempRoute = correctRoutes[i];
                        void goTicketingButton_Click(object? sender, EventArgs e)
                        {
                            if (freeSeats != 0)
                                startTicketing(tempRoute, departureStop, destinationStop);
                            else
                                MessageBox.Show("На даний рейс відсутні вільні місця", Constants.ErrorHead, MessageBoxButtons.OK);
                        }

                        goTicketingButton.Click += goTicketingButton_Click;


                        Button detailInformationButton = new Button();
                        detailInformationButton.Text = "Детальна інформація про рейс";
                        detailInformationButton.Location = new Point(783, 15);
                        detailInformationButton.Size = new Size(206, 23);
                        void goDetailInformation(object? sender, EventArgs e)
                        {
                            startDetailInformation(tempRoute, departureStop, destinationStop, freeSeats);
                        }
                        detailInformationButton.Click += goDetailInformation;


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
            f.ShowDialog();
        }

        private void startDetailInformation(Route route, Stop departure, Stop destination, int freeSeats)
        {
            DetailInformation f = new DetailInformation(route, departure, destination, freeSeats);
            f.ShowDialog();
        }

        private void RouteChose_Activated(object sender, EventArgs e)
        {
            updateRoutes();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Ви точно бажаєте вийти з програми?", Constants.ConfirmHead, MessageBoxButtons.YesNo);
            if(exit == DialogResult.Yes)
                this.Close();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form temp = new TicketsReturn();
            temp.ShowDialog();
        }

        private void editingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form temp = new RouteEditing(this);
            temp.ShowDialog();
        }

        private void RouteChose_Load(object sender, EventArgs e)
        {
            updateRoutes();
        }

        private void landingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form temp = new LandingList();
            temp.ShowDialog();
        }
    }
}