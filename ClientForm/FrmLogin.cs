using ClientForm;
using ClientForm.GuiControllers;
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

namespace Common
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            btnLogin.Click += LoginGuiController.Instance.Login;
            cbShowPassword.Click += LoginGuiController.Instance.ShowPassword;
            btnClear.Click += LoginGuiController.Instance.Clear;
            FormClosed += LoginGuiController.Instance.CloseForm;
            lblCreateAccount.Click += LoginGuiController.Instance.CreateAccount;
        }
    }
}
