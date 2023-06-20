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
using CONTROLLER_APP;
using DATABASE_APP;
using ENTITIES_APP;

namespace UI_APP
{
    public partial class FrmHome : Form
    {
        private User activeUser;
        private DbMaintOrder dbMaintOrder;

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
                this.dbMaintOrder = new DbMaintOrder();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (this.dbMaintOrder.Count() == 0)
            {
                string messsage = "No hay ordenes de mantenimiento activas.";
                this.lbl_MaintOrderDb.Text = messsage;
                this.lbl_MaintOrderDb.Visible = true;
                this.lbl_FinishedOrders.Visible = false;
                this.lbl_UnfinishedOrders.Visible = false;
                this.txb_FinishedOrders.Visible = false;
                this.txb_UnfinishedOrders.Visible = false;
            }
            else
            {
                this.lbl_MaintOrderDb.Visible = false;
                this.txb_FinishedOrders.Text = this.dbMaintOrder.Count("COMPLETED", 1).ToString();
                this.txb_UnfinishedOrders.Text = this.dbMaintOrder.Count("COMPLETED", 0).ToString();
            }
        }
    }
}
