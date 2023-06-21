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
    public partial class FrmAddUser : Form
    {
        private bool fileNumberAvailable = false;
        private DbUser dbUser;
        public FrmAddUser()
        {
            InitializeComponent();
        }
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            this.btn_Add.ImageIndex = 3;
            this.btn_Cancel.ImageIndex = 4;
            this.txb_FileNumber.MaxLength = 3;
            this.txb_UserName.MaxLength = 20;
            this.txb_Password.MaxLength = 6;
            this.txb_RepeatPassword.MaxLength = 6;
            this.rdb_Operator.Checked = true;
        }
        private void txb_FileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admite el ingreso de numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private void txb_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo se admite el ingreso de letras", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private void btn_VerifyFileNumber_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(this.txb_FileNumber.Text, out int inputFileNumber);
            if (inputFileNumber < 100 || inputFileNumber > 999)
            {
                MessageBox.Show("El numero ingresado no corresponde a un legajo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txb_FileNumber.Text = string.Empty;
            }
            else
            {
                List<User> importedList = new List<User>();
                try
                {
                    this.dbUser = new DbUser();
                    importedList = this.dbUser.Import();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al importar la base de datos.\nReintentar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                if (User.CheckFileNumberAvailable(importedList, inputFileNumber))
                {
                    this.txb_FileNumber.BackColor = Color.GreenYellow;
                    this.txb_FileNumber.ReadOnly = true;
                    this.fileNumberAvailable = true;
                }
                else
                {
                    this.txb_FileNumber.BackColor = Color.Red;
                }
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string inputUsername = this.txb_UserName.Text;
            string inputPassword = this.txb_Password.Text;
            string inputRepeatPassword = this.txb_RepeatPassword.Text;
            bool validatePassword = false;
            if (!string.IsNullOrWhiteSpace(inputPassword) && inputPassword == inputRepeatPassword)
            {
                validatePassword = true;
            }
            if (this.fileNumberAvailable && User.ValidateEntries(inputUsername) && validatePassword)
            {
                int.TryParse(this.txb_FileNumber.Text, out int inputFileNumber);
                if (this.rdb_Operator.Checked == true)
                {
                    User auxOperator = new Operator(inputFileNumber, inputUsername, inputPassword);
                    try
                    {
                        this.dbUser = new DbUser();
                        this.dbUser.Create(auxOperator);
                        MessageBox.Show("Usuario creado con exito!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo agregar el usuario a la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    User auxSupervisor = new Supervisor(inputFileNumber, inputUsername, inputPassword);
                    try
                    {
                        this.dbUser = new DbUser();
                        this.dbUser.Create(auxSupervisor);
                        MessageBox.Show("Usuario creado con exito!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo agregar el usuario a la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
