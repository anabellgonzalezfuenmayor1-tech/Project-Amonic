namespace Forms
{
    partial class FormOffices
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
            CboxOffices = new ComboBox();
            dgvUsers = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            ColLastName = new DataGridViewTextBoxColumn();
            ColAge = new DataGridViewTextBoxColumn();
            ColUserRol = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            ColOffice = new DataGridViewTextBoxColumn();
            lblRol = new Label();
            label1 = new Label();
            btnChangeRol = new Button();
            btnEnabledUsers = new Button();
            menuStrip1 = new MenuStrip();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // CboxOffices
            // 
            CboxOffices.DropDownStyle = ComboBoxStyle.DropDownList;
            CboxOffices.FormattingEnabled = true;
            CboxOffices.Location = new Point(84, 57);
            CboxOffices.Name = "CboxOffices";
            CboxOffices.Size = new Size(165, 23);
            CboxOffices.TabIndex = 0;
            CboxOffices.SelectedIndexChanged += CboxOffices_SelectedIndexChanged;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { ColName, ColLastName, ColAge, ColUserRol, ColEmail, ColOffice });
            dgvUsers.Location = new Point(30, 88);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(638, 234);
            dgvUsers.TabIndex = 1;
            dgvUsers.RowEnter += dgvUsers_RowEnter;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "FirstName";
            ColName.HeaderText = "Name";
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // ColLastName
            // 
            ColLastName.DataPropertyName = "LastName";
            ColLastName.HeaderText = "Last Name";
            ColLastName.Name = "ColLastName";
            ColLastName.ReadOnly = true;
            // 
            // ColAge
            // 
            ColAge.DataPropertyName = "Edad";
            ColAge.HeaderText = "Age";
            ColAge.Name = "ColAge";
            ColAge.ReadOnly = true;
            // 
            // ColUserRol
            // 
            ColUserRol.DataPropertyName = "RolName";
            ColUserRol.HeaderText = "User Rol";
            ColUserRol.Name = "ColUserRol";
            ColUserRol.ReadOnly = true;
            // 
            // ColEmail
            // 
            ColEmail.DataPropertyName = "Email";
            ColEmail.HeaderText = "Email Address";
            ColEmail.Name = "ColEmail";
            ColEmail.ReadOnly = true;
            // 
            // ColOffice
            // 
            ColOffice.DataPropertyName = "OfficeName";
            ColOffice.HeaderText = "Office";
            ColOffice.Name = "ColOffice";
            ColOffice.ReadOnly = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(30, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(152, 21);
            lblRol.TabIndex = 2;
            lblRol.Text = "Bienvenido señor(a) ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 62);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Offices:";
            // 
            // btnChangeRol
            // 
            btnChangeRol.Location = new Point(30, 328);
            btnChangeRol.Name = "btnChangeRol";
            btnChangeRol.Size = new Size(102, 23);
            btnChangeRol.TabIndex = 6;
            btnChangeRol.Text = "Change Rol";
            btnChangeRol.UseVisualStyleBackColor = true;
            btnChangeRol.Click += btnChangeRol_Click;
            // 
            // btnEnabledUsers
            // 
            btnEnabledUsers.Location = new Point(138, 328);
            btnEnabledUsers.Name = "btnEnabledUsers";
            btnEnabledUsers.Size = new Size(124, 23);
            btnEnabledUsers.TabIndex = 7;
            btnEnabledUsers.Text = "Enabled / Disable Login";
            btnEnabledUsers.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(693, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(67, 20);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // FormOffices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 360);
            Controls.Add(btnEnabledUsers);
            Controls.Add(btnChangeRol);
            Controls.Add(label1);
            Controls.Add(lblRol);
            Controls.Add(dgvUsers);
            Controls.Add(CboxOffices);
            Controls.Add(menuStrip1);
            Name = "FormOffices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUser";
            Load += FormOffices_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CboxOffices;
        private DataGridView dgvUsers;
        private Label lblRol;
        private Label label1;
        private Button btnChangeRol;
        private Button btnEnabledUsers;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColLastName;
        private DataGridViewTextBoxColumn ColAge;
        private DataGridViewTextBoxColumn ColUserRol;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColOffice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}