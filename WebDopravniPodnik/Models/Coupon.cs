using System;

namespace WebDopravniPodnik.Models
{
    [Serializable]
    public class Coupon
    {
        private int _id;
        DateTime _startvalidity;
        DateTime _endvalidity;
        Customer _owner;
        Payment _payment;

        public Coupon()
        { }
        
        public Coupon(int id, DateTime startvalidity, DateTime endvalidity, Customer owner, Payment payment)
        {
            this._id = id;
            this._startvalidity = startvalidity;
            this._endvalidity = endvalidity;
            this._owner = owner;
            this._payment = payment;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime Startvalidity
        {
            get { return _startvalidity; }
            set
            {
               
                _startvalidity = value;
            }
        }

        public DateTime Endvalidity
        {
            get { return _endvalidity; }
            set
            {
              
                _endvalidity = value;
            }
        }

        public Customer Owner
        {
            get
            {
                if (_owner == null)
                {
                    //_owner = datamapper.GetOwner(_customer.Id, _routeB.Id)
                }
                return _owner;
            }
            set
            {
              
                _owner = value;
            }
        }

        public Payment Payment
        {
            get
            {
                if (_payment == null)
                {
                    //_payment = datamapper.GetPayment(_customer.Id, _routeB.Id)
                }
                return _payment;
            }
            set
            {
                _payment = value;
            }
        }
    }
}
