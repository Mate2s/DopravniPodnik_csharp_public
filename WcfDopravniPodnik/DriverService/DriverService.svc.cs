using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.DriverService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název třídy DriverService společně v kódu, svc a konfiguračním souboru.
    // POZNÁMKA: Pokud chcete spustit klienta testu WCF pro otestování této služby, vyberte v Průzkumníkovi řešeníDriverService.svc nebo DriverService.svc.cs a spusťte ladění.
    public class DriverService : IDriverService
    {
        public Driver Login(string login, string password)
        {
            return Driver.DoLogin(login, password);
        }
    }
}
