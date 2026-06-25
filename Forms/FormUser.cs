using DataClass;
using ModelsData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Forms
{
    public partial class FormOffices : Form
    {
        UserDAO userDAO = new();
        OfficesDAO officesDAO = new();
        User seleccionado;

        string Email = string.Empty;

        public FormOffices(string email)
        {
            Email = email;
            InitializeComponent();

            VerificarUser();

            CargarOficinas();
            CboxOffices.SelectedIndex = 0;

        }
        private void CargarOficinas()
        {
            CboxOffices.Items.Add("All offices");
            foreach (var o in officesDAO.GetListOffices())
            {
                CboxOffices.Items.Add(o.OfficeName);
            }
        }
        public void CargarDatos()
        {
            dgvUsers.DataSource = null;

            dgvUsers.DataSource = userDAO.FiltrarUsuarios(CboxOffices.Text);

            dgvUsers.Columns["UserId"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.Columns["BirthDay"].Visible = false;
            dgvUsers.Columns["Active"].Visible = false;

            pintarFilas();
        }

        public void VerificarUser()
        {
            lblRol.Text = $"Bienvenido señor(a) {userDAO.GetRol(Email)}";
            btnChangeRol.Visible = userDAO.GetRol(Email) != "User";
            addUserToolStripMenuItem.Visible = userDAO.GetRol(Email) != "User";
            btnEnabledUsers.Visible = userDAO.GetRol(Email) != "User";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboxOffices_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void pintarFilas()
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.Cells["Active"].Value?.ToString() == "True")
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;

                    // row.DefaultCellStyle.BackColor = Color.LightGreen;
                    if (row.Cells[2].Value?.ToString() != "User")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void FormOffices_Load(object sender, EventArgs e)
        {
            pintarFilas();
        }

        private void btnChangeRol_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChangeRol formChangeRol = new(seleccionado);
            formChangeRol.ShowDialog();
            this.Visible = true;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAddUser formAddUser = new();
            formAddUser.ShowDialog();
            CargarDatos();
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var empleado = e.RowIndex;
            var list = userDAO.GetListUsers();
            seleccionado = list[empleado];
        }
    }
}
