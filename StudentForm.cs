namespace WinFormsApp1
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            InitalizeFormComponents();
        }

        private void InitalizeFormComponents()
        {
            txtFirstName.Focus();
            txtFirstName.TabIndex = 1;
            txtLastName.TabIndex = 2;
            btnSubmit.TabIndex = 3;
            btnCancel.TabIndex = 4;
            txtFullName.ReadOnly = true;
            txtFee.ReadOnly = true;
            txtFee.Text = "100000";
        }

        private void WorkingComponents()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            txtFullName.Text = String.Concat(firstName, " ", lastName);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            WorkingComponents();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            WorkingComponents();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormValidationCheck();
        }

        private void FormValidationCheck()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            if (!String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Saved Success", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Required first and lastname", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFirstName.Focus();
        }
    }
}
