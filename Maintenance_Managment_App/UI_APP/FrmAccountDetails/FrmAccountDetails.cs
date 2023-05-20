using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITIES_APP;
using CONTROLLER_APP;

namespace UI_APP
{
    public partial class FrmAccountDetails : Form
    {
        private User activeUser;
        private FrmAccountDetails()
        {
            InitializeComponent();
        }
        public FrmAccountDetails(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }

        private void FrmAccountDetails_LoadDetails(User inputUser)
        {
            //string message = Controller.MaintOrder_PrintParameter("DESCRIPTION", this.maintOrderId);
            //if (message == string.Empty)
            //{
            //    this.rtb_MaintOrderDesc.Text = "No se agrego descripcion.";
            //}
            //else
            //{
            //    this.rtb_MaintOrderDesc.Text = message;
            //}
            this.txb_UserFileNumber.Text = inputUser.FileNumber.ToString();
            if (inputUser.Name == string.Empty)
            {
                this.txb_UserName.Text = "No ingresado";
            }
        }
        private void FrmAccountDetails_AvailableFunctions()
        {
            if (!activeUser.Admin)
            {
                gpb_ControlPanel.Visible = false;
            }
        }

        private void FrmAccountDetails_Load(object sender, EventArgs e)
        {
            this.btn_SearchUser.ImageIndex = 5;
            this.btn_AddUser.ImageIndex = 0;
            this.Btn_ModifyUser.ImageIndex = 1;
            this.btn_DeleteUser.ImageIndex = 2;
            FrmAccountDetails_AvailableFunctions();
            FrmAccountDetails_LoadDetails(this.activeUser);
        }
        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(this.txb_InputUserFileNumber.Text, out int inputFileNumber);
            if (!isInt)
            {
                MessageBox.Show("Debe ingresar un numero de legajo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Controller.User_FindInDb(inputFileNumber, out int findedIndex))
                {
                    FrmAccountDetails_LoadDetails(Controller.User_Return(findedIndex));
                }
                else
                {
                    MessageBox.Show("No se ha encontrado al usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
