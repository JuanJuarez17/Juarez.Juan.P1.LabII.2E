using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLLER_APP;
using ENTITIES_APP;

namespace UI_APP
{
    public partial class FrmHome : Form
    {
        private User activeUser;
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
            if (Controller.MaintOrderDbLoaded == false)
            {
                this.lbl_MaintOrderDb.Visible = true;
                this.lbl_FinishedOrders.Visible = false;
                this.lbl_UnfinishedOrders.Visible = false;
                this.txb_FinishedOrders.Visible = false;
                this.txb_UnfinishedOrders.Visible = false;
            }
            else
            {
                this.lbl_MaintOrderDb.Visible = false;
                this.txb_FinishedOrders.Text = Controller.MaintOrder_ReturnFinished().ToString();
                this.txb_UnfinishedOrders.Text = Controller.MaintOrder_ReturnUnfinished().ToString();
            }
        }
    }
}
