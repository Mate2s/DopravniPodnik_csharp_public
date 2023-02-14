using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.Enums;
using BusinessLayer.ORM;
using BusinessLayer.ORM.DB;
using BusinessLayer.ORM.XML;

namespace BusinessLayer.Mapper
{
    public class Mapper
    {
        private static Mapper instance;
        private ERepository repositoryType = ERepository.Database;

        public static Mapper Instance
        {
            get { return instance ?? (instance = new Mapper()); }
        }

        public void SetDB()
        {
            repositoryType = ERepository.Database;
        }

        public void setXml()
        {
            repositoryType = ERepository.Xml;
        }

        public IMapper GetMapper(DomainObject domainObject)
        {
            if (repositoryType == ERepository.Database)
            {
                if (domainObject is Administrator)
                    return new AdministratorMapper();
                if (domainObject is Driver)
                    return new DriverMapper();
                if (domainObject is Coupon)
                    return new CouponMapper();
                if (domainObject is Customer)
                    return new CustomerMapper();
                if (domainObject is CustomerJourney)
                    return new CustomerJourneyMapper();
                if (domainObject is Payment)
                    return new PaymentMapper();
                if (domainObject is Route)
                    return new RouteMapper();
                if (domainObject is RouteNumber)
                    return new RouteNumberMapper();
                if (domainObject is RouteNumberStation)
                    return new RouteNumberStationMapper();
                if (domainObject is Station)
                    return new StationMapper();
                if (domainObject is Vehicle)
                    return new VehicleMapper();
            }
            if (repositoryType == ERepository.Xml)
            {
                if (domainObject is Administrator)
                    return new AdministratorXmlMapper<Administrator>();
                if (domainObject is Driver)
                    return new DriverMapper();
                if (domainObject is Coupon)
                    return new CouponXmlMapper<Coupon>();
                if (domainObject is Customer)
                    return new CustomerXmlMapper<Customer>();
                if (domainObject is CustomerJourney)
                    return new CustomerJourneyXmlMapper<CustomerJourney>();
                if (domainObject is Payment)
                    return new PaymentXmlMapper<Payment>();
                if (domainObject is Route)
                    return new RouteXmlMapper<Route>();
                if (domainObject is RouteNumber)
                    return new RouteNumberXmlMapper<RouteNumber>();
                if (domainObject is RouteNumberStation)
                    return new RouteNumberStationXmlMapper<RouteNumberStation>();
                if (domainObject is Station)
                    return new StationXmlMapper<Station>();
                if (domainObject is Vehicle)
                    return new VehicleXmlMapper<Vehicle>();
            }
            return null;
        }
    }
}
