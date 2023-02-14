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

namespace WinFormsDopravniPodnik
{
    public partial class Form1 : Form
    {
        public Driver Driverlogged=null;
        private LoginForm log;
        private NewRoute routeForm;
        private RouteDetail routeDetail;
        public Vehicle VehicleOnRoad =null;
        public RouteNumber RouteNumberForRoad = null;
        public bool RouteDirection  = false;

        public Route route=null;
        public Form1()
        {
            InitializeComponent();
            log= new LoginForm(this);
            log.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonCreateRoute_Click(object sender, EventArgs e)
        {
            routeForm=new NewRoute(this);
            routeForm.ShowDialog();
            if (route != null)
            {
                routeDetail = new RouteDetail(this);
                routeDetail.ShowDialog();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Driverlogged = null;
            log = new LoginForm(this);
            log.ShowDialog();
        }
    }
}
