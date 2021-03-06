namespace WinFormsApp1
{
    public partial class TicketsReturn : Form
    {
        public TicketsReturn()
        {
            InitializeComponent();
        }
        public List<Ticket> passangerTickets;

        private void showTickets_Click(object sender, EventArgs e)
        {
            if (phoneMaskTextBox.Text.Length != 17)
                MessageBox.Show("Введіть номер телефону", Constants.ErrorHead, MessageBoxButtons.OK);
            else
            {
                passangerTickets = AllRoutes.FindPassangerTicketsByNumber(phoneMaskTextBox.Text);
                if (passangerTickets.Count == 0)
                {
                    MessageBox.Show("Не знайдено жодного квитку за вказаним номером телефону", Constants.ErrorHead, MessageBoxButtons.OK);
                }
                passangerTicketsGrid.DataSource = passangerTickets.GetRange(0, passangerTickets.Count);
            }
        }

        private void passangerTicketsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult rez = MessageBox.Show("Ви впевнені, що хочете повернути вибраний квиток?", Constants.ConfirmHead,
                MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                AllRoutes.DeleteTicket(passangerTickets[e.RowIndex]);
                passangerTickets.RemoveAt(e.RowIndex);
                passangerTicketsGrid.DataSource = passangerTickets.GetRange(0, passangerTickets.Count);
                AllRoutes.Save(Constants.PathRoutes);
            }
        }
    }
}
