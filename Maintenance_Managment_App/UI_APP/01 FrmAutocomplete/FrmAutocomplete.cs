using ENTITIES_APP;
using DATABASE_APP;
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
    public partial class FrmAutocomplete : Form
    {
        private User selectedUser;
        private DbUser dbUser;
        public FrmAutocomplete()
        {
            InitializeComponent();
        }
        public string Username
        {
            get { return this.selectedUser.Username; }
        }
        public string Password
        {
            get { return this.selectedUser.Password; }
        }

        private void btn_Operator_Click(object sender, EventArgs e)
        {
            try
            {
                this.dbUser = new DbUser();
                this.selectedUser = this.dbUser.Read("Operario");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Cancel;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Supervisor_Click(object sender, EventArgs e)
        {
            try
            {
                this.dbUser = new DbUser();
                this.selectedUser = this.dbUser.Read("Supervisor");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Cancel;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
