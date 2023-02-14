using System;

namespace WinFormsDopravniPodnik.model
{
    [Serializable]
    public class Payment
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
                this._value = value;
            }
        }

        public DateTime PaymentDate
        {
            get { return _paymentDate; }
            set
            {
               
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
               
                _journey = value;
            }
        }


        public static void Paid(int customerId, decimal value)
        {
            WinFormsDopravniPodnik.PaymentService1.PaymentServiceClient sc =new WinFormsDopravniPodnik.PaymentService1.PaymentServiceClient();
            sc.Payment(value, customerId);
        }
    }
}
