using ClientForm.UserControls;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    public class ChangeFlightGuiController
    {
        #region singleton
        private static ChangeFlightGuiController instance;
        public static ChangeFlightGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChangeFlightGuiController();
                }
                return instance;
            }
        }

        private ChangeFlightGuiController()
        {

        }
        #endregion

        private UCChangeFlight changeFlight;
        private User user;
        public BindingList<Flight> Flights { get; set; }
        public Flight Flight { get; set; }

        public Control CreateChangeFlight(User user)
        {
            changeFlight = new UCChangeFlight();
            SetControlSettings(user);
            changeFlight.BtnUpdate.Click += ChangeFlight;
            changeFlight.BtnSelect.Click += SelectFlight;
            changeFlight.TboxTicketPrice.TextChanged += ChangeTicketPrice;
            changeFlight.TboxFrom.TextChanged += ChangeTextFrom;
            changeFlight.TboxTo.TextChanged += ChangeTextTo;
            return changeFlight;
        }

        private void SetControlSettings(User user)
        {
            Flight = null;
            this.user = user;
            changeFlight.DgvFlights.MultiSelect = false;
            changeFlight.DtDepartureTime.ShowUpDown = true;
            changeFlight.DtArrivalTime.ShowUpDown = true;
            BindingList<Flight> flights = new BindingList<Flight>(Communication.Instance.GetMyFlights(user));
            this.Flights = flights;
            changeFlight.DgvFlights.DataSource = flights;
            changeFlight.DgvFlights.Columns[0].Visible = false;
            for (int i = 10; i <= 18; i++)
            {
                changeFlight.DgvFlights.Columns[i].Visible = false;
            }
            changeFlight.CboxPlane.DataSource = Communication.Instance.GetAllPlanes();
            changeFlight.CboxDepartureAirport.DataSource = Communication.Instance.GetAllAirports();
            changeFlight.CboxArrivalAirport.DataSource = Communication.Instance.GetAllAirports();
        }

        private void ChangeTextTo(object sender, EventArgs e)
        {
            string to = changeFlight.TboxTo.Text;
            Response response = Communication.Instance.Search(to, user, "To");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            changeFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void ChangeTextFrom(object sender, EventArgs e)
        {
            string from = changeFlight.TboxFrom.Text;
            Response response = Communication.Instance.Search(from, user, "From");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            changeFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void ChangeTicketPrice(object sender, EventArgs e)
        {
            changeFlight.TboxTicketPrice.FillColor = Color.White;
        }

        private void SelectFlight(object sender, EventArgs e)
        {
            if (changeFlight.DgvFlights.SelectedRows.Count > 0)
            {
                Flight f = (Flight)changeFlight.DgvFlights.SelectedRows[0].DataBoundItem;
                Response response = Communication.Instance.FindFlightById(f.FlightID);
                Flight = ((Flight)response.Result);
                changeFlight.CboxArrivalAirport.SelectedIndex = Flight.ArrivalAirportID.AirportID - 1;
                changeFlight.CboxDepartureAirport.SelectedIndex = Flight.DepartureAirportID.AirportID - 1;
                changeFlight.CboxPlane.SelectedIndex = Flight.Plane.PlaneID - 1;
                changeFlight.TboxTicketPrice.Text = Flight.TicketPrice.ToString();
                DateTime selectedDepartureDate = DateTime.Parse(Flight.DepartureDate);
                changeFlight.DtDepartureDate.Value = selectedDepartureDate;
                DateTime selectedArrivalDate = DateTime.Parse(Flight.ArrivalDate);
                changeFlight.DtArrivalDate.Value = selectedArrivalDate;
                DateTime selectedDepartureTime = DateTime.Parse(Flight.DepartureTime);
                changeFlight.DtDepartureTime.Value = selectedDepartureTime;
                DateTime selectedArrivalTime = DateTime.Parse(Flight.ArrivalTime);
                changeFlight.DtArrivalTime.Value = selectedArrivalTime;
                MessageBox.Show("Sistem je ucitao avio let po zadatoj vrednosti");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da ucita avio let po zadatoj vrednosti");
            }
        }

        private void ChangeFlight(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Flight flight = new Flight
                {
                    DepartureDate = changeFlight.DtDepartureDate.Value.ToShortDateString(),
                    ArrivalDate = changeFlight.DtArrivalDate.Value.ToShortDateString(),
                    ArrivalTime = changeFlight.DtArrivalTime.Value.ToShortTimeString(),
                    DepartureTime = changeFlight.DtDepartureTime.Value.ToShortTimeString(),
                    CreatedBy = Flight.CreatedBy,
                    FlightID = Flight.FlightID,
                    TicketPrice = double.Parse(changeFlight.TboxTicketPrice.Text),
                    ArrivalAirportID = (Airport)changeFlight.CboxArrivalAirport.SelectedItem,
                    DepartureAirportID = (Airport)changeFlight.CboxDepartureAirport.SelectedItem,
                    Plane = (Plane)changeFlight.CboxPlane.SelectedItem
                };
                DialogResult result = MessageBox.Show("Jeste li sigurni da zelite da izmenite izabrnai let", "Izmena leta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Response res = Communication.Instance.UpdateFlight(flight);
                    if (res.Exception == null)
                    {
                        MessageBox.Show("Sistem je izmenio izabrani let");
                        changeFlight.DgvFlights.DataSource = new BindingList<Flight>(Communication.Instance.GetMyFlights(user));
                        Flight = null;
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da izmeni izabrani let");
                    }
                }
            }

        }

        private bool IsValid()
        {
            bool flag = true;
            if (Flight == null)
            {
                MessageBox.Show("Sistem ne moze da izmeni izabrani let");
                flag = false;
                return flag;
            }
            if (string.IsNullOrEmpty(changeFlight.TboxTicketPrice.Text))
            {
                changeFlight.TboxTicketPrice.FillColor = Color.Salmon;
                flag = false;
                MessageBox.Show("Morate uneti cenu karte");
            }
            for (int i = 0; i < changeFlight.TboxTicketPrice.Text.Length; i++)
            {
                if (changeFlight.TboxTicketPrice.Text[i] < '0' || changeFlight.TboxTicketPrice.Text[i] > '9')
                {

                    changeFlight.TboxTicketPrice.FillColor = Color.Salmon;
                    flag = false;
                    MessageBox.Show("Pogresan format cene");
                    break;
                }
            }
            int rezultat = DateTime.Compare(changeFlight.DtDepartureDate.Value, changeFlight.DtArrivalDate.Value);
            if (rezultat > 0)
            {
                MessageBox.Show("Datum polaska mora biti raniji ili isti kao i datum dolaska");
                flag = false;
            }
            if (changeFlight.CboxArrivalAirport.SelectedIndex == changeFlight.CboxDepartureAirport.SelectedIndex)
            {
                MessageBox.Show("Mesto polaska i mesto dolaska moraju biti razliciti");
                flag = false;
            }
            return flag;
        }

    }
}
