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

namespace UI_APP.MaintenanceOrder.FrmAddMaintenanceOrder
{
    public partial class FrmAddMaintenanceOrder : Form
    {
        #region ATTRIBUTES
        private User activeUser; 
        #endregion

        #region CONSTRUCTOR
        private FrmAddMaintenanceOrder()
        {
            InitializeComponent();
        }
        public FrmAddMaintenanceOrder(User inputUser) : this()
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
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Section inputSection = (Section)this.cbb_Section.SelectedItem;
            Machine inputMachine = (Machine)this.cbb_Machine.SelectedItem;
            Urgency inputUrgency = (Urgency)this.cbb_Urgency.SelectedItem;
            string inputDescription = this.richTextBox1.Text;
            if (Controller.ParseMaintenanceOrder(inputDescription))
            {
                if (Controller.AddMaintenanceOrder(Controller.CreateMaintenanceOrder(this.activeUser, inputMachine, inputSection, inputUrgency, inputDescription), out int idAdded))
                {
                    MessageBox.Show($"Orden de mantenimiento {idAdded} creada.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.DialogResult= DialogResult.OK;
                }
                else
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
