namespace UI_APP
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btn_Access=new System.Windows.Forms.Button();
            btn_Cancel=new System.Windows.Forms.Button();
            txb_Username=new System.Windows.Forms.TextBox();
            txb_Password=new System.Windows.Forms.TextBox();
            lbl_Title=new System.Windows.Forms.Label();
            btn_Autocomplete=new System.Windows.Forms.Button();
            iml_Login=new System.Windows.Forms.ImageList(components);
            SuspendLayout();
            // 
            // btn_Access
            // 
            btn_Access.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            btn_Access.Location=new System.Drawing.Point(211, 169);
            btn_Access.Name="btn_Access";
            btn_Access.Size=new System.Drawing.Size(75, 25);
            btn_Access.TabIndex=0;
            btn_Access.Text="Ingresar";
            btn_Access.UseVisualStyleBackColor=true;
            btn_Access.Click+=btn_Access_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            btn_Cancel.Location=new System.Drawing.Point(292, 169);
            btn_Cancel.Name="btn_Cancel";
            btn_Cancel.Size=new System.Drawing.Size(75, 25);
            btn_Cancel.TabIndex=1;
            btn_Cancel.Text="Cancelar";
            btn_Cancel.UseVisualStyleBackColor=true;
            btn_Cancel.Click+=btn_Cancel_Click;
            // 
            // txb_Username
            // 
            txb_Username.Location=new System.Drawing.Point(17, 95);
            txb_Username.Name="txb_Username";
            txb_Username.PlaceholderText="Ingrese Usuario";
            txb_Username.Size=new System.Drawing.Size(350, 23);
            txb_Username.TabIndex=2;
            // 
            // txb_Password
            // 
            txb_Password.Location=new System.Drawing.Point(17, 126);
            txb_Password.Name="txb_Password";
            txb_Password.PasswordChar='*';
            txb_Password.PlaceholderText="Ingrese Contraseña";
            txb_Password.Size=new System.Drawing.Size(350, 23);
            txb_Password.TabIndex=3;
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            lbl_Title.Font=new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Title.Location=new System.Drawing.Point(17, 11);
            lbl_Title.Name="lbl_Title";
            lbl_Title.Size=new System.Drawing.Size(350, 60);
            lbl_Title.TabIndex=4;
            lbl_Title.Text="Maintenance Management Assistant";
            lbl_Title.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Autocomplete
            // 
            btn_Autocomplete.ImageList=iml_Login;
            btn_Autocomplete.Location=new System.Drawing.Point(17, 169);
            btn_Autocomplete.Name="btn_Autocomplete";
            btn_Autocomplete.Size=new System.Drawing.Size(25, 25);
            btn_Autocomplete.TabIndex=5;
            btn_Autocomplete.UseVisualStyleBackColor=true;
            btn_Autocomplete.Click+=btn_Autocomplete_Click;
            // 
            // iml_Login
            // 
            iml_Login.ColorDepth=System.Windows.Forms.ColorDepth.Depth8Bit;
            iml_Login.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("iml_Login.ImageStream");
            iml_Login.TransparentColor=System.Drawing.Color.Transparent;
            iml_Login.Images.SetKeyName(0, "boton-de-informacion.png");
            // 
            // FrmLogin
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(384, 211);
            Controls.Add(btn_Autocomplete);
            Controls.Add(lbl_Title);
            Controls.Add(txb_Password);
            Controls.Add(txb_Username);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Access);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmLogin";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="Login";
            Load+=FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Access;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Autocomplete;
        private System.Windows.Forms.ImageList iml_Login;
    }
}
