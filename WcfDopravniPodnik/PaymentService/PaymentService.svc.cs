using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.PaymentService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název třídy PaymentService společně v kódu, svc a konfiguračním souboru.
    // POZNÁMKA: Pokud chcete spustit klienta testu WCF pro otestování této služby, vyberte v Průzkumníkovi řešeníPaymentService.svc nebo PaymentService.svc.cs a spusťte ladění.
    public class PaymentService : IPaymentService
    {
        public void Payment(decimal value, int customerId)
        {
            Customer c = Customer.Load(customerId);

            Payment p = new Payment()
            {
                Payer = c,
                Value = value,
                PaymentDate = DateTime.Now
            };
            p.DoNew();

        }
    }
}
