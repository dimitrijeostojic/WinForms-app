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
    internal class ChangeUserGuiController
    {
        #region singleton
        private static ChangeUserGuiController instance;
        public static ChangeUserGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChangeUserGuiController();
                }
                return instance;
            }
        }

        private ChangeUserGuiController()
        {

        }
        #endregion

        private UCChangeUser changeUser;
        public BindingList<User> Users { get; set; }
        public string Jmbg { get; set; }
        public User User { get; set; }

        public Control CreateChangeUser(User user)
        {
            changeUser = new UCChangeUser();
            SetControlSettings(user);
            changeUser.BtnSelect.Click += SelectUser;
            changeUser.BtnUpdateUser.Click += UpdateUser;
            changeUser.TboxFirstName.TextChanged += ChangeFirstName;
            changeUser.TboxLastName.TextChanged += ChangeLastName;
            changeUser.TboxJmbg.TextChanged += ChangeJmbg;
            changeUser.TboxUsername.TextChanged += ChangeUsername;
            changeUser.TboxPassword.TextChanged += ChangePassword;
            changeUser.TboxConfirmPassword.TextChanged += ChangeConfirmPassword;
            return changeUser;
        }

        private void SetControlSettings(User user)
        {
            changeUser.DgvUsers.MultiSelect = false;
            BindingList<User> users = new BindingList<User>(Communication.Instance.GetAllUsers(user));
            changeUser.DgvUsers.DataSource = users;
            Users = users;
            for (int i = 6; i <= 16; i++)
            {
                changeUser.DgvUsers.Columns[i].Visible = false;
            }
            User = null;
        }
        private void UpdateUser(object sender, EventArgs e)
        {
            if (IsValid())
            {
                User user = new User()
                {
                    JMBG = Jmbg,
                    Username = changeUser.TboxUsername.Text,
                    FirstName = changeUser.TboxFirstName.Text,
                    LastName = changeUser.TboxLastName.Text,
                    Password = PasswordHasher.HashPassword(changeUser.TboxPassword.Text),
                };
                DialogResult result = MessageBox.Show("Jeste li sigurni da zelite da izmenite izabrnog korisnika", "Izmena korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Response res = Communication.Instance.UpdateUser(user);
                    if (res.Exception==null)
                    {
                        MessageBox.Show("Sistem je izmenio izabranog korisnika");
                        changeUser.DgvUsers.DataSource = new BindingList<User>(Communication.Instance.GetAllUsers(user));
                        Clear();
                        User = null;
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da izmeni izabranog korisnika");

                    }
                }
            }
        }

        private void SelectUser(object sender, EventArgs e)
        {
            if (changeUser.DgvUsers.SelectedRows.Count > 0)
            {
                User user = (User)changeUser.DgvUsers.SelectedRows[0].DataBoundItem;
                Response response = Communication.Instance.FindUserByID(user.JMBG);
                User = ((User)response.Result);
                changeUser.TboxFirstName.Text = User.FirstName;
                changeUser.TboxLastName.Text = User.LastName;
                changeUser.TboxUsername.Text = User.Username;
                Jmbg = User.JMBG;
                MessageBox.Show("Sistem je ucitao korisnika po zadatoj vrednosti");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da ucita korisnika po zadatoj vrednosti");
            }
        }

        private void ChangeJmbg(object sender, EventArgs e)
        {
            string jmbg = changeUser.TboxJmbg.Text;
            Response response = Communication.Instance.Search(jmbg, null, "Jmbg");
            List<User> userList = new List<User>();

            // Konvertujte svaki objekat iz response.Result u User objekat
            foreach (var obj in (List<object>)response.Result)
            {
                userList.Add((User)obj);
            }

            // Postavite listu korisnika kao izvor podataka za DataGridView
            changeUser.DgvUsers.DataSource = new BindingList<User>(userList);
            //changeUser.DgvUsers.DataSource = new BindingList<User>((IList<User>)response.Result);
        }

        private void ChangeConfirmPassword(object sender, EventArgs e)
        {
            changeUser.TboxConfirmPassword.BackColor = Color.FromArgb(230, 231, 233);
        }

        private void ChangeUsername(object sender, EventArgs e)
        {
            changeUser.TboxUsername.BackColor = Color.FromArgb(230, 231, 233);
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            changeUser.TboxPassword.BackColor = Color.FromArgb(230, 231, 233);
        }

        private void ChangeLastName(object sender, EventArgs e)
        {
            changeUser.TboxLastName.BackColor = Color.FromArgb(230, 231, 233);
        }

        private void ChangeFirstName(object sender, EventArgs e)
        {
            changeUser.TboxFirstName.BackColor = Color.FromArgb(230, 231, 233);
        }

        private void Clear()
        {
            changeUser.TboxFirstName.Text = "";
            changeUser.TboxLastName.Text = "";
            changeUser.TboxJmbg.Text = "";
            changeUser.TboxUsername.Text = "";
            changeUser.TboxPassword.Text = "";
            changeUser.TboxConfirmPassword.Text = "";
        }

        private bool IsValid()
        {
            bool flag = true;
            if (User == null)
            {
                MessageBox.Show("Morate da izaberete korisnika iz tabele");
                flag = false;
                return flag;
            }
            if (string.IsNullOrEmpty(changeUser.TboxFirstName.Text))
            {
                changeUser.TboxFirstName.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(changeUser.TboxLastName.Text))
            {
                changeUser.TboxLastName.BackColor = Color.Salmon;
                flag = false;
            }

            if (string.IsNullOrEmpty(changeUser.TboxUsername.Text))
            {
                changeUser.TboxUsername.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(changeUser.TboxPassword.Text))
            {
                changeUser.TboxPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (string.IsNullOrEmpty(changeUser.TboxConfirmPassword.Text))
            {
                changeUser.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
            }
            if (changeUser.TboxPassword.Text != changeUser.TboxConfirmPassword.Text)
            {
                changeUser.TboxConfirmPassword.BackColor = Color.Salmon;
                flag = false;
                MessageBox.Show("Lozinke se ne poklapaju");
            }
            if (flag==false)
            {
                MessageBox.Show("Sistem ne moze da zapamti korisnika");
            }
            return flag;
        }
    }
}
