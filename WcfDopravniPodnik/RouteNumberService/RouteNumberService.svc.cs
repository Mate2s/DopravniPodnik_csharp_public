using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using BusinessLayer.BusinessLayerClass;

namespace WcfDopravniPodnik.RouteNumberService
{
    // POZNÁMKA: Pomocí příkazu Přejmenovat v nabídce Refaktorovat můžete změnit název třídy RouteNumberService společně v kódu, svc a konfiguračním souboru.
    // POZNÁMKA: Pokud chcete spustit klienta testu WCF pro otestování této služby, vyberte v Průzkumníkovi řešeníRouteNumberService.svc nebo RouteNumberService.svc.cs a spusťte ladění.
    public class RouteNumberService : IRouteNumberService
    {
        public List<RouteNumber> GetAll()
        {
           return RouteNumber.GetAll();
        }

        public List<RouteNumberStation> GetRNSDirectionOne(int routeNumberID)
        {
            RouteNumber routeNumber = RouteNumber.Load(routeNumberID);
            var x = routeNumber.RouteNumberStationsDirectionOne;
            return x;
            /*
            RouteNumber routeNumber = RouteNumber.Load(routeNumberID);
            List<sendingData> list = new List<sendingData>();
            foreach (var v in routeNumber.RouteNumberStationsDirectionOne)
            {
                list.Add(sendingData.castto(v));
            }
            return list;*/
        }

        public List<RouteNumberStation> GetRNSDirectionTwo(int routeNumberID)
        {
            RouteNumber routeNumber = RouteNumber.Load(routeNumberID);
            var x = routeNumber.RouteNumberStationsDirectionTwo;
            return x;
            /*RouteNumber routeNumber = RouteNumber.Load(routeNumberID);
            List<sendingData> list = new List<sendingData>();
            foreach (var v in routeNumber.RouteNumberStationsDirectionTwo)
            {
                list.Add(sendingData.castto(v));
            }
            return list;
            return null;*/
        }

        public RouteNumber Load(int id)
        {
            RouteNumber routeNumber = RouteNumber.Load(id);
            return routeNumber;
        }
    }
    [Serializable]
    public class sendingData
    {
        private bool direction;
        RouteNumber _routeNumber;
        Station _station;
        int _order;
        private string desc;
        private double kmToNextStation;

        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public RouteNumber RouteNumber
        {
            get { return _routeNumber; }
            set { _routeNumber = value; }
        }

        public Station Station
        {
            get { return _station; }
            set { _station = value; }
        }

        public int Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public double KmToNextStation
        {
            get { return kmToNextStation; }
            set { kmToNextStation = value; }
        }

        public static sendingData castto(RouteNumberStation rns)
        {

            sendingData sd = new sendingData()
            {
                RouteNumber = new RouteNumber() {Id = rns.RouteNumber.Id},
                Station = rns.Station,
                Order = rns.Order,
                Direction = rns.Direction,
                Desc = rns.Desc,
                KmToNextStation = rns.KmToNextStation
            };
            return sd;
        }
    }
}
