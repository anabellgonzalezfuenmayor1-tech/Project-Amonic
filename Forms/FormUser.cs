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
    public partial class FormUser : Form
    {
        UserDAO userDAO = new();
        string Email;
        DateTime timeIngresada;
        public FormUser(string email)
        {
            InitializeComponent();
            timeIngresada = DateTime.Now;
            timerTimeSpend.Start();
            this.Email = email;
            VerificarUser();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTimeSpend.Stop();
            this.Close();
        }

        public void VerificarUser()
        {
            lblRol.Text = $"Welcome {userDAO.GetUsuario(Email).FirstName}";
        }

        private void timerTimeSpend_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempo = DateTime.Now - timeIngresada;
            lblTiempo.Text = $"Time spent on system: {tiempo:hh\\:mm\\:ss}";
        }
    }
}
