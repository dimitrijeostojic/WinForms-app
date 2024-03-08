using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace ClientForm.GuiControllers
{
    public class RegistrationGuiController
    {
        #region singleton
        private static RegistrationGuiController instance;
        public static RegistrationGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegistrationGuiController();
                }
                return instance;
            }
        }

        private RegistrationGuiController()
        {

        }
        #endregion

        private FrmRegistration frmRegistration;

        public void ShowRegistrationForm()
        {
            frmRegistration = new FrmRegistration();
            frmRegistration.AutoSize = true;
            frmRegistration.ShowDialog();
        }

        public void ShowFrmLogin(object sender, EventArgs e)
        {
            frmRegistration.Visible = false;
            LoginGuiController.Instance.ShowFrmLogin();
            frmRegistration.Dispose();
        }

        public void TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.FromArgb(230, 231, 233);
        }

        public void Clear(object sender, EventArgs e)
        {
            frmRegistration.TboxFirstName.Text = "";
            frmRegistration.TboxLastName.Text = "";
            frmRegistration.TboxJMBG.Text = "";
            frmRegistration.TboxUsername.Text = "";
            frmRegistration.TboxPassword.Text = "";
            frmRegistration.TboxConfirmPassword.Text = "";
        }

        internal void ShowPassword(object sender, EventArgs e)
        {

            if (frmRegistration.CBShowPassword.Checked)
            {
                frmRegistration.TboxPassword.PasswordChar = '\0';
                frmRegistration.TboxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                frmRegistration.TboxPassword.PasswordChar = '*';
                frmRegistration.TboxConfirmPassword.PasswordChar = '*';
            }
        }

        internal void CloseForm(object sender, FormClosedEventArgs e)
        {
            Communication.Instance.Disconnect();
            frmRegistration.Dispose();
        }

        internal void Register(object sender, EventArgs e)
        {
            if (IsValid())
            {
                User user = new User()
                {
                    FirstName = frmRegistration.TboxFirstName.Text,
                    LastName = frmRegistration.TboxLastName.Text,
                    JMBG = frmRegistration.TboxJMBG.Text,
                    Username = frmRegistration.TboxUsername.Text,
                    Password = PasswordHasher.HashPassword(frmRegistration.TboxPassword.Text),
                    IsAdmin = false
                };

                Response res = Communication.Instance.Register(user);
                if (res.Exception == null)
                {
                    MessageBox.Show("Sistem je uspesno registrovao korisnika", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmRegistration.Visible = false;
                    UserGuiController.Instance.ShowFrmUser(user);
                    frmRegistration.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da registruje korisnika!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValid()
        {
            bool flag = true;

            if (string.IsNullOrEmpty(frmRegistration.TboxFirstName.Text))
            {
                frmRegistration.TboxFirstName.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(frmRegistration.TboxLastName.Text))
            {
                frmRegistration.TboxLastName.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(frmRegistration.TboxJMBG.Text))
            {
                frmRegistration.TboxJMBG.BackColor = Color.Salmon;
                flag = false;
            }
            if (frmRegistration.TboxJMBG.Text == "" && frmRegistration.TboxJMBG.Text.Length != 13)
            {
                frmRegistration.TboxJMBG.BackColor = Color.Salmon;
                flag = false;
                MessageBox.Show("JMBG se sastoji od 13 cifara");
            }
            else
            {
                if (frmRegistration.TboxJMBG.Text.Length != 13)
                {
                    frmRegistration.TboxJMBG.BackColor = Color.Salmon;
                    flag = false;
                    MessageBox.Show("JMBG se sastoji od 13 cifara");
                }
                else
                {
                    for (int i = 0; i < 13; i++)
                    {
                        if (frmRegistration.TboxJMBG.Text[i] < '0' || frmRegistration.TboxJMBG.Text[i] > '9')
                        {

                            frmRegistration.TboxJMBG.BackColor = Color.Salmon;
                            flag = false;
                            MessageBox.Show("JMBG se sastoji samo od cifara od 0 do 9");
                            break;
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(frmRegistration.TboxUsername.Text))
            {
                frmRegistration.TboxUsername.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(frmRegistration.TboxPassword.Text))
            {
                frmRegistration.TboxPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(frmRegistration.TboxConfirmPassword.Text))
            {
                frmRegistration.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (frmRegistration.TboxPassword.Text != frmRegistration.TboxConfirmPassword.Text)
            {
                frmRegistration.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
                MessageBox.Show("Lozinke se ne poklapaju");
            }
            return flag;
        }

    }
}
