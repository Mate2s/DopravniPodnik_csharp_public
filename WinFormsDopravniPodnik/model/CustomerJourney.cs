using System;



namespace WinFormsDopravniPodnik.model
{
    [Serializable]
    public class CustomerJourney
    {
        DateTime _exitDate;
        DateTime _startDate;
        private string _comment;
        Station _startStation;
        Station _endStation;
        Route _route;
        Customer _customer;
        Payment _payment;

        public CustomerJourney()
        { }

        

        public DateTime ExitDate
        {
            get { return _exitDate; }
            set
            {
              
                _exitDate = value;
            }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set
            { 
                _startDate = value;
            }
        }

        public string Comment
        {
            get { return _comment; }
            set
            {
               
                _comment = value;
            }
        }

        //lazy load
        public Station StartStation
        {
            get
            {
                if (_startStation == null)
                {
                    //_startStation = datamapper.GetStartStation(_customer.Id, _routeB.Id)
                }
                return _startStation;
            }
            set
            {
               
                _startStation = value;
            }
        }

        //lazy load
        public Station EndStation
        {
            get
            {
                if (_endStation == null)
                {
                    //_endStation = datamapper.GetEndStation(_customer.Id, _routeB.Id)
                }
                return _endStation;
            }
            set
            {
                
                _endStation = value;
            }
        }

        public Route Route
        {
            get { return _route; }
            set
            {
               
                _route = value;
            }
        }

        public Customer Customer
        {
            get { return _customer; }
            set
            {
              
                _customer = value;
            }
        }

        //lazy load
        public Payment Payment
        {
            get
            {
                if (_payment == null)
                {
                    //_payment = datamapper.GetDetailPayment(_customer.Id, _routeB.Id)
                }
                return _payment;
            }
            set
            {
               
                _payment = value;
            }
        }

        public static CustomerJourney Add(int routeId, int customerId, int startStationID, int endStationID)
        {
            WinFormsDopravniPodnik.CustomerJourneyService1.CustomerJourneyServiceClient sc = new WinFormsDopravniPodnik.CustomerJourneyService1.CustomerJourneyServiceClient();
            return CustomerJourney.CastTo(sc.Add(routeId, customerId, startStationID, endStationID));
        }

        public static CustomerJourney CastTo(WinFormsDopravniPodnik.CustomerJourneyService1.CustomerJourney item)
        {
            return new CustomerJourney()
            {
               Customer = new Customer()
               {
                   Adress = item._customer._adress,
                   Id = item._customer._id,
                   Password = item._customer._password,
                   Firstname = item._customer._firstname,
                   Email = item._customer._email,
                   Lastname = item._customer._lastname,
                   City = item._customer._city,
                   BirthDate = item._customer._birthDate,
                   Login = item._customer._login
               },
                StartStation = new Station()
                {
                    Id = item._startStation._id,
                    Name = item._startStation._name,
                    Gpslat = item._startStation._gpslat,
                    Gpslng = item._startStation._gpslng
                },
                EndStation = new Station()
                {
                    Id = item._endStation._id,
                    Name = item._endStation._name,
                    Gpslat = item._endStation._gpslat,
                    Gpslng = item._endStation._gpslng
                },
                StartDate = item._startDate,
                ExitDate = item._exitDate

            };
        }
    }
}
