using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.pk;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class CustomerJourney:DomainObject
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
               // MarkDirty();
                _exitDate = value;
            }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                // MarkDirty();
                _startDate = value;
            }
        }

        public string Comment
        {
            get { return _comment; }
            set
            {
                // MarkDirty();
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
                //MarkDirty();
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
                // MarkDirty();
                _endStation = value;
            }
        }

        public Route Route
        {
            get { return _route; }
            set
            {
                // MarkDirty();
                _route = value;
            }
        }

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                // MarkDirty();
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
                //MarkDirty();
                _payment = value;
            }
        }

        public override object GetId()
        {
            return new CustomerJourneyPK(_route,_customer);
        }

        public override void SetId(object id)
        {
            throw new NotImplementedException();
        }

        public void DoNew()
        {
            MarkNew();
            UnitOfWork.UnitOfWork.Instance.Commit();
        }


        public static List<CustomerJourney> GetAll()
        {
            return Mapper.Mapper.Instance.GetMapper(new CustomerJourney()).LoadAll().Cast<CustomerJourney>().ToList();
        }
    }
}
