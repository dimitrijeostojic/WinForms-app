using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    public class LoginGuiController
    {
        #region singleton
        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {

        }
        #endregion

        private FrmLogin frmLogin;

        public void ShowFrmLogin()
        {

            using (var frmLogin = new FrmLogin())
            {
                frmLogin.AutoSize = true;
                this.frmLogin = frmLogin;
                frmLogin.ShowDialog();
            }
        }

        public void Login(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = frmLogin.TboxUsername.Text,
                Password = frmLogin.TboxPassword.Text,
            };

            Response response = Communication.Instance.Login(user);

            if (response.Result != null)
            {
                if (((User)response.Result).IsAdmin)
                {
                    ShowAdminForm((User)response.Result);
                }
                else
                {
                    ShowUserForm((User)response.Result);
                }
            }
            else
            {
                MessageBox.Show("Neuspešno prijavljivanje na sistem!");
            }
        }

        public void ShowPassword(object sender, EventArgs e)
        {
            if (frmLogin.CBShowPassword.Checked)
            {
                frmLogin.TboxPassword.PasswordChar = '\0';
            }
            else
            {
                frmLogin.TboxPassword.PasswordChar = '*';
            }
        }

        public void Clear(object sender, EventArgs e)
        {
            frmLogin.TboxUsername.Text = "";
            frmLogin.TboxPassword.Text = "";
        }

        public void CloseForm(object sender, FormClosedEventArgs e)
        {
            Communication.Instance.Disconnect();
        }

        public void CreateAccount(object sender, EventArgs e)
        {
            frmLogin.Visible = false;
            RegistrationGuiController.Instance.ShowRegistrationForm();
        }

        public void ShowAdminForm(User result)
        {
            MessageBox.Show($"Uspešno ste se prijavili {result.FirstName} {result.LastName}");
            frmLogin.Visible = false;
            AdminGuiController.Instance.ShowFrmAdmin(result);
            frmLogin.Visible = true;
            frmLogin.TboxUsername.Text = "";
            frmLogin.TboxPassword.Text = "";
        }

        public void ShowUserForm(User result)
        {
            MessageBox.Show($"Uspešno ste se prijavili {result.FirstName} {result.LastName}");
            frmLogin.Visible = false;
            UserGuiController.Instance.ShowFrmUser(result);
            frmLogin.Visible = true;
            frmLogin.TboxUsername.Text = "";
            frmLogin.TboxPassword.Text = "";
        }
    }
}
