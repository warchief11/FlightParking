using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkAssist.Models
{
    public class Repository : IRepository
    {
        private static List<Flight> _flights = new List<Flight>();
        private static List<Gate> _gates = new List<Gate>();
        private static List<Reservation> _reservations = new List<Reservation>();

        public Repository()
        {
            SeedData();
        }

        private void SeedData()
        {
            _flights.Clear();
            _gates.Clear();
            _reservations.Clear();
            for (int i = 1; i < 20; i++)
            {
                _flights.Add(new Flight { ID = i, AirLine = "Quantas", Name = "QN" + i.ToString() });
                _flights.Add(new Flight { ID = i + 20, AirLine = "Virgin Australia", Name = "VA" + (i + 20).ToString() });
                _flights.Add(new Flight { ID = i + 40, AirLine = "Cathay Pacific", Name = "CP" + (i + 40).ToString() });

                _gates.Add(new Gate { ID = 1, Name = i.ToString() });

            }
            _reservations.Add(new Reservation { ID = 1, GateID = 2, FlightID = 1, Arrival = DateTime.Today.AddHours(5), Departure = DateTime.Today.AddHours(6), Destination = "AuckLand" });
            _reservations.Add(new Reservation { ID = 2, GateID = 3, FlightID = 5, Arrival = DateTime.Today.AddHours(5), Departure = DateTime.Today.AddHours(5.5), Destination = "Canberra" });
            _reservations.Add(new Reservation { ID = 3, GateID = 3, FlightID = 4, Arrival = DateTime.Today.AddHours(5.5), Departure = DateTime.Today.AddHours(6), Destination = "Melbourne" });

        }
        public List<Flight> Flights
        {
            get
            {
                return _flights;
            }

            set
            {
                _flights = value;
            }
        }

        public List<Gate> Gates
        {
            get
            {
                return _gates;
            }

            set
            {
                _gates = value;
            }
        }

        public List<Reservation> Reservations
        {
            get
            {
                return _reservations;
            }

            set
            {
                _reservations = value;
            }
        }
    }

    public interface IRepository
    {
        List<Flight> Flights { get; set; }
        List<Gate> Gates { get; set; }
        List<Reservation> Reservations { get; set; }
    }
}