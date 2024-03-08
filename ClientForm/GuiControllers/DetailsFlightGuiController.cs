using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm.GuiControllers
{
    internal class DetailsFlightGuiController
    {
        #region singleton
        private static DetailsFlightGuiController instance;
        public static DetailsFlightGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DetailsFlightGuiController();
                }
                return instance;
            }
        }

        private DetailsFlightGuiController()
        {

        }
        #endregion

        FrmDetailsFlight frmDetails;

        internal void ShowDetails(Flight flight)
        {
            frmDetails = new FrmDetailsFlight(flight);
            frmDetails.AutoSize = true;
            frmDetails.ShowDialog();
        }


    }
}
