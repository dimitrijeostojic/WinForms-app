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
    public class DeleteFlightGuiController
    {
        UCDeleteFlight deleteFlight;
        public Flight Flight { get; set; }
        User user;
        #region singleton
        private static DeleteFlightGuiController instance;
        public static DeleteFlightGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeleteFlightGuiController();
                }
                return instance;
            }
        }

        private DeleteFlightGuiController()
        {

        }
        #endregion

        internal Control CreateDeleteFlight(User user)
        {
            deleteFlight = new UCDeleteFlight();
            SetControlSettings(user);
            deleteFlight.BtnDelete.Click += DeleteFlight;
            deleteFlight.BtnSelect.Click += SelectFlight;
            deleteFlight.TboxFrom.TextChanged += ChangeTextFrom;
            deleteFlight.TboxTo.TextChanged += ChangeTextTo;
            return deleteFlight;
        }

        private void ChangeTextTo(object sender, EventArgs e)
        {
            string to = deleteFlight.TboxTo.Text;
            Response response = Communication.Instance.Search(to, user, "To");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            deleteFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void ChangeTextFrom(object sender, EventArgs e)
        {
            string from = deleteFlight.TboxFrom.Text;
            Response response = Communication.Instance.Search(from, user, "From");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            deleteFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void SelectFlight(object sender, EventArgs e)
        {
            if (deleteFlight.DgvFlights.SelectedRows.Count > 0)
            {
                Flight f = (Flight)deleteFlight.DgvFlights.SelectedRows[0].DataBoundItem;
                Response response = Communication.Instance.FindFlightById(f.FlightID);
                Flight = ((Flight)response.Result);
                MessageBox.Show("Sistem je ucitao avio let po zadatoj vrednosti");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da ucita avio let po zadatoj vrednosti");
            }
        }

        private void SetControlSettings(User user)
        {
            Flight = null;
            this.user = user;
            deleteFlight.DgvFlights.MultiSelect = false;
            deleteFlight.DgvFlights.DataSource = new BindingList<Flight>(Communication.Instance.GetMyFlights(user));
            deleteFlight.DgvFlights.Columns[0].Visible = false;
            for (int i = 10; i <= 18; i++)
            {
                deleteFlight.DgvFlights.Columns[i].Visible = false;

            }
        }

        private void DeleteFlight(object sender, EventArgs e)
        {
            if (Flight != null)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da zelite da obrisete izabrani let", "Brisanje leta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Response response = Communication.Instance.DeleteFlight(Flight);
                    if (response.Exception == null)
                    {
                        MessageBox.Show("Sistem je uspesno obrisao izabrani let");
                        deleteFlight.DgvFlights.DataSource = new BindingList<Flight>(Communication.Instance.GetMyFlights(user));
                        Flight = null;
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da obrise izabrani let");
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati let iz tabele");
                MessageBox.Show("Sistem ne moze da obrise izabrani let");
            }
        }
    }
}
