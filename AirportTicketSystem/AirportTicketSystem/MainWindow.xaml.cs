using System.Windows;

namespace AirportTicketSystem
{
    public partial class MainWindow : Window
    {
        private FlightData selectedFlight;

        public MainWindow()
        {
            InitializeComponent();
            LoadFlights(); // Загрузка рейсов при запуске приложения
        }

        // Загрузка списка рейсов
        private void LoadFlights()
        {
            // Ваш код для загрузки списка рейсов из базы данных или другого источника данных
            // Пример:
            FlightsListView.ItemsSource = FlightData.GetFlights();
        }

        // Обработчик выбора рейса в списке
        private void FlightsListView_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (FlightsListView.SelectedItem != null)
            {
                selectedFlight = (FlightData)FlightsListView.SelectedItem;
                DisplayFlightDetails(selectedFlight);
            }
        }

        // Отображение информации о выбранном рейсе
        private void DisplayFlightDetails(FlightData flight)
        {
            FlightNumberTextBox.Text = flight.FlightNumber;
            DepartureCityTextBox.Text = flight.DepartureCity;
            DestinationCityTextBox.Text = flight.DestinationCity;
            DepartureTimeTextBox.Text = flight.DepartureTime.ToString();
            PriceTextBox.Text = flight.Price.ToString();
        }

        // Обработчик щелчка кнопки "Buy Ticket"
        private void BuyTicketButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedFlight != null)
            {
                // Ваш код для покупки билета
                MessageBox.Show($"Ticket for flight {selectedFlight.FlightNumber} purchased successfully!");
            }
            else
            {
                MessageBox.Show("Please select a flight first.");
            }
        }
    }
}
