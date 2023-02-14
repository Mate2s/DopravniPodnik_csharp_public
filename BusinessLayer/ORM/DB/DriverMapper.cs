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
    public class DriverMapper : AbstractMapper,IDriverMapper
    {
        protected override Type GetTypeDO()
        {
            return new Driver().GetType();
        }

        protected override DomainObject DoLoad()
        {
            return new Driver()
            {
                Id = (int)Reader["ID"],
                Password = Reader["password"].ToString(),
                Login = (string)Reader["login"],
                Firstname = (string)Reader["firstname"],
                Lastname = (string)Reader["lastname"],
                Birthdate = (DateTime)Reader["birthDate"],
                City = (string)Reader["city"],
                Adress = (string)Reader["adress"],
                Email = (string)Reader["email"],
                //Employment = (string)reader["employment"]
            };
        }

        protected override DomainObject DoLoad(object id)
        {
            return new Driver()
            {
                Id = (int)id,
                Password = Reader["password"].ToString(),
                Login = (string)Reader["login"],
                Firstname = (string)Reader["firstname"],
                Lastname = (string)Reader["lastname"],
                Birthdate = (DateTime)Reader["birthDate"],
                City = (string)Reader["city"],
                Adress = (string)Reader["adress"],
                Email = (string)Reader["email"],
                //Employment = (string)reader["employment"]
            };
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [Employee] WHERE employment like 'Driver'";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Employee] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            Driver item = (Driver)domainObject;
            Command.CommandText = "INSERT INTO [Employee] Values (@Login,@Password,@Firstname,@Lastname,@City,@Adress,@Email,@Employment)";
            Command.Parameters.AddWithValue("@Password", item.Password);
            Command.Parameters.AddWithValue("@Login", item.Login);
            Command.Parameters.AddWithValue("@Firstname", item.Firstname);
            Command.Parameters.AddWithValue("@Lastname", item.Lastname);
            Command.Parameters.AddWithValue("@City", item.City);
            Command.Parameters.AddWithValue("@Adress", item.Adress);
            Command.Parameters.AddWithValue("@Email", item.Email);
            Command.Parameters.AddWithValue("@Employment", "Driver");

        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            Driver item = (Driver)domainObject;
            Command.CommandText = "DELETE FROM [Employee] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            Driver item = (Driver)domainObject;
            Command.CommandText = "UPDATE [Employee] SET login=@Login,firstname=@Firstname,lastname=@Lastname,city=@City,adress=@Adress,email=@Email WHERE ID=@ID";
            // command.Parameters.AddWithValue("@Password", item.Password);
            Command.Parameters.AddWithValue("@Login", item.Login);
            Command.Parameters.AddWithValue("@Firstname", item.Firstname);
            Command.Parameters.AddWithValue("@Lastname", item.Lastname);
            Command.Parameters.AddWithValue("@City", item.City);
            Command.Parameters.AddWithValue("@Adress", item.Adress);
            Command.Parameters.AddWithValue("@Email", item.Email);
            //  command.Parameters.AddWithValue("@Employment", item.Employment);
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        public Driver LoadByLogin(string login)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = "SELECT * FROM [Employee] WHERE [login] = @login";
                    Command.Parameters.AddWithValue("@login", login);

                    using (Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            Reader.Read();
                            Driver item= new Driver()
                            {
                                Id = (int)Reader["ID"],
                                Password = Reader["password"].ToString(),
                                Login = (string)Reader["login"],
                                Firstname = (string)Reader["firstname"],
                                Lastname = (string)Reader["lastname"],
                                Birthdate = (DateTime)Reader["birthDate"],
                                City = (string)Reader["city"],
                                Adress = (string)Reader["adress"],
                                Email = (string)Reader["email"],
                                
                            };
                            if (IdentifyMap.Instance.Find(GetTypeDO(), item.GetId()) == null)
                            {
                                IdentifyMap.Instance.Add(GetTypeDO(), item);
                            }
                            return item;
                        }
                    }
                }
            }
            return null;
        }

        protected override string GetTableName()
        {
            return "Employee";
        }
    }
}
