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
    public partial class FormChangeRol : Form
    {
        List<Office> oficinas = new();
        OfficesDAO officesDAO = new();
        UserDAO userDAO = new();
        User Seleccionado;
        int officeIndex;

        public FormChangeRol(User seleccionado)
        {
            this.Seleccionado = seleccionado;
            InitializeComponent();
            CargarOficinas();
            CargarDatos();


        }
        private void CargarOficinas()
        {
            foreach (var o in officesDAO.GetListOffices())
            {
                cboxOffices.Items.Add(o.OfficeName);
            }

            cboxOffices.SelectedIndex = officeIndex;
        }
        private void CargarDatos()
        {
            txtAdress.Text = Seleccionado.Email;
            txtFname.Text = Seleccionado.FirstName;
            txtLname.Text = Seleccionado.LastName;
              

            cboxOffices.SelectedIndex = officeIndex >= 0 ? officeIndex : -1;
            rbAdministrador.Checked = Seleccionado.RolName != "User";
            rbUser.Checked = Seleccionado.RolName == "User";

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLname.Text) && !string.IsNullOrEmpty(txtAdress.Text) && !string.IsNullOrEmpty(txtFname.Text))
            {

            

                int officeID = oficinas[cboxOffices.SelectedIndex].OfficeId;
                int roleID = rbAdministrador.Checked ? 1 : 2;

                userDAO.ActualizarDatos(
                    Seleccionado.UserId,
                    txtAdress.Text.Trim(),
                    txtFname.Text.Trim(),
                    txtLname.Text.Trim(),
                    officeID,
                    roleID
                    );
                MessageBox.Show("Usuario actualizado con exito", "Actulizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Porfavor completa todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
