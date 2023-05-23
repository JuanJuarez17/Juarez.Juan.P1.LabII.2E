using ENTITIES_APP;
using CONTROLLER_APP;
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
            this.selectedUser = Controller.User_Return("Operario");
            this.DialogResult = DialogResult.OK;
        }
        private void btn_Supervisor_Click(object sender, EventArgs e)
        {
            this.selectedUser = Controller.User_Return("Supervisor");
            this.DialogResult = DialogResult.OK;
        }
    }
}
