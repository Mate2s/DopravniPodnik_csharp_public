using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDopravniPodnik.CustomerService1;
using Customer= WinFormsDopravniPodnik.model.Customer;
using CustomerJourney = WinFormsDopravniPodnik.model.CustomerJourney;
using Station = WinFormsDopravniPodnik.model.Station;
using Payment = WinFormsDopravniPodnik.model.Payment;


namespace WinFormsDopravniPodnik
{
    public partial class NewPassanger : Form
    {
        private RouteDetail _parrent;
        public NewPassanger(RouteDetail form)
        {
            InitializeComponent();
            _parrent = form;
            SetCustomerComboBox();
            SetStationComboBox();
        }
       
        private List<Customer> GetAllCustomer()
        {
            return Customer.GetAll();
        }

        private List<Station> getAllStation()
        {
            if (_parrent.MainForm.RouteDirection)
            {
                return _parrent.MainForm.route.RouteNumber.RouteNumberStationsDirectionTwo.Where(x=>x.Order> _parrent.MainForm.route.CurrentStation.Order).OrderBy(x => x.Order).Select(x=>x.Station).ToList();
            }
            else
            {
                return _parrent.MainForm.route.RouteNumber.RouteNumberStationsDirectionOne.Where(x => x.Order > _parrent.MainForm.route.CurrentStation.Order).OrderBy(x => x.Order).Select(x => x.Station).ToList();
            }
              
        }
        private void SetCustomerComboBox()
        {
            cBoxCustomer.DataSource = GetAllCustomer();
            cBoxCustomer.DisplayMember = "Login";
            cBoxCustomer.ValueMember = "Id";
        }

        private void SetStationComboBox()
        {
            cBoxStation.DataSource = getAllStation();
            cBoxStation.DisplayMember = "Name";
            cBoxStation.ValueMember = "Id";
        }

        private double calculateKm()
        {
            double km = 0;
            try
            {
                if (_parrent.MainForm.RouteDirection)
                {
                    foreach (var station in _parrent.MainForm.route.RouteNumber.RouteNumberStationsDirectionTwo
                        .Where(x => x.Order >= _parrent.MainForm.route.CurrentStation.Order)
                        .OrderBy(x => x.Order)
                        .Select(x => x).ToList())
                    {
                        km += station.KmToNextStation;
                        if (station.Station.Id == ((Station) cBoxStation.SelectedItem).Id)
                        {
                            break;
                        }
                    }
                }
                else
                {

                    foreach (var station in _parrent.MainForm.route.RouteNumber.RouteNumberStationsDirectionOne
                        .Where(x => x.Order >= _parrent.MainForm.route.CurrentStation.Order)
                        .OrderBy(x => x.Order)
                        .Select(x => x).ToList())
                    {
                        km += station.KmToNextStation;
                        if (station.Station.Id == ((Station) cBoxStation.SelectedItem).Id)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            return km;
        }

        private void buttonStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal calculateValue()
        {
            return (decimal)calculateKm() * 5;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                decimal value = calculateValue();
                Customer customer = (Customer)cBoxCustomer.SelectedItem;
                Payment.Paid(customer.Id, value);

                CustomerJourney cj = CustomerJourney.Add(_parrent.MainForm.route.Id, customer.Id,
                    _parrent.MainForm.route.CurrentStation.Station.Id, ((Station)cBoxStation.SelectedItem).Id);

                if (_parrent.MainForm.route.CustomerJourneys == null)
                {
                    _parrent.MainForm.route.CustomerJourneys = new List<CustomerJourney>();
                }
                _parrent.MainForm.route.CustomerJourneys.Add(cj);
            }
            catch (Exception ee)
            {
            }
            
            this.Close();
        }

        private void cBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxStation_Click(object sender, EventArgs e)
        {
            labelValue.Text = calculateValue().ToString() + "Kc";
        }
    }
}
