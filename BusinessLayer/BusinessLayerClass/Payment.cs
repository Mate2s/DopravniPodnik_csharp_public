using System;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Payment:DomainObject
    {
        private int _id;
        decimal _value;
        DateTime _paymentDate;
        Coupon _coupon;
        private Customer _payer;
        CustomerJourney _journey;

        public Payment() { }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public decimal Value
        {
            get { return _value; }
            set
            {
                //MarkDirty();
                this._value = value;
            }
        }

        public DateTime PaymentDate
        {
            get { return _paymentDate; }
            set
            {
                //MarkDirty();
                _paymentDate = value;
            }
        }
        //lazy load
        public Coupon Coupon
        {
            get
            {
                if (_coupon == null)
                {
                    //_coupon = datamapper.GetCoupon(_customer.Id, _routeB.Id)
                }
                return _coupon;
            }
            set
            {
                // MarkDirty();
                _coupon = value;
            }
        }
        //lazy load
        public Customer Payer
        {
            get
            {
                if (_payer == null)
                {
                    //_payer = datamapper.GetPayer(_customer.Id, _routeB.Id)
                }
                return _payer;
            }
            set
            {
                //MarkDirty();
                _payer = value;
            }
        }
        //lazy load
        public CustomerJourney Journey
        {
            get
            {
                if (_journey == null)
                {
                    //_journey = datamapper.GetJourney(_customer.Id, _routeB.Id)
                }
                return _journey;
            }
            set
            {
                // MarkDirty();
                _journey = value;
            }
        }

        public override object GetId()
        {
            return Id;
            
        }

        public override void SetId(object id)
        {
            _id = (int)id;
        }

        public void DoNew()
        {
            MarkNew();
            UnitOfWork.UnitOfWork.Instance.Commit();
        }
    }
}
