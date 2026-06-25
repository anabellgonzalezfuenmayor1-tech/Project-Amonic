namespace Forms
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnLogin = new Button();
            btnExit = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            checkMostrar = new CheckBox();
            timeIntentos = new System.Windows.Forms.Timer(components);
            lblEspere = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.Location = new Point(137, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(235, 244);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(166, 161);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(215, 23);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(166, 203);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(215, 23);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 164);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 211);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkMostrar
            // 
            checkMostrar.AutoSize = true;
            checkMostrar.Location = new Point(387, 206);
            checkMostrar.Name = "checkMostrar";
            checkMostrar.Size = new Size(67, 19);
            checkMostrar.TabIndex = 7;
            checkMostrar.Text = "Mostrar";
            checkMostrar.UseVisualStyleBackColor = true;
            checkMostrar.CheckedChanged += checkMostrar_CheckedChanged;
            // 
            // timeIntentos
            // 
            timeIntentos.Interval = 1000;
            timeIntentos.Tick += timeIntentos_Tick;
            // 
            // lblEspere
            // 
            lblEspere.AutoSize = true;
            lblEspere.Location = new Point(69, 24);
            lblEspere.Name = "lblEspere";
            lblEspere.Size = new Size(116, 15);
            lblEspere.TabIndex = 8;
            lblEspere.Text = "Espere:  10 segundos";
            lblEspere.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 298);
            Controls.Add(lblEspere);
            Controls.Add(checkMostrar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnExit;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox checkMostrar;
        private System.Windows.Forms.Timer timeIntentos;
        private Label lblEspere;
    }
}
