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
        #region ATTRIBUTES
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT METHODS
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.btn_Autocomplete.ImageIndex = 0;
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
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Autocomplete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se aucompletaran los campos usuario y contraseña", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txb_Username.Text = "JJuarez";
            txb_Password.Text = "rty000";
        }
        #endregion
    }
}
