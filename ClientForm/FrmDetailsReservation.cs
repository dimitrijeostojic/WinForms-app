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
    public partial class FrmDetailsReservation : Form
    {
        public FrmDetailsReservation(Reservation reservation)
        {
            InitializeComponent();
            tboxFlightID.Text = reservation.Flight_id.ToString();
            tboxJMBG.Text = reservation.Jmbg.ToString();
            tboxNumOfSeats.Text = reservation.NumOfSeats.ToString();
        }
    }
}
