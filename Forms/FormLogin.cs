using ModelsData;

namespace Forms
{
    public partial class FormLogin : Form
    {
        RolDao rolDao = new RolDao();
        CountryDAO countryDAO = new CountryDAO();
        OfficesDAO officesDAO = new OfficesDAO();
        UserDAO userDAO = new UserDAO();

        int errores = 1;
        int time = 10;

        public FormLogin()
        {
            InitializeComponent();
        }


        private void ValidarBotones()
        {
            btnLogin.Enabled = !string.IsNullOrEmpty(txtUser.Text) || !string.IsNullOrEmpty(txtPass.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (errores <= 3)
            {

                if (userDAO.ExistenciaUsuario(txtUser.Text))
                {
                    if (userDAO.ValidarContraseña(txtUser.Text, txtPass.Text))
                    {
                        if (userDAO.VerificarEstado(txtUser.Text))
                        {
                            if (userDAO.GetRol(txtUser.Text) != "User")
                            {
                                this.Visible = false;
                                FormManager formUser = new(txtUser.Text);
                                formUser.ShowDialog();
                                this.Visible = true;
                                txtPass.Text = string.Empty;
                                txtUser.Text = string.Empty;
                                errores = 0;

                            }
                            else
                            {
                                
                                this.Visible = false;
                                FormUser formUser = new(txtUser.Text);
                                formUser.ShowDialog();
                                this.Visible = true;
                                txtPass.Text = string.Empty;
                                txtUser.Text = string.Empty;
                                errores = 0;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Your account is disabled; please contact an administrator", "Account Status");
                            errores++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                        errores++;
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                    errores++;
                }
            }
            else
            {
                MessageBox.Show("Your user is blocked");
                lblEspere.Visible = true;
                btnLogin.Enabled = false;
                txtPass.Enabled = false;
                txtUser.Enabled = false;
                timeIntentos.Start();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            ValidarBotones();

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            ValidarBotones();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !checkMostrar.Checked;
        }

        private void timeIntentos_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                lblEspere.Text = $"Wait: {time} seconds";

            }
            else
            {
                errores = 0;
                btnLogin.Enabled = true;
                txtUser.Enabled = true;
                txtPass.Enabled = true;
                time = 10;
                lblEspere.Visible = false;
                lblEspere.Text = $"Wait: {time} seconds";
                timeIntentos.Stop();
            }
        }
    }
}
