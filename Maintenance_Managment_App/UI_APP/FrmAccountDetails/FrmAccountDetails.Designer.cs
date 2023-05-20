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
            textBox4=new System.Windows.Forms.TextBox();
            label4=new System.Windows.Forms.Label();
            txb_UserFileNumber=new System.Windows.Forms.TextBox();
            lbl_FileNumber=new System.Windows.Forms.Label();
            txb_UserAge=new System.Windows.Forms.TextBox();
            lbl_Age=new System.Windows.Forms.Label();
            txb_UserSurname=new System.Windows.Forms.TextBox();
            lbl_Surname=new System.Windows.Forms.Label();
            txb_InputUserFileNumber=new System.Windows.Forms.TextBox();
            lbl_SearchFileNumber=new System.Windows.Forms.Label();
            btn_SearchUser=new System.Windows.Forms.Button();
            iml_AccountDetails=new System.Windows.Forms.ImageList(components);
            gpb_ControlPanel=new System.Windows.Forms.GroupBox();
            btn_DeleteUser=new System.Windows.Forms.Button();
            Btn_ModifyUser=new System.Windows.Forms.Button();
            btn_AddUser=new System.Windows.Forms.Button();
            groupBox1=new System.Windows.Forms.GroupBox();
            textBox5=new System.Windows.Forms.TextBox();
            label5=new System.Windows.Forms.Label();
            textBox3=new System.Windows.Forms.TextBox();
            label3=new System.Windows.Forms.Label();
            textBox2=new System.Windows.Forms.TextBox();
            label2=new System.Windows.Forms.Label();
            textBox1=new System.Windows.Forms.TextBox();
            label1=new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pcb_UserImage).BeginInit();
            gpb_UserDetails.SuspendLayout();
            gpb_ControlPanel.SuspendLayout();
            groupBox1.SuspendLayout();
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
            txb_UserName.ReadOnly=true;
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
            gpb_UserDetails.Controls.Add(textBox4);
            gpb_UserDetails.Controls.Add(label4);
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
            gpb_UserDetails.Text="Detalles del Usuario";
            // 
            // textBox4
            // 
            textBox4.Location=new System.Drawing.Point(137, 146);
            textBox4.Name="textBox4";
            textBox4.ReadOnly=true;
            textBox4.Size=new System.Drawing.Size(130, 23);
            textBox4.TabIndex=38;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location=new System.Drawing.Point(20, 149);
            label4.Name="label4";
            label4.Size=new System.Drawing.Size(108, 17);
            label4.TabIndex=37;
            label4.Text="Fecha de ingreso";
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
            txb_UserAge.ReadOnly=true;
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
            txb_UserSurname.ReadOnly=true;
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
            // txb_InputUserFileNumber
            // 
            txb_InputUserFileNumber.Location=new System.Drawing.Point(82, 22);
            txb_InputUserFileNumber.Name="txb_InputUserFileNumber";
            txb_InputUserFileNumber.Size=new System.Drawing.Size(100, 23);
            txb_InputUserFileNumber.TabIndex=29;
            // 
            // lbl_SearchFileNumber
            // 
            lbl_SearchFileNumber.AutoSize=true;
            lbl_SearchFileNumber.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_SearchFileNumber.Location=new System.Drawing.Point(17, 25);
            lbl_SearchFileNumber.Name="lbl_SearchFileNumber";
            lbl_SearchFileNumber.Size=new System.Drawing.Size(47, 17);
            lbl_SearchFileNumber.TabIndex=28;
            lbl_SearchFileNumber.Text="Legajo";
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
            gpb_ControlPanel.Controls.Add(btn_DeleteUser);
            gpb_ControlPanel.Controls.Add(Btn_ModifyUser);
            gpb_ControlPanel.Controls.Add(btn_AddUser);
            gpb_ControlPanel.Controls.Add(btn_SearchUser);
            gpb_ControlPanel.Controls.Add(lbl_SearchFileNumber);
            gpb_ControlPanel.Controls.Add(txb_InputUserFileNumber);
            gpb_ControlPanel.Location=new System.Drawing.Point(238, 12);
            gpb_ControlPanel.Name="gpb_ControlPanel";
            gpb_ControlPanel.Size=new System.Drawing.Size(700, 60);
            gpb_ControlPanel.TabIndex=31;
            gpb_ControlPanel.TabStop=false;
            gpb_ControlPanel.Text="Panel de control";
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
            // 
            // Btn_ModifyUser
            // 
            Btn_ModifyUser.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            Btn_ModifyUser.ImageList=iml_AccountDetails;
            Btn_ModifyUser.Location=new System.Drawing.Point(608, 14);
            Btn_ModifyUser.Name="Btn_ModifyUser";
            Btn_ModifyUser.Size=new System.Drawing.Size(40, 40);
            Btn_ModifyUser.TabIndex=32;
            Btn_ModifyUser.UseVisualStyleBackColor=true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location=new System.Drawing.Point(593, 78);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new System.Drawing.Size(345, 180);
            groupBox1.TabIndex=32;
            groupBox1.TabStop=false;
            groupBox1.Text="Detalles del Puesto";
            // 
            // textBox5
            // 
            textBox5.Location=new System.Drawing.Point(122, 119);
            textBox5.Name="textBox5";
            textBox5.ReadOnly=true;
            textBox5.Size=new System.Drawing.Size(130, 23);
            textBox5.TabIndex=44;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location=new System.Drawing.Point(34, 122);
            label5.Name="label5";
            label5.Size=new System.Drawing.Size(72, 17);
            label5.TabIndex=43;
            label5.Text="Vacaciones";
            // 
            // textBox3
            // 
            textBox3.Location=new System.Drawing.Point(122, 88);
            textBox3.Name="textBox3";
            textBox3.ReadOnly=true;
            textBox3.Size=new System.Drawing.Size(130, 23);
            textBox3.TabIndex=42;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location=new System.Drawing.Point(34, 91);
            label3.Name="label3";
            label3.Size=new System.Drawing.Size(75, 17);
            label3.TabIndex=41;
            label3.Text="Antiguedad";
            // 
            // textBox2
            // 
            textBox2.Location=new System.Drawing.Point(122, 59);
            textBox2.Name="textBox2";
            textBox2.ReadOnly=true;
            textBox2.Size=new System.Drawing.Size(130, 23);
            textBox2.TabIndex=40;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location=new System.Drawing.Point(34, 62);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(42, 17);
            label2.TabIndex=39;
            label2.Text="Turno";
            // 
            // textBox1
            // 
            textBox1.Location=new System.Drawing.Point(122, 30);
            textBox1.Name="textBox1";
            textBox1.ReadOnly=true;
            textBox1.Size=new System.Drawing.Size(130, 23);
            textBox1.TabIndex=38;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(34, 33);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(53, 17);
            label1.TabIndex=37;
            label1.Text="Division";
            // 
            // FrmAccountDetails
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txb_InputUserFileNumber;
        private System.Windows.Forms.Label lbl_SearchFileNumber;
        private System.Windows.Forms.Button btn_SearchUser;
        private System.Windows.Forms.GroupBox gpb_ControlPanel;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button Btn_ModifyUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.ImageList iml_AccountDetails;
        private System.Windows.Forms.TextBox txb_UserFileNumber;
        private System.Windows.Forms.Label lbl_FileNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
    }
}