namespace Forms
{
    partial class FormAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cbOffices = new ComboBox();
            dtCumpleano = new DateTimePicker();
            txtPass = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Email Adress:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 104);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "first Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 161);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 223);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Office:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 283);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Birthdate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 344);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 43);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(190, 103);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 27);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(190, 161);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 27);
            txtLastName.TabIndex = 8;
            // 
            // cbOffices
            // 
            cbOffices.FormattingEnabled = true;
            cbOffices.Location = new Point(190, 223);
            cbOffices.Margin = new Padding(3, 4, 3, 4);
            cbOffices.Name = "cbOffices";
            cbOffices.Size = new Size(175, 28);
            cbOffices.TabIndex = 9;
            // 
            // dtCumpleano
            // 
            dtCumpleano.Format = DateTimePickerFormat.Short;
            dtCumpleano.Location = new Point(190, 283);
            dtCumpleano.Margin = new Padding(3, 4, 3, 4);
            dtCumpleano.Name = "dtCumpleano";
            dtCumpleano.Size = new Size(175, 27);
            dtCumpleano.TabIndex = 10;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(190, 340);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(175, 27);
            txtPass.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 413);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 31);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(209, 413);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 31);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 491);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPass);
            Controls.Add(dtCumpleano);
            Controls.Add(cbOffices);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox cbOffices;
        private DateTimePicker dtCumpleano;
        private TextBox txtPass;
        private Button btnSave;
        private Button btnCancel;
    }
}