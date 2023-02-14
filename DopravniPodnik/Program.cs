using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.Mapper;

namespace DopravniPodnik
{
    class Program
    {
        static void Main(string[] args)
        {

            Mapper.Instance.setXml();
            Station st=new Station()
            {
                Gpslat = (float)49.7828,
                Gpslng = (float)18.2561,
                Id = 100,
                Name = "josefa kotase"
            };
            st.DoNew();

            Station stt = new Station()
            {
                Gpslat = (float)49.7828,
                Gpslng = (float)18.2561,
                Id = 100,
                Name = "Dubina"
            };
            stt.DoNew();

            Customer c= new Customer()
            {
                Adress = "adressa",
                BirthDate = DateTime.Now,
                City = "ostrava",
                Id = 100,
                Password = "asd",
                Firstname = "ja",
                Email = "emaillllllll@seznam.cz",
                Lastname = "prijmeni",
                Login = "kot0177",
            };
            c.DoNew();

           
            CustomerJourney cj = new CustomerJourney()
            {
                Comment = "asdasd",
                Customer = c,
                StartStation = st,
                EndStation = stt,
                StartDate = DateTime.Now,
                ExitDate = DateTime.Now,
                Route = new Route()
                {
                    Id = 100,
                    StartRoute = DateTime.Now,
                    EndRoute = DateTime.Now
                }
            };
            cj.DoNew();
        }
    }
}
