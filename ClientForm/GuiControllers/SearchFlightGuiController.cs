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
    internal class SearchFlightGuiController
    {
        #region singleton
        private static SearchFlightGuiController instance;
        public static SearchFlightGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SearchFlightGuiController();
                }
                return instance;
            }
        }
        private SearchFlightGuiController()
        {

        }
        #endregion

        public BindingList<Flight> flights { get; set; }
        public Flight Flight { get; set; }
        private UCSearchFlight searchFlight;

        internal Control CreateSearchFlight()
        {
            searchFlight = new UCSearchFlight();
            SetControlSettings();
            searchFlight.TboxFrom.TextChanged += ChangeFrom;
            searchFlight.TboxTo.TextChanged += ChangeTo;
            searchFlight.DtpDateOfDeparture.ValueChanged += ChangeDateOfDeparture;
            searchFlight.BtnDetails.Click += ShowDetails;
            return searchFlight;
        }

        private void ShowDetails(object sender, EventArgs e)
        {

            if (searchFlight.DgvFlights.SelectedRows.Count > 0)
            {
                Flight flight1 = (Flight)searchFlight.DgvFlights.SelectedRows[0].DataBoundItem;
                Response response = Communication.Instance.FindFlightById(flight1.FlightID);
                if (response.Exception == null)
                {
                    MessageBox.Show("Sistem je ucitao avio let po zadatoj vrednosti");
                    DetailsFlightGuiController.Instance.ShowDetails((Flight)response.Result);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da ucita avio let po zadatoj vrednosti");
                }
            }
            else
            {
                MessageBox.Show("Morate selektovati red");
                MessageBox.Show("Sistem ne moze da ucita avio let po zadatoj vrednosti");
            }

        }

        private void SetControlSettings()
        {
            BindingList<Flight> flights = new BindingList<Flight>(Communication.Instance.GetAllFlights());
            searchFlight.DgvFlights.DataSource = flights;
            this.flights = flights;
            searchFlight.DgvFlights.MultiSelect = false;
            searchFlight.DgvFlights.Columns[0].Visible = false;
            for (int i = 10; i <= 18; i++)
            {
                searchFlight.DgvFlights.Columns[i].Visible = false;
            }
        }

        private void ChangeDateOfDeparture(object sender, EventArgs e)
        {
            string date = searchFlight.DtpDateOfDeparture.Value.ToShortDateString();
            Response response = Communication.Instance.Search(date, null, "Date");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            searchFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void ChangeTo(object sender, EventArgs e)
        {
            string to = searchFlight.TboxTo.Text;
            Response response = Communication.Instance.Search(to, null, "To");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            searchFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }

        private void ChangeFrom(object sender, EventArgs e)
        {
            string from = searchFlight.TboxFrom.Text;
            Response response = Communication.Instance.Search(from, null, "From");
            List<Flight> flightList = new List<Flight>();
            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                flightList.Add((Flight)obj);
            }
            // Postavite listu korisnika kao izvor podataka za DataGridView
            searchFlight.DgvFlights.DataSource = new BindingList<Flight>(flightList);
        }
    }
}
