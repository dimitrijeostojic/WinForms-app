using ClientForm.UserControls;
using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    public class ReserveFlightGuiController
    {
        #region singleton
        private static ReserveFlightGuiController instance;
        public static ReserveFlightGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReserveFlightGuiController();
                }
                return instance;
            }
        }
        private ReserveFlightGuiController()
        {

        }
        #endregion
        private UCReserveFlight reserveFlight;
        private User User { get; set; }
        BindingList<Reservation> reservations;
        public Flight Flight { get; set; }

        internal Control CreateReserveFlighth(User user)
        {
            reserveFlight = new UCReserveFlight();
            SetControlSettings(user);
            reserveFlight.TboxFrom.TextChanged += ChangeTextFrom;
            reserveFlight.TboxTo.TextChanged += ChangeTextTo;
            reserveFlight.BtnAddReservation.Click += AddReservation;
            reserveFlight.BtnSaveAllReservations.Click += SaveReservations;
            return reserveFlight;
        }

        private void SaveReservations(object sender, EventArgs e)
        {
            if (reservations.Count == 0)
            {
                MessageBox.Show("Morate da izaberete letove");
                return;
            }

            List<Reservation> SelectedReservations = new List<Reservation>();
            foreach (DataGridViewRow row in reserveFlight.DgvReservations.Rows)
            {
                // Kreiranje novog objekta Reservation za svaki red
                Reservation reservation = new Reservation
                {
                    Flight_id = new Flight()
                    {
                        FlightID = Convert.ToInt32(row.Cells["Flight_id"].Value.ToString()) // Pristupamo FlightID svojstvu i pretvaramo u string
                    },
                    Jmbg = new User()
                    {
                        JMBG = ((User)row.Cells["Jmbg"].Value).JMBG // Pristupamo JMBG svojstvu objekta User
                    },
                    NumOfSeats = Convert.ToInt32(row.Cells["NumOfSeats"].Value)
                };

                // Dodavanje objekta Reservation u listu rezervacija
                SelectedReservations.Add(reservation);
            }
            Response response = Communication.Instance.SaveAllReservations(SelectedReservations);
            if (response.Exception == null)
            {
                MessageBox.Show("Sistem vam je rezervisao izabrane letove");
                reservations = new BindingList<Reservation>();
                reserveFlight.DgvReservations.DataSource = reservations;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da vam rezervise izabrane letove");
                reservations = new BindingList<Reservation>();
                reserveFlight.DgvReservations.DataSource = reservations;
            }
        }

        private void AddReservation(object sender, EventArgs e)
        {

            if (IsValid())
            {
                if (reserveFlight.DgvFlights.SelectedRows.Count > 0)
                {
                    Flight = (Flight)reserveFlight.DgvFlights.SelectedRows[0].DataBoundItem;
                    Response response = Communication.Instance.FindFlightById(Flight.FlightID);
                    MessageBox.Show("Sistem je ucitao let po zadatoj vrednosti");

                    Reservation reservation = new Reservation()
                    {
                        Flight_id = new Flight()
                        {
                            FlightID = Flight.FlightID
                        },
                        Jmbg = new User()
                        {
                            JMBG = User.JMBG
                        },
                        NumOfSeats = int.Parse(reserveFlight.TboxNumberOfSeats.Text)
                    };
                    if (!exists(reservation.Flight_id, reservation.Jmbg))
                    {
                        reservations.Add(reservation);
                    }
                    else
                    {
                        MessageBox.Show("Vec postoji");
                    }
                    reserveFlight.DgvReservations.DataSource = reservations;
                    for (int i = 3; i <= 13; i++)
                    {
                        reserveFlight.DgvReservations.Columns[i].Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da ucita let po zadatoj vrednosti");
                    return;
                }
            }
        }

        private bool exists(Flight flight_id, User jmbg)
        {
            foreach (var reservation in reservations)
            {
                if (reservation.Flight_id.FlightID == flight_id.FlightID && reservation.Jmbg.JMBG == jmbg.JMBG)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(reserveFlight.TboxNumberOfSeats.Text))
            {
                return false;
            }
            for (int i = 0; i < reserveFlight.TboxNumberOfSeats.Text.Length; i++)
            {
                if (reserveFlight.TboxNumberOfSeats.Text[i] > '9' || reserveFlight.TboxNumberOfSeats.Text[i] < '1')
                {
                    MessageBox.Show("Za broj mesta unesite vrednost od 1 do 9");
                    return false;
                }
            }
            return true;
        }

        private void ChangeTextTo(object sender, EventArgs e)
        {
            string to = reserveFlight.TboxTo.Text;
            Response response = Communication.Instance.Search(to, null, "To");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            reserveFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void ChangeTextFrom(object sender, EventArgs e)
        {
            string from = reserveFlight.TboxFrom.Text;
            Response response = Communication.Instance.Search(from, null, "From");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            reserveFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void SetControlSettings(User user)
        {
            reservations = new BindingList<Reservation>();
            this.User = user;
            reserveFlight.DgvFlights.MultiSelect = false;
            reserveFlight.DgvFlights.DataSource = new BindingList<Flight>(Communication.Instance.GetAllFlights());
            //reserveFlight.DgvFlights.Columns[0].Visible = false;
            for (int i = 9; i <= 18; i++)
            {
                reserveFlight.DgvFlights.Columns[i].Visible = false;
            }
        }

    }
}
