using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABASE_APP;
using ENTITIES_APP;

namespace UI_APP
{
    public partial class FrmHome : Form
    {
        private User activeUser;
        private DbEntityMaintOrder dbMaintOrder;

        private FrmHome()
        {
            InitializeComponent();
        }
        public FrmHome(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            this.lbl_Welcome.Text = $"Bienvenido {this.activeUser.Username}.";
            try
            {
                this.dbMaintOrder = new DbEntityMaintOrder();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al importar la base de datos.\nReinicie la aplicacion.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            if (this.dbMaintOrder.Count("ACTIVE", "1") == 0)
            {
                string messsage = "No hay ordenes de mantenimiento activas.";
                this.lbl_MaintOrderDb.Text = messsage;
                this.lbl_MaintOrderDb.Visible = true;
                this.lbl_FinishedOrders.Visible = false;
                this.lbl_UnfinishedOrders.Visible = false;
                this.lbl_RushOrders.Visible = false;
                this.lbl_IdRushOrders.Visible = false;
                this.txb_FinishedOrders.Visible = false;
                this.txb_UnfinishedOrders.Visible = false;
                this.txb_RushOrders.Visible = false;
                this.txb_IdRushOrders.Visible = false;
            }
            else
            {
                this.lbl_MaintOrderDb.Visible = false;
                this.txb_FinishedOrders.Text = this.dbMaintOrder.Count("ACTIVE", "1", "COMPLETED", "1").ToString();
                this.txb_UnfinishedOrders.Text = this.dbMaintOrder.Count("ACTIVE", "1", "COMPLETED", "0").ToString();
                int rushUncompleteMaintOrders = this.dbMaintOrder.Count("ACTIVE", "1", "COMPLETED", "0", "URGENCY", "Urgente");
                if (rushUncompleteMaintOrders != 0)
                {
                    this.txb_RushOrders.Text = rushUncompleteMaintOrders.ToString();
                    this.txb_IdRushOrders.Text = MaintenanceOrder.GetMaintOrderId(this.dbMaintOrder.Import("ACTIVE", "1", "COMPLETED", "0", "URGENCY", "Urgente"));
                }
                else
                {
                    this.txb_RushOrders.Text = "-";
                    this.txb_IdRushOrders.Text = "-";
                }
            }
        }

        private void tmr_FrmHome_Tick(object sender, EventArgs e)
        {
            this.lbl_DateTime.Text = DateTime.Now.ToString("dddd dd/MM/yyyy HH:mm:ss");
        }
    }
}
