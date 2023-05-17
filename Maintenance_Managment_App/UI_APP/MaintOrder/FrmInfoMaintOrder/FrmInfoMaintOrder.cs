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
            this.txb_MaintOrderId.Text = Controller.MaintOrder_PrintParameter("ID", this.maintOrderId);
            this.txb_MaintOrderUser.Text = Controller.MaintOrder_PrintParameter("USERNAME", this.maintOrderId);
            this.txb_MaintOrderSector.Text = Controller.MaintOrder_PrintParameter("SECTION", this.maintOrderId);
            this.txb_MaintOrderMachine.Text = Controller.MaintOrder_PrintParameter("MACHINE", this.maintOrderId);
            this.txb_MaintOrderUrgency.Text = Controller.MaintOrder_PrintParameter("URGENCY", this.maintOrderId);
            string message = Controller.MaintOrder_PrintParameter("DESCRIPTION", this.maintOrderId);
            if (message == string.Empty)
            {
                this.rtb_MaintOrderDesc.Text = "No se agrego descripcion.";
            }
            else
            {
                this.rtb_MaintOrderDesc.Text = message;
            }
            this.txb_MaintOrderAntiq.Text = Controller.MaintOrder_PrintParameter("ANTIQUITY", this.maintOrderId);
            if (Controller.MaintOrder_GetStatus(this.maintOrderId))
            {
                this.lbl_Antiquity.Visible = false;
                this.lbl_Days.Visible = false;
                this.txb_MaintOrderAntiq.Visible = false;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
