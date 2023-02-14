using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.RouteService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název rozhraní IRouteService společně v kódu a konfiguračním souboru.
    [ServiceContract]
    public interface IRouteService
    {
        [OperationContract]
        Route CreateRoute(int vehicleID, int driverID, int routeNumberID);

        [OperationContract]
        void  EndRoute(int id);
    }
}
