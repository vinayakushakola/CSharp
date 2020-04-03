using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorPattern.AirTrafficController
{
    class ATCProgram
    {
        public static void ATCRun()
        {
            IATCMediator atcMediator = new ATCMediator();
            Flight sparrow101 = new Flight(atcMediator);
            Runway mainRunway = new Runway(atcMediator);
            atcMediator.RegisterFlight(sparrow101);
            atcMediator.RegisterRunway(mainRunway);
            sparrow101.GetReady();
            mainRunway.Land();
            sparrow101.Land();
        }
    }
}
