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
            DbEntityMaintOrder dbMaintOrder = new DbEntityMaintOrder();
            MaintenanceOrder auxMaintOrder = dbMaintOrder.Read(this.maintOrderId.ToString());
            this.btn_Cancel.ImageIndex = 4;
            this.txb_MaintOrderId.Text = auxMaintOrder.Id.ToString();
            this.txb_MaintOrderUser.Text = auxMaintOrder.Username.ToString();
            this.txb_MaintOrderSector.Text = auxMaintOrder.Section.ToString();
            this.txb_MaintOrderMachine.Text = auxMaintOrder.Machine.ToString();
            this.txb_MaintOrderUrgency.Text = auxMaintOrder.Urgency.ToString();
            string message = auxMaintOrder.Description.ToString();
            if (message == string.Empty)
            {
                this.rtb_MaintOrderDesc.Text = "No se agrego descripcion.";
            }
            else
            {
                this.rtb_MaintOrderDesc.Text = message;
            }
            this.txb_MaintOrderAntiq.Text = auxMaintOrder.Antiquity.ToString();
            if (auxMaintOrder.Completed.ToString() == "True")
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
