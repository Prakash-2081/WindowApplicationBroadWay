using Demo.BAL.Implementations;
using Demo.BAL.Interfaces;
using Demo.DAL.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Demo.Desktop
{
    public partial class LoginForm : Form
    {
       
        public ILoginService _loginService;
        public LoginForm()
        {
            _loginService = new LoginService();
            InitializeComponent();
            InitiallizeFormComponent();
        }

        #region CollectionPractice
        private static void CollectionPractice()
        {
            CollectionExample collectionExample = new CollectionExample();
            var addingIEnumerableCollection = collectionExample.GetIEnumerable();

            var addingICollection = collectionExample.GetICollection();
            addingICollection.Add("Pradip");
            addingICollection.Remove("Suvana");

            var addingList = collectionExample.GetList();
            var get = addingList[0];
            addingList.Add("Suvana");

            var getDictionary = collectionExample.GetDictionary();
            getDictionary.Add(5, "Biography");
            var getValue = getDictionary[1];
            MessageBox.Show($"All Dictionary Value are: {getValue}", "Dictionary Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion CollectionPractice

        #region GenericPractice
        private void GenericPractice()
        {
            GenericClassExample genericClassExample = new GenericClassExample(5);
            genericClassExample.SetNum(2, "Prakash Khadka");
            string num = genericClassExample.GetNum(2);
            MessageBox.Show($"Array are {num}", "All Arrays", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion GenericPractice

        private void InitiallizeFormComponent()
        {
            lblUserNameError.Visible = false;
            lblPasswordError.Visible = false;
            txtPassword.PasswordChar = '*';
            txtUserName.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
            btnCancel.TabIndex = 3;
            this.AcceptButton = btnLogin;
            KeyPreview = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            bool isSuccess = ValidateLogin(userName, password);

            if (!isSuccess) return;

            if (_loginService.Login(userName,password))
            {
                var studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
                return;

            }

            MessageBox.Show("Invalid UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateLogin(string userName, string password)
        {

            if (String.IsNullOrWhiteSpace(userName))
            {
                lblUserNameError.Visible = true;

            }
            else
            {
                lblUserNameError.Visible = false;
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                lblPasswordError.Visible = true;
            }
            else
            {
                lblPasswordError.Visible = false;
            }
            bool result = !String.IsNullOrWhiteSpace(userName) && !String.IsNullOrWhiteSpace(password);
            return result;


        }

        private void lblUserNameError_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            if (!String.IsNullOrWhiteSpace(userName))
            {
                lblUserNameError.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            if (!String.IsNullOrWhiteSpace(password))
            {
                lblPasswordError.Visible = false;
            }
        }

        private void lblPasswordError_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumLock)
            {
                login();
            }
            else if (e.KeyCode == Keys.F2)
            {
                Application.Exit();
            }
        }
    }
}
