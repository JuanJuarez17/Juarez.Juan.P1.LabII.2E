using DATABASE_APP;
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
    public partial class FrmEditMaintOrder : Form
    {
        private int maintOrderId;
        private FrmEditMaintOrder()
        {
            InitializeComponent();
        }
        public FrmEditMaintOrder(int inputMaintOrderId) : this()
        {
            this.maintOrderId = inputMaintOrderId;
        }
        private void FrmEditMaintOrder_Load(object sender, EventArgs e)
        {
            DbMaintOrder dbMaintOrder = new DbMaintOrder();
            MaintenanceOrder auxMaintOrder = dbMaintOrder.Read(this.maintOrderId.ToString());
            this.btn_Accept.ImageIndex = 3;
            this.btn_Cancel.ImageIndex = 4;
            this.txb_MaintOrderId.Text = auxMaintOrder.Id.ToString();
            this.txb_MaintOrderUser.Text = auxMaintOrder.Username.ToString();
            this.cbb_Section.DataSource = Enum.GetValues(typeof(Section));
            this.cbb_Machine.DataSource = Enum.GetValues(typeof(Machine));
            this.cbb_Urgency.DataSource = Enum.GetValues(typeof(Urgency));
            this.cbb_Section.Text = auxMaintOrder.Section.ToString();
            this.cbb_Machine.Text = auxMaintOrder.Machine.ToString();
            this.cbb_Urgency.Text = auxMaintOrder.Urgency.ToString();
            this.rtb_MaintOrderDesc.Text = auxMaintOrder.Description.ToString();
            if (auxMaintOrder.Completed.ToString() == "True")
            {
                this.chb_Completed.Checked = true;
            }
        }
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string inputSection = ((Section)this.cbb_Section.SelectedItem).ToString();
            string inputMachine = ((Machine)this.cbb_Machine.SelectedItem).ToString();
            string inputUrgency = ((Urgency)this.cbb_Urgency.SelectedItem).ToString();
            string inputDescription = this.rtb_MaintOrderDesc.Text;
            bool inputStatus;
            if (this.chb_Completed.Checked) { inputStatus = true; }
            else { inputStatus = false; }
            // TODO: Reemplaza Controller.MaintOrder_Parse por otro metodo llamado desde otro lado
            if (MaintenanceOrder.ValidateEntries(inputDescription))
            {
                try
                {
                    DbMaintOrder dbMaintOrder = new DbMaintOrder();
                    dbMaintOrder.Update(this.maintOrderId.ToString(), "SECTION", inputSection);
                    dbMaintOrder.Update(this.maintOrderId.ToString(), "MACHINE", inputMachine);
                    dbMaintOrder.Update(this.maintOrderId.ToString(), "URGENCY", inputUrgency);
                    dbMaintOrder.Update(this.maintOrderId.ToString(), "DESCR", inputDescription);
                    dbMaintOrder.Update(this.maintOrderId.ToString(), "COMPLETED", inputStatus.ToString());
                    if (inputStatus)
                    {
                        dbMaintOrder.Update(this.maintOrderId.ToString(), "END_DATE", DateTime.Now.ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        dbMaintOrder.Update(this.maintOrderId.ToString(), "END_DATE", new DateTime(1753,01,01).ToString("yyyy-MM-dd"));
                    }
                    MessageBox.Show($"Orden de mantenimiento {this.maintOrderId} modificada.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo agregar la orden a la base de datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo ingresado incorrectamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
