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
using System.IO;

namespace UI_APP
{
    public partial class FrmListUser : Form
    {
        private User activeUser;
        private User auxUser;
        private Form activeForm;
        private bool modifyModeEnable = false;
        private bool userSearchedEnable = false;
        private FrmListUser()
        {
            InitializeComponent();
        }
        public FrmListUser(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }
        private void HideForm()
        {
            if (activeForm is not null)
            {
                activeForm.Close();
            }
        }
        private void ActivateForm(Form form, out DialogResult result)
        {
            HideForm();
            activeForm = form;
            activeForm.BringToFront();
            result = activeForm.ShowDialog();
        }
        private void FrmAccountDetails_AvailableFunctions()
        {
            if (!this.activeUser.Admin) { gpb_ControlPanel.Visible = false; }

            if (this.userSearchedEnable)
            {
                this.btn_ModifyUser.Enabled = true;
                this.btn_DeleteUser.Enabled = true;
            }
            else
            {
                this.btn_ModifyUser.Enabled = false;
                this.btn_DeleteUser.Enabled = false;
            }

            if (this.modifyModeEnable)
            {
                this.cbb_UsernameList.Enabled = false;
                this.btn_SearchUser.Enabled = false;
                this.btn_AddUser.Enabled = false;
                this.btn_DeleteUser.Enabled = false;
                this.btn_SaveUserDb.Enabled = false;

                this.btn_Accept.Visible = true;
                this.btn_Cancel.Visible = true;

                this.txb_UserName.ReadOnly = false;
                this.txb_UserSurname.ReadOnly = false;
                this.txb_UserAge.ReadOnly = false;
                this.txb_EntryDate.ReadOnly = false;
                this.cbb_UserDivision.Enabled = true;
                this.cbb_UserShift.Enabled = true;
                this.cbb_UserCategory.Enabled = true;

            }
            else
            {
                this.cbb_UsernameList.Enabled = true;
                this.btn_SearchUser.Enabled = true;
                this.btn_AddUser.Enabled = true;
                this.btn_SaveUserDb.Enabled = true;

                this.btn_Accept.Visible = false;
                this.btn_Cancel.Visible = false;

                this.txb_UserName.ReadOnly = true;
                this.txb_UserSurname.ReadOnly = true;
                this.txb_UserAge.ReadOnly = true;
                this.txb_EntryDate.ReadOnly = true;
                this.cbb_UserDivision.Enabled = false;
                this.cbb_UserShift.Enabled = false;
                this.cbb_UserCategory.Enabled = false;
            }
        }
        private void FrmAccountDetails_LoadDetails(User inputUser)
        {
            if (inputUser.Admin) { this.gpb_PositionDetails.Visible = false; }
            else { this.gpb_PositionDetails.Visible = true; }


            this.gpb_UserDetails.Text = $"Detalles del usuario {inputUser.Username}";
            this.gpb_PositionDetails.Text = $"Detalles del puesto de {inputUser.Username}";

            if (this.modifyModeEnable)
            {
                this.txb_UserFileNumber.Text = inputUser.FileNumber.ToString();
                this.txb_UserName.Text = inputUser.Name;
                this.txb_UserSurname.Text = inputUser.Surname;
                this.txb_UserAge.Text = inputUser.Age.ToString();
                this.txb_EntryDate.Text = inputUser.EntryDate.ToShortDateString();

                if (this.gpb_PositionDetails.Visible == true)
                {
                    this.cbb_UserDivision.Text = ((Operator)inputUser).Division.ToString();
                    this.cbb_UserShift.Text = ((Operator)inputUser).Shift.ToString();
                    this.cbb_UserCategory.Text = ((Operator)inputUser).Category.ToString();
                    this.txb_Antiquity.Text = ((Operator)inputUser).Antiquity.ToString();
                    this.txb_Vacations.Text = ((Operator)inputUser).VacationDays.ToString();
                }

                this.btn_Accept.Visible = true;
                this.btn_Cancel.Visible = true;
            }
            else
            {
                this.txb_UserFileNumber.Text = inputUser.FileNumber.ToString();
                this.txb_UserName.Text = inputUser.Name;
                this.txb_UserSurname.Text = inputUser.Surname;
                this.txb_UserAge.Text = inputUser.Age.ToString();
                this.txb_EntryDate.Text = inputUser.EntryDate.ToShortDateString();

                if (string.IsNullOrWhiteSpace(txb_UserName.Text)) { this.txb_UserName.Text = "No ingresado"; }
                if (string.IsNullOrWhiteSpace(txb_UserSurname.Text)) { this.txb_UserSurname.Text = "No ingresado"; }
                if (txb_UserAge.Text == "0") { this.txb_UserAge.Text = "No ingresado"; }
                if (txb_EntryDate.Text == "1/1/0001") { this.txb_EntryDate.Text = "No ingresado"; }

                if (this.gpb_PositionDetails.Visible == true)
                {
                    this.cbb_UserDivision.Text = ((Operator)inputUser).Division.ToString();
                    this.cbb_UserShift.Text = ((Operator)inputUser).Shift.ToString();
                    this.cbb_UserCategory.Text = ((Operator)inputUser).Category.ToString();
                    this.txb_Antiquity.Text = ((Operator)inputUser).Antiquity.ToString();
                    this.txb_Vacations.Text = ((Operator)inputUser).VacationDays.ToString();
                    if (txb_EntryDate.Text == "No ingresado")
                    {
                        this.txb_Antiquity.Text = "No ingresado";
                        this.txb_Vacations.Text = "No ingresado";
                    }
                }
                this.btn_Accept.Visible = false;
                this.btn_Cancel.Visible = false;
            }
        }
        private void FrmAccountDetails_Load(object sender, EventArgs e)
        {
            this.cbb_UsernameList.DataSource = Controller.User_LoadUsernameList();
            this.cbb_UserDivision.DataSource = Enum.GetValues(typeof(Division));
            this.cbb_UserShift.DataSource = Enum.GetValues(typeof(Shift));
            this.cbb_UserCategory.DataSource = Enum.GetValues(typeof(Category));
            this.btn_SearchUser.ImageIndex = 5;
            this.btn_AddUser.ImageIndex = 0;
            this.btn_ModifyUser.ImageIndex = 1;
            this.btn_DeleteUser.ImageIndex = 2;
            this.btn_Accept.ImageIndex = 4;
            this.btn_Cancel.ImageIndex = 3;
            this.btn_SaveUserDb.ImageIndex = 8;
            FrmAccountDetails_AvailableFunctions();
            FrmAccountDetails_LoadDetails(this.activeUser);
        }
        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            this.userSearchedEnable = true;
            string selectedUsername = this.cbb_UsernameList.SelectedItem.ToString();
            Controller.User_FindInDb(selectedUsername, out int findedIndex);
            this.auxUser = Controller.User_Return(findedIndex);
            FrmAccountDetails_AvailableFunctions();
            FrmAccountDetails_LoadDetails(this.auxUser);
        }
        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmAddUser(), out DialogResult result);
            if (result == DialogResult.OK)
            {
                this.cbb_UsernameList.DataSource = Controller.User_LoadUsernameList();
                FrmAccountDetails_AvailableFunctions();
                FrmAccountDetails_LoadDetails(this.activeUser);
            }
            else
            {
                MessageBox.Show("Carga cancelada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            this.modifyModeEnable = true;
            FrmAccountDetails_AvailableFunctions();
            FrmAccountDetails_LoadDetails(auxUser);
        }
        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Eliminar Usuario {this.auxUser.Username}?\nEsta accion es inrreversible", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                this.auxUser.Active = false;
                this.cbb_UsernameList.DataSource = Controller.User_LoadUsernameList();
                FrmAccountDetails_AvailableFunctions();
                FrmAccountDetails_LoadDetails(this.activeUser);
            }
        }
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string inputName = this.txb_UserName.Text;
            string inputSurname = this.txb_UserSurname.Text;
            string inputAge = this.txb_UserAge.Text;
            string inputDate = this.txb_EntryDate.Text;

            if (User.ValidateEntries(inputName, inputSurname, inputAge, inputDate))
            {
                auxUser.Name = inputName;
                auxUser.Surname = inputSurname;
                auxUser.Age = int.Parse(inputAge);
                auxUser.EntryDate = DateTime.Parse(inputDate);
                ((Operator)auxUser).Division = (Division)this.cbb_UserDivision.SelectedItem;
                ((Operator)auxUser).Shift = (Shift)this.cbb_UserShift.SelectedItem;
                ((Operator)auxUser).Category = (Category)this.cbb_UserCategory.SelectedItem;

                this.modifyModeEnable = false;
                FrmAccountDetails_AvailableFunctions();
                FrmAccountDetails_LoadDetails(this.auxUser);
            }
            else
            {
                MessageBox.Show("Informacion incompleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificacion de usuario cancelada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.modifyModeEnable = false;
            FrmAccountDetails_AvailableFunctions();
            FrmAccountDetails_LoadDetails(this.auxUser);
        }
        private void btn_SaveOperatorDb_Click(object sender, EventArgs e)
        {
            if (Controller.User_SaveDbAsText())
            {
                MessageBox.Show("Base de datos guardada con exito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la base de datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
