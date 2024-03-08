using ClientForm.UserControls;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    public class ChangeReservationGuiController
    {
        #region singleton
        private static ChangeReservationGuiController instance;
        public static ChangeReservationGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChangeReservationGuiController();
                }
                return instance;
            }
        }
        private ChangeReservationGuiController()
        {

        }
        #endregion

        private UCChangeReservation changeReservation;
        public User User { get; set; }


        internal Control CreateChangeReservationFlighth(User user)
        {
            changeReservation = new UCChangeReservation();
            SetControlSettings(user);
            changeReservation.BtnDelete.Click += Delete;
            changeReservation.BtnSaveAll.Click += SaveAll;
            changeReservation.BtnEdit.Click += Edit;
            changeReservation.TboxFlightID.TextChanged += SearchFlightID;
            return changeReservation;
        }

        private void Edit(object sender, EventArgs e)
        {
            if (changeReservation.DgvReservations.SelectedRows.Count > 0)
            {
                Reservation r = (Reservation)changeReservation.DgvReservations.SelectedRows[0].DataBoundItem;

                DetailsReservationGuiController.Instance.ShowDetails(r);
                if (DetailsReservationGuiController.Instance.Reservation == null)
                {
                    return;
                }
                foreach (DataGridViewRow row in changeReservation.DgvReservations.Rows)
                {
                    Reservation reservation = (Reservation)row.DataBoundItem;
                    if (reservation.Flight_id.FlightID == DetailsReservationGuiController.Instance.Reservation.Flight_id.FlightID && reservation.Jmbg.JMBG == DetailsReservationGuiController.Instance.Reservation.Jmbg.JMBG)
                    {
                        row.Cells["NumOfSeats"].Value = DetailsReservationGuiController.Instance.Reservation.NumOfSeats;
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Morate selektovati red u tabeli");
                MessageBox.Show("Sistem ne moze da ucita rezervaciju");
            }
        }

        private void SearchFlightID(object sender, EventArgs e)
        {
            string flightID = changeReservation.TboxFlightID.Text;
            Response response = Communication.Instance.Search(flightID, User, "flightId");
            List<Reservation> reservationsList = new List<Reservation>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                reservationsList.Add((Reservation)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            changeReservation.DgvReservations.DataSource = new BindingList<Reservation>(reservationsList);
        }

        private void SaveAll(object sender, EventArgs e)
        {
            List<Reservation> reservations = new List<Reservation>();
            foreach (DataGridViewRow row in changeReservation.DgvReservations.Rows)
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
                if (IsValid(reservation))
                {
                    reservations.Add(reservation);
                }
                else
                {
                    return;
                }
            }
            Response response = Communication.Instance.UpdateAllReservations(reservations);
            if (response.Exception == null)
            {
                MessageBox.Show("Sistem je azurirao rezervacije");
                changeReservation.DgvReservations.DataSource = Communication.Instance.GetReservationsByID(User);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da azurira rezervacije");
                changeReservation.DgvReservations.DataSource = Communication.Instance.GetReservationsByID(User);
            }

        }

        private void Delete(object sender, EventArgs e)
        {
            if (changeReservation.DgvReservations.SelectedRows.Count > 0)
            {
                Reservation r = (Reservation)changeReservation.DgvReservations.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show("Jeste li sigurni da zelite da obrisete izabranu rezervaciju", "Brisanje rezervacije", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Response response = Communication.Instance.DeleteReservation(r);
                    if (response.Exception == null)
                    {
                        MessageBox.Show("Sistem je uspesno obrisao izabranu rezervaciju");

                        changeReservation.DgvReservations.DataSource = new BindingList<Reservation>(Communication.Instance.GetReservationsByID(User));
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da obrise izabranu rezervaciju");
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate selektovati red u tabeli");
            }
        }

        private bool IsValid(Reservation r)
        {
            if (r.NumOfSeats < 1 || r.NumOfSeats > 9)
            {
                MessageBox.Show("Num of seats mora biti jednocifren broj u opsegu od 1 do 9");
                return false;
            }
            return true;
        }

        private void SetControlSettings(User user)
        {
            changeReservation.DgvReservations.MultiSelect = false;
            User = user;
            changeReservation.DgvReservations.DataSource = Communication.Instance.GetReservationsByID(user);
            changeReservation.DgvReservations.Columns[0].ReadOnly = true;
            changeReservation.DgvReservations.Columns[1].ReadOnly = true;
            for (int i = 3; i <= 13; i++)
            {
                changeReservation.DgvReservations.Columns[i].Visible = false;
            }
        }
    }
}