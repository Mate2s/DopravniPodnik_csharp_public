using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDopravniPodnik.PaymentService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název rozhraní IPaymentService společně v kódu a konfiguračním souboru.
    [ServiceContract]
    public interface IPaymentService
    {
        [OperationContract]
        void Payment(decimal value, int customerId);
    }
}
