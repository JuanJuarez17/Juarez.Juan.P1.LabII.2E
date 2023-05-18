namespace UI_APP
{
    partial class FrmAutocomplete
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
            btn_Operator=new System.Windows.Forms.Button();
            btn_Supervisor=new System.Windows.Forms.Button();
            lbl_Info=new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_Operator
            // 
            btn_Operator.Location=new System.Drawing.Point(47, 76);
            btn_Operator.Name="btn_Operator";
            btn_Operator.Size=new System.Drawing.Size(75, 25);
            btn_Operator.TabIndex=0;
            btn_Operator.Text="Operario";
            btn_Operator.UseVisualStyleBackColor=true;
            btn_Operator.Click+=btn_Operator_Click;
            // 
            // btn_Supervisor
            // 
            btn_Supervisor.Location=new System.Drawing.Point(162, 76);
            btn_Supervisor.Name="btn_Supervisor";
            btn_Supervisor.Size=new System.Drawing.Size(75, 25);
            btn_Supervisor.TabIndex=1;
            btn_Supervisor.Text="Supervisor";
            btn_Supervisor.UseVisualStyleBackColor=true;
            btn_Supervisor.Click+=btn_Supervisor_Click;
            // 
            // lbl_Info
            // 
            lbl_Info.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Info.Location=new System.Drawing.Point(30, 9);
            lbl_Info.Name="lbl_Info";
            lbl_Info.Size=new System.Drawing.Size(225, 51);
            lbl_Info.TabIndex=2;
            lbl_Info.Text="¿Con que tipo de usuario desea ingresar a la aplicacion?";
            lbl_Info.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAutocomplete
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(284, 111);
            Controls.Add(lbl_Info);
            Controls.Add(btn_Supervisor);
            Controls.Add(btn_Operator);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmAutocomplete";
            SizeGripStyle=System.Windows.Forms.SizeGripStyle.Show;
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="Autocompletar";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Operator;
        private System.Windows.Forms.Button btn_Supervisor;
        private System.Windows.Forms.Label lbl_Info;
    }
}