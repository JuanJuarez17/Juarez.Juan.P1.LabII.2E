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
            this.txb_MaintOrderId.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "ID");
            this.txb_MaintOrderUser.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "USERNAME");
            this.txb_MaintOrderSector.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "SECTION");
            this.txb_MaintOrderMachine.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "MACHINE");
            this.txb_MaintOrderUrgency.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "URGENCY");
            string message = SqlServerConnection.PrintParameter(this.maintOrderId, "DESCRIPTION");
            if (message == string.Empty)
            {
                this.rtb_MaintOrderDesc.Text = "No se agrego descripcion.";
            }
            else
            {
                this.rtb_MaintOrderDesc.Text = message;
            }
            this.txb_MaintOrderAntiq.Text = SqlServerConnection.PrintParameter(this.maintOrderId, "ANTIQUITY");
            if (SqlServerConnection.PrintParameter(this.maintOrderId, "STATUS") == "True")
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
