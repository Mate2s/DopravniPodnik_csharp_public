using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.map;

namespace BusinessLayer.ORM.DB
{
    public class RouteNumberMapper : AbstractMapper,IRouteNumberMapper
    {
        protected override Type GetTypeDO()
        {
            return new RouteNumber().GetType();
        }

        protected override DomainObject DoLoad()
        {
            RouteNumber item = new RouteNumber()
            {
                Id = (int)Reader["ID"],
                Number = (int)Reader["NUMBER"],
                Description = (string)Reader["desciption"]
            };
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            return new RouteNumber()
            {
                Id = (int)id,
                Number = (int)Reader["NUMBER"],
                Description = (string)Reader["desciption"]
            };
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [RouteNumber]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [RouteNumber] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            var item = (RouteNumber)domainObject;
            Command.CommandText = "INSERT INTO [RouteNumber] Values (@NUMBER,@desciption)";
            Command.Parameters.AddWithValue("@NUMBER", item.Number);
            Command.Parameters.AddWithValue("@desciption", item.Description);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            var item = (RouteNumber)domainObject;
            Command.CommandText = "DELETE FROM [RouteNumber] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            var item = (RouteNumber)domainObject;
            Command.CommandText = "UPDATE [RouteNumber] SET NUMBER=@NUMBER, desciption=@desciption WHERE ID=@ID";
            Command.Parameters.AddWithValue("@NUMBER", item.Number);
            Command.Parameters.AddWithValue("@desciption", item.Description);
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override string GetTableName()
        {
            return "RouteNumber";
        }

       
        
    }
}
