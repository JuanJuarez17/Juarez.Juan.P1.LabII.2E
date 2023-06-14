using CONTROLLER_APP;
using DATABASE_APP;
using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int flagCreationDateSort = 0;
        int flagSectionSort = 0;
        int flagMachineSort = 0;
        int flagPrioritySort = 0;

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
        private void FrmListMaintenanceOrder_AvailableFunctions()
        {
            // Users Permissions
            if (!this.activeUser.Admin)
            {
                this.btn_EditMaintOrder.Visible = false;
                this.btn_DeleteMaintOrder.Visible = false;
            }
            // Datagridview Permissions
            if (SqlServerConnection.ImportedDbFlag)
            {
                this.btn_ImportDb.Enabled = false;
                this.dtg_MaintOrderDb.Visible = true;
                this.lbl_MaintOrderDb.Visible = false;
                this.btn_SaveDb.Enabled = true;
                this.btn_AddMaintOrder.Enabled = true;
                this.btn_InfoMaintOrder.Enabled = true;
                this.btn_EditMaintOrder.Enabled = true;
                this.btn_DeleteMaintOrder.Enabled = true;
                this.gpb_ShowMaintOrders.Enabled = true;
                this.rdb_ActiveMaintOrders.Checked = true;
                if (SqlServerConnection.Count("ACTIVE") == 0)
                {
                    this.dtg_MaintOrderDb.Visible = false;
                    this.lbl_MaintOrderDb.Visible = true;
                    this.lbl_MaintOrderDb.Text = "No hay ordenes de mantenimiento activas.";
                    this.btn_InfoMaintOrder.Enabled = false;
                    this.btn_EditMaintOrder.Enabled = false;
                    this.btn_DeleteMaintOrder.Enabled = false;
                }
            }
            else
            {
                this.dtg_MaintOrderDb.Visible = false;
                this.lbl_MaintOrderDb.Visible = true;
                this.btn_ImportDb.Enabled = true;
                this.btn_SaveDb.Enabled = false;
                this.btn_AddMaintOrder.Enabled = false;
                this.btn_InfoMaintOrder.Enabled = false;
                this.btn_EditMaintOrder.Enabled = false;
                this.btn_DeleteMaintOrder.Enabled = false;
                this.gpb_ShowMaintOrders.Enabled = false;
            }
        }
        public void FrmListMaintenanceOrder_LoadDataGrid<T>(List<T> inputDataSource) where T : class
        {
            if (SqlServerConnection.ImportedDbFlag && SqlServerConnection.Count("ACTIVE") > 0)
            {
                this.dtg_MaintOrderDb.DataSource = null;
                this.dtg_MaintOrderDb.DataSource = inputDataSource;
                this.dtg_MaintOrderDb.Columns["Active"].Visible = false;
                this.dtg_MaintOrderDb.Columns["Description"].Visible = false;
                this.dtg_MaintOrderDb.Columns["Antiquity"].Visible = false;
                this.dtg_MaintOrderDb.Columns[0].HeaderText = "ID ORDEN";
                this.dtg_MaintOrderDb.Columns[2].HeaderText = "GENERÓ";
                this.dtg_MaintOrderDb.Columns[3].HeaderText = "SECCCIÓN";
                this.dtg_MaintOrderDb.Columns[4].HeaderText = "UNIDAD";
                this.dtg_MaintOrderDb.Columns[5].HeaderText = "URGENCIA";
                this.dtg_MaintOrderDb.Columns[6].HeaderText = "INGRESO";
                this.dtg_MaintOrderDb.Columns[8].HeaderText = "COMPLETADA";
                this.dtg_MaintOrderDb.Columns[9].HeaderText = "FINALIZADA";
            }
        }
        #endregion

        #region EVENT METHODS
        private void FrmListMaintenanceOrder_Load(object sender, EventArgs e)
        {
            this.btn_ImportDb.ImageIndex = 6;
            this.btn_SaveDb.ImageIndex = 12;
            this.btn_AddMaintOrder.ImageIndex = 0;
            this.btn_InfoMaintOrder.ImageIndex = 5;
            this.btn_EditMaintOrder.ImageIndex = 1;
            this.btn_DeleteMaintOrder.ImageIndex = 2;
            this.btn_SortByDate.ImageIndex = 10;
            this.btn_SortBySector.ImageIndex = 7;
            this.btn_SortByMachine.ImageIndex = 9;
            this.btn_SortByUrgency.ImageIndex = 8;
            this.btn_ShowMaintOrders.ImageIndex = 11;
            FrmListMaintenanceOrder_AvailableFunctions();
            if (!SqlServerConnection.ImportedDbFlag)
            {
                FrmListMaintenanceOrder_LoadDataGrid(new List<object>());
            }
            else
            {
                try
                {
                    FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("ACTIVE"));
                    FrmListMaintenanceOrder_AvailableFunctions();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btn_ImportDb_MouseHover(object sender, EventArgs e)
        {
            this.tlt_Help.Show("Importar Base de Datos", this.btn_ImportDb);
        }
        private void btn_AddMaintOrder_MouseHover(object sender, EventArgs e)
        {
            this.tlt_Help.Show("Crear Orden Mantenimiento", this.btn_AddMaintOrder);
        }
        private void btn_ImportDb_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("ACTIVE"));
                FrmListMaintenanceOrder_AvailableFunctions();
                MessageBox.Show("Base de datos importada con exito.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_AddMaintOrder_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmAddMaintOrder(this.User), out DialogResult result);
            if (result == DialogResult.OK)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("ACTIVE"));
                FrmListMaintenanceOrder_AvailableFunctions();
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
        private void btn_EditMaintOrder_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_MaintOrderDb.CurrentRow.Cells[0].Value;
            ActivateForm(new FrmEditMaintOrder(selectedId), out DialogResult result);
            if (result == DialogResult.OK)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("ACTIVE"));
            }
            else
            {
                MessageBox.Show("Modificacion cancelada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_DeleteMaintOrder_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_MaintOrderDb.CurrentRow.Cells[0].Value;
            DialogResult respuesta = MessageBox.Show($"¿Eliminar OM {selectedId}?\nEsta accion es inrreversible", "Eliminar Orden de Mantenimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                SqlServerConnection.Delete(selectedId);
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("ACTIVE"));
                FrmListMaintenanceOrder_AvailableFunctions();
            }
        }

        private void btn_ShowMaintOrders_Click(object sender, EventArgs e)
        {
            if (this.rdb_ActiveMaintOrders.Checked)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("ACTIVE"));
            }
            else if (this.rdb_CompletedMaintOrders.Checked)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("COMPLETED"));
            }
            else if (this.rdb_UncompletedMaintOrders.Checked)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.ImportDb("UNCOMPLETED"));
            }

        }




        private void btn_SortByDate_Click(object sender, EventArgs e)
        {
            if (this.flagCreationDateSort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("DATE"));
                this.flagCreationDateSort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("DATE"));
                this.flagCreationDateSort = 0;
            }
        }
        private void btn_SortBySector_Click(object sender, EventArgs e)
        {
            if (this.flagSectionSort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("SECTION"));
                this.flagSectionSort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("SECTION"));
                this.flagSectionSort = 0;
            }
        }
        private void btn_SortByMachine_Click(object sender, EventArgs e)
        {
            if (this.flagMachineSort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("MACHINE"));
                this.flagMachineSort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("MACHINE"));
                this.flagMachineSort = 0;
            }
        }
        private void btn_SortByUrgency_Click(object sender, EventArgs e)
        {
            if (this.flagPrioritySort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("URGENCY"));
                this.flagPrioritySort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(SqlServerConnection.Sort("URGENCY"));
                this.flagPrioritySort = 0;
            }
        }
        #endregion

    }
}
