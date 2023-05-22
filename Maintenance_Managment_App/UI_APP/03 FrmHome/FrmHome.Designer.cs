namespace UI_APP
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            txb_FinishedOrders=new System.Windows.Forms.TextBox();
            lbl_FinishedOrders=new System.Windows.Forms.Label();
            txb_UnfinishedOrders=new System.Windows.Forms.TextBox();
            lbl_UnfinishedOrders=new System.Windows.Forms.Label();
            lbl_MaintOrderDb=new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txb_FinishedOrders
            // 
            txb_FinishedOrders.Location=new System.Drawing.Point(172, 12);
            txb_FinishedOrders.Name="txb_FinishedOrders";
            txb_FinishedOrders.ReadOnly=true;
            txb_FinishedOrders.Size=new System.Drawing.Size(130, 23);
            txb_FinishedOrders.TabIndex=26;
            // 
            // lbl_FinishedOrders
            // 
            lbl_FinishedOrders.AutoSize=true;
            lbl_FinishedOrders.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_FinishedOrders.Location=new System.Drawing.Point(22, 15);
            lbl_FinishedOrders.Name="lbl_FinishedOrders";
            lbl_FinishedOrders.Size=new System.Drawing.Size(127, 17);
            lbl_FinishedOrders.TabIndex=25;
            lbl_FinishedOrders.Text="Ordenes terminadas";
            // 
            // txb_UnfinishedOrders
            // 
            txb_UnfinishedOrders.Location=new System.Drawing.Point(172, 41);
            txb_UnfinishedOrders.Name="txb_UnfinishedOrders";
            txb_UnfinishedOrders.ReadOnly=true;
            txb_UnfinishedOrders.Size=new System.Drawing.Size(130, 23);
            txb_UnfinishedOrders.TabIndex=28;
            // 
            // lbl_UnfinishedOrders
            // 
            lbl_UnfinishedOrders.AutoSize=true;
            lbl_UnfinishedOrders.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_UnfinishedOrders.Location=new System.Drawing.Point(22, 44);
            lbl_UnfinishedOrders.Name="lbl_UnfinishedOrders";
            lbl_UnfinishedOrders.Size=new System.Drawing.Size(136, 17);
            lbl_UnfinishedOrders.TabIndex=27;
            lbl_UnfinishedOrders.Text="Ordenes por terminar";
            // 
            // lbl_MaintOrderDb
            // 
            lbl_MaintOrderDb.Font=new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_MaintOrderDb.Location=new System.Drawing.Point(215, 175);
            lbl_MaintOrderDb.Name="lbl_MaintOrderDb";
            lbl_MaintOrderDb.Size=new System.Drawing.Size(520, 200);
            lbl_MaintOrderDb.TabIndex=29;
            lbl_MaintOrderDb.Text=resources.GetString("lbl_MaintOrderDb.Text");
            lbl_MaintOrderDb.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(lbl_MaintOrderDb);
            Controls.Add(txb_UnfinishedOrders);
            Controls.Add(lbl_UnfinishedOrders);
            Controls.Add(txb_FinishedOrders);
            Controls.Add(lbl_FinishedOrders);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmHome";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmHome";
            Load+=FrmHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txb_FinishedOrders;
        private System.Windows.Forms.Label lbl_FinishedOrders;
        private System.Windows.Forms.TextBox txb_UnfinishedOrders;
        private System.Windows.Forms.Label lbl_UnfinishedOrders;
        private System.Windows.Forms.Label lbl_MaintOrderDb;
    }
}