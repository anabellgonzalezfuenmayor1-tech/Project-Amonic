using DataClass;
using ModelsData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormAddUser : Form
    {
        OfficesDAO officesDAO = new OfficesDAO();
        UserDAO userDAO = new UserDAO();
        User user = new();
        
        public FormAddUser()
        {
            InitializeComponent();

            CargarOficinas();
            cbOffices.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarOficinas()
        {
            foreach (var o in officesDAO.GetListOffices())
            {
                cbOffices.Items.Add(o.OfficeName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtFirstName.Text) ||
               string.IsNullOrWhiteSpace(txtLastName.Text) ||
               string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please, complete all the inputs");
                return;
            }

            string officeNameSeleccionado = cbOffices.SelectedItem?.ToString();

            var oficinaSeleccionada = officesDAO.GetListOffices().FirstOrDefault(o => o.OfficeName == officeNameSeleccionado);

            string email = txtEmail.Text.Trim().ToLower();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime birthDate = dtCumpleano.Value;
            string password = txtPass.Text.Trim();
            int officeId = oficinaSeleccionada.OfficeId;
            int roleId = 2;
            if (birthDate <= DateTime.Now)
            {
                if (userDAO.GetListUsers().Any(u => u.Email == email))
                {
                    MessageBox.Show("This User Exist.");

                }
                else
                {
                    bool exito = userDAO.InsertUser(email, password, firstName, lastName, birthDate, officeId, roleId);

                    if (exito)
                    {
                        MessageBox.Show("User created correctly.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Can't create the user. Try Again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid date of birth");
            }
        }
    }
}
