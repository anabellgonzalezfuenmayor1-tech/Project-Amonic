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
        RolDao rolDao = new RolDao();
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
                int roleId = 0;
                int officeId = 0;
                string rolSeleccionado;
                if (rbUser.Checked)
                {
                    rolSeleccionado = "User";
                }
                else
                {
                    rolSeleccionado = "Administrator";
                }

                foreach (var rol in rolDao.GetListRoles()){
                    if (rol.title == rolSeleccionado)
                    {
                        roleId = rol.RolId;
                    }
                }
                foreach (var of in officesDAO.GetListOffices())
                {
                    if (of.OfficeName == cboxOffices.Text)
                    {
                        officeId = of.OfficeId;
                    }
                }
                userDAO.ActualizarDatos(Seleccionado.UserId, txtAdress.Text, txtFname.Text, txtLname.Text, officeId, roleId);
                MessageBox.Show("Updated data correctly");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete all the inputs", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
