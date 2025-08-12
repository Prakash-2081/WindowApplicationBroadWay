namespace WinFormsApp1
{
    partial class StudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblFee = new Label();
            txtFee = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(25, 31);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(61, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(104, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(165, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(25, 83);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LastName";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(104, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(165, 23);
            txtLastName.TabIndex = 2;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(25, 138);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(58, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "FullName";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(104, 135);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(165, 23);
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(26, 193);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(31, 15);
            lblFee.Text = "Fee: ";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(105, 190);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(164, 23);
            txtFee.TextChanged += txtFee_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(104, 241);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(76, 32);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 241);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(83, 32);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtFee);
            Controls.Add(lblFee);
            Controls.Add(txtFullName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFullName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "StudentForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblFee;
        private TextBox txtFee;
        private Button btnSubmit;
        private Button btnCancel;
    }
}
