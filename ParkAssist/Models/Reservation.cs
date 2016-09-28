using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkAssist.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public int GateID { get; set; }
        public int FlightID { get; set; }
        public string Destination { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public FlightStatus Status { get; set; }
    }
}