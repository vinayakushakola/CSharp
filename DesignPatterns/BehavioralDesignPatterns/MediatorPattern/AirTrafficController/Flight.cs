using System;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorPattern.AirTrafficController
{
    public class Flight : Command
    {
        private IATCMediator atcMediator;

        public Flight(IATCMediator atcMediator)
        {
            this.atcMediator = atcMediator;
        }

        public void Land()
        {
            if (atcMediator.IsLandingOk())
            {
                Console.WriteLine("Successfully Landed.");
                atcMediator.SetLandingStatus(true);
            }
            else
                Console.WriteLine("Waiting for landing.");
        }

        public void GetReady()
        {
            Console.WriteLine("Ready for landing.");
        }
    }
}