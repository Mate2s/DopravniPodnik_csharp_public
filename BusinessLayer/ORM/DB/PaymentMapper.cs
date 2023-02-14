using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.DB
{
    public class PaymentMapper : AbstractMapper,IPaymentMapper
    {
        protected override Type GetTypeDO()
        {
            return new Payment().GetType();
        }

        protected override DomainObject DoLoad()
        {
            CustomerMapper cm = new CustomerMapper();
            Payment item = new Payment()
            {
                Id = (int)Reader["ID"],
                Value = (Decimal)Reader["value"],
                PaymentDate = (DateTime)Reader["paymentDate"],
                Payer = (Customer)cm.Load((int)Reader["Customer_ID"])
                //Coupon = CouponDataMapper.GetByID((int)Reader["Coupon_ID"]),
                //Journey = CustomerJourneyDataMapper.GetByIDs((int)Reader["CustomerJourney_Customer_ID"], (int)reader["CustomerJourney_Route_ID"])
            };
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            CustomerMapper cm = new CustomerMapper();
            Payment item = new Payment()
            {
                Id = (int)id,
                Value = (Decimal)Reader["value"],
                PaymentDate = (DateTime)Reader["paymentDate"],
                Payer = (Customer)cm.Load((int)Reader["Customer_ID"])
                //Coupon = CouponDataMapper.GetByID((int)Reader["Coupon_ID"]),
                //Journey = CustomerJourneyDataMapper.GetByIDs((int)Reader["CustomerJourney_Customer_ID"], (int)reader["CustomerJourney_Route_ID"])
            };
            return item;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [Payment]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Payment] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            var item = (Payment)domainObject;
            Command.CommandText = "INSERT INTO [Payment] Values (@value,@paymentDate,@Customer_ID)";
            Command.Parameters.AddWithValue("@value", item.Value);
            Command.Parameters.AddWithValue("@paymentDate", item.PaymentDate);
            Command.Parameters.AddWithValue("@Customer_ID", item.Payer.Id);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            var item = (Payment)domainObject;
            Command.CommandText = "DELETE FROM [Payment] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            var item = (Payment)domainObject;
            Command.CommandText = "UPDATE [Payment] SET value=@value, paymentDate=@paymentDate, Customer_ID=@Customer_ID WHERE ID=@ID";
            Command.Parameters.AddWithValue("@value", item.Value);
            Command.Parameters.AddWithValue("@paymentDate", item.PaymentDate);
            Command.Parameters.AddWithValue("@Customer_ID", item.Payer.Id);
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override string GetTableName()
        {
            return "Payment";
        }
    }
}
