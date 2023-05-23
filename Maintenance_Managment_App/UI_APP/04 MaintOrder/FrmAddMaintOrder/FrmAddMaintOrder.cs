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
    public partial class FrmAddMaintOrder : Form
    {
        private User activeUser;
        private FrmAddMaintOrder()
        {
            InitializeComponent();
        }
        public FrmAddMaintOrder(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }
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
            if (Controller.MaintOrder_Parse(inputDescription))
            {
                if (Controller.MaintOrder_Add(this.activeUser.Username, inputMachine, inputSection, inputUrgency, inputDescription, out int idAdded))
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
    }
}
