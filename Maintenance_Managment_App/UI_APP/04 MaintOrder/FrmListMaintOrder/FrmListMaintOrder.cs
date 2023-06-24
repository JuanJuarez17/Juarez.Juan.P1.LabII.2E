using DATABASE_APP;
using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_APP
{
    public partial class FrmListMaintOrder : Form
    {
        #region ATTRIBUTES
        private User activeUser;
        private Form activeForm;
        private DbEntityMaintOrder dbMaintOrder;
        private int flagCreationDateSort = 0;
        private int flagSectionSort = 0;
        private int flagMachineSort = 0;
        private int flagUrgencySort = 0;
        private Logs logsRecord;
        private event Action<string, string> LogsNotification;

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
            if (this.dbMaintOrder.Count("ACTIVE", "1") > 0)
            {
                this.dtg_MaintOrderDb.Visible = true;
                this.lbl_MaintOrderDb.Visible = false;
                this.btn_InfoMaintOrder.Enabled = true;
                this.btn_EditMaintOrder.Enabled = true;
                this.btn_DeleteMaintOrder.Enabled = true;
                this.gpb_ShowMaintOrders.Enabled = true;
                this.gpb_ListOrder.Enabled = true;
                this.gpb_Reports.Enabled = true;
                this.rdb_ActiveMaintOrders.Checked = true;
            }
            else
            {
                this.dtg_MaintOrderDb.Visible = false;
                this.lbl_MaintOrderDb.Visible = true;
                this.lbl_MaintOrderDb.Text = "No hay ordenes de mantenimiento activas.";
                this.btn_InfoMaintOrder.Enabled = false;
                this.btn_EditMaintOrder.Enabled = false;
                this.btn_DeleteMaintOrder.Enabled = false;
                this.gpb_ShowMaintOrders.Enabled = false;
                this.gpb_ListOrder.Enabled = false;
                this.gpb_Reports.Enabled = false;
            }
        }
        public void FrmListMaintenanceOrder_LoadDataGrid<T>(List<T> inputDataSource) where T : class
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
        public List<MaintenanceOrder> GetDataGridElements()
        {
            List<MaintenanceOrder> list = new List<MaintenanceOrder>();
            if (this.dtg_MaintOrderDb != null)
            {
                for (int i = 0; i < this.dtg_MaintOrderDb.RowCount; i++)
                {
                    list.Add((MaintenanceOrder)this.dtg_MaintOrderDb.Rows[i].DataBoundItem);
                }
            }
            return list;
        }
        #endregion

        #region EVENT METHODS
        private void FrmListMaintenanceOrder_Load(object sender, EventArgs e)
        {
            this.logsRecord = new Logs();
            LogsNotification += this.logsRecord.GenerateLog;
            this.btn_AddMaintOrder.ImageIndex = 0;
            this.btn_InfoMaintOrder.ImageIndex = 5;
            this.btn_EditMaintOrder.ImageIndex = 1;
            this.btn_DeleteMaintOrder.ImageIndex = 2;
            this.btn_ExportCsv.ImageIndex = 13;
            this.btn_ExportJson.ImageIndex = 14;
            this.btn_SortByDate.ImageIndex = 10;
            this.btn_SortBySector.ImageIndex = 7;
            this.btn_SortByMachine.ImageIndex = 9;
            this.btn_SortByUrgency.ImageIndex = 8;
            this.btn_ShowMaintOrders.ImageIndex = 11;
            try
            {
                this.dbMaintOrder = new DbEntityMaintOrder();
                FrmListMaintenanceOrder_LoadDataGrid(this.dbMaintOrder.Import());
                FrmListMaintenanceOrder_AvailableFunctions();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_AddMaintOrder_MouseHover(object sender, EventArgs e)
        {
            this.tlt_Help.Show("Crear Orden Mantenimiento", this.btn_AddMaintOrder);
        }
        private void btn_AddMaintOrder_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmAddMaintOrder(this.activeUser), out DialogResult result);
            if (result == DialogResult.OK)
            {
                try
                {             
                    string idAdded = this.dbMaintOrder.GetLast("ID");
                    FrmListMaintenanceOrder_LoadDataGrid(dbMaintOrder.Import());
                    FrmListMaintenanceOrder_AvailableFunctions();
                    if (LogsNotification is not null)
                    {
                        LogsNotification.Invoke(this.activeUser.Username, $"Agrego Orden de Mantenimiento ID {idAdded}");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                try
                {
                    FrmListMaintenanceOrder_LoadDataGrid(this.dbMaintOrder.Import());
                    if (LogsNotification is not null)
                    {
                        LogsNotification.Invoke(this.activeUser.Username, $"Modifico Orden de Mantenimiento ID {selectedId}");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
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
                try
                {
                    this.dbMaintOrder.Delete(selectedId.ToString());
                    FrmListMaintenanceOrder_LoadDataGrid(this.dbMaintOrder.Import());
                    FrmListMaintenanceOrder_AvailableFunctions();
                    if (LogsNotification is not null)
                    {
                        LogsNotification.Invoke(this.activeUser.Username, $"Elimino Orden de Mantenimiento ID {selectedId}");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btn_ShowMaintOrders_Click(object sender, EventArgs e)
        {
            if (this.rdb_ActiveMaintOrders.Checked)
            {
                FrmListMaintenanceOrder_LoadDataGrid(this.dbMaintOrder.Import());
            }
            else if (this.rdb_CompletedMaintOrders.Checked)
            {
                FrmListMaintenanceOrder_LoadDataGrid(this.dbMaintOrder.Import("ACTIVE", "1", "COMPLETED", "1"));
            }
            else if (this.rdb_UncompletedMaintOrders.Checked)
            {
                FrmListMaintenanceOrder_LoadDataGrid(this.dbMaintOrder.Import("ACTIVE", "1", "COMPLETED", "0"));
            }

        }
        private void bnt_ExportCsv_Click(object sender, EventArgs e)
        {
            if (MaintenanceOrder.SaveAsText(GetDataGridElements()))
            {
                MessageBox.Show("Informe CSV exportado con exito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo exportar el informe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ExportJson_Click(object sender, EventArgs e)
        {          
            if (MaintenanceOrder.SerializeToJson(GetDataGridElements()))
            {
                MessageBox.Show("Informe JSON exportado con exito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo exportar el informe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_SortByDate_Click(object sender, EventArgs e)
        {
            if (this.flagCreationDateSort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "CREATION_DATE", this.flagCreationDateSort));
                this.flagCreationDateSort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "CREATION_DATE", this.flagCreationDateSort));
                this.flagCreationDateSort = 0;
            }
        }
        private void btn_SortBySector_Click(object sender, EventArgs e)
        {
            if (this.flagSectionSort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "SECTION", this.flagSectionSort));
                this.flagSectionSort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "SECTION", this.flagSectionSort));
                this.flagSectionSort = 0;
            }
        }
        private void btn_SortByMachine_Click(object sender, EventArgs e)
        {
            if (this.flagMachineSort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "MACHINE", this.flagMachineSort));
                this.flagMachineSort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "MACHINE", this.flagMachineSort));
                this.flagMachineSort = 0;
            }
        }
        private void btn_SortByUrgency_Click(object sender, EventArgs e)
        {
            if (this.flagUrgencySort == 0)
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "URGENCY", this.flagUrgencySort));
                this.flagUrgencySort = 1;
            }
            else
            {
                FrmListMaintenanceOrder_LoadDataGrid(MaintenanceOrder.Sort(GetDataGridElements(), "URGENCY", this.flagUrgencySort));
                this.flagUrgencySort = 0;
            }
        }
        #endregion



    }
}
