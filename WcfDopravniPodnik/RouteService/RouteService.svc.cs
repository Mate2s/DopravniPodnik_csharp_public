using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.UnitOfWork;

namespace WcfDopravniPodnik.RouteService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název třídy RouteService společně v kódu, svc a konfiguračním souboru.
    // POZNÁMKA: Pokud chcete spustit klienta testu WCF pro otestování této služby, vyberte v Průzkumníkovi řešeníRouteService.svc nebo RouteService.svc.cs a spusťte ladění.
    public class RouteService : IRouteService
    {
        public Route CreateRoute(int vehicleID, int driverID, int routeNumberID)
        {
            Driver dr = Driver.Load(driverID);
            Vehicle vh = Vehicle.Load(vehicleID);
            RouteNumber rn = RouteNumber.Load(routeNumberID);

            Route route = new Route(){Driver = dr,Vehicle = vh,RouteNumber = rn,StartRoute = DateTime.Now,EndRoute = DateTime.Now };
            route.DoNew();
            return route;
        }

        public void EndRoute(int id)
        {
            Route route = Route.Load(id);
            route.EndRoute = DateTime.Now;
            route.DoUpdate();
        }
    }
}
