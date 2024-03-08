using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    internal class DetailsReservationGuiController
    {
        #region singleton
        private static DetailsReservationGuiController instance;
        public static DetailsReservationGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DetailsReservationGuiController();
                }
                return instance;
            }
        }

        private DetailsReservationGuiController()
        {

        }
        #endregion
        public Reservation Reservation { get; set; }

        FrmDetailsReservation frmDetailsReservation;

        internal void ShowDetails(Reservation reservation)
        {
            Response res = Communication.Instance.GetReservationByID(reservation);
            if (res.Exception==null)
            {
                MessageBox.Show("Let je uspesno ucitan");
                frmDetailsReservation = new FrmDetailsReservation(reservation);
                frmDetailsReservation.AutoSize = true;
                frmDetailsReservation.BtnUpdateReservation.Click += UpdateReservation;
                frmDetailsReservation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Let nije uspesno ucitan");
            }
            
        }

        private void UpdateReservation(object sender, EventArgs e)
        {
            int numOfSeats;
            int.TryParse(frmDetailsReservation.TboxNumOfSeats.Text, out numOfSeats);
            if (numOfSeats < 1 || numOfSeats > 9)
            {
                MessageBox.Show("Unesite broj od 1 do 9");
                return;
            }
            Reservation res = new Reservation
            {
                Flight_id = new Flight()
                {
                    FlightID = int.Parse(frmDetailsReservation.TboxFlightID.Text)
                },
                Jmbg = new User()
                {
                    JMBG = frmDetailsReservation.TboxJMBG.Text
                },
                NumOfSeats = numOfSeats
            };
            Reservation = res;
            MessageBox.Show("Azurirano");
        }

    }
}
