using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_DatabaseFirst_CopenhagenAirport
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Country> countries = new List<Country>();
            List<Airport> airports = new List<Airport>();
            List<Company> companies = new List<Company>();
            List<Route> routes = new List<Route>();
            List<Flight> flights = new List<Flight>();

            using (var context = new CopenhagenAirportDBEntities())
            {
                countries = context.Countries.ToList<Country>();
                airports = context.Airports.ToList<Airport>();
                companies = context.Companies.ToList<Company>();
                routes = context.Routes.ToList<Route>();
                flights= context.Flights.ToList<Flight>();
            }

            foreach (var country in countries)
            {
                Console.WriteLine($"Country ID: {country.id} | Country Name: {country.name}");
            }

            foreach (var airport in airports) 
            {
                Console.WriteLine($"Airport ID: {airport.id} | Airport Name: {airport.name} | IATA: {airport.iata} |  Located in: {airport.Country.name}");
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"Company ID: {company.id} | Company Name: {company.name}");
            }

            foreach (var route in routes)
            {
                Console.WriteLine($"Route ID: {route.id} | Owner of route: {route.Company.name} | Origin IATA: {route.Airport1.iata} | Origin Country: {route.Airport1.Country.name} | Destination IATA: {route.Airport.iata} | Destination Country {route.Airport.Country.name}");
            }

            foreach(var flight in flights)
            {
                Console.WriteLine($"Flight ID: {flight.id} | Owner of flight: {flight.Company.name} | On route from {flight.Route.Airport1.name} to {flight.Route.Airport.name} | Departure at {flight.departure}");
            }

            Console.ReadLine();
        }
    }
}