using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class FrmDetailsFlight : Form
    {
        public FrmDetailsFlight(Flight flight)
        {
            InitializeComponent();
            tboxDepartureAirport.Text = flight.DepartureAirportID.AirportName;
            tboxArrivalAirport.Text = flight.ArrivalAirportID.AirportName;
            tboxDepartureDate.Text = flight.DepartureDate;
            tboxArrivalDate.Text = flight.ArrivalDate;
            tboxPlane.Text = flight.Plane.PlaneName;
            tboxDepartureTime.Text = flight.DepartureTime;
        }
    }
}
