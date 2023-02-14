using BusinessLayer.BusinessLayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDopravniPodnik.CustomerService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název rozhraní ICusomerService společně v kódu a konfiguračním souboru.
    [ServiceContract]
    public interface ICusomerService
    {
        [OperationContract]
        Customer Login(string login, string password);

        [OperationContract]
        List<Customer> GetAll();

        [OperationContract]
        Customer Load(int id);
    }
}
