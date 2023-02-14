using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.VehicleService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název rozhraní IVehicleService společně v kódu a konfiguračním souboru.
    [ServiceContract]
    public interface IVehicleService
    {
        [OperationContract]
        List<Vehicle> GetAll();
    }
}
