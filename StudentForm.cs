using Demo.BAL.Implementations;
using Demo.BAL.Interfaces;
using Demo.DAL.Constants;
using Demo.DAL.Implementations;
using Demo.DAL.Interfaces;
using Demo.DAL.Models;
using System.Data;
using System.Text.Json;

namespace Demo.Desktop
{
    public partial class StudentForm : Form
    {
        private readonly IStudentReadServices _studentReadServices;
        private readonly IStudentWriteServices _studentWriteServices;

        private List<StudentRead> _students;

        public StudentForm()
        {
            InitializeComponent();
            _studentReadServices = new StudentServices();
            _studentWriteServices = new StudentServices();
            InitalizeFormComponents();
            LoadCourse();
            LoadHobbies();

        }
        private void LoadStudentGrid()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = ApplicationConstant.SN,
                HeaderText = "S.N",
                CellTemplate = new DataGridViewTextBoxCell()

            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Id),
                HeaderText = "Id",
                DataPropertyName = nameof(StudentRead.Id),
                CellTemplate = new DataGridViewTextBoxCell()

            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.FirstName),
                HeaderText = "First Name",
                DataPropertyName = nameof(StudentRead.FirstName),
                CellTemplate = new DataGridViewTextBoxCell()

            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.LastName),
                HeaderText = "Last Name",
                DataPropertyName = nameof(StudentRead.LastName),
                CellTemplate = new DataGridViewTextBoxCell()
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Fee),
                HeaderText = "Fee",
                DataPropertyName = nameof(StudentRead.Fee),
                CellTemplate = new DataGridViewTextBoxCell()
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Gender),
                HeaderText = "Gender",
                DataPropertyName = nameof(StudentRead.Gender),
                CellTemplate = new DataGridViewTextBoxCell()

            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Course),
                HeaderText = "Course Selected",
                DataPropertyName = nameof(StudentRead.Course),
                CellTemplate = new DataGridViewTextBoxCell()

            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Agree),
                HeaderText = "Agree or Not",
                DataPropertyName = nameof(StudentRead.Agree),
                CellTemplate = new DataGridViewTextBoxCell()
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Profile),
                HeaderText = "Profile",
                DataPropertyName = nameof(StudentRead.Profile),
                CellTemplate = new DataGridViewTextBoxCell()
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.CreatedDate),
                HeaderText = "Created Date",
                DataPropertyName = nameof(StudentRead.CreatedDate),
                CellTemplate = new DataGridViewTextBoxCell()

            });
            LoadStudents();
        }

        private void LoadStudents()
        {
            _students = _studentReadServices.GetAllStudents();
            dgvStudents.DataSource = _students;

            UpdateSerialNumber();

        }

        private void UpdateSerialNumber()
        {
            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                dgvStudents.Rows[i].Cells[ApplicationConstant.SN].Value = (i + 1).ToString();
            }
        }

        private void InitalizeFormComponents()
        {
            txtFirstName.Focus();
            txtFirstName.TabIndex = 0;
            txtLastName.TabIndex = 1;
            dtpDOB.TabIndex = 2;
            lblHobby.TabIndex = 3;
            btnSubmit.TabIndex = 4;
            btnCancel.TabIndex = 5;
            txtFullName.ReadOnly = true;
            txtFee.ReadOnly = true;
            txtFee.Text = StudentRepository._fee;
            txtProfileName.ReadOnly = true;
            pbProfile.BorderStyle = BorderStyle.Fixed3D;
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            imageUploadDialog.Filter = "Image Files (*.jpg;.jpeg;*.png;*.gif;)|*.jpg;*.jpeg;*.png;";
            lblFirstNameError.Visible = false;
            lblLastNameError.Visible = false;
            lblChkAgreeError.Visible = false;
            rbMale.Checked = true;
            lblcmbCourseError.Visible = false;
            lblDOBError.Visible = false;
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = " ";
            lblHobbyError.Visible = false;
        }
        private void LoadHobbies()
        {
            var table = _studentReadServices.GetAllHobbies();
            clbHobby.DataSource = table;
            clbHobby.DisplayMember = nameof(Dropdown.Name);
            clbHobby.ValueMember = nameof(Dropdown.Id);
        }
        private void LoadCourse()
        {
            //cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            //string[] courses = _studentReadServices.ListOfCourses();
            //#region This is optional for adding items

            //here Add manually add one items with loop

            //for (int i = 0; i < courses.Length; i++)
            //{
            //    cmbCourse.Items.Add(courses[i]);
            //}

            //here AddRange add all items at once
            //#endregion
            //cmbCourse.Items.AddRange(courses);
            //cmbCourse.SelectedIndex = 0;

            var courses = _studentReadServices.GetAllCourses();
            courses.Insert(0, new Dropdown { Id = 0, Name = "Please Select a Course" });
            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = nameof(Dropdown.Name);
            cmbCourse.ValueMember = nameof(Dropdown.Id);
            cmbCourse.SelectedIndex = 0;
        }

        private void WorkingComponents()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            txtFullName.Text = String.Concat(firstName, " ", lastName);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentGrid();

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            WorkingComponents();
            string firstName = txtFirstName.Text;
            if (!String.IsNullOrWhiteSpace(firstName))
            {
                lblFirstNameError.Visible = false;
            }

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            WorkingComponents();
            string lastName = txtLastName.Text;
            if (!String.IsNullOrWhiteSpace(lastName))
            {
                lblLastNameError.Visible = false;
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormSubmit();

        }

        private void FormSubmit()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fee = txtFee.Text;
            bool gender = rbMale.Checked;
            bool agree = chkAgree.Checked;
            string profile = txtProfileName.Text;
            int course = (int)cmbCourse.SelectedValue;
            DateTime dob = dtpDOB.Value;
            var hobbies=clbHobby
                           .CheckedItems
                           .Cast<DataRowView>()
                           .Select(x => (int)x.Row[nameof(Dropdown.Id)])
                           .ToList();
            string hobbyId = String.Join(",", hobbies);
            var student = new StudentWrite
            {
                FirstName = firstName,
                LastName = lastName,
                Fee = fee,
                Gender = gender,
                Courseid = course,
                DOB = dob,
                Agree = agree,
                Profile = profile,
                HobbyId = hobbyId
            };

            bool isSuccess = StudentFormValidationCheck(student);

            if (!isSuccess)
            {
                return;
            }
            if (isSuccess)
            {
                _studentWriteServices.SaveData(student);
                LoadStudents();
                ClearTextField();
                MessageBox.Show("Saved Success", "Success", MessageBoxButtons.OK);
            }

        }


        private bool StudentFormValidationCheck(StudentWrite student)
        {
            if (String.IsNullOrWhiteSpace(student.FirstName))
            {
                lblFirstNameError.Visible = true;
            }
            else
            {
                lblFirstNameError.Visible = false;

            }
            if (String.IsNullOrWhiteSpace(student.LastName))
            {
                lblLastNameError.Visible = true;
            }
            else
            {
                lblLastNameError.Visible = false;

            }
            if (!student.Agree)
            {
                lblChkAgreeError.Visible = true;
            }
            else
            {
                lblChkAgreeError.Visible = false;
            }
            if (cmbCourse.SelectedIndex == 0)
            {
                lblcmbCourseError.Visible = true;
            }
            else
            {
                lblcmbCourseError.Visible = false;
            }
            if (dtpDOB.CustomFormat == " ")
            {
                lblDOBError.Visible = true;
            }
            else
            {
                lblDOBError.Visible = false;
            }
            if (String.IsNullOrEmpty(student.HobbyId))
            {
                lblHobbyError.Visible = true;
            }
            else
            {
                lblHobbyError.Visible = false;
            }

            bool result = !String.IsNullOrWhiteSpace(student.FirstName) && !String.IsNullOrWhiteSpace(student.LastName) && cmbCourse.SelectedIndex > 0 && student.Agree && dtpDOB.CustomFormat != " " && !String.IsNullOrEmpty(student.HobbyId);
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextField();
        }

        private void ClearTextField()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbCourse.SelectedIndex = 0;
            rbMale.Checked = true;
            chkAgree.Checked = false;
            pbProfile.Image = null;
            cmbCourse.SelectedIndex = 0;
            txtFirstName.Focus();
            dtpDOB.CustomFormat = " ";
            clbHobby.SelectedItems.Clear();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (imageUploadDialog.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Load(imageUploadDialog.FileName);
                txtProfileName.Text = imageUploadDialog.SafeFileName;

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pbProfile.Image = null;
            txtProfileName.Clear();
        }

        private void imageUploadDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void txtProfileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAgree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            bool isAgree = chkAgree.Checked;
            if (isAgree)
            {
                lblChkAgreeError.Visible = false;
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudents_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblChkAgreeError_Click(object sender, EventArgs e)
        {

        }

        private void lblCourse_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedIndex > 0)
            {
                lblcmbCourseError.Visible = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            _students = _studentReadServices.GetAllStudents();

            if (String.IsNullOrWhiteSpace(search))
            {
                dgvStudents.DataSource = _students;
            }
            else
            {

                var filtered = _students
                    .Where(s => s.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase)
                    || s.LastName.Contains(search, StringComparison.OrdinalIgnoreCase)
                    || s.Gender != null && s.Gender.StartsWith(search, StringComparison.OrdinalIgnoreCase)
                    || s.Course != null && s.Course.StartsWith(search, StringComparison.OrdinalIgnoreCase)
                    )
                    .ToList();

                dgvStudents.DataSource = filtered;
            }
            UpdateSerialNumber();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = ApplicationConstant.DateFormat;
            lblDOBError.Visible = false;
        }



        

        private void clbHobby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbHobby.SelectedItems.Count > 0)
            {
                lblHobbyError.Visible = false;
            }


        }
    }
}
