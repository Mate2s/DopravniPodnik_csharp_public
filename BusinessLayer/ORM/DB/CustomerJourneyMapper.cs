using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.pk;

namespace BusinessLayer.ORM.DB
{
    public class CustomerJourneyMapper : AbstractMapper,ICustomerJourneyMapper
    {
        protected override Type GetTypeDO()
        {
            return new CustomerJourney().GetType();
        }

        protected override DomainObject DoLoad()
        {
            CustomerMapper cm = new CustomerMapper();
            RouteMapper rm = new RouteMapper();
            StationMapper sm = new StationMapper();
            CustomerJourney item = new CustomerJourney()
            {
                Customer = (Customer)cm.Load((int)Reader["Customer_ID"]),
                Route = (Route)rm.Load((int)Reader["Route_ID"]),
                ExitDate = (DateTime)Reader["exitDate"],
                StartDate = (DateTime)Reader["startDate"],
                Comment = (string)Reader["comment"],
                StartStation = (Station)sm.Load((int)Reader["Station_IDstart"]),
                EndStation = (Station)sm.Load((int)Reader["Station_IDend"]),
                //Payment = PaymentDataMapper.GetByID((int)Reader["Payment_ID"])
            };
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            CustomerMapper cm = new CustomerMapper();
            RouteMapper rm = new RouteMapper();
            CustomerJourneyPK pk = (CustomerJourneyPK)id;
            //StationMapper sm = new StationMapper();
            CustomerJourney item = new CustomerJourney()
            {
                Customer = pk.Customer,
                Route = pk.Route,
                ExitDate = (DateTime)Reader["exitDate"],
                StartDate = (DateTime)Reader["startDate"],
                Comment = (string)Reader["comment"],
                //StartStation = (Station)sm.Load((int)Reader["Station_IDstart"]),
                //EndStation = (Station)sm.Load((int)Reader["Station_IDend"]),
                //Payment = PaymentDataMapper.GetByID((int)Reader["Payment_ID"])
            };
            return item;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [CustomerJourney]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [CustomerJourney] WHERE [Customer_ID] = @ID";
            Command.Parameters.AddWithValue("@ID", ((CustomerJourneyPK)id).Customer.Id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            var item = (CustomerJourney)domainObject;
            Command.CommandText = "INSERT INTO [CustomerJourney] Values (@Customer_ID,@Route_ID,@exitDate,@startDate,@comment,@Station_IDstart,@Station_IDend,@Payment_ID)";
            Command.Parameters.AddWithValue("@Customer_ID", item.Customer.Id);
            Command.Parameters.AddWithValue("@Route_ID", item.Route.Id);
            Command.Parameters.AddWithValue("@exitDate", item.ExitDate);
            Command.Parameters.AddWithValue("@startDate", item.StartDate);
            Command.Parameters.AddWithValue("@comment", "");
            Command.Parameters.AddWithValue("@Station_IDstart", item.StartStation.Id);
            Command.Parameters.AddWithValue("@Station_IDend", item.EndStation.Id);
            if(item.Payment==null)
                Command.Parameters.AddWithValue("@Payment_ID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Payment_ID", item.Payment.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            var item = (CustomerJourney)domainObject;
            Command.CommandText = "UPDATE [CustomerJourney] SET exitDate=@exitDate, startDate=@startDate, comment=@comment, Station_IDstart=@Station_IDstart,Station_IDend=@Station_IDend,Payment_ID=@Payment_ID WHERE Customer_ID= @Customer_ID AND Route_ID=@Route_ID";
            Command.Parameters.AddWithValue("@Customer_ID", item.Customer.Id);
            Command.Parameters.AddWithValue("@Route_ID", item.Route.Id);
            Command.Parameters.AddWithValue("@exitDate", item.ExitDate);
            Command.Parameters.AddWithValue("@startDate", item.StartDate);
            Command.Parameters.AddWithValue("@comment", item.Comment);
            Command.Parameters.AddWithValue("@Station_IDstart", item.StartStation.Id);
            Command.Parameters.AddWithValue("@Station_IDend", item.EndStation.Id);
            Command.Parameters.AddWithValue("@Payment_ID", item.Payment.Id);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            var item = (CustomerJourney)domainObject;
            Command.CommandText = "DELETE FROM [CustomerJourney] WHERE [Route_ID] = @Route_ID AND [Customer_ID]=@Customer_ID";
            Command.Parameters.AddWithValue("@Route_ID", item.Route.Id);
            Command.Parameters.AddWithValue("@Customer_ID", item.Customer.Id);
        }

        protected override string GetTableName()
        {
            return "CustomerJourney";
        }
    }
}
