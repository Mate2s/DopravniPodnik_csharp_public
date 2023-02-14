using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.VehicleService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název třídy VehicleService společně v kódu, svc a konfiguračním souboru.
    // POZNÁMKA: Pokud chcete spustit klienta testu WCF pro otestování této služby, vyberte v Průzkumníkovi řešeníVehicleService.svc nebo VehicleService.svc.cs a spusťte ladění.
    public class VehicleService : IVehicleService
    {
        public List<Vehicle> GetAll()
        {
            return Vehicle.GetAll();
        }
    }
}
