using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorPattern.AirTrafficController
{
    public interface IATCMediator
    {
        public void RegisterRunway(Runway runway);

        public void RegisterFlight(Flight flight);

        public bool IsLandingOk();

        public void SetLandingStatus(bool status);
    }
}
