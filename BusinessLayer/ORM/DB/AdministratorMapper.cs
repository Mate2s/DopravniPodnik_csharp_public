using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.DB
{
    public class AdministratorMapper : AbstractMapper,IAdministratorMapper
    {
        protected override DomainObject DoLoad()
        {
            //if Id = (int)Reader["ID"] is in map ->item=loadfrommap(id,admin) else ...
            DomainObject item = new Administrator()
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
            return item;
        }

        protected override DomainObject DoLoad(object id)
        {
            return new Administrator()
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
            return "SELECT * FROM [Employee] WHERE employment like 'Administrator'";
        }

        protected override void SetComandLoad(object id)
        {
            Command.CommandText = "SELECT * FROM [Employee] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", (int)id);
        }

        protected override void SetCommandInsert(DomainObject domainObject)
        {
            Administrator item = (Administrator)domainObject;
            Command.CommandText = "INSERT INTO [Employee] Values (@Login,@Password,@Firstname,@Lastname,@City,@Adress,@Email,@Employment)";
            Command.Parameters.AddWithValue("@Password", item.Password);
            Command.Parameters.AddWithValue("@Login", item.Login);
            Command.Parameters.AddWithValue("@Firstname", item.Firstname);
            Command.Parameters.AddWithValue("@Lastname", item.Lastname);
            Command.Parameters.AddWithValue("@City", item.City);
            Command.Parameters.AddWithValue("@Adress", item.Adress);
            Command.Parameters.AddWithValue("@Email", item.Email);
            Command.Parameters.AddWithValue("@Employment", "Administrator");
        }

        protected override void SetCommandUpdate(DomainObject domainObject)
        {
            Administrator item = (Administrator)domainObject;
            Command.CommandText = "UPDATE [Employee] SET login=@Login,firstname=@Firstname,lastname=@Lastname,city=@City,adress=@Adress,email=@Email WHERE ID=@ID";
            // Command.Parameters.AddWithValue("@Password", item.Password);
            Command.Parameters.AddWithValue("@Login", item.Login);
            Command.Parameters.AddWithValue("@Firstname", item.Firstname);
            Command.Parameters.AddWithValue("@Lastname", item.Lastname);
            Command.Parameters.AddWithValue("@City", item.City);
            Command.Parameters.AddWithValue("@Adress", item.Adress);
            Command.Parameters.AddWithValue("@Email", item.Email);
            //  Command.Parameters.AddWithValue("@Employment", item.Employment);
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override void SetComandDelete(DomainObject domainObject)
        {
            Administrator item = (Administrator)domainObject;
            Command.CommandText = "DELETE FROM [Employee] WHERE [ID] = @ID";
            Command.Parameters.AddWithValue("@ID", item.Id);
        }

        protected override Type GetTypeDO()
        {
            return new Administrator().GetType();
        }

        protected override string GetTableName()
        {
            return "Employee";
        }
    }
}
