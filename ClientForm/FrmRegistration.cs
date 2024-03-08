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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            lblBackToLogin.Click += RegistrationGuiController.Instance.ShowFrmLogin;
            tboxFirstName.TextChanged += RegistrationGuiController.Instance.TextChanged;
            tboxLastName.TextChanged += RegistrationGuiController.Instance.TextChanged;
            tboxJMBG.TextChanged += RegistrationGuiController.Instance.TextChanged;
            tboxUsername.TextChanged += RegistrationGuiController.Instance.TextChanged;
            tboxPassword.TextChanged += RegistrationGuiController.Instance.TextChanged;
            tboxConfirmPassword.TextChanged += RegistrationGuiController.Instance.TextChanged;
            btnClear.Click += RegistrationGuiController.Instance.Clear;
            cbShowPassword.CheckedChanged += RegistrationGuiController.Instance.ShowPassword;
            FormClosed += RegistrationGuiController.Instance.CloseForm;
            btnRegister.Click += RegistrationGuiController.Instance.Register;
        }
    }
}
