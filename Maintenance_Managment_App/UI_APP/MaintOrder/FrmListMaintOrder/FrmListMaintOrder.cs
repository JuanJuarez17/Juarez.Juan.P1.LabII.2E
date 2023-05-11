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
    public partial class FrmListMaintOrder : Form
    {
        #region ATTRIBUTES
        private User activeUser;
        private Form activeForm;
        #endregion

        #region CONSTRUCTOR
        private FrmListMaintOrder()
        {
            InitializeComponent();
        }
        public FrmListMaintOrder(User inputUser) : this()
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
        public static void FrmListMaintenanceOrder_LoadDataGrid(DataGridView drv)
        {
            if (Controller.MaintOrderDb.Count > 0)
            {
                drv.DataSource = null;
                drv.DataSource = Controller.MaintOrderDb;
                drv.Columns["User"].Visible = false;
                drv.Columns["Description"].Visible = false;
                drv.Columns["Completed"].Visible = false;
                drv.Columns["EndDate"].Visible = false;
                drv.Columns["Antiquity"].Visible = false;
                drv.Columns[0].HeaderText = "ID ORDEN";
                drv.Columns[2].HeaderText = "GENERÓ";
                drv.Columns[3].HeaderText = "SECCCIÓN";
                drv.Columns[4].HeaderText = "UNIDAD";
                drv.Columns[5].HeaderText = "URGENCIA";
                drv.Columns[6].HeaderText = "FECHA DE INGRESO";
                drv.Visible = true;
            }
            else
            {
                drv.Visible = false;
            }
        }
        #endregion

        #region EVENT METHODS
        private void FrmListMaintenanceOrder_Load(object sender, EventArgs e)
        {
            this.btn_AddMaintOrder.ImageIndex = 0;
            this.btn_InfoMaintOrder.ImageIndex = 5;
            this.btn_EditMaintOrder.ImageIndex = 1;
            this.btn_DeleteMaintOrder.ImageIndex = 2;
            this.btn_Close.ImageIndex = 3;
            FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
        }
        private void btn_AddMaintOrder_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmAddMaintOrder(this.User), out DialogResult result);
            if (result == DialogResult.OK)
            {
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
            }
            else
            {
                MessageBox.Show("Carga cancelada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_InfoMaintOrder_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_MaintOrderDb.CurrentRow.Cells[0].Value;
            ActivateForm(new FrmInfoMaintOrder(selectedId), out DialogResult result);
        }
        private void btn_DeleteMaintOrder_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_MaintOrderDb.CurrentRow.Cells[0].Value;
            DialogResult respuesta = MessageBox.Show($"¿Eliminar OM {selectedId}?{Environment.NewLine}Esta accion es inrreversible", "Eliminar Orden de Mantenimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                Controller.RemoveMaintOrder(selectedId);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
