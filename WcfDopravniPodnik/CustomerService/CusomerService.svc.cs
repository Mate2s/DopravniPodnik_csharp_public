using BusinessLayer.BusinessLayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDopravniPodnik.CustomerService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název třídy CusomerService společně v kódu, svc a konfiguračním souboru.
    // POZNÁMKA: Pokud chcete spustit klienta testu WCF pro otestování této služby, vyberte v Průzkumníkovi řešeníCusomerService.svc nebo CusomerService.svc.cs a spusťte ladění.
    public class CusomerService : ICusomerService
    {
        public Customer Login(string login, string password)
        {
            return Customer.DoLogin(login, password);
        }

        public Customer Load(int id)
        {
            return Customer.Load(id);
        }

        public List<Customer> GetAll()
        {
            return Customer.GetAll();
        }
    }
}
