namespace UI_APP
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            iml_AddUser=new System.Windows.Forms.ImageList(components);
            btn_Add=new System.Windows.Forms.Button();
            btn_Cancel=new System.Windows.Forms.Button();
            txb_UserName=new System.Windows.Forms.TextBox();
            lbl_Username=new System.Windows.Forms.Label();
            txb_Password=new System.Windows.Forms.TextBox();
            lbl_Password=new System.Windows.Forms.Label();
            txb_RepeatPassword=new System.Windows.Forms.TextBox();
            lbl_RepeatPassword=new System.Windows.Forms.Label();
            txb_FileNumber=new System.Windows.Forms.TextBox();
            lbl_fileNumber=new System.Windows.Forms.Label();
            btn_VerifyFileNumber=new System.Windows.Forms.Button();
            rdb_Supervisor=new System.Windows.Forms.RadioButton();
            rdb_Operator=new System.Windows.Forms.RadioButton();
            gpb_UserType=new System.Windows.Forms.GroupBox();
            gpb_UserType.SuspendLayout();
            SuspendLayout();
            // 
            // iml_AddUser
            // 
            iml_AddUser.ColorDepth=System.Windows.Forms.ColorDepth.Depth8Bit;
            iml_AddUser.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("iml_AddUser.ImageStream");
            iml_AddUser.TransparentColor=System.Drawing.Color.Transparent;
            iml_AddUser.Images.SetKeyName(0, "mas.png");
            iml_AddUser.Images.SetKeyName(1, "lapiz.png");
            iml_AddUser.Images.SetKeyName(2, "borrar.png");
            iml_AddUser.Images.SetKeyName(3, "aceptar.png");
            iml_AddUser.Images.SetKeyName(4, "boton-eliminar.png");
            iml_AddUser.Images.SetKeyName(5, "lupa.png");
            // 
            // btn_Add
            // 
            btn_Add.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Add.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Add.ImageList=iml_AddUser;
            btn_Add.Location=new System.Drawing.Point(186, 199);
            btn_Add.Name="btn_Add";
            btn_Add.Size=new System.Drawing.Size(50, 50);
            btn_Add.TabIndex=7;
            btn_Add.UseVisualStyleBackColor=true;
            btn_Add.Click+=btn_Add_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Cancel.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Cancel.ImageList=iml_AddUser;
            btn_Cancel.Location=new System.Drawing.Point(242, 199);
            btn_Cancel.Name="btn_Cancel";
            btn_Cancel.Size=new System.Drawing.Size(50, 50);
            btn_Cancel.TabIndex=8;
            btn_Cancel.UseVisualStyleBackColor=true;
            btn_Cancel.Click+=btn_Cancel_Click;
            // 
            // txb_UserName
            // 
            txb_UserName.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txb_UserName.Location=new System.Drawing.Point(162, 46);
            txb_UserName.Name="txb_UserName";
            txb_UserName.ShortcutsEnabled=false;
            txb_UserName.Size=new System.Drawing.Size(130, 25);
            txb_UserName.TabIndex=3;
            txb_UserName.KeyPress+=txb_UserName_KeyPress;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize=true;
            lbl_Username.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Username.Location=new System.Drawing.Point(16, 54);
            lbl_Username.Name="lbl_Username";
            lbl_Username.Size=new System.Drawing.Size(53, 17);
            lbl_Username.TabIndex=0;
            lbl_Username.Text="Usuario";
            // 
            // txb_Password
            // 
            txb_Password.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txb_Password.Location=new System.Drawing.Point(162, 85);
            txb_Password.Name="txb_Password";
            txb_Password.PasswordChar='*';
            txb_Password.ShortcutsEnabled=false;
            txb_Password.Size=new System.Drawing.Size(130, 25);
            txb_Password.TabIndex=4;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize=true;
            lbl_Password.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Password.Location=new System.Drawing.Point(16, 93);
            lbl_Password.Name="lbl_Password";
            lbl_Password.Size=new System.Drawing.Size(74, 17);
            lbl_Password.TabIndex=0;
            lbl_Password.Text="Contraseña";
            // 
            // txb_RepeatPassword
            // 
            txb_RepeatPassword.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txb_RepeatPassword.Location=new System.Drawing.Point(162, 124);
            txb_RepeatPassword.Name="txb_RepeatPassword";
            txb_RepeatPassword.PasswordChar='*';
            txb_RepeatPassword.ShortcutsEnabled=false;
            txb_RepeatPassword.Size=new System.Drawing.Size(130, 25);
            txb_RepeatPassword.TabIndex=5;
            // 
            // lbl_RepeatPassword
            // 
            lbl_RepeatPassword.AutoSize=true;
            lbl_RepeatPassword.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_RepeatPassword.Location=new System.Drawing.Point(16, 132);
            lbl_RepeatPassword.Name="lbl_RepeatPassword";
            lbl_RepeatPassword.Size=new System.Drawing.Size(118, 17);
            lbl_RepeatPassword.TabIndex=0;
            lbl_RepeatPassword.Text="Repetir contraseña";
            // 
            // txb_FileNumber
            // 
            txb_FileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txb_FileNumber.Location=new System.Drawing.Point(162, 7);
            txb_FileNumber.Name="txb_FileNumber";
            txb_FileNumber.ShortcutsEnabled=false;
            txb_FileNumber.Size=new System.Drawing.Size(50, 25);
            txb_FileNumber.TabIndex=1;
            txb_FileNumber.KeyPress+=txb_FileNumber_KeyPress;
            // 
            // lbl_fileNumber
            // 
            lbl_fileNumber.AutoSize=true;
            lbl_fileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_fileNumber.Location=new System.Drawing.Point(16, 15);
            lbl_fileNumber.Name="lbl_fileNumber";
            lbl_fileNumber.Size=new System.Drawing.Size(47, 17);
            lbl_fileNumber.TabIndex=0;
            lbl_fileNumber.Text="Legajo";
            // 
            // btn_VerifyFileNumber
            // 
            btn_VerifyFileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_VerifyFileNumber.Location=new System.Drawing.Point(218, 7);
            btn_VerifyFileNumber.Name="btn_VerifyFileNumber";
            btn_VerifyFileNumber.Size=new System.Drawing.Size(74, 25);
            btn_VerifyFileNumber.TabIndex=2;
            btn_VerifyFileNumber.Text="Verificar";
            btn_VerifyFileNumber.UseVisualStyleBackColor=true;
            btn_VerifyFileNumber.Click+=btn_VerifyFileNumber_Click;
            // 
            // rdb_Supervisor
            // 
            rdb_Supervisor.AutoSize=true;
            rdb_Supervisor.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rdb_Supervisor.Location=new System.Drawing.Point(17, 25);
            rdb_Supervisor.Name="rdb_Supervisor";
            rdb_Supervisor.Size=new System.Drawing.Size(88, 21);
            rdb_Supervisor.TabIndex=1;
            rdb_Supervisor.TabStop=true;
            rdb_Supervisor.Text="Supervisor";
            rdb_Supervisor.UseVisualStyleBackColor=true;
            // 
            // rdb_Operator
            // 
            rdb_Operator.AutoSize=true;
            rdb_Operator.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rdb_Operator.Location=new System.Drawing.Point(17, 54);
            rdb_Operator.Name="rdb_Operator";
            rdb_Operator.Size=new System.Drawing.Size(79, 21);
            rdb_Operator.TabIndex=2;
            rdb_Operator.TabStop=true;
            rdb_Operator.Text="Operario";
            rdb_Operator.UseVisualStyleBackColor=true;
            // 
            // gpb_UserType
            // 
            gpb_UserType.Controls.Add(rdb_Supervisor);
            gpb_UserType.Controls.Add(rdb_Operator);
            gpb_UserType.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gpb_UserType.Location=new System.Drawing.Point(10, 164);
            gpb_UserType.Name="gpb_UserType";
            gpb_UserType.Size=new System.Drawing.Size(150, 85);
            gpb_UserType.TabIndex=6;
            gpb_UserType.TabStop=false;
            gpb_UserType.Text="Tipo de Usuario";
            // 
            // FrmAddUser
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(304, 261);
            Controls.Add(gpb_UserType);
            Controls.Add(btn_VerifyFileNumber);
            Controls.Add(txb_FileNumber);
            Controls.Add(lbl_fileNumber);
            Controls.Add(txb_RepeatPassword);
            Controls.Add(lbl_RepeatPassword);
            Controls.Add(txb_Password);
            Controls.Add(lbl_Password);
            Controls.Add(txb_UserName);
            Controls.Add(lbl_Username);
            Controls.Add(btn_Add);
            Controls.Add(btn_Cancel);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmAddUser";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="Alta Usuario";
            Load+=FrmAddUser_Load;
            gpb_UserType.ResumeLayout(false);
            gpb_UserType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ImageList iml_AddUser;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_RepeatPassword;
        private System.Windows.Forms.Label lbl_RepeatPassword;
        private System.Windows.Forms.TextBox txb_FileNumber;
        private System.Windows.Forms.Label lbl_fileNumber;
        private System.Windows.Forms.Button btn_VerifyFileNumber;
        private System.Windows.Forms.RadioButton rdb_Supervisor;
        private System.Windows.Forms.RadioButton rdb_Operator;
        private System.Windows.Forms.GroupBox gpb_UserType;
    }
}