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
using UI_APP.MaintenanceOrder.FrmAddMaintenanceOrder;

namespace UI_APP
{
    public partial class FrmListMaintenanceOrder : Form
    {
        #region ATTRIBUTES
        private User activeUser;
        private Form activeForm;
        #endregion

        #region CONSTRUCTOR
        private FrmListMaintenanceOrder()
        {
            InitializeComponent();
        }
        public FrmListMaintenanceOrder(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }
        #endregion

        #region PROPERTIES
        private User User
        {
            get { return this.activeUser; }
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
        private void ActivateForm(Form form, out DialogResult result)
        {
            HideForm();
            activeForm = form;
            activeForm.BringToFront();
            result = activeForm.ShowDialog();
        }
        public static void FrmListMaintenanceOrder_LoadDataGrid(DataGridView dtg)
        {
            if (Controller.MaintOrdersDB.Count > 0)
            {
                dtg.DataSource = null;
                dtg.DataSource = Controller.MaintOrdersDB;
                dtg.Columns["User"].Visible = false;
                dtg.Columns["Description"].Visible = false;
                dtg.Columns["Completed"].Visible = false;
                dtg.Columns["EndDate"].Visible = false;
                dtg.Visible = true;
            }
            else
            {
                dtg.Visible = false;
            }
        }
        #endregion

        #region EVENT METHODS
        private void FrmListMaintenanceOrder_Load(object sender, EventArgs e)
        {
            this.btn_AddMaintOrder.ImageIndex = 0;
            this.btn_EditMaintOrder.ImageIndex = 1;
            this.btn_DeleteMaintOrder.ImageIndex = 2;
            this.btn_Close.ImageIndex = 3;
            FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDB);
        }
        private void btn_AddMaintOrder_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmAddMaintenanceOrder(this.User), out DialogResult result);
            if (result == DialogResult.OK)
            {
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDB);
            }
            else
            {
                MessageBox.Show("Carga cancelada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
