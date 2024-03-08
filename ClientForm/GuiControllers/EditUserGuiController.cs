using ClientForm.UserControls;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    public class EditUserGuiController
    {
        #region singleton
        private static EditUserGuiController instance;
        public static EditUserGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditUserGuiController();
                }
                return instance;
            }
        }
        private EditUserGuiController()
        {

        }
        #endregion

        private UCEditUser editUser;
        public User User { get; set; }

        internal Control CreateEditUser(User user)
        {

            editUser = new UCEditUser();
            SetControlSettings(user);
            editUser.BtnEdit.Click += EditUser;
            editUser.BtnSave.Click += SaveUser;
            editUser.TboxFirstName.TextChanged += ChangeFirstName;
            editUser.TboxLastName.TextChanged += ChangeLastName;
            editUser.TboxUsername.TextChanged += ChangeUsername;
            editUser.TboxPassword.TextChanged += ChangePassword;
            editUser.TboxConfirmPassword.TextChanged += ChangeConfirmPassword;
            return editUser;
        }

        private void ChangeConfirmPassword(object sender, EventArgs e)
        {
            editUser.TboxConfirmPassword.BackColor = Color.Silver;
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            editUser.TboxPassword.BackColor = Color.Silver;
        }

        private void ChangeUsername(object sender, EventArgs e)
        {
            editUser.TboxUsername.BackColor = Color.Silver;
        }

        private void ChangeLastName(object sender, EventArgs e)
        {
            editUser.TboxLastName.BackColor = Color.Silver;
        }

        private void ChangeFirstName(object sender, EventArgs e)
        {
            editUser.TboxFirstName.BackColor = Color.Silver;
        }

        private void SaveUser(object sender, EventArgs e)
        {
            if (IsValid())
            {
                User user = new User()
                {
                    JMBG = User.JMBG,
                    FirstName = editUser.TboxFirstName.Text,
                    LastName = editUser.TboxLastName.Text,
                    Username = editUser.TboxUsername.Text,
                    Password = PasswordHasher.HashPassword(editUser.TboxPassword.Text),
                };
                Response res = Communication.Instance.UpdateUser(user);
                if (res.Exception==null)
                {
                    MessageBox.Show("Updated");
                    Clear(user);
                }
                else
                {
                    MessageBox.Show("Not updated");
                }
            }
        }

        private void EditUser(object sender, EventArgs e)
        {
            editUser.TboxFirstName.Enabled = true;
            editUser.TboxLastName.Enabled = true;
            editUser.TboxUsername.Enabled = true;
            editUser.TboxPassword.Enabled = true;
            editUser.TboxConfirmPassword.Enabled = true;
        }

        private void SetControlSettings(User user)
        {
            User = user;
            editUser.TboxFirstName.Text = user.FirstName;
            editUser.TboxLastName.Text = user.LastName;
            editUser.TboxUsername.Text = user.Username;
        }

        private void Clear(User user)
        {
            editUser.TboxFirstName.Text = user.FirstName;
            editUser.TboxLastName.Text = user.LastName;
            editUser.TboxUsername.Text = user.Username;
            editUser.TboxPassword.Text = "";
            editUser.TboxConfirmPassword.Text = "";
            editUser.TboxFirstName.Enabled = false;
            editUser.TboxLastName.Enabled = false;
            editUser.TboxUsername.Enabled = false;
            editUser.TboxPassword.Enabled = false;
            editUser.TboxConfirmPassword.Enabled = false;
        }

        private bool IsValid()
        {
            bool flag = true;

            if (string.IsNullOrEmpty(editUser.TboxFirstName.Text))
            {
                editUser.TboxFirstName.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(editUser.TboxLastName.Text))
            {
                editUser.TboxLastName.BackColor = Color.Salmon;
                flag = false;
            }

            if (string.IsNullOrEmpty(editUser.TboxUsername.Text))
            {
                editUser.TboxUsername.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(editUser.TboxPassword.Text))
            {
                editUser.TboxPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(editUser.TboxConfirmPassword.Text))
            {
                editUser.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (editUser.TboxPassword.Text != editUser.TboxConfirmPassword.Text)
            {
                editUser.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
                MessageBox.Show("Passwords do not match");
            }
            return flag;
        }
    }
}
