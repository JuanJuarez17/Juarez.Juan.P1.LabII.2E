using DATABASE_APP;
using ENTITIES_APP;
using System;
using System.Windows.Forms;

namespace UI_APP
{
    public partial class FrmLogin : Form
    {
        #region ATTRIBUTES
        private DbEntityUser dbUser;
        #endregion

        public FrmLogin()
        {
            InitializeComponent();
        }
        #region EVENT METHODS
        private void FrmLogin_Load(object sender, EventArgs e)
        {

            this.btn_Autocomplete.ImageIndex = 0;
            try
            {
                this.dbUser = new DbEntityUser();
                this.dbUser.Count("ACTIVE", "1");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al importar la base de datos.\nReinicie la aplicacion.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
        private void btn_Access_Click(object sender, EventArgs e)
        {
            string inputUsername = txb_Username.Text;
            string inputPassword = txb_Password.Text;
            if (string.IsNullOrWhiteSpace(txb_Username.Text) || string.IsNullOrWhiteSpace(txb_Password.Text))
            {
                MessageBox.Show("Ingrese usuario y contrasenia.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.dbUser = new DbEntityUser();
                    User inputUser = this.dbUser.Read(inputUsername);
                    if (inputUser.CheckPassword(inputPassword))
                    {
                        FrmMainMenu frmMainMenu = new FrmMainMenu(inputUser);
                        frmMainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Usuario incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
