using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorPattern.AirTrafficController
{
    public class ATCMediator : IATCMediator
    {
        private Flight flight;
        private Runway runway;
        public bool land;

        public void RegisterRunway(Runway runway)
        {
            this.runway = runway;
        }

        public void RegisterFlight(Flight flight)
        {
            this.flight = flight;
        }

        public bool IsLandingOk()
        {
            return land;
        }

        public void SetLandingStatus(bool status)
        {
            land = status;
        }
    }
}
