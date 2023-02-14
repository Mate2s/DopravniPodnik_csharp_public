using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.map;
using BusinessLayer.Mapper;

namespace BusinessLayer.ORM.DB
{
    public abstract class AbstractMapper : IMapper
    {
        protected static readonly string ConnectionString = BusinessLayer.Properties.Resources.connectionString;
        protected SqlCommand Command;
        protected SqlDataReader Reader;

        public List<DomainObject> LoadAll()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = LoadAllStatement();//"SELECT * FROM [Employee] WHERE employment like 'Administrator'";

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
                            return res;
                            //venku List<Administrator> listOfAdmin = listOfDomain.Cast<Admin>().ToList();
                        }
                    }
                }
            }

            return null;
        }
       /* public int GetIdentity(string tableName)
        {
            SqlCommand command = CreateCommand("SELECT IDENT_CURRENT(@tableName)");
            command.Parameters.AddWithValue("tableName", tableName);
            return Convert.ToInt32(command.ExecuteScalar());
        }*/
        public DomainObject Load(Object id)
        {
            DomainObject loaded = IdentifyMap.Instance.Find(GetTypeDO(), id);
            if (loaded != null)
                return loaded;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    SetComandLoad(id);

                    using (Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            Reader.Read();
                            DomainObject item = DoLoad(id);
                            if (IdentifyMap.Instance.Find(GetTypeDO(), item.GetId()) == null)
                            {
                                IdentifyMap.Instance.Add(GetTypeDO(), item);
                            }
                            else
                            {
                                item = IdentifyMap.Instance.Find(GetTypeDO(), item.GetId());
                            }
                            return item;
                        }
                    }
                }
            }
            return null;
        }

        protected abstract Type GetTypeDO();
        protected abstract string GetTableName();

        public void Insert(DomainObject item)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    SetCommandInsert(item);
                    Command.ExecuteNonQuery();
                }
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (Command = connection.CreateCommand())
                    {
                        Command.CommandType = CommandType.Text;
                        Command.CommandText = "SELECT IDENT_CURRENT(@tableName)";
                        Command.Parameters.AddWithValue("tableName", GetTableName());
                        item.SetId(Convert.ToInt32(Command.ExecuteScalar()));
                    }
                }
            }
            catch (Exception e)
            {
            }

        }

        public void Update(DomainObject item)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    SetCommandUpdate(item);
                    Command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(DomainObject item)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    SetComandDelete(item);
                    Command.ExecuteNonQuery();
                }
            }
        }


        protected abstract DomainObject DoLoad();
        protected abstract DomainObject DoLoad(object id);
        protected abstract String LoadAllStatement();
        protected abstract void SetComandLoad(Object id);
        protected abstract void SetCommandInsert(DomainObject domainObject);
        protected abstract void SetComandDelete(DomainObject domainObject);
        protected abstract void SetCommandUpdate(DomainObject domainObject);


    }
}
