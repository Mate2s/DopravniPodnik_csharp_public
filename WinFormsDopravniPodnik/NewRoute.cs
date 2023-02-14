using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDopravniPodnik.model;
using WinFormsDopravniPodnik.RouteNumberService1;
using WinFormsDopravniPodnik.RouteService1;
using WinFormsDopravniPodnik.VehicleService1;
using Vehicle = WinFormsDopravniPodnik.model.Vehicle;
using RouteNumber = WinFormsDopravniPodnik.model.RouteNumber;
using Route = WinFormsDopravniPodnik.model.Route;


namespace WinFormsDopravniPodnik
{
    public partial class NewRoute : Form
    {
        private Form1 mainForm;
        RouteNumberServiceClient sc = new RouteNumberServiceClient();
        public NewRoute()
        {
            InitializeComponent();
        }

        public NewRoute(Form1 form1)
        {
            
            InitializeComponent();
            this.mainForm = form1;
            SetVehicleComboBox();
            SetRouteNumberComboBox();

        }

        private List<Vehicle> getAllVehicle()
        {
            return Vehicle.GetAll();
        }
        private List<RouteNumber> getAllRouteNumbers()
        {
            return RouteNumber.GetAll();
        }

        private void SetVehicleComboBox()
        {
            cBoxVehicle.DataSource=getAllVehicle();
            cBoxVehicle.DisplayMember = "Name";
            cBoxVehicle.ValueMember = "Id";
        }

        private void SetRouteNumberComboBox()
        {
            cBoxRouteNumber.DataSource = getAllRouteNumbers();
            cBoxRouteNumber.DisplayMember = "Number";
            cBoxRouteNumber.ValueMember = "Id";
        }

        private void SetDirectionComboBox()
        {
            

            List<Direction> directionList = new List<Direction>();

            directionList.Add(new Direction()
            {
                Name =
                    String.Format("{0} - {1}",
                        ((mainForm.RouteNumberForRoad.RouteNumberStationsDirectionTwo.OrderBy(x => x.Order)).First
                            ().Station.Name),
                        ((mainForm.RouteNumberForRoad.RouteNumberStationsDirectionTwo.OrderBy(x => x.Order)).Last()
                            .Station.Name)),
                direction = true
            });
            directionList.Add(new Direction()
            {
                Name =
                    String.Format("{0} - {1}",
                        ((mainForm.RouteNumberForRoad.RouteNumberStationsDirectionOne.OrderBy(x => x.Order)).First
                            ().Station.Name),
                        ((mainForm.RouteNumberForRoad.RouteNumberStationsDirectionOne.OrderBy(x => x.Order)).Last()
                            .Station.Name)),
                direction = false
            });
            comboBoxDirection.DataSource = directionList;
            comboBoxDirection.DisplayMember = "Name";
            comboBoxDirection.ValueMember = "direction";
        }

        private void vehicleChange()
        {
            mainForm.VehicleOnRoad = (Vehicle)cBoxVehicle.SelectedItem;
        }

        private void RouteNumberChange()
        {
            vehicleChange();
            mainForm.RouteNumberForRoad = (RouteNumber)cBoxRouteNumber.SelectedItem;
            if (mainForm.VehicleOnRoad != null)
            {
                SetDirectionComboBox();
            }
        }

        private void DirectionChange()
        {
            mainForm.RouteDirection = ((Direction)comboBoxDirection.SelectedItem).direction;
        }
        private void cBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBoxRouteNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        public class Direction 
        {
           public string Name { get; set; }
            public bool direction { get; set; }
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCreateRoute_Click(object sender, EventArgs e)
        {
            RouteServiceClient sc = new RouteServiceClient();
            if (mainForm.VehicleOnRoad != null && mainForm.Driverlogged != null && mainForm.RouteNumberForRoad != null)
            {
                mainForm.route = Route.CastTo(sc.CreateRoute(mainForm.VehicleOnRoad.Id, mainForm.Driverlogged.Id,
                mainForm.RouteNumberForRoad.Id));
                DirectionChange();
                if (mainForm.RouteDirection)
                    mainForm.route.CurrentStation =mainForm.route.RouteNumber.RouteNumberStationsDirectionTwo.OrderBy(x => x.Order)
                            .FirstOrDefault();
                else
                    mainForm.route.CurrentStation = mainForm.route.RouteNumber.RouteNumberStationsDirectionOne.OrderBy(x => x.Order)
                               .FirstOrDefault();

                this.Close();
            }
            
        }

        private void cBoxRouteNumber_Click(object sender, EventArgs e)
        {
            RouteNumberChange();
        }
    }
}
