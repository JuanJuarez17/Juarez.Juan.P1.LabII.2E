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
    public partial class FrmAddMaintOrder : Form
    {
        #region ATTRIBUTES
        private User activeUser;
        #endregion

        #region CONSTRUCTOR
        private FrmAddMaintOrder()
        {
            InitializeComponent();
        }
        public FrmAddMaintOrder(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }
        #endregion

        #region EVENT METHODS
        private void FrmAddMaintenanceOrder_Load(object sender, EventArgs e)
        {
            this.cbb_Section.DataSource = Enum.GetValues(typeof(Section));
            this.cbb_Machine.DataSource = Enum.GetValues(typeof(Machine));
            this.cbb_Urgency.DataSource = Enum.GetValues(typeof(Urgency));
            this.btn_Add.ImageIndex = 3;
            this.btn_Cancel.ImageIndex = 4;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Section inputSection = (Section)this.cbb_Section.SelectedItem;
            Machine inputMachine = (Machine)this.cbb_Machine.SelectedItem;
            Urgency inputUrgency = (Urgency)this.cbb_Urgency.SelectedItem;
            string inputDescription = this.rtb_Description.Text;
            // TODO: Reemplaza Controller.MaintOrder_Parse por otro metodo llamado desde otro lado
            if (Controller.MaintOrder_Parse(inputDescription))
            {
                try
                {
                    SqlServerConnection.Create(this.activeUser.Username, inputMachine, inputSection, inputUrgency, inputDescription);
                    int idAdded = SqlServerConnection.GetLastId();
                    MessageBox.Show($"Orden de mantenimiento {idAdded} creada.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.DialogResult= DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo agregar la orden a la base de datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo ingresado incorrectamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
