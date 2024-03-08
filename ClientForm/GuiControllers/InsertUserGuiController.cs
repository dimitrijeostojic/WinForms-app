using ClientForm.UserControls;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm.GuiControllers
{
    public class InsertUserGuiController
    {
        UCInsertUser insertUser;
        #region singleton
        private static InsertUserGuiController instance;
        public static InsertUserGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InsertUserGuiController();
                }
                return instance;
            }
        }
        private InsertUserGuiController()
        {

        }
        #endregion

        internal Control CreateInsertUser()
        {
            insertUser = new UCInsertUser();
            insertUser.BtnInsertUser.Click += InserUser;
            insertUser.TboxFirstName.TextChanged += ChangeFirstName;
            insertUser.TboxLastName.TextChanged += ChangeLastName;
            insertUser.TboxJmbg.TextChanged += ChangeJmbg;
            insertUser.TboxUsername.TextChanged += ChangeUsername;
            insertUser.TboxPassword.TextChanged += ChangePassword;
            insertUser.TboxConfirmPassword.TextChanged += ChangeConfirmPassword;
            return insertUser;
        }

        private void InserUser(object sender, EventArgs e)
        {
            if (IsValid())
            {

                User user = new User()
                {
                    FirstName = insertUser.TboxFirstName.Text,
                    LastName = insertUser.TboxLastName.Text,
                    JMBG = insertUser.TboxJmbg.Text,
                    Username = insertUser.TboxUsername.Text,
                    Password = PasswordHasher.HashPassword(insertUser.TboxPassword.Text),
                    IsAdmin = false
                };


                Response res = Communication.Instance.SaveUser(user);
                if (res.Exception == null)
                {
                    MessageBox.Show("Sistem je zapamtio korisnika", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti korisnika!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ChangeFirstName(object sender, EventArgs e)
        {
            insertUser.TboxFirstName.BackColor = Color.FromArgb(230, 231, 233);
        }
        private void ChangeLastName(object sender, EventArgs e)
        {
            insertUser.TboxLastName.BackColor = Color.FromArgb(230, 231, 233);
        }
        private void ChangeJmbg(object sender, EventArgs e)
        {
            insertUser.TboxJmbg.BackColor = Color.FromArgb(230, 231, 233);
        }
        private void ChangeUsername(object sender, EventArgs e)
        {
            insertUser.TboxUsername.BackColor = Color.FromArgb(230, 231, 233);
        }
        private void ChangePassword(object sender, EventArgs e)
        {
            insertUser.TboxPassword.BackColor = Color.FromArgb(230, 231, 233);
        }
        private void ChangeConfirmPassword(object sender, EventArgs e)
        {
            insertUser.TboxConfirmPassword.BackColor = Color.FromArgb(230, 231, 233);
        }
        private bool IsValid()
        {
            bool flag = true;

            if (string.IsNullOrEmpty(insertUser.TboxFirstName.Text))
            {
                insertUser.TboxFirstName.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(insertUser.TboxLastName.Text))
            {
                insertUser.TboxLastName.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(insertUser.TboxJmbg.Text))
            {
                insertUser.TboxJmbg.BackColor = Color.Salmon;
                flag = false;
            }
            if (insertUser.TboxJmbg.Text == "" && insertUser.TboxJmbg.Text.Length != 13)
            {
                insertUser.TboxJmbg.BackColor = Color.Salmon;
                flag = false;
                MessageBox.Show("JMBG se sastoji od 13 cifara");
            }
            else
            {
                if (insertUser.TboxJmbg.Text.Length != 13)
                {
                    insertUser.TboxJmbg.BackColor = Color.Salmon;
                    flag = false;
                    MessageBox.Show("JMBG se sastoji od 13 cifara");
                }
                else
                {
                    for (int i = 0; i < 13; i++)
                    {
                        if (insertUser.TboxJmbg.Text[i] < '0' || insertUser.TboxJmbg.Text[i] > '9')
                        {

                            insertUser.TboxJmbg.BackColor = Color.Salmon;
                            flag = false;
                            MessageBox.Show("JMBG se sastoji samo od cifara i to od 0 do 9");
                            break;
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(insertUser.TboxUsername.Text))
            {
                insertUser.TboxUsername.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(insertUser.TboxPassword.Text))
            {
                insertUser.TboxPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(insertUser.TboxConfirmPassword.Text))
            {
                insertUser.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (insertUser.TboxPassword.Text != insertUser.TboxConfirmPassword.Text)
            {
                insertUser.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
                MessageBox.Show("Lozinke se ne poklapaju");
            }
            if (flag==false)
            {
                MessageBox.Show("Sistem ne moze da zapamti korisnika");
            }
            return flag;
        }
        public void Clear()
        {
            insertUser.TboxFirstName.Text = "";
            insertUser.TboxLastName.Text = "";
            insertUser.TboxJmbg.Text = "";
            insertUser.TboxUsername.Text = "";
            insertUser.TboxPassword.Text = "";
            insertUser.TboxConfirmPassword.Text = "";
        }
    }
}
