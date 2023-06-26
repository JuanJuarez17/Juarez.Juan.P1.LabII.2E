using System;
using System.Windows.Forms;
using ENTITIES_APP;
using DATABASE_APP;
using System.Collections.Generic;

namespace UI_APP
{
    public partial class FrmListUser : Form
    {
        private User activeUser;
        private User auxUser;
        private DbEntityUser dbUser;
        private DbEntityMaintOrder dbMaintOrder;
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

        #region METHODS
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
        private void FrmListUser_AvailableFunctions()
        {
            if (!this.activeUser.Admin) { gpb_ControlPanel.Visible = false; }

            if (this.userSearchedEnable)
            {
                this.btn_ModifyUser.Enabled = true;
                this.btn_DeleteUser.Enabled = true;
                this.dtg_UserMaintOrder.Visible = true;
                this.lbl_Datagrid.Visible = false;
            }
            else
            {
                this.btn_ModifyUser.Enabled = false;
                this.btn_DeleteUser.Enabled = false;
                this.dtg_UserMaintOrder.Visible = false;
                this.lbl_Datagrid.Visible = true;
            }

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
        private void FrmListUser_LoadDetails(User inputUser)
        {
            if (inputUser.Admin)
            {
                this.gpb_PositionDetails.Visible = false;
            }
            else
            {
                this.gpb_PositionDetails.Visible = true;
                this.lbl_Datagrid.Text = "No se pueden mostrar las ordenes.";
            }

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
                if (txb_EntryDate.Text == "1753/01/01") { this.txb_EntryDate.Text = "No ingresado"; }

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
        public void FrmListUser_LoadDataGrid<T>(List<T> inputDataSource) where T : class
        {
            this.dtg_UserMaintOrder.DataSource = null;
            this.dtg_UserMaintOrder.DataSource = inputDataSource;
            this.dtg_UserMaintOrder.Columns["Active"].Visible = false;
            this.dtg_UserMaintOrder.Columns["Username"].Visible = false;
            this.dtg_UserMaintOrder.Columns["Description"].Visible = false;
            this.dtg_UserMaintOrder.Columns["EndDate"].Visible = false;
            this.dtg_UserMaintOrder.Columns["Antiquity"].Visible = false;
            this.dtg_UserMaintOrder.Columns[0].HeaderText = "ID ORDEN";
            this.dtg_UserMaintOrder.Columns[2].HeaderText = "GENERÓ";
            this.dtg_UserMaintOrder.Columns[3].HeaderText = "SECCCIÓN";
            this.dtg_UserMaintOrder.Columns[4].HeaderText = "UNIDAD";
            this.dtg_UserMaintOrder.Columns[5].HeaderText = "URGENCIA";
            this.dtg_UserMaintOrder.Columns[6].HeaderText = "INGRESO";
            this.dtg_UserMaintOrder.Columns[8].HeaderText = "COMPLETADA";
            this.dtg_UserMaintOrder.Columns[9].HeaderText = "FINALIZADA";
        }
        #endregion

        #region EVENT METHODS
        private void FrmAccountDetails_Load(object sender, EventArgs e)
        {
            this.cbb_UserDivision.DataSource = Enum.GetValues(typeof(Division));
            this.cbb_UserShift.DataSource = Enum.GetValues(typeof(Shift));
            this.cbb_UserCategory.DataSource = Enum.GetValues(typeof(Category));
            this.btn_SearchUser.ImageIndex = 5;
            this.btn_AddUser.ImageIndex = 0;
            this.btn_ModifyUser.ImageIndex = 1;
            this.btn_DeleteUser.ImageIndex = 2;
            this.btn_Accept.ImageIndex = 4;
            this.btn_Cancel.ImageIndex = 3;
            this.lbl_Datagrid.Text = "Seleccione un operario para ver las ordenes generadas.";
            FrmListUser_AvailableFunctions();
            FrmListUser_LoadDetails(this.activeUser);

            try
            {
                this.dbUser = new DbEntityUser();
                this.cbb_UsernameList.DataSource = User.ImportUsernames(this.dbUser.Import());
                this.dbMaintOrder = new DbEntityMaintOrder();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al importar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            this.userSearchedEnable = true;
            string selectedUsername = this.cbb_UsernameList.SelectedItem.ToString();
            this.auxUser = this.dbUser.Read(selectedUsername);
            FrmListUser_AvailableFunctions();
            FrmListUser_LoadDetails(this.auxUser);
            List<MaintenanceOrder> maintORderDb = this.dbMaintOrder.Import();
            FrmListUser_LoadDataGrid(maintORderDb.Filtrar(MaintenanceOrder.CompareUsername, this.auxUser.Username));
        }
        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            ActivateForm(new FrmAddUser(), out DialogResult result);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.cbb_UsernameList.DataSource = User.ImportUsernames(this.dbUser.Import());
                    FrmListUser_AvailableFunctions();
                    FrmListUser_LoadDetails(this.activeUser);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al conectar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Carga cancelada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            this.modifyModeEnable = true;
            FrmListUser_AvailableFunctions();
            FrmListUser_LoadDetails(auxUser);
        }
        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Eliminar Usuario {this.auxUser.Username}?\nEsta accion es inrreversible", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                this.dbUser.Delete(this.auxUser.Username);
                this.cbb_UsernameList.DataSource = User.ImportUsernames(this.dbUser.Import());
                FrmListUser_AvailableFunctions();
                FrmListUser_LoadDetails(this.activeUser);
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
                User auxUser = new Operator();
                auxUser.Name = inputName;
                auxUser.Surname = inputSurname;
                auxUser.Age = Convert.ToInt32(inputAge);
                auxUser.EntryDate = Convert.ToDateTime(inputDate);
                ((Operator)auxUser).Division = (Division)this.cbb_UserDivision.SelectedItem;
                ((Operator)auxUser).Shift = (Shift)this.cbb_UserShift.SelectedItem;
                ((Operator)auxUser).Category = (Category)this.cbb_UserCategory.SelectedItem;
                try
                {
                    this.dbUser.Update(auxUser, this.auxUser.Username);
                    this.modifyModeEnable = false;
                    FrmListUser_AvailableFunctions();
                    FrmListUser_LoadDetails(this.dbUser.Read(this.auxUser.Username));
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al conectar la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
            FrmListUser_AvailableFunctions();
            FrmListUser_LoadDetails(this.auxUser);
        }
        #endregion
    }
}
