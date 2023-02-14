using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using System.Data.SqlClient;
using System.Data;
using BusinessLayer.map;

namespace BusinessLayer.ORM.DB
{
    public class CustomerMapper : AbstractMapper,ICustomerMapper
    {
        protected override Type GetTypeDO()
        {
            return new Customer().GetType();
        }

        protected override DomainObject DoLoad()
        {
            var a = new Customer()
            {
                Id = (int)Reader["ID"],
                Password = Reader["password"].ToString(),
                Login = (string)Reader["login"],
                Firstname = (string)Reader["firstname"],
                Lastname = (string)Reader["lastname"],
                BirthDate = (DateTime)Reader["birthDate"],
                City = (string)Reader["city"],
                Adress = (string)Reader["adress"],
                Email = (string)Reader["email"]
            };
            return a;
        }

        protected override DomainObject DoLoad(object id)
        {
            var a = new Customer()
            {
                Id = (int)id,
                Password = Reader["password"].ToString(),
                Login = (string)Reader["login"],
                Firstname = (string)Reader["firstname"],
                Lastname = (string)Reader["lastname"],
                BirthDate = (DateTime)Reader["birthDate"],
                City = (string)Reader["city"],
                Adress = (string)Reader["adress"],
                Email = (string)Reader["email"]
            };
            return a;
        }

        protected override string LoadAllStatement()
        {
            return "SELECT * FROM [Customer]";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Customer] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            Customer item = (Customer)domainObject;
            Command.CommandText = "INSERT INTO [Customer] Values (@login,@passwod,@firstname,@lastname,@birthDate,@city,@adress,@email)";
            Command.Parameters.AddWithValue("@passwod", item.Password);
            Command.Parameters.AddWithValue("@login", item.Login);
            Command.Parameters.AddWithValue("@firstname", item.Firstname);
            Command.Parameters.AddWithValue("@lastname", item.Lastname);
            Command.Parameters.AddWithValue("@birthDate", item.BirthDate);
            Command.Parameters.AddWithValue("@city", item.City);
            Command.Parameters.AddWithValue("@adress", item.Adress);
            Command.Parameters.AddWithValue("@email", item.Email);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            Customer item = (Customer)domainObject;
            Command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            Customer item = (Customer)domainObject;
            Command.CommandText = "UPDATE [Customer] SET login=@login, firstname=@firstname, lastname=@lastname, birthDate=@birthDate, city=@city, adress=@adress, email=@email WHERE ID= @id";
            //  command.Parameters.AddWithValue("@passwod", item.Password);
            Command.Parameters.AddWithValue("@login", item.Login);
            Command.Parameters.AddWithValue("@firstname", item.Firstname);
            Command.Parameters.AddWithValue("@lastname", item.Lastname);
            Command.Parameters.AddWithValue("@birthDate", item.BirthDate);
            Command.Parameters.AddWithValue("@city", item.City);
            Command.Parameters.AddWithValue("@adress", item.Adress);
            Command.Parameters.AddWithValue("@email", item.Email);
            Command.Parameters.AddWithValue("@id", item.Id);
        }

        public Customer LoadByLogin(string login)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (Command = connection.CreateCommand())
                {
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = "SELECT * FROM [Customer] WHERE [login] = @login";
                    Command.Parameters.AddWithValue("@login", login);

                    using (Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            Reader.Read();
                            Customer item = new Customer()
                            {
                                Id = (int)Reader["ID"],
                                Password = Reader["password"].ToString(),
                                Login = (string)Reader["login"],
                                Firstname = (string)Reader["firstname"],
                                Lastname = (string)Reader["lastname"],
                                BirthDate = (DateTime)Reader["birthDate"],
                                City = (string)Reader["city"],
                                Adress = (string)Reader["adress"],
                                Email = (string)Reader["email"],

                            };
                            if (IdentifyMap.Instance.Find(GetTypeDO(), item.GetId()) == null)
                            {
                                IdentifyMap.Instance.Add(GetTypeDO(), item);
                            }
                            else
                            {
                                item = (Customer)IdentifyMap.Instance.Find(GetTypeDO(), item.GetId());
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
            return "Customer";
        }
    }
}
