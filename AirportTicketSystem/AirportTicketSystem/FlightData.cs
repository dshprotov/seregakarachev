using System;
using System.Collections.Generic;

namespace AirportTicketSystem
{
    public class FlightData
    {
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }

        // Пример метода для получения списка рейсов (замените на вашу логику получения данных)
        public static List<FlightData> GetFlights()
        {
            var flights = new List<FlightData>()
            {
                new FlightData { FlightNumber = "ABC123", DepartureCity = "New York", DestinationCity = "Los Angeles", DepartureTime = DateTime.Now.AddDays(1), Price = 200.00m },
                new FlightData { FlightNumber = "DEF456", DepartureCity = "Chicago", DestinationCity = "San Francisco", DepartureTime = DateTime.Now.AddDays(2), Price = 250.00m },
                new FlightData { FlightNumber = "GHI789", DepartureCity = "Miami", DestinationCity = "Las Vegas", DepartureTime = DateTime.Now.AddDays(3), Price = 300.00m }
            };
            return flights;
        }
    }
}
