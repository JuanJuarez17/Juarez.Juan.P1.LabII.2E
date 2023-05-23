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

        private void ActivateForm(Form form)
        {
            form.ShowDialog();
        }

        #region EVENT METHODS
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.btn_Autocomplete.ImageIndex = 0;
            try
            {
                Controller.User_LoadDbFromText();
            }
            catch (Exception ex)
            {
                string message = ex.Message + "\nReinicie la aplicacion.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void btn_Access_Click(object sender, EventArgs e)
        {
            string inputUsername = txb_Username.Text;
            string inputPassword = txb_Password.Text;
            if (Controller.User_CheckExist(inputUsername, inputPassword) == 1)
            {
                FrmMainMenu frmMainMenu = new FrmMainMenu(Controller.User_Return(inputUsername));
                frmMainMenu.Show();
                this.Hide();
            }
            else if (Controller.User_CheckExist(inputUsername, inputPassword) == 0)
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
            FrmAutocomplete frmAutocomplete = new FrmAutocomplete();
            DialogResult result = frmAutocomplete.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txb_Username.Text = frmAutocomplete.Username;
                this.txb_Password.Text = frmAutocomplete.Password;
            }
        }
        #endregion
    }
}
