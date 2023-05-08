namespace UI_APP
{
    partial class FrmMainMenu
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
            mst_MainMenuOpt=new System.Windows.Forms.MenuStrip();
            smi_MaintOrder=new System.Windows.Forms.ToolStripMenuItem();
            smi_AddMaintenanceOrder=new System.Windows.Forms.ToolStripMenuItem();
            smi_EditMaintenanceOrder=new System.Windows.Forms.ToolStripMenuItem();
            smi_ListMaintenanceOrder=new System.Windows.Forms.ToolStripMenuItem();
            smi_Operator=new System.Windows.Forms.ToolStripMenuItem();
            sts_Status=new System.Windows.Forms.StatusStrip();
            tss_User=new System.Windows.Forms.ToolStripStatusLabel();
            tss_Status=new System.Windows.Forms.ToolStripStatusLabel();
            eliminarOMToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            mst_MainMenuOpt.SuspendLayout();
            sts_Status.SuspendLayout();
            SuspendLayout();
            // 
            // mst_MainMenuOpt
            // 
            mst_MainMenuOpt.GripStyle=System.Windows.Forms.ToolStripGripStyle.Visible;
            mst_MainMenuOpt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { smi_MaintOrder, smi_Operator });
            mst_MainMenuOpt.Location=new System.Drawing.Point(0, 0);
            mst_MainMenuOpt.Name="mst_MainMenuOpt";
            mst_MainMenuOpt.Size=new System.Drawing.Size(984, 24);
            mst_MainMenuOpt.TabIndex=0;
            mst_MainMenuOpt.Text="menuStrip1";
            // 
            // smi_MaintOrder
            // 
            smi_MaintOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { smi_AddMaintenanceOrder, smi_EditMaintenanceOrder, eliminarOMToolStripMenuItem, smi_ListMaintenanceOrder });
            smi_MaintOrder.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            smi_MaintOrder.Name="smi_MaintOrder";
            smi_MaintOrder.Size=new System.Drawing.Size(137, 20);
            smi_MaintOrder.Text="Orden Mantenimiento";
            // 
            // smi_AddMaintenanceOrder
            // 
            smi_AddMaintenanceOrder.Name="smi_AddMaintenanceOrder";
            smi_AddMaintenanceOrder.Size=new System.Drawing.Size(148, 22);
            smi_AddMaintenanceOrder.Text="Agregar OM";
            smi_AddMaintenanceOrder.Click+=cargarToolStripMenuItem_Click;
            // 
            // smi_EditMaintenanceOrder
            // 
            smi_EditMaintenanceOrder.Name="smi_EditMaintenanceOrder";
            smi_EditMaintenanceOrder.Size=new System.Drawing.Size(148, 22);
            smi_EditMaintenanceOrder.Text="Modificar OM";
            // 
            // smi_ListMaintenanceOrder
            // 
            smi_ListMaintenanceOrder.Name="smi_ListMaintenanceOrder";
            smi_ListMaintenanceOrder.Size=new System.Drawing.Size(180, 22);
            smi_ListMaintenanceOrder.Text="Ver";
            smi_ListMaintenanceOrder.Click+=verToolStripMenuItem_Click;
            // 
            // smi_Operator
            // 
            smi_Operator.Name="smi_Operator";
            smi_Operator.Size=new System.Drawing.Size(65, 20);
            smi_Operator.Text="Operario";
            // 
            // sts_Status
            // 
            sts_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tss_User, tss_Status });
            sts_Status.Location=new System.Drawing.Point(0, 539);
            sts_Status.Name="sts_Status";
            sts_Status.Size=new System.Drawing.Size(984, 22);
            sts_Status.TabIndex=6;
            sts_Status.Text="statusStrip1";
            // 
            // tss_User
            // 
            tss_User.Name="tss_User";
            tss_User.Size=new System.Drawing.Size(49, 17);
            tss_User.Text="tss_User";
            // 
            // tss_Status
            // 
            tss_Status.Name="tss_Status";
            tss_Status.Size=new System.Drawing.Size(58, 17);
            tss_Status.Text="tss_Status";
            // 
            // eliminarOMToolStripMenuItem
            // 
            eliminarOMToolStripMenuItem.Name="eliminarOMToolStripMenuItem";
            eliminarOMToolStripMenuItem.Size=new System.Drawing.Size(148, 22);
            eliminarOMToolStripMenuItem.Text="Eliminar OM";
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(984, 561);
            Controls.Add(sts_Status);
            Controls.Add(mst_MainMenuOpt);
            IsMdiContainer=true;
            Name="FrmMainMenu";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="Maintenance Management Assistant";
            FormClosing+=FrmMainMenu_FormClosing;
            Load+=FrmMainMenu_Load;
            mst_MainMenuOpt.ResumeLayout(false);
            mst_MainMenuOpt.PerformLayout();
            sts_Status.ResumeLayout(false);
            sts_Status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mst_MainMenuOpt;
        private System.Windows.Forms.ToolStripMenuItem smi_MaintOrder;
        private System.Windows.Forms.ToolStripMenuItem smi_Operator;
        private System.Windows.Forms.ToolStripMenuItem smi_AddMaintenanceOrder;
        private System.Windows.Forms.ToolStripMenuItem smi_EditMaintenanceOrder;
        private System.Windows.Forms.ToolStripMenuItem smi_ListMaintenanceOrder;
        private System.Windows.Forms.StatusStrip sts_Status;
        private System.Windows.Forms.ToolStripStatusLabel tss_User;
        private System.Windows.Forms.ToolStripStatusLabel tss_Status;
        private System.Windows.Forms.ToolStripMenuItem eliminarOMToolStripMenuItem;
    }
}