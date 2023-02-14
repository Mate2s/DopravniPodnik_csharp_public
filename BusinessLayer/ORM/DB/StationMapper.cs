using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.DB
{
    public class StationMapper : AbstractMapper,IStationMapper
    {
        protected override Type GetTypeDO()
        {
            return new Station().GetType();
        }

        protected override DomainObject DoLoad()
        {
            Station item = new Station()
            {
                Id = (int)Reader["ID"],
                Name = (string)Reader["name"],
                Gpslat = (float)Reader["gpslat"],
                Gpslng = (float)Reader["gpslng"]
            };
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            Station item = new Station()
            {
                Id = (int)id,
                Name = (string)Reader["name"],
                Gpslat = (float)Reader["gpslat"],
                Gpslng = (float)Reader["gpslng"]
            };
            return item;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [Station]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Station] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);

        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            var item = (Station)domainObject;
            Command.CommandText = "INSERT INTO [Station] Values (@name,@gpslat,@gpslng)";
            Command.Parameters.AddWithValue("@name", item.Name);
            Command.Parameters.AddWithValue("@gpslat", item.Gpslat);
            Command.Parameters.AddWithValue("@gpslng", item.Gpslng);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            var item = (Station)domainObject;
            Command.CommandText = "DELETE FROM [Station] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            var item = (Station)domainObject;
            Command.CommandText = "UPDATE [Station] SET name=@name, gpslat=@gpslat,gpslng=@gpslng WHERE ID=@ID";
            Command.Parameters.AddWithValue("@name", item.Name);
            Command.Parameters.AddWithValue("@gpslat", item.Gpslat);
            Command.Parameters.AddWithValue("@gpslng", item.Gpslng);
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override string GetTableName()
        {
            return "Station";
        }
    }
}
