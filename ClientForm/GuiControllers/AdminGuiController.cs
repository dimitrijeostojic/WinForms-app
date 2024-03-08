using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm.GuiControllers
{
    public class AdminGuiController
    {
        #region singleton
        private static AdminGuiController instance;
        public static AdminGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AdminGuiController();
                }
                return instance;
            }
        }

        private AdminGuiController()
        {

        }
        #endregion

        private FrmAdmin frmAdmin;
        private User user;

        internal void ShowFrmAdmin(User user)
        {
            frmAdmin = new FrmAdmin(user);
            this.user = user;
            frmAdmin.AutoSize = true;
            ShowCreateFlightPanel();
            frmAdmin.ShowDialog();
        }

        internal void ShowCreateFlightPanel()
        {
            frmAdmin.ChangePanel(CreateFlightGuiController.Instance.CreateCreateFlight(user));
        }

        internal void ShowChangeFlightPanel()
        {
            frmAdmin.ChangePanel(ChangeFlightGuiController.Instance.CreateChangeFlight(user));
        }

        internal void ShowDeleteFlightPanel()
        {
            frmAdmin.ChangePanel(DeleteFlightGuiController.Instance.CreateDeleteFlight(user));
        }

        internal void ShowSearchFlightPanel()
        {
            frmAdmin.ChangePanel(SearchFlightGuiController.Instance.CreateSearchFlight());
        }

        internal void ShowInsertUserPanel()
        {
            frmAdmin.ChangePanel(InsertUserGuiController.Instance.CreateInsertUser());
        }

        internal void ShowChangeUserPanel()
        {
            frmAdmin.ChangePanel(ChangeUserGuiController.Instance.CreateChangeUser(user));
        }

        internal void Logout(FrmAdmin frmAdmin)
        {
            frmAdmin.Dispose();
        }
    }
}
