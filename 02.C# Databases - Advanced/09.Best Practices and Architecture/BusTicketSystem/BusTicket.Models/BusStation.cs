﻿using System.Collections.Generic;

namespace BusTicket.Models
{
    public class BusStation
    {
        public BusStation()
        {
            this.ArrivalTrips = new List<Trip>();

            this.DestionationTrips = new List<Trip>();
        }

        public int BusStationId { get; set; }

        public string Name { get; set; }

        public int TownId { get; set; }
        public virtual Town Town { get; set; }
        
        public virtual ICollection<Trip> ArrivalTrips { get; set; }

        public virtual ICollection<Trip> DestionationTrips { get; set; }
    }
}
