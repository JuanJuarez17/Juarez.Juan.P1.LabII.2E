namespace UI_APP
{
    partial class FrmListUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            btn_Cancel=new System.Windows.Forms.Button();
            btn_Accept=new System.Windows.Forms.Button();
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
            lbl_Datagrid=new System.Windows.Forms.Label();
            dtg_UserMaintOrder=new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcb_UserImage).BeginInit();
            gpb_UserDetails.SuspendLayout();
            gpb_ControlPanel.SuspendLayout();
            gpb_PositionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_UserMaintOrder).BeginInit();
            SuspendLayout();
            // 
            // pcb_UserImage
            // 
            pcb_UserImage.Anchor=System.Windows.Forms.AnchorStyles.Top;
            pcb_UserImage.Image=Properties.Resources.usuario;
            pcb_UserImage.Location=new System.Drawing.Point(425, 12);
            pcb_UserImage.Name="pcb_UserImage";
            pcb_UserImage.Size=new System.Drawing.Size(100, 100);
            pcb_UserImage.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcb_UserImage.TabIndex=0;
            pcb_UserImage.TabStop=false;
            // 
            // txb_UserName
            // 
            txb_UserName.Location=new System.Drawing.Point(169, 59);
            txb_UserName.Name="txb_UserName";
            txb_UserName.Size=new System.Drawing.Size(130, 23);
            txb_UserName.TabIndex=2;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize=true;
            lbl_Name.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Name.Location=new System.Drawing.Point(49, 62);
            lbl_Name.Name="lbl_Name";
            lbl_Name.Size=new System.Drawing.Size(57, 17);
            lbl_Name.TabIndex=25;
            lbl_Name.Text="Nombre";
            // 
            // gpb_UserDetails
            // 
            gpb_UserDetails.Anchor=System.Windows.Forms.AnchorStyles.Top;
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
            gpb_UserDetails.Location=new System.Drawing.Point(125, 196);
            gpb_UserDetails.Name="gpb_UserDetails";
            gpb_UserDetails.Size=new System.Drawing.Size(345, 180);
            gpb_UserDetails.TabIndex=2;
            gpb_UserDetails.TabStop=false;
            gpb_UserDetails.Text="gpb_UserDetails";
            // 
            // txb_EntryDate
            // 
            txb_EntryDate.Location=new System.Drawing.Point(169, 146);
            txb_EntryDate.Name="txb_EntryDate";
            txb_EntryDate.Size=new System.Drawing.Size(130, 23);
            txb_EntryDate.TabIndex=5;
            // 
            // lbl_EntryDate
            // 
            lbl_EntryDate.AutoSize=true;
            lbl_EntryDate.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_EntryDate.Location=new System.Drawing.Point(49, 149);
            lbl_EntryDate.Name="lbl_EntryDate";
            lbl_EntryDate.Size=new System.Drawing.Size(108, 17);
            lbl_EntryDate.TabIndex=0;
            lbl_EntryDate.Text="Fecha de ingreso";
            // 
            // txb_UserFileNumber
            // 
            txb_UserFileNumber.Location=new System.Drawing.Point(169, 30);
            txb_UserFileNumber.Name="txb_UserFileNumber";
            txb_UserFileNumber.ReadOnly=true;
            txb_UserFileNumber.Size=new System.Drawing.Size(130, 23);
            txb_UserFileNumber.TabIndex=1;
            // 
            // lbl_FileNumber
            // 
            lbl_FileNumber.AutoSize=true;
            lbl_FileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_FileNumber.Location=new System.Drawing.Point(49, 33);
            lbl_FileNumber.Name="lbl_FileNumber";
            lbl_FileNumber.Size=new System.Drawing.Size(47, 17);
            lbl_FileNumber.TabIndex=0;
            lbl_FileNumber.Text="Legajo";
            // 
            // txb_UserAge
            // 
            txb_UserAge.Location=new System.Drawing.Point(169, 117);
            txb_UserAge.Name="txb_UserAge";
            txb_UserAge.Size=new System.Drawing.Size(130, 23);
            txb_UserAge.TabIndex=4;
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize=true;
            lbl_Age.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Age.Location=new System.Drawing.Point(49, 120);
            lbl_Age.Name="lbl_Age";
            lbl_Age.Size=new System.Drawing.Size(38, 17);
            lbl_Age.TabIndex=0;
            lbl_Age.Text="Edad";
            // 
            // txb_UserSurname
            // 
            txb_UserSurname.Location=new System.Drawing.Point(169, 88);
            txb_UserSurname.Name="txb_UserSurname";
            txb_UserSurname.Size=new System.Drawing.Size(130, 23);
            txb_UserSurname.TabIndex=3;
            // 
            // lbl_Surname
            // 
            lbl_Surname.AutoSize=true;
            lbl_Surname.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Surname.Location=new System.Drawing.Point(49, 91);
            lbl_Surname.Name="lbl_Surname";
            lbl_Surname.Size=new System.Drawing.Size(56, 17);
            lbl_Surname.TabIndex=0;
            lbl_Surname.Text="Apellido";
            // 
            // lbl_SearchFileNumber
            // 
            lbl_SearchFileNumber.AutoSize=true;
            lbl_SearchFileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_SearchFileNumber.Location=new System.Drawing.Point(17, 25);
            lbl_SearchFileNumber.Name="lbl_SearchFileNumber";
            lbl_SearchFileNumber.Size=new System.Drawing.Size(53, 17);
            lbl_SearchFileNumber.TabIndex=0;
            lbl_SearchFileNumber.Text="Usuario";
            // 
            // btn_SearchUser
            // 
            btn_SearchUser.ImageList=iml_AccountDetails;
            btn_SearchUser.Location=new System.Drawing.Point(200, 14);
            btn_SearchUser.Name="btn_SearchUser";
            btn_SearchUser.Size=new System.Drawing.Size(40, 40);
            btn_SearchUser.TabIndex=1;
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
            iml_AccountDetails.Images.SetKeyName(8, "exportar.png");
            // 
            // gpb_ControlPanel
            // 
            gpb_ControlPanel.Anchor=System.Windows.Forms.AnchorStyles.Top;
            gpb_ControlPanel.Controls.Add(cbb_UsernameList);
            gpb_ControlPanel.Controls.Add(btn_Cancel);
            gpb_ControlPanel.Controls.Add(btn_Accept);
            gpb_ControlPanel.Controls.Add(btn_DeleteUser);
            gpb_ControlPanel.Controls.Add(btn_ModifyUser);
            gpb_ControlPanel.Controls.Add(btn_AddUser);
            gpb_ControlPanel.Controls.Add(btn_SearchUser);
            gpb_ControlPanel.Controls.Add(lbl_SearchFileNumber);
            gpb_ControlPanel.Location=new System.Drawing.Point(125, 128);
            gpb_ControlPanel.Name="gpb_ControlPanel";
            gpb_ControlPanel.Size=new System.Drawing.Size(700, 60);
            gpb_ControlPanel.TabIndex=1;
            gpb_ControlPanel.TabStop=false;
            gpb_ControlPanel.Text="Panel de control";
            // 
            // cbb_UsernameList
            // 
            cbb_UsernameList.FormattingEnabled=true;
            cbb_UsernameList.Location=new System.Drawing.Point(70, 24);
            cbb_UsernameList.Name="cbb_UsernameList";
            cbb_UsernameList.Size=new System.Drawing.Size(121, 23);
            cbb_UsernameList.TabIndex=0;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor=System.Windows.Forms.AnchorStyles.Top;
            btn_Cancel.ImageList=iml_AccountDetails;
            btn_Cancel.Location=new System.Drawing.Point(292, 14);
            btn_Cancel.Name="btn_Cancel";
            btn_Cancel.Size=new System.Drawing.Size(40, 40);
            btn_Cancel.TabIndex=6;
            btn_Cancel.UseVisualStyleBackColor=true;
            btn_Cancel.Click+=btn_Cancel_Click;
            // 
            // btn_Accept
            // 
            btn_Accept.Anchor=System.Windows.Forms.AnchorStyles.Top;
            btn_Accept.ImageList=iml_AccountDetails;
            btn_Accept.Location=new System.Drawing.Point(246, 14);
            btn_Accept.Name="btn_Accept";
            btn_Accept.Size=new System.Drawing.Size(40, 40);
            btn_Accept.TabIndex=5;
            btn_Accept.UseVisualStyleBackColor=true;
            btn_Accept.Click+=btn_Accept_Click;
            // 
            // btn_DeleteUser
            // 
            btn_DeleteUser.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            btn_DeleteUser.ImageList=iml_AccountDetails;
            btn_DeleteUser.Location=new System.Drawing.Point(654, 14);
            btn_DeleteUser.Name="btn_DeleteUser";
            btn_DeleteUser.Size=new System.Drawing.Size(40, 40);
            btn_DeleteUser.TabIndex=4;
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
            btn_ModifyUser.TabIndex=3;
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
            btn_AddUser.TabIndex=2;
            btn_AddUser.UseVisualStyleBackColor=true;
            btn_AddUser.Click+=btn_AddUser_Click;
            // 
            // gpb_PositionDetails
            // 
            gpb_PositionDetails.Anchor=System.Windows.Forms.AnchorStyles.Top;
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
            gpb_PositionDetails.Location=new System.Drawing.Point(480, 196);
            gpb_PositionDetails.Name="gpb_PositionDetails";
            gpb_PositionDetails.Size=new System.Drawing.Size(345, 180);
            gpb_PositionDetails.TabIndex=3;
            gpb_PositionDetails.TabStop=false;
            gpb_PositionDetails.Text="gpb_PositionDetails";
            // 
            // cbb_UserCategory
            // 
            cbb_UserCategory.FormattingEnabled=true;
            cbb_UserCategory.Location=new System.Drawing.Point(154, 88);
            cbb_UserCategory.Name="cbb_UserCategory";
            cbb_UserCategory.Size=new System.Drawing.Size(130, 23);
            cbb_UserCategory.TabIndex=3;
            // 
            // cbb_UserShift
            // 
            cbb_UserShift.FormattingEnabled=true;
            cbb_UserShift.Location=new System.Drawing.Point(154, 59);
            cbb_UserShift.Name="cbb_UserShift";
            cbb_UserShift.Size=new System.Drawing.Size(130, 23);
            cbb_UserShift.TabIndex=2;
            // 
            // cbb_UserDivision
            // 
            cbb_UserDivision.FormattingEnabled=true;
            cbb_UserDivision.Location=new System.Drawing.Point(154, 30);
            cbb_UserDivision.Name="cbb_UserDivision";
            cbb_UserDivision.Size=new System.Drawing.Size(130, 23);
            cbb_UserDivision.TabIndex=1;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize=true;
            lbl_Category.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Category.Location=new System.Drawing.Point(54, 91);
            lbl_Category.Name="lbl_Category";
            lbl_Category.Size=new System.Drawing.Size(65, 17);
            lbl_Category.TabIndex=0;
            lbl_Category.Text="Categoria";
            // 
            // txb_Vacations
            // 
            txb_Vacations.Location=new System.Drawing.Point(154, 149);
            txb_Vacations.Name="txb_Vacations";
            txb_Vacations.ReadOnly=true;
            txb_Vacations.Size=new System.Drawing.Size(130, 23);
            txb_Vacations.TabIndex=5;
            // 
            // lbl_Vacations
            // 
            lbl_Vacations.AutoSize=true;
            lbl_Vacations.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Vacations.Location=new System.Drawing.Point(54, 152);
            lbl_Vacations.Name="lbl_Vacations";
            lbl_Vacations.Size=new System.Drawing.Size(72, 17);
            lbl_Vacations.TabIndex=0;
            lbl_Vacations.Text="Vacaciones";
            // 
            // txb_Antiquity
            // 
            txb_Antiquity.Location=new System.Drawing.Point(154, 118);
            txb_Antiquity.Name="txb_Antiquity";
            txb_Antiquity.ReadOnly=true;
            txb_Antiquity.Size=new System.Drawing.Size(130, 23);
            txb_Antiquity.TabIndex=4;
            // 
            // lbl_Antiquity
            // 
            lbl_Antiquity.AutoSize=true;
            lbl_Antiquity.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Antiquity.Location=new System.Drawing.Point(54, 121);
            lbl_Antiquity.Name="lbl_Antiquity";
            lbl_Antiquity.Size=new System.Drawing.Size(75, 17);
            lbl_Antiquity.TabIndex=0;
            lbl_Antiquity.Text="Antiguedad";
            // 
            // lbl_Shift
            // 
            lbl_Shift.AutoSize=true;
            lbl_Shift.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Shift.Location=new System.Drawing.Point(54, 62);
            lbl_Shift.Name="lbl_Shift";
            lbl_Shift.Size=new System.Drawing.Size(42, 17);
            lbl_Shift.TabIndex=0;
            lbl_Shift.Text="Turno";
            // 
            // lbl_Divison
            // 
            lbl_Divison.AutoSize=true;
            lbl_Divison.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Divison.Location=new System.Drawing.Point(54, 33);
            lbl_Divison.Name="lbl_Divison";
            lbl_Divison.Size=new System.Drawing.Size(53, 17);
            lbl_Divison.TabIndex=0;
            lbl_Divison.Text="Division";
            // 
            // lbl_Datagrid
            // 
            lbl_Datagrid.Anchor=System.Windows.Forms.AnchorStyles.Top;
            lbl_Datagrid.BackColor=System.Drawing.SystemColors.ControlDark;
            lbl_Datagrid.Font=new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Datagrid.Location=new System.Drawing.Point(125, 439);
            lbl_Datagrid.Name="lbl_Datagrid";
            lbl_Datagrid.Size=new System.Drawing.Size(700, 30);
            lbl_Datagrid.TabIndex=0;
            lbl_Datagrid.Text="lbl_Datagrid";
            lbl_Datagrid.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            lbl_Datagrid.Visible=false;
            // 
            // dtg_UserMaintOrder
            // 
            dtg_UserMaintOrder.AllowUserToAddRows=false;
            dtg_UserMaintOrder.AllowUserToDeleteRows=false;
            dtg_UserMaintOrder.AllowUserToResizeColumns=false;
            dtg_UserMaintOrder.AllowUserToResizeRows=false;
            dtg_UserMaintOrder.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Bottom;
            dtg_UserMaintOrder.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor=System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            dtg_UserMaintOrder.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle4;
            dtg_UserMaintOrder.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor=System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor=System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            dtg_UserMaintOrder.DefaultCellStyle=dataGridViewCellStyle5;
            dtg_UserMaintOrder.EnableHeadersVisualStyles=false;
            dtg_UserMaintOrder.Location=new System.Drawing.Point(125, 384);
            dtg_UserMaintOrder.MultiSelect=false;
            dtg_UserMaintOrder.Name="dtg_UserMaintOrder";
            dtg_UserMaintOrder.ReadOnly=true;
            dataGridViewCellStyle6.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor=System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            dtg_UserMaintOrder.RowHeadersDefaultCellStyle=dataGridViewCellStyle6;
            dtg_UserMaintOrder.RowHeadersVisible=false;
            dtg_UserMaintOrder.RowTemplate.Height=25;
            dtg_UserMaintOrder.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtg_UserMaintOrder.Size=new System.Drawing.Size(700, 150);
            dtg_UserMaintOrder.TabIndex=0;
            dtg_UserMaintOrder.TabStop=false;
            dtg_UserMaintOrder.VirtualMode=true;
            // 
            // FrmListUser
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            BackColor=System.Drawing.Color.RoyalBlue;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(lbl_Datagrid);
            Controls.Add(gpb_ControlPanel);
            Controls.Add(gpb_UserDetails);
            Controls.Add(pcb_UserImage);
            Controls.Add(gpb_PositionDetails);
            Controls.Add(dtg_UserMaintOrder);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmListUser";
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
            ((System.ComponentModel.ISupportInitialize)dtg_UserMaintOrder).EndInit();
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
        private System.Windows.Forms.Label lbl_Datagrid;
        private System.Windows.Forms.DataGridView dtg_UserMaintOrder;
    }
}