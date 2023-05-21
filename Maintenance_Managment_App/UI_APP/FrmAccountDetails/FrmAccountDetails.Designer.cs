namespace UI_APP
{
    partial class FrmAccountDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountDetails));
            pcb_UserImage=new System.Windows.Forms.PictureBox();
            txb_UserName=new System.Windows.Forms.TextBox();
            lbl_Name=new System.Windows.Forms.Label();
            gpb_UserDetails=new System.Windows.Forms.GroupBox();
            txb_EntryDate=new System.Windows.Forms.TextBox();
            lbl_EntryDate=new System.Windows.Forms.Label();
            txb_UserFileNumber=new System.Windows.Forms.TextBox();
            lbl_FileNumber=new System.Windows.Forms.Label();
            txb_UserAge=new System.Windows.Forms.TextBox();
            lbl_Age=new System.Windows.Forms.Label();
            txb_UserSurname=new System.Windows.Forms.TextBox();
            lbl_Surname=new System.Windows.Forms.Label();
            lbl_SearchFileNumber=new System.Windows.Forms.Label();
            btn_SearchUser=new System.Windows.Forms.Button();
            iml_AccountDetails=new System.Windows.Forms.ImageList(components);
            gpb_ControlPanel=new System.Windows.Forms.GroupBox();
            cbb_UsernameList=new System.Windows.Forms.ComboBox();
            btn_DeleteUser=new System.Windows.Forms.Button();
            btn_ModifyUser=new System.Windows.Forms.Button();
            btn_AddUser=new System.Windows.Forms.Button();
            gpb_PositionDetails=new System.Windows.Forms.GroupBox();
            cbb_UserCategory=new System.Windows.Forms.ComboBox();
            cbb_UserShift=new System.Windows.Forms.ComboBox();
            cbb_UserDivision=new System.Windows.Forms.ComboBox();
            lbl_Category=new System.Windows.Forms.Label();
            txb_Vacations=new System.Windows.Forms.TextBox();
            lbl_Vacations=new System.Windows.Forms.Label();
            txb_Antiquity=new System.Windows.Forms.TextBox();
            lbl_Antiquity=new System.Windows.Forms.Label();
            lbl_Shift=new System.Windows.Forms.Label();
            lbl_Divison=new System.Windows.Forms.Label();
            btn_Cancel=new System.Windows.Forms.Button();
            btn_Accept=new System.Windows.Forms.Button();
            btn_SaveUserDb=new System.Windows.Forms.Button();
            btn_LoadUserDb=new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pcb_UserImage).BeginInit();
            gpb_UserDetails.SuspendLayout();
            gpb_ControlPanel.SuspendLayout();
            gpb_PositionDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pcb_UserImage
            // 
            pcb_UserImage.Image=Properties.Resources.usuario;
            pcb_UserImage.Location=new System.Drawing.Point(12, 12);
            pcb_UserImage.Name="pcb_UserImage";
            pcb_UserImage.Size=new System.Drawing.Size(200, 200);
            pcb_UserImage.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcb_UserImage.TabIndex=0;
            pcb_UserImage.TabStop=false;
            // 
            // txb_UserName
            // 
            txb_UserName.Location=new System.Drawing.Point(137, 59);
            txb_UserName.Name="txb_UserName";
            txb_UserName.Size=new System.Drawing.Size(130, 23);
            txb_UserName.TabIndex=26;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize=true;
            lbl_Name.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Name.Location=new System.Drawing.Point(20, 62);
            lbl_Name.Name="lbl_Name";
            lbl_Name.Size=new System.Drawing.Size(57, 17);
            lbl_Name.TabIndex=25;
            lbl_Name.Text="Nombre";
            // 
            // gpb_UserDetails
            // 
            gpb_UserDetails.Controls.Add(txb_EntryDate);
            gpb_UserDetails.Controls.Add(lbl_EntryDate);
            gpb_UserDetails.Controls.Add(txb_UserFileNumber);
            gpb_UserDetails.Controls.Add(lbl_FileNumber);
            gpb_UserDetails.Controls.Add(txb_UserAge);
            gpb_UserDetails.Controls.Add(lbl_Age);
            gpb_UserDetails.Controls.Add(txb_UserSurname);
            gpb_UserDetails.Controls.Add(lbl_Surname);
            gpb_UserDetails.Controls.Add(txb_UserName);
            gpb_UserDetails.Controls.Add(lbl_Name);
            gpb_UserDetails.Location=new System.Drawing.Point(238, 78);
            gpb_UserDetails.Name="gpb_UserDetails";
            gpb_UserDetails.Size=new System.Drawing.Size(345, 180);
            gpb_UserDetails.TabIndex=27;
            gpb_UserDetails.TabStop=false;
            gpb_UserDetails.Text="gpb_UserDetails";
            // 
            // txb_EntryDate
            // 
            txb_EntryDate.Location=new System.Drawing.Point(137, 146);
            txb_EntryDate.Name="txb_EntryDate";
            txb_EntryDate.Size=new System.Drawing.Size(130, 23);
            txb_EntryDate.TabIndex=38;
            // 
            // lbl_EntryDate
            // 
            lbl_EntryDate.AutoSize=true;
            lbl_EntryDate.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_EntryDate.Location=new System.Drawing.Point(20, 149);
            lbl_EntryDate.Name="lbl_EntryDate";
            lbl_EntryDate.Size=new System.Drawing.Size(108, 17);
            lbl_EntryDate.TabIndex=37;
            lbl_EntryDate.Text="Fecha de ingreso";
            // 
            // txb_UserFileNumber
            // 
            txb_UserFileNumber.Location=new System.Drawing.Point(137, 30);
            txb_UserFileNumber.Name="txb_UserFileNumber";
            txb_UserFileNumber.ReadOnly=true;
            txb_UserFileNumber.Size=new System.Drawing.Size(130, 23);
            txb_UserFileNumber.TabIndex=36;
            // 
            // lbl_FileNumber
            // 
            lbl_FileNumber.AutoSize=true;
            lbl_FileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_FileNumber.Location=new System.Drawing.Point(20, 33);
            lbl_FileNumber.Name="lbl_FileNumber";
            lbl_FileNumber.Size=new System.Drawing.Size(47, 17);
            lbl_FileNumber.TabIndex=35;
            lbl_FileNumber.Text="Legajo";
            // 
            // txb_UserAge
            // 
            txb_UserAge.Location=new System.Drawing.Point(137, 117);
            txb_UserAge.Name="txb_UserAge";
            txb_UserAge.Size=new System.Drawing.Size(130, 23);
            txb_UserAge.TabIndex=30;
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize=true;
            lbl_Age.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Age.Location=new System.Drawing.Point(20, 120);
            lbl_Age.Name="lbl_Age";
            lbl_Age.Size=new System.Drawing.Size(38, 17);
            lbl_Age.TabIndex=29;
            lbl_Age.Text="Edad";
            // 
            // txb_UserSurname
            // 
            txb_UserSurname.Location=new System.Drawing.Point(137, 88);
            txb_UserSurname.Name="txb_UserSurname";
            txb_UserSurname.Size=new System.Drawing.Size(130, 23);
            txb_UserSurname.TabIndex=28;
            // 
            // lbl_Surname
            // 
            lbl_Surname.AutoSize=true;
            lbl_Surname.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Surname.Location=new System.Drawing.Point(20, 91);
            lbl_Surname.Name="lbl_Surname";
            lbl_Surname.Size=new System.Drawing.Size(56, 17);
            lbl_Surname.TabIndex=27;
            lbl_Surname.Text="Apellido";
            // 
            // lbl_SearchFileNumber
            // 
            lbl_SearchFileNumber.AutoSize=true;
            lbl_SearchFileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_SearchFileNumber.Location=new System.Drawing.Point(17, 25);
            lbl_SearchFileNumber.Name="lbl_SearchFileNumber";
            lbl_SearchFileNumber.Size=new System.Drawing.Size(53, 17);
            lbl_SearchFileNumber.TabIndex=28;
            lbl_SearchFileNumber.Text="Usuario";
            // 
            // btn_SearchUser
            // 
            btn_SearchUser.ImageList=iml_AccountDetails;
            btn_SearchUser.Location=new System.Drawing.Point(200, 14);
            btn_SearchUser.Name="btn_SearchUser";
            btn_SearchUser.Size=new System.Drawing.Size(40, 40);
            btn_SearchUser.TabIndex=30;
            btn_SearchUser.UseVisualStyleBackColor=true;
            btn_SearchUser.Click+=btn_SearchUser_Click;
            // 
            // iml_AccountDetails
            // 
            iml_AccountDetails.ColorDepth=System.Windows.Forms.ColorDepth.Depth8Bit;
            iml_AccountDetails.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("iml_AccountDetails.ImageStream");
            iml_AccountDetails.TransparentColor=System.Drawing.Color.Transparent;
            iml_AccountDetails.Images.SetKeyName(0, "mas.png");
            iml_AccountDetails.Images.SetKeyName(1, "lapiz.png");
            iml_AccountDetails.Images.SetKeyName(2, "borrar.png");
            iml_AccountDetails.Images.SetKeyName(3, "boton-eliminar.png");
            iml_AccountDetails.Images.SetKeyName(4, "aceptar.png");
            iml_AccountDetails.Images.SetKeyName(5, "lupa.png");
            iml_AccountDetails.Images.SetKeyName(6, "base-de-datos.png");
            iml_AccountDetails.Images.SetKeyName(7, "sincronizar.png");
            // 
            // gpb_ControlPanel
            // 
            gpb_ControlPanel.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            gpb_ControlPanel.Controls.Add(cbb_UsernameList);
            gpb_ControlPanel.Controls.Add(btn_DeleteUser);
            gpb_ControlPanel.Controls.Add(btn_ModifyUser);
            gpb_ControlPanel.Controls.Add(btn_AddUser);
            gpb_ControlPanel.Controls.Add(btn_SearchUser);
            gpb_ControlPanel.Controls.Add(lbl_SearchFileNumber);
            gpb_ControlPanel.Location=new System.Drawing.Point(238, 12);
            gpb_ControlPanel.Name="gpb_ControlPanel";
            gpb_ControlPanel.Size=new System.Drawing.Size(700, 60);
            gpb_ControlPanel.TabIndex=31;
            gpb_ControlPanel.TabStop=false;
            gpb_ControlPanel.Text="Panel de control";
            // 
            // cbb_UsernameList
            // 
            cbb_UsernameList.FormattingEnabled=true;
            cbb_UsernameList.Location=new System.Drawing.Point(70, 24);
            cbb_UsernameList.Name="cbb_UsernameList";
            cbb_UsernameList.Size=new System.Drawing.Size(121, 23);
            cbb_UsernameList.TabIndex=33;
            // 
            // btn_DeleteUser
            // 
            btn_DeleteUser.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            btn_DeleteUser.ImageList=iml_AccountDetails;
            btn_DeleteUser.Location=new System.Drawing.Point(654, 14);
            btn_DeleteUser.Name="btn_DeleteUser";
            btn_DeleteUser.Size=new System.Drawing.Size(40, 40);
            btn_DeleteUser.TabIndex=32;
            btn_DeleteUser.UseVisualStyleBackColor=true;
            btn_DeleteUser.Click+=btn_DeleteUser_Click;
            // 
            // btn_ModifyUser
            // 
            btn_ModifyUser.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            btn_ModifyUser.ImageList=iml_AccountDetails;
            btn_ModifyUser.Location=new System.Drawing.Point(608, 14);
            btn_ModifyUser.Name="btn_ModifyUser";
            btn_ModifyUser.Size=new System.Drawing.Size(40, 40);
            btn_ModifyUser.TabIndex=32;
            btn_ModifyUser.UseVisualStyleBackColor=true;
            btn_ModifyUser.Click+=btn_ModifyUser_Click;
            // 
            // btn_AddUser
            // 
            btn_AddUser.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            btn_AddUser.ImageList=iml_AccountDetails;
            btn_AddUser.Location=new System.Drawing.Point(562, 14);
            btn_AddUser.Name="btn_AddUser";
            btn_AddUser.Size=new System.Drawing.Size(40, 40);
            btn_AddUser.TabIndex=31;
            btn_AddUser.UseVisualStyleBackColor=true;
            // 
            // gpb_PositionDetails
            // 
            gpb_PositionDetails.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            gpb_PositionDetails.Controls.Add(cbb_UserCategory);
            gpb_PositionDetails.Controls.Add(cbb_UserShift);
            gpb_PositionDetails.Controls.Add(cbb_UserDivision);
            gpb_PositionDetails.Controls.Add(lbl_Category);
            gpb_PositionDetails.Controls.Add(txb_Vacations);
            gpb_PositionDetails.Controls.Add(lbl_Vacations);
            gpb_PositionDetails.Controls.Add(txb_Antiquity);
            gpb_PositionDetails.Controls.Add(lbl_Antiquity);
            gpb_PositionDetails.Controls.Add(lbl_Shift);
            gpb_PositionDetails.Controls.Add(lbl_Divison);
            gpb_PositionDetails.Location=new System.Drawing.Point(593, 78);
            gpb_PositionDetails.Name="gpb_PositionDetails";
            gpb_PositionDetails.Size=new System.Drawing.Size(345, 180);
            gpb_PositionDetails.TabIndex=32;
            gpb_PositionDetails.TabStop=false;
            gpb_PositionDetails.Text="gpb_PositionDetails";
            // 
            // cbb_UserCategory
            // 
            cbb_UserCategory.FormattingEnabled=true;
            cbb_UserCategory.Location=new System.Drawing.Point(122, 88);
            cbb_UserCategory.Name="cbb_UserCategory";
            cbb_UserCategory.Size=new System.Drawing.Size(130, 23);
            cbb_UserCategory.TabIndex=49;
            // 
            // cbb_UserShift
            // 
            cbb_UserShift.FormattingEnabled=true;
            cbb_UserShift.Location=new System.Drawing.Point(122, 59);
            cbb_UserShift.Name="cbb_UserShift";
            cbb_UserShift.Size=new System.Drawing.Size(130, 23);
            cbb_UserShift.TabIndex=48;
            // 
            // cbb_UserDivision
            // 
            cbb_UserDivision.FormattingEnabled=true;
            cbb_UserDivision.Location=new System.Drawing.Point(122, 30);
            cbb_UserDivision.Name="cbb_UserDivision";
            cbb_UserDivision.Size=new System.Drawing.Size(130, 23);
            cbb_UserDivision.TabIndex=47;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize=true;
            lbl_Category.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Category.Location=new System.Drawing.Point(34, 91);
            lbl_Category.Name="lbl_Category";
            lbl_Category.Size=new System.Drawing.Size(65, 17);
            lbl_Category.TabIndex=45;
            lbl_Category.Text="Categoria";
            // 
            // txb_Vacations
            // 
            txb_Vacations.Location=new System.Drawing.Point(122, 149);
            txb_Vacations.Name="txb_Vacations";
            txb_Vacations.ReadOnly=true;
            txb_Vacations.Size=new System.Drawing.Size(130, 23);
            txb_Vacations.TabIndex=44;
            // 
            // lbl_Vacations
            // 
            lbl_Vacations.AutoSize=true;
            lbl_Vacations.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Vacations.Location=new System.Drawing.Point(34, 152);
            lbl_Vacations.Name="lbl_Vacations";
            lbl_Vacations.Size=new System.Drawing.Size(72, 17);
            lbl_Vacations.TabIndex=43;
            lbl_Vacations.Text="Vacaciones";
            // 
            // txb_Antiquity
            // 
            txb_Antiquity.Location=new System.Drawing.Point(122, 118);
            txb_Antiquity.Name="txb_Antiquity";
            txb_Antiquity.ReadOnly=true;
            txb_Antiquity.Size=new System.Drawing.Size(130, 23);
            txb_Antiquity.TabIndex=42;
            // 
            // lbl_Antiquity
            // 
            lbl_Antiquity.AutoSize=true;
            lbl_Antiquity.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Antiquity.Location=new System.Drawing.Point(34, 121);
            lbl_Antiquity.Name="lbl_Antiquity";
            lbl_Antiquity.Size=new System.Drawing.Size(75, 17);
            lbl_Antiquity.TabIndex=41;
            lbl_Antiquity.Text="Antiguedad";
            // 
            // lbl_Shift
            // 
            lbl_Shift.AutoSize=true;
            lbl_Shift.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Shift.Location=new System.Drawing.Point(34, 62);
            lbl_Shift.Name="lbl_Shift";
            lbl_Shift.Size=new System.Drawing.Size(42, 17);
            lbl_Shift.TabIndex=39;
            lbl_Shift.Text="Turno";
            // 
            // lbl_Divison
            // 
            lbl_Divison.AutoSize=true;
            lbl_Divison.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Divison.Location=new System.Drawing.Point(34, 33);
            lbl_Divison.Name="lbl_Divison";
            lbl_Divison.Size=new System.Drawing.Size(53, 17);
            lbl_Divison.TabIndex=37;
            lbl_Divison.Text="Division";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            btn_Cancel.ImageList=iml_AccountDetails;
            btn_Cancel.Location=new System.Drawing.Point(892, 274);
            btn_Cancel.Name="btn_Cancel";
            btn_Cancel.Size=new System.Drawing.Size(40, 40);
            btn_Cancel.TabIndex=33;
            btn_Cancel.UseVisualStyleBackColor=true;
            btn_Cancel.Click+=btn_Cancel_Click;
            // 
            // btn_Accept
            // 
            btn_Accept.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            btn_Accept.ImageList=iml_AccountDetails;
            btn_Accept.Location=new System.Drawing.Point(846, 274);
            btn_Accept.Name="btn_Accept";
            btn_Accept.Size=new System.Drawing.Size(40, 40);
            btn_Accept.TabIndex=34;
            btn_Accept.UseVisualStyleBackColor=true;
            btn_Accept.Click+=btn_Accept_Click;
            // 
            // btn_SaveUserDb
            // 
            btn_SaveUserDb.Location=new System.Drawing.Point(244, 277);
            btn_SaveUserDb.Name="btn_SaveUserDb";
            btn_SaveUserDb.Size=new System.Drawing.Size(111, 23);
            btn_SaveUserDb.TabIndex=35;
            btn_SaveUserDb.Text="Save User DB";
            btn_SaveUserDb.UseVisualStyleBackColor=true;
            btn_SaveUserDb.Click+=btn_SaveOperatorDb_Click;
            // 
            // btn_LoadUserDb
            // 
            btn_LoadUserDb.Location=new System.Drawing.Point(361, 277);
            btn_LoadUserDb.Name="btn_LoadUserDb";
            btn_LoadUserDb.Size=new System.Drawing.Size(111, 23);
            btn_LoadUserDb.TabIndex=36;
            btn_LoadUserDb.Text="Load User DB";
            btn_LoadUserDb.UseVisualStyleBackColor=true;
            btn_LoadUserDb.Click+=btn_LoadUserDb_Click;
            // 
            // FrmAccountDetails
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(btn_LoadUserDb);
            Controls.Add(btn_SaveUserDb);
            Controls.Add(btn_Accept);
            Controls.Add(btn_Cancel);
            Controls.Add(gpb_PositionDetails);
            Controls.Add(gpb_ControlPanel);
            Controls.Add(gpb_UserDetails);
            Controls.Add(pcb_UserImage);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmAccountDetails";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmAccountDetails";
            Load+=FrmAccountDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pcb_UserImage).EndInit();
            gpb_UserDetails.ResumeLayout(false);
            gpb_UserDetails.PerformLayout();
            gpb_ControlPanel.ResumeLayout(false);
            gpb_ControlPanel.PerformLayout();
            gpb_PositionDetails.ResumeLayout(false);
            gpb_PositionDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_UserImage;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.GroupBox gpb_UserDetails;
        private System.Windows.Forms.TextBox txb_UserAge;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txb_UserSurname;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_SearchFileNumber;
        private System.Windows.Forms.Button btn_SearchUser;
        private System.Windows.Forms.GroupBox gpb_ControlPanel;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_ModifyUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.ImageList iml_AccountDetails;
        private System.Windows.Forms.TextBox txb_UserFileNumber;
        private System.Windows.Forms.Label lbl_FileNumber;
        private System.Windows.Forms.GroupBox gpb_PositionDetails;
        private System.Windows.Forms.TextBox txb_Antiquity;
        private System.Windows.Forms.Label lbl_Antiquity;
        private System.Windows.Forms.Label lbl_Shift;
        private System.Windows.Forms.Label lbl_Divison;
        private System.Windows.Forms.TextBox txb_EntryDate;
        private System.Windows.Forms.Label lbl_EntryDate;
        private System.Windows.Forms.TextBox txb_Vacations;
        private System.Windows.Forms.Label lbl_Vacations;
        private System.Windows.Forms.ComboBox cbb_UsernameList;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.ComboBox cbb_UserCategory;
        private System.Windows.Forms.ComboBox cbb_UserShift;
        private System.Windows.Forms.ComboBox cbb_UserDivision;
        private System.Windows.Forms.Button btn_SaveUserDb;
        private System.Windows.Forms.Button btn_LoadUserDb;
    }
}