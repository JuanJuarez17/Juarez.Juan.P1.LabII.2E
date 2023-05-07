using CONTROLLER_APP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_APP
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Access_Click(object sender, EventArgs e)
        {
            string inputUsername = txb_Username.Text;
            string inputPassword = txb_Password.Text;
            if (Controller.CheckUser(inputUsername, inputPassword) == 1)
            {
                FrmMainMenu frmMainMenu = new FrmMainMenu(Controller.ReturnUser(inputUsername));
                frmMainMenu.Show();
                this.Hide();
            }
            else if (Controller.CheckUser(inputUsername, inputPassword) == 0)
            {
                string msbTitulo = "Error";
                string msbMensaje = "Usuario y/o contraseña incorrectos";
                MessageBox.Show(msbMensaje, msbTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string msbTitulo = "Error";
                string msbMensaje = "Ingrese usuario y contraseña";
                MessageBox.Show(msbMensaje, msbTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Autocomplete_Click(object sender, EventArgs e)
        {            
            string msbTitulo = "Atencion";
            string msbMensaje = "Se aucompletaran los campos usuario y contraseña";
            MessageBox.Show(msbMensaje, msbTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            txb_Username.Text = "Admin";
            txb_Password.Text = "asd123";
        }
    }
}
