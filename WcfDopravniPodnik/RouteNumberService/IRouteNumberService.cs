using System.Collections.Generic;
using System.ServiceModel;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.RouteNumberService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název rozhraní IRouteNumberService společně v kódu a konfiguračním souboru.
    [ServiceContract]
    public interface IRouteNumberService
    {
        [OperationContract]
        List<RouteNumber> GetAll();

        [OperationContract]
        RouteNumber Load(int id);


        [OperationContract]
        List<RouteNumberStation> GetRNSDirectionOne(int routeNumberID);

        [OperationContract]
        List<RouteNumberStation> GetRNSDirectionTwo(int routeNumberID);
    }
}
