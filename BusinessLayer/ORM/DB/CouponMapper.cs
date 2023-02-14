using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.DB
{
    public class CouponMapper : AbstractMapper,ICouponMapper
    {
        protected override Type GetTypeDO()
        {
            return new Coupon().GetType();
        }

        protected override DomainObject DoLoad()
        {
            Coupon item = new Coupon()
            {
                Id = (int)Reader["ID"],
                //Payment = PaymentDataMapper.GetByID((int)reader["Payment_ID"]),
                //Owner = CustomerDataMapper.GetByID((int)reader["Customer_ID"]),
                Endvalidity = (DateTime)Reader["endvalidity"],
                Startvalidity = (DateTime)Reader["startvalidity"]
            };
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            Coupon item = new Coupon()
            {
                Id = (int)id,
                //Payment = PaymentDataMapper.GetByID((int)reader["Payment_ID"]),
                //Owner = CustomerDataMapper.GetByID((int)reader["Customer_ID"]),
                Endvalidity = (DateTime)Reader["endvalidity"],
                Startvalidity = (DateTime)Reader["startvalidity"]
            };
            return item;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [Coupon]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Coupon] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            var coupon = (Coupon)domainObject;
            Command.CommandText = "INSERT INTO [Coupon] Values (@startvalidity,@endvalidity,@owner,@payment)";
            Command.Parameters.AddWithValue("@startvalidity", coupon.Startvalidity);
            Command.Parameters.AddWithValue("@endvalidity", coupon.Endvalidity);
            Command.Parameters.AddWithValue("@owner", coupon.Owner.Id);
            Command.Parameters.AddWithValue("@payment", coupon.Payment.Id);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            var coupon = (Coupon)domainObject;
            Command.CommandText = "DELETE FROM [Coupon] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", coupon.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            var coupon = (Coupon)domainObject;
            Command.CommandText = "UPDATE [Coupon] SET startvalidity=@startvalidity , endvalidity=@endvalidity , Customer_ID=@owner , Payment_ID=@payment WHERE ID=@id";
            Command.Parameters.AddWithValue("@startvalidity", coupon.Startvalidity);
            Command.Parameters.AddWithValue("@endvalidity", coupon.Endvalidity);
            Command.Parameters.AddWithValue("@owner", coupon.Owner.Id);
            Command.Parameters.AddWithValue("@payment", coupon.Payment.Id);
            Command.Parameters.AddWithValue("@id", coupon.Id);
        }

        protected override string GetTableName()
        {
            return "Coupon";
        }
    }
}
