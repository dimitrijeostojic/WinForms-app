using ClientForm.GuiControllers;
using ClientForm.UserControls;
using Common;
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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin(User user)
        {
            InitializeComponent();
            lblName.Text = $"Welcome {user.FirstName} {user.LastName}";
            btnCreateFlight.Click += (s, a) => AdminGuiController.Instance.ShowCreateFlightPanel();
            btnChangeFlight.Click += (s, a) => AdminGuiController.Instance.ShowChangeFlightPanel();
            btnDeleteFlight.Click += (s, a) => AdminGuiController.Instance.ShowDeleteFlightPanel();
            btnSearchFlight.Click += (s, a) => AdminGuiController.Instance.ShowSearchFlightPanel();
            btnInsertUser.Click += (s, a) => AdminGuiController.Instance.ShowInsertUserPanel();
            btnChangeUser.Click += (s, a) => AdminGuiController.Instance.ShowChangeUserPanel();
            btnLogout.Click += (s, a) => AdminGuiController.Instance.Logout(this);
            btnCreateFlight.Checked = true;
        }

        public void ChangePanel(Control control)
        {
            pnlAdmin.Controls.Clear();
            pnlAdmin.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
