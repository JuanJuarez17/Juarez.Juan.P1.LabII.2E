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
    public partial class FrmInfoMaintOrder : Form
    {
        private int maintOrderId;
        private FrmInfoMaintOrder()
        {
            InitializeComponent();
        }
        public FrmInfoMaintOrder(int inputMaintOrderId) : this()
        {
            this.maintOrderId = inputMaintOrderId;
        }
        private void FrmInfoMaintOrder_Load(object sender, EventArgs e)
        {
            this.btn_Cancel.ImageIndex = 4;
            this.txb_MaintOrderId.Text = Controller.MaintOrder_PrintId(this.maintOrderId);
            this.txb_MaintOrderUser.Text = Controller.MaintOrder_PrintUsername(this.maintOrderId);
            this.txb_MaintOrderSector.Text = Controller.MaintOrder_PrintSection(this.maintOrderId);
            this.txb_MaintOrderMachine.Text = Controller.MaintOrder_PrintMachine(this.maintOrderId);
            this.txb_MaintOrderUrgency.Text = Controller.MaintOrder_PrintUrgency(this.maintOrderId);
            string message = Controller.MaintOrder_PrintDescription(this.maintOrderId);
            if (message == string.Empty)
            {
                this.rtb_MaintOrderDesc.Text = "No se agrego descripcion.";
            }
            else
            {
                this.rtb_MaintOrderDesc.Text = message;
            }
            this.txb_MaintOrderAntiq.Text = Controller.MaintOrder_PrintAntiquity(this.maintOrderId);
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
