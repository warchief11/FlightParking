using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkAssist.Models
{
    public class FlightManager
    {
        private IRepository _repo;
        public FlightManager(IRepository repo)
        {
            _repo = repo;
        }

        public List<Reservation> GetReservations(int? gateId = null, int? flightID = null)
        {
            return _repo.Reservations.Where(r => (!gateId.HasValue || gateId.Value == r.GateID)
                                           && (!flightID.HasValue || flightID.Value == r.FlightID))
                              .ToList();
        }

        public void BookReservation(Reservation reservation)
        {

        }
    }
}