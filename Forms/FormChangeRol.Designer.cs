namespace Forms
{
    partial class FormChangeRol
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
            txtAdress = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            cboxOffices = new ComboBox();
            rbAdministrador = new RadioButton();
            rbUser = new RadioButton();
            btnApply = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Email Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 144);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 202);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Office:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 260);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "Rol:";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(176, 20);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(172, 23);
            txtAdress.TabIndex = 5;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(176, 76);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(172, 23);
            txtFname.TabIndex = 6;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(176, 136);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(172, 23);
            txtLname.TabIndex = 7;
            // 
            // cboxOffices
            // 
            cboxOffices.FormattingEnabled = true;
            cboxOffices.Location = new Point(176, 199);
            cboxOffices.Name = "cboxOffices";
            cboxOffices.Size = new Size(172, 23);
            cboxOffices.TabIndex = 8;
            // 
            // rbAdministrador
            // 
            rbAdministrador.AutoSize = true;
            rbAdministrador.Location = new Point(176, 258);
            rbAdministrador.Name = "rbAdministrador";
            rbAdministrador.Size = new Size(101, 19);
            rbAdministrador.TabIndex = 9;
            rbAdministrador.TabStop = true;
            rbAdministrador.Text = "Administrador";
            rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            rbUser.AutoSize = true;
            rbUser.Location = new Point(300, 258);
            rbUser.Name = "rbUser";
            rbUser.Size = new Size(48, 19);
            rbUser.TabIndex = 10;
            rbUser.TabStop = true;
            rbUser.Text = "User";
            rbUser.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(89, 300);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 11;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(193, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormChangeRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 349);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(rbUser);
            Controls.Add(rbAdministrador);
            Controls.Add(cboxOffices);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtAdress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormChangeRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Rol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAdress;
        private TextBox txtFname;
        private TextBox txtLname;
        private ComboBox cboxOffices;
        private RadioButton rbAdministrador;
        private RadioButton rbUser;
        private Button btnApply;
        private Button btnCancel;
    }
}