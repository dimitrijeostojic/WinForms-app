using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.UserControls
{
    public partial class UCCreateFlight : UserControl
    {
        public UCCreateFlight()
        {
            InitializeComponent();
            DtDepartureTime.ShowUpDown = true;
            DtArrivalTime.ShowUpDown = true;
            CboxPlane.DataSource = Communication.Instance.GetAllPlanes();
            CboxDepartureAirport.DataSource = Communication.Instance.GetAllAirports();
            CboxArrivalAirport.DataSource = Communication.Instance.GetAllAirports();
        }
    }
}
