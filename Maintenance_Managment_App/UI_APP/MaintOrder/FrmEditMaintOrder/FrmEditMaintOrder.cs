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
            this.txb_MaintOrderId.Text = Controller.MaintOrder_PrintId(this.maintOrderId);
            this.txb_MaintOrderUser.Text = Controller.MaintOrder_PrintUsername(this.maintOrderId);
            this.cbb_Section.DataSource = Enum.GetValues(typeof(Section));
            this.cbb_Machine.DataSource = Enum.GetValues(typeof(Machine));
            this.cbb_Urgency.DataSource = Enum.GetValues(typeof(Urgency));
            this.cbb_Section.Text = Controller.MaintOrder_PrintSection(this.maintOrderId);
            this.cbb_Machine.Text = Controller.MaintOrder_PrintMachine(this.maintOrderId);
            this.cbb_Urgency.Text = Controller.MaintOrder_PrintUrgency(this.maintOrderId);
            this.rtb_MaintOrderDesc.Text = Controller.MaintOrder_PrintDescription(this.maintOrderId);
        }
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Section inputSection = (Section)this.cbb_Section.SelectedItem;
            Machine inputMachine = (Machine)this.cbb_Machine.SelectedItem;
            Urgency inputUrgency = (Urgency)this.cbb_Urgency.SelectedItem;
            string inputDescription = this.rtb_MaintOrderDesc.Text;
            bool inputStatus = false;
            if (this.chb_Completed.Checked)
            {
                inputStatus = true;
            }
            if (Controller.MaintOrder_Parse(inputDescription))
            {
                if (Controller.MaintOrder_Edit(this.maintOrderId, inputMachine, inputSection, inputUrgency, inputDescription, inputStatus))
                {
                    MessageBox.Show($"Orden de mantenimiento {this.maintOrderId} modificada.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
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
