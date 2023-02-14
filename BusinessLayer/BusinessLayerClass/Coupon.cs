using System;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Coupon:DomainObject
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
                //MarkDirty();
                _startvalidity = value;
            }
        }

        public DateTime Endvalidity
        {
            get { return _endvalidity; }
            set
            {
                //MarkDirty();
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
               // MarkDirty();
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
                //MarkDirty();
                _payment = value;
            }
        }

        public override object GetId()
        {
            return Id;
        }

        public override void SetId(object id)
        {
            _id = (int) id;
        }
    }
}
