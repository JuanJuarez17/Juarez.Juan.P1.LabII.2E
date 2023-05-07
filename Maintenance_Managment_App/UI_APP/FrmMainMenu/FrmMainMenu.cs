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
    public partial class FrmMainMenu : Form
    {
        private User inputUser;
        private FrmMainMenu()
        {
            InitializeComponent();
        }

        public FrmMainMenu(User inputUser) : this()
        {
            this.inputUser = inputUser;
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            if (!this.inputUser.Admin)
            {
                smi_SeeWO.Visible = false;
                smi_Operators.Visible = false;
                // TODO: Enable = flase los desactiva peor no los oculta, Visible = false los oculta
            }

            lbl_Test.Text = " Bienvenido " + this.inputUser.Username;
            rtb_Test.Text = Controller.ShowMaintOrderList();
        }
    }
}
