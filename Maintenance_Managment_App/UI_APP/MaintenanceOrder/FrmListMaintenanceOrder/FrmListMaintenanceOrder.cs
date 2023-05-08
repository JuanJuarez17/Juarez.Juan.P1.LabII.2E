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
    public partial class FrmListMaintenanceOrder : Form
    {
        public FrmListMaintenanceOrder()
        {
            InitializeComponent();
        }
        private void FrmListMaintenanceOrder_Load(object sender, EventArgs e)
        {
            if (Controller.ListMaintenanceOrder(out string message))
            {
                rtb_Test.Text = message;
            }
            else
            {
                rtb_Test.Text = "NO SE PUDO CARGAR LA BASE DE DATOS";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
