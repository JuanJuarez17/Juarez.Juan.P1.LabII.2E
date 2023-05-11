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
            this.txb_MaintOrderId.Text = Controller.PrintMaintOrderId(this.maintOrderId);
            this.txb_MaintOrderUser.Text = Controller.PrintMaintOrderUsername(this.maintOrderId);
            this.txb_MaintOrderSector.Text = Controller.PrintMaintOrderSection(this.maintOrderId);
            this.txb_MaintOrderMachine.Text = Controller.PrintMaintOrderMachine(this.maintOrderId);
            this.txb_MaintOrderUrgency.Text = Controller.PrintMaintOrderUrgency(this.maintOrderId);
            this.rtb_MaintOrderDesc.Text = Controller.PrintMaintOrderDescription(this.maintOrderId);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
