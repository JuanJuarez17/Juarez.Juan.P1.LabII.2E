namespace UI_APP
{
    partial class FrmAddMaintOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddMaintOrder));
            btn_Cancel=new System.Windows.Forms.Button();
            iml_AddMaintOrder=new System.Windows.Forms.ImageList(components);
            cbb_Machine=new System.Windows.Forms.ComboBox();
            cbb_Section=new System.Windows.Forms.ComboBox();
            cbb_Urgency=new System.Windows.Forms.ComboBox();
            rtb_Description=new System.Windows.Forms.RichTextBox();
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
            btn_Cancel.ImageList=iml_AddMaintOrder;
            btn_Cancel.Location=new System.Drawing.Point(573, 149);
            btn_Cancel.Name="btn_Cancel";
            btn_Cancel.Size=new System.Drawing.Size(50, 50);
            btn_Cancel.TabIndex=6;
            btn_Cancel.UseVisualStyleBackColor=true;
            btn_Cancel.Click+=btn_Close_Click;
            // 
            // iml_AddMaintOrder
            // 
            iml_AddMaintOrder.ColorDepth=System.Windows.Forms.ColorDepth.Depth8Bit;
            iml_AddMaintOrder.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("iml_AddMaintOrder.ImageStream");
            iml_AddMaintOrder.TransparentColor=System.Drawing.Color.Transparent;
            iml_AddMaintOrder.Images.SetKeyName(0, "mas.png");
            iml_AddMaintOrder.Images.SetKeyName(1, "lapiz.png");
            iml_AddMaintOrder.Images.SetKeyName(2, "borrar.png");
            iml_AddMaintOrder.Images.SetKeyName(3, "aceptar.png");
            iml_AddMaintOrder.Images.SetKeyName(4, "boton-eliminar.png");
            iml_AddMaintOrder.Images.SetKeyName(5, "lupa.png");
            // 
            // cbb_Machine
            // 
            cbb_Machine.Anchor=System.Windows.Forms.AnchorStyles.Top;
            cbb_Machine.FormattingEnabled=true;
            cbb_Machine.Location=new System.Drawing.Point(77, 73);
            cbb_Machine.Name="cbb_Machine";
            cbb_Machine.Size=new System.Drawing.Size(130, 23);
            cbb_Machine.TabIndex=2;
            // 
            // cbb_Section
            // 
            cbb_Section.FormattingEnabled=true;
            cbb_Section.Location=new System.Drawing.Point(77, 34);
            cbb_Section.Name="cbb_Section";
            cbb_Section.Size=new System.Drawing.Size(130, 23);
            cbb_Section.TabIndex=1;
            // 
            // cbb_Urgency
            // 
            cbb_Urgency.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            cbb_Urgency.FormattingEnabled=true;
            cbb_Urgency.Location=new System.Drawing.Point(77, 112);
            cbb_Urgency.Name="cbb_Urgency";
            cbb_Urgency.Size=new System.Drawing.Size(130, 23);
            cbb_Urgency.TabIndex=3;
            // 
            // rtb_Description
            // 
            rtb_Description.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            rtb_Description.Location=new System.Drawing.Point(223, 34);
            rtb_Description.Name="rtb_Description";
            rtb_Description.Size=new System.Drawing.Size(400, 101);
            rtb_Description.TabIndex=4;
            rtb_Description.Text="";
            // 
            // lbl_Section
            // 
            lbl_Section.AutoSize=true;
            lbl_Section.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Section.Location=new System.Drawing.Point(12, 37);
            lbl_Section.Name="lbl_Section";
            lbl_Section.Size=new System.Drawing.Size(45, 17);
            lbl_Section.TabIndex=0;
            lbl_Section.Text="Sector";
            // 
            // lbl_Machine
            // 
            lbl_Machine.Anchor=System.Windows.Forms.AnchorStyles.Top;
            lbl_Machine.AutoSize=true;
            lbl_Machine.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Machine.Location=new System.Drawing.Point(12, 76);
            lbl_Machine.Name="lbl_Machine";
            lbl_Machine.Size=new System.Drawing.Size(59, 17);
            lbl_Machine.TabIndex=0;
            lbl_Machine.Text="Maquina";
            // 
            // lbl_Urgency
            // 
            lbl_Urgency.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            lbl_Urgency.AutoSize=true;
            lbl_Urgency.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Urgency.Location=new System.Drawing.Point(12, 115);
            lbl_Urgency.Name="lbl_Urgency";
            lbl_Urgency.Size=new System.Drawing.Size(60, 17);
            lbl_Urgency.TabIndex=0;
            lbl_Urgency.Text="Urgencia";
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize=true;
            lbl_Description.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Description.Location=new System.Drawing.Point(223, 14);
            lbl_Description.Name="lbl_Description";
            lbl_Description.Size=new System.Drawing.Size(220, 17);
            lbl_Description.TabIndex=0;
            lbl_Description.Text="Descripcion (Maximo 200 Carateres)";
            // 
            // btn_Add
            // 
            btn_Add.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Add.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Add.ImageList=iml_AddMaintOrder;
            btn_Add.Location=new System.Drawing.Point(517, 149);
            btn_Add.Name="btn_Add";
            btn_Add.Size=new System.Drawing.Size(50, 50);
            btn_Add.TabIndex=5;
            btn_Add.UseVisualStyleBackColor=true;
            btn_Add.Click+=btn_Add_Click;
            // 
            // FrmAddMaintOrder
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(634, 211);
            Controls.Add(btn_Add);
            Controls.Add(lbl_Description);
            Controls.Add(lbl_Urgency);
            Controls.Add(lbl_Machine);
            Controls.Add(lbl_Section);
            Controls.Add(rtb_Description);
            Controls.Add(cbb_Urgency);
            Controls.Add(cbb_Section);
            Controls.Add(cbb_Machine);
            Controls.Add(btn_Cancel);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmAddMaintOrder";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="Alta Orden de Mantenimiento";
            Load+=FrmAddMaintenanceOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cbb_Machine;
        private System.Windows.Forms.ComboBox cbb_Section;
        private System.Windows.Forms.ComboBox cbb_Urgency;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Label lbl_Section;
        private System.Windows.Forms.Label lbl_Machine;
        private System.Windows.Forms.Label lbl_Urgency;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ImageList iml_AddMaintOrder;
    }
}