namespace UI_APP
{
    partial class FrmInfoMaintOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoMaintOrder));
            btn_Cancel=new System.Windows.Forms.Button();
            iml_InfoMaintOrder=new System.Windows.Forms.ImageList(components);
            rtb_MaintOrderDesc=new System.Windows.Forms.RichTextBox();
            lbl_Section=new System.Windows.Forms.Label();
            lbl_Machine=new System.Windows.Forms.Label();
            lbl_Urgency=new System.Windows.Forms.Label();
            lbl_Description=new System.Windows.Forms.Label();
            txb_MaintOrderMachine=new System.Windows.Forms.TextBox();
            txb_MaintOrderUrgency=new System.Windows.Forms.TextBox();
            lbl_Username=new System.Windows.Forms.Label();
            lbl_Id=new System.Windows.Forms.Label();
            txb_MaintOrderSector=new System.Windows.Forms.TextBox();
            txb_MaintOrderUser=new System.Windows.Forms.TextBox();
            txb_MaintOrderId=new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Cancel.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Cancel.ImageList=iml_InfoMaintOrder;
            btn_Cancel.Location=new System.Drawing.Point(572, 149);
            btn_Cancel.Name="btn_Cancel";
            btn_Cancel.Size=new System.Drawing.Size(50, 50);
            btn_Cancel.TabIndex=3;
            btn_Cancel.UseVisualStyleBackColor=true;
            btn_Cancel.Click+=btn_Cancel_Click;
            // 
            // iml_InfoMaintOrder
            // 
            iml_InfoMaintOrder.ColorDepth=System.Windows.Forms.ColorDepth.Depth8Bit;
            iml_InfoMaintOrder.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("iml_InfoMaintOrder.ImageStream");
            iml_InfoMaintOrder.TransparentColor=System.Drawing.Color.Transparent;
            iml_InfoMaintOrder.Images.SetKeyName(0, "mas.png");
            iml_InfoMaintOrder.Images.SetKeyName(1, "lapiz.png");
            iml_InfoMaintOrder.Images.SetKeyName(2, "borrar.png");
            iml_InfoMaintOrder.Images.SetKeyName(3, "aceptar.png");
            iml_InfoMaintOrder.Images.SetKeyName(4, "boton-eliminar.png");
            iml_InfoMaintOrder.Images.SetKeyName(5, "lupa.png");
            // 
            // rtb_MaintOrderDesc
            // 
            rtb_MaintOrderDesc.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            rtb_MaintOrderDesc.Location=new System.Drawing.Point(223, 33);
            rtb_MaintOrderDesc.Name="rtb_MaintOrderDesc";
            rtb_MaintOrderDesc.ReadOnly=true;
            rtb_MaintOrderDesc.Size=new System.Drawing.Size(400, 101);
            rtb_MaintOrderDesc.TabIndex=14;
            rtb_MaintOrderDesc.Text="";
            // 
            // lbl_Section
            // 
            lbl_Section.AutoSize=true;
            lbl_Section.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Section.Location=new System.Drawing.Point(12, 94);
            lbl_Section.Name="lbl_Section";
            lbl_Section.Size=new System.Drawing.Size(45, 17);
            lbl_Section.TabIndex=15;
            lbl_Section.Text="Sector";
            // 
            // lbl_Machine
            // 
            lbl_Machine.Anchor=System.Windows.Forms.AnchorStyles.Top;
            lbl_Machine.AutoSize=true;
            lbl_Machine.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Machine.Location=new System.Drawing.Point(12, 130);
            lbl_Machine.Name="lbl_Machine";
            lbl_Machine.Size=new System.Drawing.Size(59, 17);
            lbl_Machine.TabIndex=16;
            lbl_Machine.Text="Maquina";
            // 
            // lbl_Urgency
            // 
            lbl_Urgency.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Right;
            lbl_Urgency.AutoSize=true;
            lbl_Urgency.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Urgency.Location=new System.Drawing.Point(12, 169);
            lbl_Urgency.Name="lbl_Urgency";
            lbl_Urgency.Size=new System.Drawing.Size(60, 17);
            lbl_Urgency.TabIndex=17;
            lbl_Urgency.Text="Urgencia";
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize=true;
            lbl_Description.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Description.Location=new System.Drawing.Point(223, 13);
            lbl_Description.Name="lbl_Description";
            lbl_Description.Size=new System.Drawing.Size(220, 17);
            lbl_Description.TabIndex=18;
            lbl_Description.Text="Descripcion (Maximo 200 Carateres)";
            // 
            // txb_MaintOrderMachine
            // 
            txb_MaintOrderMachine.Location=new System.Drawing.Point(77, 127);
            txb_MaintOrderMachine.Name="txb_MaintOrderMachine";
            txb_MaintOrderMachine.ReadOnly=true;
            txb_MaintOrderMachine.Size=new System.Drawing.Size(130, 23);
            txb_MaintOrderMachine.TabIndex=20;
            // 
            // txb_MaintOrderUrgency
            // 
            txb_MaintOrderUrgency.Location=new System.Drawing.Point(77, 166);
            txb_MaintOrderUrgency.Name="txb_MaintOrderUrgency";
            txb_MaintOrderUrgency.ReadOnly=true;
            txb_MaintOrderUrgency.Size=new System.Drawing.Size(130, 23);
            txb_MaintOrderUrgency.TabIndex=21;
            // 
            // lbl_Username
            // 
            lbl_Username.Anchor=System.Windows.Forms.AnchorStyles.Top;
            lbl_Username.AutoSize=true;
            lbl_Username.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Username.Location=new System.Drawing.Point(12, 56);
            lbl_Username.Name="lbl_Username";
            lbl_Username.Size=new System.Drawing.Size(53, 17);
            lbl_Username.TabIndex=23;
            lbl_Username.Text="Usuario";
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize=true;
            lbl_Id.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Id.Location=new System.Drawing.Point(12, 18);
            lbl_Id.Name="lbl_Id";
            lbl_Id.Size=new System.Drawing.Size(20, 17);
            lbl_Id.TabIndex=22;
            lbl_Id.Text="ID";
            // 
            // txb_MaintOrderSector
            // 
            txb_MaintOrderSector.Location=new System.Drawing.Point(77, 91);
            txb_MaintOrderSector.Name="txb_MaintOrderSector";
            txb_MaintOrderSector.ReadOnly=true;
            txb_MaintOrderSector.Size=new System.Drawing.Size(130, 23);
            txb_MaintOrderSector.TabIndex=19;
            // 
            // txb_MaintOrderUser
            // 
            txb_MaintOrderUser.Location=new System.Drawing.Point(77, 53);
            txb_MaintOrderUser.Name="txb_MaintOrderUser";
            txb_MaintOrderUser.ReadOnly=true;
            txb_MaintOrderUser.Size=new System.Drawing.Size(130, 23);
            txb_MaintOrderUser.TabIndex=25;
            // 
            // txb_MaintOrderId
            // 
            txb_MaintOrderId.Location=new System.Drawing.Point(77, 15);
            txb_MaintOrderId.Name="txb_MaintOrderId";
            txb_MaintOrderId.ReadOnly=true;
            txb_MaintOrderId.Size=new System.Drawing.Size(130, 23);
            txb_MaintOrderId.TabIndex=24;
            // 
            // FrmInfoMaintOrder
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(634, 211);
            Controls.Add(txb_MaintOrderUser);
            Controls.Add(txb_MaintOrderId);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_Id);
            Controls.Add(txb_MaintOrderUrgency);
            Controls.Add(txb_MaintOrderMachine);
            Controls.Add(txb_MaintOrderSector);
            Controls.Add(lbl_Description);
            Controls.Add(lbl_Urgency);
            Controls.Add(lbl_Machine);
            Controls.Add(lbl_Section);
            Controls.Add(rtb_MaintOrderDesc);
            Controls.Add(btn_Cancel);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmInfoMaintOrder";
            SizeGripStyle=System.Windows.Forms.SizeGripStyle.Show;
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmInfoMaintOrder";
            Load+=FrmInfoMaintOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ImageList iml_InfoMaintOrder;
        private System.Windows.Forms.RichTextBox rtb_MaintOrderDesc;
        private System.Windows.Forms.Label lbl_Section;
        private System.Windows.Forms.Label lbl_Machine;
        private System.Windows.Forms.Label lbl_Urgency;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txb_MaintOrderMachine;
        private System.Windows.Forms.TextBox txb_MaintOrderUrgency;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txb_MaintOrderSector;
        private System.Windows.Forms.TextBox txb_MaintOrderUser;
        private System.Windows.Forms.TextBox txb_MaintOrderId;
        private System.Windows.Forms.ComboBox cbb_Urgency;
        private System.Windows.Forms.ComboBox cbb_Machine;
    }
}