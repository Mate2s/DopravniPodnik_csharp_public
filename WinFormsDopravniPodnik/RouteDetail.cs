using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDopravniPodnik.RouteService1;
using Station=WinFormsDopravniPodnik.model.Station;
using RouteNumberStation = WinFormsDopravniPodnik.model.RouteNumberStation;

namespace WinFormsDopravniPodnik
{
    public partial class RouteDetail : Form
    {
        private Form1 mainForm;

        public Form1 MainForm
        {
            get { return mainForm; }
            set { mainForm = value; }
        }

        public RouteDetail()
        {
            InitializeComponent();
        }
        public RouteDetail(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            ShowPassangerNumbers();
            ShowVehicleInfo();
            ShowRouteNumberInfo();
            ShowStation();
            ShowPassangers();
        }

        private void ShowPassangerNumbers()
        {
            try
            {
                labelPassangerNumber.Text = mainForm.route.CustomerJourneys.Count().ToString();
            }
            catch (Exception e)
            {
                labelPassangerNumber.Text = "0";
                Console.WriteLine(e);
            }
            
        }

        private void ShowVehicleInfo()
        {
            labelVehicleID.Text = mainForm.route.Vehicle.Id.ToString();
        }

        private void ShowRouteNumberInfo()
        {
            labelNumberRoute.Text = mainForm.route.RouteNumber.Number.ToString();
        }
        private void ShowStation()
        {
            labelStation.Text = mainForm.route.CurrentStation.Station.Name.ToString();
        }

        private void ShowPassangers()
        {
            try
            {
                dataGridViewPassanger.Rows.Clear();
                foreach (var passanger in mainForm.route.CustomerJourneys)
                {
                    dataGridViewPassanger.Rows.Add(passanger.Customer.Id.ToString(),passanger.Customer.Login,
                        passanger.Customer.Firstname + " " + passanger.Customer.Lastname, passanger.StartStation.Name,
                        passanger.EndStation.Name, passanger.StartDate.ToString());
                }
            }
            catch (Exception e)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void labelNumberRoute_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RouteDetail_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewPassanger_Click(object sender, EventArgs e)
        {
            NewPassanger np=new NewPassanger(this);
            np.ShowDialog();
            ShowPassangers();
            ShowPassangerNumbers();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            //registrace
        }

        private void buttonRouteEnd_Click(object sender, EventArgs e)
        {
            RouteServiceClient sc = new RouteServiceClient();
            sc.EndRoute(mainForm.route.Id);
            this.Close();
        }

        private void buttonNextStation_Click(object sender, EventArgs e)
        {
            if (mainForm.RouteDirection)
                foreach (var va in mainForm.route.RouteNumber.RouteNumberStationsDirectionTwo.OrderBy(x => x.Order).ToList())
                {
                    if (mainForm.route.CurrentStation.Order + 1 == va.Order )
                    {
                        mainForm.route.CurrentStation = va;
                        labelStation.Text = mainForm.route.CurrentStation.Station.Name.ToString();
                        return;
                    }
                }
            else
                foreach (var va in mainForm.route.RouteNumber.RouteNumberStationsDirectionOne.OrderBy(x => x.Order).ToList())
                {
                    if (mainForm.route.CurrentStation.Order + 1 == va.Order )
                    {
                        mainForm.route.CurrentStation = va;
                        labelStation.Text = mainForm.route.CurrentStation.Station.Name.ToString();
                        return;
                    }
                }
        }

        private void buttonStationBefore_Click(object sender, EventArgs e)
        {
            if (mainForm.RouteDirection)
                foreach (var va in mainForm.route.RouteNumber.RouteNumberStationsDirectionTwo.OrderBy(x => x.Order).ToList())
                {
                    if (mainForm.route.CurrentStation.Order - 1 == va.Order)
                    {
                        mainForm.route.CurrentStation = va;
                        labelStation.Text = mainForm.route.CurrentStation.Station.Name.ToString();
                        return;
                    }
                }
            else
                foreach (var va in mainForm.route.RouteNumber.RouteNumberStationsDirectionOne.OrderBy(x => x.Order).ToList())
                {
                    if (mainForm.route.CurrentStation.Order - 1 == va.Order )
                    {
                        mainForm.route.CurrentStation = va;
                        labelStation.Text = mainForm.route.CurrentStation.Station.Name.ToString();
                        return;
                    }
                }
            
        }
    }
}
