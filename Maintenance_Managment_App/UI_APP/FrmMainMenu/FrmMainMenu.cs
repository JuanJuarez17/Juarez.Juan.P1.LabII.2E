using CONTROLLER_APP;
using ENTITIES_APP;
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
    public partial class FrmMainMenu : Form
    {
        #region ATTRIBUTES
        private User activeUser;
        private Form activeForm;
        #endregion

        #region PROPERTIES
        private User User
        {
            get { return this.activeUser; }
        }
        #endregion

        #region CONSTRUCTOR
        private FrmMainMenu()
        {
            InitializeComponent();
        }
        public FrmMainMenu(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }
        #endregion

        #region METHODS
        private void HideForm()
        {
            if (activeForm is not null)
            {
                activeForm.Close();
            }
        }
        private void ActivateForm(Form form)
        {
            try
            {
                HideForm();
                this.activeForm = form;
                this.activeForm.MdiParent = this;
                this.activeForm.Dock = DockStyle.Fill;
                this.activeForm.BringToFront();
                this.activeForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex.Message}, Reiniciar la aplicacion");
            }
        }
        private void FrmMainMenu_Info()
        {
            // CARGA lbl_User
            StringBuilder lblUserTxt = new StringBuilder();
            lblUserTxt.Append("Usuario: ");
            if (this.activeUser.Admin)
            {
                lblUserTxt.Append("Supervisor");
            }
            else
            {
                lblUserTxt.Append("Operario");
            }
            lblUserTxt.Append(" / ");
            lblUserTxt.Append(this.activeUser.Username);
            tss_User.Text = lblUserTxt.ToString();

            // CARGA lbl_Info
            StringBuilder lblInfoTxt = new StringBuilder();
            lblInfoTxt.Append(DateTime.Now.ToString("dd/MM/yyyy"));
            lblInfoTxt.Append(" / ");
            lblInfoTxt.Append(DateTime.Now.ToString("HH:mm"));
            lblInfoTxt.Append(" / ");
            lblInfoTxt.Append("v1.02");
            tss_Status.Text = lblInfoTxt.ToString();
        }
        private void FrmMainMenu_AvailableFunctions()
        {
            if (!this.activeUser.Admin)
            {
                smi_Operator.Visible = false;
                // TODO: Enable = false los desactiva peor no los oculta, Visible = false los oculta
            }
        }
        #endregion

        #region EVENT METHODS
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            FrmMainMenu_Info();
            FrmMainMenu_AvailableFunctions();
        }
        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void smi_MaintOrder_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmListMaintOrder(this.User));
        }
        #endregion
    }
}
