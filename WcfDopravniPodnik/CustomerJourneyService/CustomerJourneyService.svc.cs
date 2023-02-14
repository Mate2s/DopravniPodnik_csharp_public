using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.CustomerJourneyService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název třídy CustomerJourneyService společně v kódu, svc a konfiguračním souboru.
    // POZNÁMKA: Pokud chcete spustit klienta testu WCF pro otestování této služby, vyberte v Průzkumníkovi řešeníCustomerJourneyService.svc nebo CustomerJourneyService.svc.cs a spusťte ladění.
    public class CustomerJourneyService : ICustomerJourneyService
    {

        public CustomerJourney Add(int routeId, int customerId, int startStationID, int endStationID)
        {
            Route r= Route.Load(routeId);
            Customer c= Customer.Load(customerId);
            Station start = Station.Load(startStationID);
            Station end = Station.Load(endStationID);
            CustomerJourney customerjourney = new CustomerJourney()
            {
                Customer = c,
                StartStation = start,
                EndStation = end,
                StartDate = DateTime.Now,
                ExitDate = DateTime.Now,
                Route = r
            };
            customerjourney.DoNew();
            return customerjourney;
        }

        public List<CustomerJourney> GetHistory(int idCustomer)
        {
            List<CustomerJourney> listAll =CustomerJourney.GetAll();
            return listAll.Where(x => x.Customer.Id == idCustomer).ToList();
        }
    }
}
