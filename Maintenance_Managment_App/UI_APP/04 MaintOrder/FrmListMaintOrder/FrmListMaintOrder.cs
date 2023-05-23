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
            if (Controller.MaintOrderDbLoaded)
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
                if (Controller.ActiveMaintOrders.Count == 0)
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
        public void FrmListMaintenanceOrder_LoadDataGrid(DataGridView inputDtg)
        {
            if (Controller.MaintOrderDb.Count > 0)
            {
                inputDtg.DataSource = null;
                if (this.rdb_ActiveMaintOrders.Checked)
                {
                    inputDtg.DataSource = Controller.ActiveMaintOrders;
                }
                else if (this.rdb_CompletedMaintOrders.Checked)
                {
                    inputDtg.DataSource = Controller.CompletedMaintOrders;
                }
                else if (this.rdb_UncompletedMaintOrders.Checked)
                {
                    inputDtg.DataSource = Controller.UncompletedMaintOrders;
                }
                inputDtg.Columns["Active"].Visible = false;
                inputDtg.Columns["User"].Visible = false;
                inputDtg.Columns["Description"].Visible = false;
                inputDtg.Columns["Antiquity"].Visible = false;
                inputDtg.Columns[0].HeaderText = "ID ORDEN";
                inputDtg.Columns[3].HeaderText = "GENERÓ";
                inputDtg.Columns[4].HeaderText = "SECCCIÓN";
                inputDtg.Columns[5].HeaderText = "UNIDAD";
                inputDtg.Columns[6].HeaderText = "URGENCIA";
                inputDtg.Columns[7].HeaderText = "INGRESO";
                inputDtg.Columns[9].HeaderText = "COMPLETADA";
                inputDtg.Columns[10].HeaderText = "FINALIZADA";
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
            FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
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
            if (Controller.MaintOrder_HardcodeDb())
            {
                FrmListMaintenanceOrder_AvailableFunctions();
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                MessageBox.Show("Base de datos importada con exito.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_AddMaintOrder_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmAddMaintOrder(this.User), out DialogResult result);
            if (result == DialogResult.OK)
            {
                FrmListMaintenanceOrder_AvailableFunctions();
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
        private void btn_EditMaintOrder_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_MaintOrderDb.CurrentRow.Cells[0].Value;
            ActivateForm(new FrmEditMaintOrder(selectedId), out DialogResult result);
            if (result == DialogResult.OK)
            {
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
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
                Controller.MaintOrder_Remove(selectedId);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                FrmListMaintenanceOrder_AvailableFunctions();
            }
        }
        private void btn_ShowMaintOrders_Click(object sender, EventArgs e)
        {
            FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
        }
        private void btn_SortByDate_Click(object sender, EventArgs e)
        {
            if (this.flagCreationDateSort == 0)
            {
                Controller.MaintOrder_Sort("DATE", this.flagCreationDateSort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagCreationDateSort = 1;
            }
            else
            {
                Controller.MaintOrder_Sort("DATE", this.flagCreationDateSort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagCreationDateSort = 0;
            }
        }
        private void btn_SortBySector_Click(object sender, EventArgs e)
        {
            if (this.flagSectionSort == 0)
            {
                Controller.MaintOrder_Sort("SECTION", this.flagSectionSort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagSectionSort = 1;
            }
            else
            {
                Controller.MaintOrder_Sort("SECTION", this.flagSectionSort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagSectionSort = 0;
            }
        }
        private void btn_SortByMachine_Click(object sender, EventArgs e)
        {
            if (this.flagMachineSort == 0)
            {
                Controller.MaintOrder_Sort("MACHINE", this.flagMachineSort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagMachineSort = 1;
            }
            else
            {
                Controller.MaintOrder_Sort("MACHINE", this.flagMachineSort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagMachineSort = 0;
            }
        }
        private void btn_SortByUrgency_Click(object sender, EventArgs e)
        {
            if (this.flagPrioritySort == 0)
            {
                Controller.MaintOrder_Sort("PRIORITY", this.flagPrioritySort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagPrioritySort = 1;
            }
            else
            {
                Controller.MaintOrder_Sort("PRIORITY", this.flagPrioritySort);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb);
                this.flagPrioritySort = 0;
            }
        }
        #endregion

        private void btn_SaveMaintOrderDb_Click(object sender, EventArgs e)
        {
            if (Controller.MaintOrder_SaveDbAsText())
            {
                MessageBox.Show("Base de datos guardada con exito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la base de datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
