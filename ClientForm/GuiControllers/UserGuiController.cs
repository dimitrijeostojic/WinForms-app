using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm.GuiControllers
{
    public class UserGuiController
    {
        #region singleton
        private static UserGuiController instance;
        public static UserGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserGuiController();
                }
                return instance;
            }
        }

        private UserGuiController()
        {

        }
        #endregion
        private FrmUser frmUser;
        private User user;
        private bool sidebarExpand;

        internal void ShowFrmUser(User user)
        {
            frmUser = new FrmUser(user);
            this.user = user;
            frmUser.AutoSize = true;
            ShowReserveFlight();
            frmUser.ShowDialog();
        }

        internal void ShowReserveFlight()
        {
            frmUser.BtnReserveFlight.Checked = true;
            frmUser.ChangePanel(ReserveFlightGuiController.Instance.CreateReserveFlighth(user));
        }

        internal void ShowChangeReservationFlight()
        {
            frmUser.BtnChangeReservation.Checked = true;
            frmUser.ChangePanel(ChangeReservationGuiController.Instance.CreateChangeReservationFlighth(user));
        }

        public void ShowEditUser(User user)
        {
            frmUser.BtnUser.Checked = true;
            frmUser.ChangePanel(EditUserGuiController.Instance.CreateEditUser(user));
        }

        internal void Logout(FrmUser frmUser)
        {
            frmUser.Dispose();
        }

        internal void SlideMenu()
        {
            frmUser.SidebarTimer.Start();
        }

        internal void TimerTick()
        {
            if (sidebarExpand)
            {
                frmUser.Sidebar.Width -= 10;
                if (frmUser.Sidebar.Width == frmUser.Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    frmUser.SidebarTimer.Stop();
                }
            }
            else
            {
                frmUser.Sidebar.Width += 10;
                if (frmUser.Sidebar.Width == frmUser.Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    frmUser.SidebarTimer.Stop();
                }
            }
        }
    }
}
