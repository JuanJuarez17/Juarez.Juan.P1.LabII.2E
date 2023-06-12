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
            if (!SqlServerConnection.ImportedDbFlag)
            {
                string messsage = "La base de datos de ordenes de mantenimiento se encuentra vacia.\r\nDirijase a la pestaña \"Orden de mantenimiento\" y seleccione \"Importar\" para traer una base de datos.\r\n";
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
                // TODO: Estos se pueden reemplazar con el count en sql
                this.txb_FinishedOrders.Text = SqlServerConnection.Count("COMPLETED").ToString();
                this.txb_UnfinishedOrders.Text = SqlServerConnection.Count("UNCOMPLETED").ToString();
            }
        }
    }
}
