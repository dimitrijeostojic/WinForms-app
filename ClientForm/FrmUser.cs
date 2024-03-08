using ClientForm.GuiControllers;
using ClientForm.UserControls;
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

namespace Common
{
    public partial class FrmUser : Form
    {
        
        public FrmUser(User user)
        {
            InitializeComponent();
            btnUser.Text = $"{user.FirstName}";
            btnReserveFlight.Click += (s, a) => UserGuiController.Instance.ShowReserveFlight();
            pbReserveFlight.Click += (s, a) => UserGuiController.Instance.ShowReserveFlight();
            btnChangeReservation.Click += (s, a) => UserGuiController.Instance.ShowChangeReservationFlight();
            pbChangeFlight.Click += (s, a) => UserGuiController.Instance.ShowChangeReservationFlight();
            btnUser.Click += (s, a) => UserGuiController.Instance.ShowEditUser(user);
            pbUser.Click += (s, a) => UserGuiController.Instance.ShowEditUser(user);
            btnLogout.Click += (s, a) => UserGuiController.Instance.Logout(this);
            pbLogout.Click += (s, a) => UserGuiController.Instance.Logout(this);
            menuButton.Click += (s, a) => UserGuiController.Instance.SlideMenu();
            btnMenu.Click += (s, a) => UserGuiController.Instance.SlideMenu();
            sidebarTimer.Tick += (s, a) => UserGuiController.Instance.TimerTick();
        }

        public void ChangePanel(Control control)
        {
            pnlUser.Controls.Clear();
            pnlUser.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
