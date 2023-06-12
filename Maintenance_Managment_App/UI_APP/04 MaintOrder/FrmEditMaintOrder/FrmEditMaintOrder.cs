using CONTROLLER_APP;
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
            this.btn_Accept.ImageIndex = 3;
            this.btn_Cancel.ImageIndex = 4;
            this.txb_MaintOrderId.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "ID");
            this.txb_MaintOrderUser.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "USERNAME");
            this.cbb_Section.DataSource = Enum.GetValues(typeof(Section));
            this.cbb_Machine.DataSource = Enum.GetValues(typeof(Machine));
            this.cbb_Urgency.DataSource = Enum.GetValues(typeof(Urgency));
            this.cbb_Section.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "SECTION");
            this.cbb_Machine.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "MACHINE");
            this.cbb_Urgency.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "URGENCY");
            this.rtb_MaintOrderDesc.Text =SqlServerConnection.PrintParameter(this.maintOrderId, "DESCRIPTION");
            if (SqlServerConnection.PrintParameter(this.maintOrderId, "STATUS") == "True")
            {
                this.chb_Completed.Checked = true;
            }
        }
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Section inputSection = (Section)this.cbb_Section.SelectedItem;
            Machine inputMachine = (Machine)this.cbb_Machine.SelectedItem;
            Urgency inputUrgency = (Urgency)this.cbb_Urgency.SelectedItem;
            string inputDescription = this.rtb_MaintOrderDesc.Text;
            bool inputStatus = false;
            if (this.chb_Completed.Checked) { inputStatus = true; }
            else { inputStatus = false; }
            // TODO: Reemplaza Controller.MaintOrder_Parse por otro metodo llamado desde otro lado
            if (Controller.MaintOrder_Parse(inputDescription))
            {
                //if (Controller.MaintOrder_Edit(this.maintOrderId, inputMachine, inputSection, inputUrgency, inputDescription, inputStatus))
                try
                {
                    SqlServerConnection.Update(this.maintOrderId, inputSection, inputMachine, inputUrgency, inputDescription, inputStatus);
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
