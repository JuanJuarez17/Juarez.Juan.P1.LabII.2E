namespace UI_APP.MaintenanceOrder.FrmAddMaintenanceOrder
{
    partial class FrmAddMaintenanceOrder
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
            btn_Cancel=new System.Windows.Forms.Button();
            cbb_Machine=new System.Windows.Forms.ComboBox();
            cbb_Section=new System.Windows.Forms.ComboBox();
            cbb_Urgency=new System.Windows.Forms.ComboBox();
            richTextBox1=new System.Windows.Forms.RichTextBox();
            lbl_Section=new System.Windows.Forms.Label();
            lbl_Machine=new System.Windows.Forms.Label();
            lbl_Urgency=new System.Windows.Forms.Label();
            lbl_Description=new System.Windows.Forms.Label();
            btn_Add=new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Cancel.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Cancel.Location=new System.Drawing.Point(838, 508);
            btn_Cancel.Name="btn_Cancel";
            btn_Cancel.Size=new System.Drawing.Size(100, 30);
            btn_Cancel.TabIndex=2;
            btn_Cancel.Text="Cancelar";
            btn_Cancel.UseVisualStyleBackColor=true;
            btn_Cancel.Click+=btn_Close_Click;
            // 
            // cbb_Machine
            // 
            cbb_Machine.Anchor=System.Windows.Forms.AnchorStyles.Top;
            cbb_Machine.FormattingEnabled=true;
            cbb_Machine.Location=new System.Drawing.Point(390, 63);
            cbb_Machine.Name="cbb_Machine";
            cbb_Machine.Size=new System.Drawing.Size(170, 23);
            cbb_Machine.TabIndex=3;
            // 
            // cbb_Section
            // 
            cbb_Section.FormattingEnabled=true;
            cbb_Section.Location=new System.Drawing.Point(60, 63);
            cbb_Section.Name="cbb_Section";
            cbb_Section.Size=new System.Drawing.Size(170, 23);
            cbb_Section.TabIndex=4;
            // 
            // cbb_Urgency
            // 
            cbb_Urgency.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            cbb_Urgency.FormattingEnabled=true;
            cbb_Urgency.Location=new System.Drawing.Point(720, 63);
            cbb_Urgency.Name="cbb_Urgency";
            cbb_Urgency.Size=new System.Drawing.Size(170, 23);
            cbb_Urgency.TabIndex=5;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.Location=new System.Drawing.Point(60, 129);
            richTextBox1.Name="richTextBox1";
            richTextBox1.Size=new System.Drawing.Size(830, 274);
            richTextBox1.TabIndex=6;
            richTextBox1.Text="";
            // 
            // lbl_Section
            // 
            lbl_Section.AutoSize=true;
            lbl_Section.Font=new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Section.Location=new System.Drawing.Point(60, 41);
            lbl_Section.Name="lbl_Section";
            lbl_Section.Size=new System.Drawing.Size(132, 19);
            lbl_Section.TabIndex=7;
            lbl_Section.Text="Seleccione Sector:";
            // 
            // lbl_Machine
            // 
            lbl_Machine.Anchor=System.Windows.Forms.AnchorStyles.Top;
            lbl_Machine.AutoSize=true;
            lbl_Machine.Font=new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Machine.Location=new System.Drawing.Point(390, 41);
            lbl_Machine.Name="lbl_Machine";
            lbl_Machine.Size=new System.Drawing.Size(146, 19);
            lbl_Machine.TabIndex=8;
            lbl_Machine.Text="Seleccione Maquina:";
            // 
            // lbl_Urgency
            // 
            lbl_Urgency.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            lbl_Urgency.AutoSize=true;
            lbl_Urgency.Font=new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Urgency.Location=new System.Drawing.Point(720, 41);
            lbl_Urgency.Name="lbl_Urgency";
            lbl_Urgency.Size=new System.Drawing.Size(148, 19);
            lbl_Urgency.TabIndex=9;
            lbl_Urgency.Text="Seleccione Urgencia:";
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize=true;
            lbl_Description.Font=new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Description.Location=new System.Drawing.Point(60, 107);
            lbl_Description.Name="lbl_Description";
            lbl_Description.Size=new System.Drawing.Size(284, 19);
            lbl_Description.TabIndex=10;
            lbl_Description.Text="Ingrese una descripcion de ser necesario:";
            // 
            // btn_Add
            // 
            btn_Add.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Add.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Add.Location=new System.Drawing.Point(732, 508);
            btn_Add.Name="btn_Add";
            btn_Add.Size=new System.Drawing.Size(100, 30);
            btn_Add.TabIndex=11;
            btn_Add.Text="Agregar";
            btn_Add.UseVisualStyleBackColor=true;
            btn_Add.Click+=btn_Add_Click;
            // 
            // FrmAddMaintenanceOrder
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(btn_Add);
            Controls.Add(lbl_Description);
            Controls.Add(lbl_Urgency);
            Controls.Add(lbl_Machine);
            Controls.Add(lbl_Section);
            Controls.Add(richTextBox1);
            Controls.Add(cbb_Urgency);
            Controls.Add(cbb_Section);
            Controls.Add(cbb_Machine);
            Controls.Add(btn_Cancel);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmAddMaintenanceOrder";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmAddMaintenanceOrder";
            Load+=FrmAddMaintenanceOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cbb_Machine;
        private System.Windows.Forms.ComboBox cbb_Section;
        private System.Windows.Forms.ComboBox cbb_Urgency;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_Section;
        private System.Windows.Forms.Label lbl_Machine;
        private System.Windows.Forms.Label lbl_Urgency;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Add;
    }
}