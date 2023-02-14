using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.map;
using BusinessLayer.pk;

namespace BusinessLayer.ORM.DB
{
    public class RouteNumberStationMapper : AbstractMapper,IRouteNumberStationMapper
    {
        protected override Type GetTypeDO()
        {
            return new RouteNumberStation().GetType();
        }

        protected override DomainObject DoLoad()
        {
            RouteNumberMapper rmm = new RouteNumberMapper();
            StationMapper sm = new StationMapper();
            RouteNumberStation item = new RouteNumberStation()
            {
                Order = (int)Reader["orderr"],
                Direction = (bool)Reader["direction"],
                RouteNumber = (RouteNumber)rmm.Load((int)Reader["RouteNumber_ID"]),
                Station = (Station)sm.Load((int)Reader["Station_ID"]),
                Desc = Reader["describe"].ToString(),
                KmToNextStation = (float)Reader["kmToNextStation"]

            };
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            var pk = (RouteNumberStationPK)id;
            RouteNumberMapper rmm = new RouteNumberMapper();
            StationMapper sm = new StationMapper();
            RouteNumberStation item = new RouteNumberStation()
            {
                Order = pk.Order,
                Direction = pk.Direction,
                RouteNumber = pk.RouteNumber,
                Station = pk.Station,
                Desc = Reader["describe"].ToString(),
                KmToNextStation = (float)Reader["kmToNextStation"]
            };
            return item;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [RouteNumberStation]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [RouteNumberStation] WHERE [RouteNumber_ID] = @RouteNumber_ID";
            Command.Parameters.AddWithValue("@RouteNumber_ID", ((RouteNumberStationPK)id).RouteNumber.Id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            var item = (RouteNumberStation)domainObject;
            Command.CommandText = "INSERT INTO [RouteNumberStation] Values (@direction,@RouteNumber_ID,Station_ID,@order,@desc,@kmToNextStation)";
            Command.Parameters.AddWithValue("@direction", item.Direction);
            Command.Parameters.AddWithValue("@order", item.Order);
            Command.Parameters.AddWithValue("@RouteNumber_ID", item.RouteNumber.Id);
            Command.Parameters.AddWithValue("@Station_ID", item.Station.Id);
            Command.Parameters.AddWithValue("@desc", item.Desc);
            Command.Parameters.AddWithValue("@kmToNextStation", item.KmToNextStation);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            var item = (RouteNumberStation)domainObject;
            Command.CommandText = "DELETE FROM [RouteNumberStation] WHERE RouteNumber_ID=@RouteNumber_ID";
            Command.Parameters.AddWithValue("@RouteNumber_ID", item.RouteNumber.Id);

        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            //update na nic :D
            var item = (RouteNumberStation)domainObject;
            Command.CommandText = "UPDATE [RouteNumberStation] SET  describe=@desc, kmToNextStation=@kmToNextStation, orderr=@order,RouteNumber_ID=@RouteNumber_ID,Station_ID=@Station_ID,direction=@direction WHERE RouteNumber_ID=@RouteNumber_ID AND Station_ID=@Station_ID AND order=@order AND direction=@direction";
            Command.Parameters.AddWithValue("@direction", item.Direction);
            Command.Parameters.AddWithValue("@order", item.Order);
            Command.Parameters.AddWithValue("@RouteNumber_ID", item.RouteNumber.Id);
            Command.Parameters.AddWithValue("@Station_ID", item.Station.Id);
            Command.Parameters.AddWithValue("@desc", item.Desc);
            Command.Parameters.AddWithValue("@kmToNextStation", item.KmToNextStation);
        }

        protected override string GetTableName()
        {
            return "RouteNumberStation";
        }

        public List<RouteNumberStation> LoadStationsByDirection(object id, bool direction)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    if(direction)
                        Command.CommandText = "SELECT * FROM [RouteNumberStation] WHERE [RouteNumber_ID] = @ID AND direction = 1";
                    else
                        Command.CommandText = "SELECT * FROM [RouteNumberStation] WHERE [RouteNumber_ID] = @ID AND direction = 0";
                    Command.Parameters.AddWithValue("@ID", (int)id);

                    using (Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {

                            List<DomainObject> res = new List<DomainObject>();
                            while (Reader.Read())
                            {
                                DomainObject item = DoLoad();
                                if (IdentifyMap.Instance.Find(GetTypeDO(), item.GetId()) == null)
                                {
                                    IdentifyMap.Instance.Add(GetTypeDO(), item);
                                }
                                else
                                {
                                    item = IdentifyMap.Instance.Find(GetTypeDO(), item.GetId());
                                }
                                res.Add(item);
                            }
                            return res.Cast<RouteNumberStation>().ToList();
                        }
                    }
                }
            }
            return null;
        }
    }
}
