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
        public static void FrmListMaintenanceOrder_LoadDataGrid(DataGridView inputDtg, Label inputLabel)
        {
            if (Controller.MaintOrderDb.Count > 0)
            {
                Controller.MaintOrder_LoadActiveOrders();
                inputDtg.DataSource = null;
                inputDtg.DataSource = Controller.ActiveMaintOrders;
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
                inputDtg.Visible = true;
                inputLabel.Visible = false;
            }
            else
            {
                inputDtg.Visible = false;
                inputLabel.Visible = true;
            }
        }
        #endregion

        #region EVENT METHODS
        private void FrmListMaintenanceOrder_Load(object sender, EventArgs e)
        {
            this.btn_ImportDb.ImageIndex = 6;
            this.btn_AddMaintOrder.ImageIndex = 0;
            this.btn_InfoMaintOrder.ImageIndex = 5;
            this.btn_EditMaintOrder.ImageIndex = 1;
            this.btn_DeleteMaintOrder.ImageIndex = 2;
            this.btn_Close.ImageIndex = 3;
            FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb, this.lbl_MaintOrderDb);
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
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb, this.lbl_MaintOrderDb);
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
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb, this.lbl_MaintOrderDb);
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
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb, this.lbl_MaintOrderDb);
            }
            else
            {
                MessageBox.Show("Modificacion cancelada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_DeleteMaintOrder_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_MaintOrderDb.CurrentRow.Cells[0].Value;
            DialogResult respuesta = MessageBox.Show($"¿Eliminar OM {selectedId}?{Environment.NewLine}Esta accion es inrreversible", "Eliminar Orden de Mantenimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                Controller.MaintOrder_Remove(selectedId);
                FrmListMaintenanceOrder_LoadDataGrid(this.dtg_MaintOrderDb, this.lbl_MaintOrderDb);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
