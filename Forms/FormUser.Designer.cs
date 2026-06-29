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
            CboxOffices.Location = new Point(96, 76);
            CboxOffices.Margin = new Padding(3, 4, 3, 4);
            CboxOffices.Name = "CboxOffices";
            CboxOffices.Size = new Size(188, 28);
            CboxOffices.TabIndex = 0;
            CboxOffices.SelectedIndexChanged += CboxOffices_SelectedIndexChanged;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { ColName, ColLastName, ColAge, ColUserRol, ColEmail, ColOffice });
            dgvUsers.Location = new Point(34, 117);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(729, 312);
            dgvUsers.TabIndex = 1;
            dgvUsers.RowEnter += dgvUsers_RowEnter;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "FirstName";
            ColName.HeaderText = "Name";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // ColLastName
            // 
            ColLastName.DataPropertyName = "LastName";
            ColLastName.HeaderText = "Last Name";
            ColLastName.MinimumWidth = 6;
            ColLastName.Name = "ColLastName";
            ColLastName.ReadOnly = true;
            // 
            // ColAge
            // 
            ColAge.DataPropertyName = "Edad";
            ColAge.HeaderText = "Age";
            ColAge.MinimumWidth = 6;
            ColAge.Name = "ColAge";
            ColAge.ReadOnly = true;
            // 
            // ColUserRol
            // 
            ColUserRol.DataPropertyName = "RolName";
            ColUserRol.HeaderText = "User Rol";
            ColUserRol.MinimumWidth = 6;
            ColUserRol.Name = "ColUserRol";
            ColUserRol.ReadOnly = true;
            // 
            // ColEmail
            // 
            ColEmail.DataPropertyName = "Email";
            ColEmail.HeaderText = "Email Address";
            ColEmail.MinimumWidth = 6;
            ColEmail.Name = "ColEmail";
            ColEmail.ReadOnly = true;
            // 
            // ColOffice
            // 
            ColOffice.DataPropertyName = "OfficeName";
            ColOffice.HeaderText = "Office";
            ColOffice.MinimumWidth = 6;
            ColOffice.Name = "ColOffice";
            ColOffice.ReadOnly = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(34, 39);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(189, 28);
            lblRol.TabIndex = 2;
            lblRol.Text = "Bienvenido señor(a) ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 83);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Offices:";
            // 
            // btnChangeRol
            // 
            btnChangeRol.Location = new Point(34, 437);
            btnChangeRol.Margin = new Padding(3, 4, 3, 4);
            btnChangeRol.Name = "btnChangeRol";
            btnChangeRol.Size = new Size(117, 31);
            btnChangeRol.TabIndex = 6;
            btnChangeRol.Text = "Change Rol";
            btnChangeRol.UseVisualStyleBackColor = true;
            btnChangeRol.Click += btnChangeRol_Click;
            // 
            // btnEnabledUsers
            // 
            btnEnabledUsers.Location = new Point(158, 437);
            btnEnabledUsers.Margin = new Padding(3, 4, 3, 4);
            btnEnabledUsers.Name = "btnEnabledUsers";
            btnEnabledUsers.Size = new Size(142, 31);
            btnEnabledUsers.TabIndex = 7;
            btnEnabledUsers.Text = "Enabled / Disable Login";
            btnEnabledUsers.UseVisualStyleBackColor = true;
            btnEnabledUsers.Click += btnEnabledUsers_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(792, 30);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(84, 24);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // FormOffices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 480);
            Controls.Add(btnEnabledUsers);
            Controls.Add(btnChangeRol);
            Controls.Add(label1);
            Controls.Add(lblRol);
            Controls.Add(dgvUsers);
            Controls.Add(CboxOffices);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
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