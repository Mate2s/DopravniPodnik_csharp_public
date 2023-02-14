using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.DB
{
    public class RouteMapper : AbstractMapper,IRouteMapper
    {
        protected override Type GetTypeDO()
        {
            return new Route().GetType();
        }

        protected override DomainObject DoLoad()
        {
            DriverMapper dm = new DriverMapper();
            return new Route()
            {
                Id = (int)Reader["ID"],
                StartRoute = (DateTime)Reader["startRoute"],
                EndRoute = (DateTime)Reader["endRoute"],
                //Todo lazy load
                //Employee = (Employee)(dm.Load((int)Reader["Employee_ID"])),
                //Vehicle = vehicleMapper.Load((int)Reader["Vehicle_ID"]),
                //RouteNumber = routeNumberMapper.Load((int)Reader["RouteNumber_ID"])
            };
        }

        protected override DomainObject DoLoad(object id)
        {
            DriverMapper dm = new DriverMapper();
            VehicleMapper vehicleMapper = new VehicleMapper();
            RouteNumberMapper rm = new RouteNumberMapper();
            var a = new Route()
            {
                Id = (int)id,
                StartRoute = (DateTime)Reader["startRoute"],
                EndRoute = (DateTime)Reader["endRoute"],
                //Todo lazy load
                Driver = (Driver)(dm.Load((int)Reader["Employee_ID"])),
                Vehicle = (Vehicle)vehicleMapper.Load((int)Reader["Vehicle_ID"]),
                RouteNumber = (RouteNumber)rm.Load((int)Reader["RouteNumber_ID"])
            };
            return a;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [Route]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Route] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            Route item = (Route)domainObject;
            Command.CommandText = "INSERT INTO [Route] Values (@startRoute,@endRoute,@Employee_ID,@Vehicle_ID,@RouteNumber_ID)";
            Command.Parameters.AddWithValue("@startRoute", item.StartRoute);
            Command.Parameters.AddWithValue("@endRoute", item.EndRoute);
            Command.Parameters.AddWithValue("@Employee_ID", item.Driver.Id);
            Command.Parameters.AddWithValue("@Vehicle_ID", item.Vehicle.Id);
            Command.Parameters.AddWithValue("@RouteNumber_ID", item.RouteNumber.Id);

        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            Route item = (Route)domainObject;
            Command.CommandText = "DELETE FROM [Route] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            Route item = (Route)domainObject;
            Command.CommandText = "UPDATE [Route] SET startRoute=@startRoute, endRoute=@endRoute, Employee_ID=@Employee_ID, Vehicle_ID=@Vehicle_ID,RouteNumber_ID=@RouteNumber_ID WHERE ID=@ID";
            Command.Parameters.AddWithValue("@startRoute", item.StartRoute);
            Command.Parameters.AddWithValue("@endRoute", item.EndRoute);
            Command.Parameters.AddWithValue("@Employee_ID", item.Driver.Id);
            Command.Parameters.AddWithValue("@Vehicle_ID", item.Vehicle.Id);
            Command.Parameters.AddWithValue("@RouteNumber_ID", item.RouteNumber.Id);
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override string GetTableName()
        {
            return "Route";
        }
    }
}
