using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.DriverService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název rozhraní IDriverService společně v kódu a konfiguračním souboru.
    [ServiceContract]
    public interface IDriverService
    {
        [OperationContract]
        Driver Login(string login,string password);
    }
}
