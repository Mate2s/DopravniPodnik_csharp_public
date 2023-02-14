using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.CustomerJourneyService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název rozhraní ICustomerJourneyService společně v kódu a konfiguračním souboru.
    [ServiceContract]
    public interface ICustomerJourneyService
    {
        [OperationContract]
        CustomerJourney Add(int routeId,int customerId,int startStationID,int endStationID);

        [OperationContract]
        List<CustomerJourney> GetHistory(int idCustomer);
    }
}
