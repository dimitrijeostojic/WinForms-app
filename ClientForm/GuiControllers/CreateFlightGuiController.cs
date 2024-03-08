using ClientForm.UserControls;
using Common;
using Common.Domain;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    public class CreateFlightGuiController
    {

        private UCCreateFlight createFlight;
        private User user;

        #region singleton
        private static CreateFlightGuiController instance;
        public static CreateFlightGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateFlightGuiController();
                }
                return instance;
            }
        }
        private CreateFlightGuiController()
        {

        }
        #endregion

        public Control CreateCreateFlight(User user)
        {
            createFlight = new UCCreateFlight();
            SetControlSettings(user);
            createFlight.BtnCreateFlight.Click += CreateFlight;
            createFlight.TboxTicketPrice.TextChanged += ChangeTicketPrice;
            return createFlight;
        }
        private void CreateFlight(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Flight flight = new Flight()
                {
                    DepartureAirportID = (Airport)createFlight.CboxDepartureAirport.SelectedItem,
                    ArrivalAirportID = (Airport)createFlight.CboxArrivalAirport.SelectedItem,
                    DepartureDate = createFlight.DtDepartureDate.Value.ToShortDateString(),
                    ArrivalDate = createFlight.DtArrivalDate.Value.ToShortDateString(),
                    ArrivalTime = createFlight.DtArrivalTime.Value.ToShortTimeString(),
                    DepartureTime = createFlight.DtDepartureTime.Value.ToShortTimeString(),
                    Plane = (Plane)createFlight.CboxPlane.SelectedItem,
                    TicketPrice = double.Parse(createFlight.TboxTicketPrice.Text),
                    CreatedBy = user.JMBG
                };
                Response res = Communication.Instance.CreateFlight(flight);
                if (res.Exception == null)
                {
                    MessageBox.Show("Sistem je zapamtio avio let");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sistem ne može da zapamti avio let");
                }
            }
        }
        private void SetControlSettings(User user)
        {
            this.user = user;
            createFlight.DtDepartureTime.ShowUpDown = true;
            createFlight.DtArrivalTime.ShowUpDown = true;
            createFlight.CboxPlane.DataSource = Communication.Instance.GetAllPlanes();
            createFlight.CboxDepartureAirport.DataSource = Communication.Instance.GetAllAirports();
            createFlight.CboxArrivalAirport.DataSource = Communication.Instance.GetAllAirports();
        }
        private void ChangeTicketPrice(object sender, EventArgs e)
        {
            createFlight.TboxTicketPrice.FillColor = Color.White;
        }
        private bool IsValid()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(createFlight.TboxTicketPrice.Text))
            {
                createFlight.TboxTicketPrice.FillColor = Color.Salmon;
                MessageBox.Show("Morate uneti cenu karte");

                flag = false;
            }
            for (int i = 0; i < createFlight.TboxTicketPrice.Text.Length; i++)
            {
                if (createFlight.TboxTicketPrice.Text[i] < '0' || createFlight.TboxTicketPrice.Text[i] > '9')
                {

                    createFlight.TboxTicketPrice.FillColor = Color.Salmon;
                    flag = false;
                    MessageBox.Show("Pogresan format cene");
                    break;
                }
            }
            int rezultat = DateTime.Compare(createFlight.DtDepartureDate.Value, createFlight.DtArrivalDate.Value);
            if (rezultat > 0)
            {
                MessageBox.Show("Datum polaska mora biti raniji ili isti kao i datum dolaska");
                flag = false;
            }
            if (createFlight.CboxArrivalAirport.SelectedIndex == createFlight.CboxDepartureAirport.SelectedIndex)
            {
                MessageBox.Show("Mesto polaska i mesto dolaska moraju biti razliciti");
                MessageBox.Show("Sistem ne može da zapamti avio let");
                flag = false;
            }
            return flag;
        }
        private void Clear()
        {
            createFlight.CboxArrivalAirport.SelectedIndex = 0;
            createFlight.CboxDepartureAirport.SelectedIndex = 0;
            createFlight.CboxPlane.SelectedIndex = 0;
            createFlight.TboxTicketPrice.Text = "";
        }

    }
}
