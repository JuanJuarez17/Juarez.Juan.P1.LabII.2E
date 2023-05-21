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
    public partial class FrmAccountDetails : Form
    {
        private User activeUser;
        private User auxUser;
        private bool modifyModeEnable = false;
        private bool userSearchedEnable = false;
        private FrmAccountDetails()
        {
            InitializeComponent();
        }
        public FrmAccountDetails(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }

        #region METHODS
        private void FrmAccountDetails_AvailableFunctions()
        {
            if (!this.activeUser.Admin) { gpb_ControlPanel.Visible = false; }

            if (this.userSearchedEnable) { this.btn_ModifyUser.Enabled = true; }
            else { this.btn_ModifyUser.Enabled = false; }

            if (this.modifyModeEnable)
            {
                this.cbb_UsernameList.Enabled = false;
                this.btn_SearchUser.Enabled = false;
                this.btn_AddUser.Enabled = false;
                this.btn_DeleteUser.Enabled = false;

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
                this.btn_DeleteUser.Enabled = true;

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
        #endregion

        #region EVENT METHODS
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
            this.btn_Cancel.ImageIndex = 3;
            this.btn_Accept.ImageIndex = 4;
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
        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            this.modifyModeEnable = true;
            FrmAccountDetails_AvailableFunctions();
            FrmAccountDetails_LoadDetails(auxUser);
        }
        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            this.auxUser.Active = false;
            this.cbb_UsernameList.DataSource = Controller.User_LoadUsernameList();
            FrmAccountDetails_AvailableFunctions();
            FrmAccountDetails_LoadDetails(this.activeUser);
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
        private void btn_LoadUserDb_Click(object sender, EventArgs e)
        {
            if (LoadUserDbFromText())
            {
                MessageBox.Show("Se cargo correctamente");
                this.cbb_UsernameList.DataSource = Controller.User_LoadUsernameList();
            }
            else
            {
                MessageBox.Show("No se pudo cargar");
            }       
        }
        private void btn_SaveOperatorDb_Click(object sender, EventArgs e)
        {
            if (SaveUserDbAsText())
            {
                MessageBox.Show("Se guardo correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo cargar");
            }
        }
        #endregion


        private bool LoadUserDbFromText()
        {
            bool rtn = false;
            string route = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test", "OperatorDb.txt");
            if (File.Exists(route))
            {
                StringBuilder sb = new StringBuilder();
                string[] readFile = File.ReadAllLines(route);
                for (int i = 0; i < readFile.Length; i++)
                {
                    if (i != 0)
                    {
                        sb.AppendLine(readFile[i]);
                    }
                }
                rtn = Controller.User_ReadFromText(sb.ToString());
            }
            return rtn;
        }
        private bool SaveUserDbAsText()
        {
            bool rtn = false;
            string route = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test");
            if (!Directory.Exists(route))
            {
                Directory.CreateDirectory(route);
            }
            route = Path.Combine(route, "OperatorDb.txt");
            if (File.Exists(route))
            {
                File.Delete(route);
                rtn = true;
            }
            File.WriteAllText(route, Controller.User_OperatorDBSaveAsText());
            return rtn;
        }
    }
}
