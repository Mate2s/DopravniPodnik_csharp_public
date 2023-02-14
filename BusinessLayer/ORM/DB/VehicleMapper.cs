using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.DB
{
    public class VehicleMapper : AbstractMapper,IVehicleMapper
    {
        protected override Type GetTypeDO()
        {
            return new Vehicle().GetType();
        }

        protected override DomainObject DoLoad()
        {
            Vehicle item = new Vehicle()
            {
                Id = (int)Reader["ID"],
                Name = (string)Reader["name"],
                Brand = (string)Reader["brand"],
                Spz = (string)Reader["spz"],
                Year = (int)Reader["year"],
                Capacity = (int)Reader["capacity"]
            };
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            Vehicle item = new Vehicle()
            {
                Id = (int)id,
                Name = (string)Reader["name"],
                Brand = (string)Reader["brand"],
                Spz = (string)Reader["spz"],
                Year = (int)Reader["year"],
                Capacity = (int)Reader["capacity"]
            };
            return item;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [Vehicle]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Vehicle] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            var item = (Vehicle)domainObject;
            Command.CommandText = "INSERT INTO [Vehicle] Values (@name,@brand,@spz,@year,@capacity)";
            Command.Parameters.AddWithValue("@name", item.Name);
            Command.Parameters.AddWithValue("@brand", item.Brand);
            Command.Parameters.AddWithValue("@spz", item.Spz);
            Command.Parameters.AddWithValue("@year", item.Year);
            Command.Parameters.AddWithValue("@capacity", item.Capacity);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            var item = (Vehicle)domainObject;
            Command.CommandText = "DELETE FROM [Vehicle] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            var item = (Vehicle)domainObject;
            Command.CommandText = "UPDATE [Vehicle] SET name=@name,brand=@brand,spz=@spz,year=@year,capacity=@capacity WHERE ID=@ID";
            Command.Parameters.AddWithValue("@name", item.Name);
            Command.Parameters.AddWithValue("@brand", item.Brand);
            Command.Parameters.AddWithValue("@spz", item.Spz);
            Command.Parameters.AddWithValue("@year", item.Year);
            Command.Parameters.AddWithValue("@capacity", item.Capacity);
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override string GetTableName()
        {
            return "Vehicle";
        }
    }
}
