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
            components=new System.ComponentModel.Container();
            txb_FinishedOrders=new System.Windows.Forms.TextBox();
            lbl_FinishedOrders=new System.Windows.Forms.Label();
            txb_UnfinishedOrders=new System.Windows.Forms.TextBox();
            lbl_UnfinishedOrders=new System.Windows.Forms.Label();
            lbl_MaintOrderDb=new System.Windows.Forms.Label();
            lbl_Welcome=new System.Windows.Forms.Label();
            pcb_Front=new System.Windows.Forms.PictureBox();
            txb_RushOrders=new System.Windows.Forms.TextBox();
            lbl_RushOrders=new System.Windows.Forms.Label();
            txb_IdRushOrders=new System.Windows.Forms.TextBox();
            lbl_IdRushOrders=new System.Windows.Forms.Label();
            lbl_DateTime=new System.Windows.Forms.Label();
            tmr_FrmHome=new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcb_Front).BeginInit();
            SuspendLayout();
            // 
            // txb_FinishedOrders
            // 
            txb_FinishedOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            txb_FinishedOrders.Location=new System.Drawing.Point(546, 253);
            txb_FinishedOrders.Name="txb_FinishedOrders";
            txb_FinishedOrders.ReadOnly=true;
            txb_FinishedOrders.Size=new System.Drawing.Size(100, 23);
            txb_FinishedOrders.TabIndex=1;
            txb_FinishedOrders.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_FinishedOrders
            // 
            lbl_FinishedOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            lbl_FinishedOrders.AutoSize=true;
            lbl_FinishedOrders.BackColor=System.Drawing.Color.White;
            lbl_FinishedOrders.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_FinishedOrders.Location=new System.Drawing.Point(304, 256);
            lbl_FinishedOrders.Name="lbl_FinishedOrders";
            lbl_FinishedOrders.Size=new System.Drawing.Size(127, 17);
            lbl_FinishedOrders.TabIndex=0;
            lbl_FinishedOrders.Text="Ordenes terminadas";
            // 
            // txb_UnfinishedOrders
            // 
            txb_UnfinishedOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            txb_UnfinishedOrders.Location=new System.Drawing.Point(546, 282);
            txb_UnfinishedOrders.Name="txb_UnfinishedOrders";
            txb_UnfinishedOrders.ReadOnly=true;
            txb_UnfinishedOrders.Size=new System.Drawing.Size(100, 23);
            txb_UnfinishedOrders.TabIndex=2;
            txb_UnfinishedOrders.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_UnfinishedOrders
            // 
            lbl_UnfinishedOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            lbl_UnfinishedOrders.AutoSize=true;
            lbl_UnfinishedOrders.BackColor=System.Drawing.Color.White;
            lbl_UnfinishedOrders.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_UnfinishedOrders.Location=new System.Drawing.Point(304, 285);
            lbl_UnfinishedOrders.Name="lbl_UnfinishedOrders";
            lbl_UnfinishedOrders.Size=new System.Drawing.Size(136, 17);
            lbl_UnfinishedOrders.TabIndex=0;
            lbl_UnfinishedOrders.Text="Ordenes por terminar";
            // 
            // lbl_MaintOrderDb
            // 
            lbl_MaintOrderDb.Anchor=System.Windows.Forms.AnchorStyles.None;
            lbl_MaintOrderDb.BackColor=System.Drawing.Color.White;
            lbl_MaintOrderDb.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_MaintOrderDb.Location=new System.Drawing.Point(285, 222);
            lbl_MaintOrderDb.Name="lbl_MaintOrderDb";
            lbl_MaintOrderDb.Size=new System.Drawing.Size(380, 150);
            lbl_MaintOrderDb.TabIndex=0;
            lbl_MaintOrderDb.Text="\r\nlbl_MaintOrderDb";
            lbl_MaintOrderDb.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.Anchor=System.Windows.Forms.AnchorStyles.None;
            lbl_Welcome.BackColor=System.Drawing.Color.White;
            lbl_Welcome.Font=new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Welcome.Location=new System.Drawing.Point(285, 136);
            lbl_Welcome.Name="lbl_Welcome";
            lbl_Welcome.Size=new System.Drawing.Size(380, 40);
            lbl_Welcome.TabIndex=0;
            lbl_Welcome.Text="lbl_Welcome";
            lbl_Welcome.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcb_Front
            // 
            pcb_Front.Anchor=System.Windows.Forms.AnchorStyles.None;
            pcb_Front.BackColor=System.Drawing.Color.White;
            pcb_Front.Location=new System.Drawing.Point(275, 125);
            pcb_Front.Name="pcb_Front";
            pcb_Front.Size=new System.Drawing.Size(400, 300);
            pcb_Front.TabIndex=31;
            pcb_Front.TabStop=false;
            // 
            // txb_RushOrders
            // 
            txb_RushOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            txb_RushOrders.Location=new System.Drawing.Point(546, 311);
            txb_RushOrders.Name="txb_RushOrders";
            txb_RushOrders.ReadOnly=true;
            txb_RushOrders.Size=new System.Drawing.Size(100, 23);
            txb_RushOrders.TabIndex=3;
            txb_RushOrders.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RushOrders
            // 
            lbl_RushOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            lbl_RushOrders.AutoSize=true;
            lbl_RushOrders.BackColor=System.Drawing.Color.White;
            lbl_RushOrders.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_RushOrders.Location=new System.Drawing.Point(304, 314);
            lbl_RushOrders.Name="lbl_RushOrders";
            lbl_RushOrders.Size=new System.Drawing.Size(202, 17);
            lbl_RushOrders.TabIndex=0;
            lbl_RushOrders.Text="Ordenes por terminar - Urgentes";
            // 
            // txb_IdRushOrders
            // 
            txb_IdRushOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            txb_IdRushOrders.Location=new System.Drawing.Point(546, 340);
            txb_IdRushOrders.Name="txb_IdRushOrders";
            txb_IdRushOrders.ReadOnly=true;
            txb_IdRushOrders.Size=new System.Drawing.Size(100, 23);
            txb_IdRushOrders.TabIndex=4;
            txb_IdRushOrders.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_IdRushOrders
            // 
            lbl_IdRushOrders.Anchor=System.Windows.Forms.AnchorStyles.None;
            lbl_IdRushOrders.AutoSize=true;
            lbl_IdRushOrders.BackColor=System.Drawing.Color.White;
            lbl_IdRushOrders.Font=new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_IdRushOrders.Location=new System.Drawing.Point(304, 343);
            lbl_IdRushOrders.Name="lbl_IdRushOrders";
            lbl_IdRushOrders.Size=new System.Drawing.Size(227, 17);
            lbl_IdRushOrders.TabIndex=0;
            lbl_IdRushOrders.Text="Ordenes por terminar - Urgentes - ID";
            // 
            // lbl_DateTime
            // 
            lbl_DateTime.Anchor=System.Windows.Forms.AnchorStyles.None;
            lbl_DateTime.BackColor=System.Drawing.Color.White;
            lbl_DateTime.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_DateTime.Location=new System.Drawing.Point(285, 176);
            lbl_DateTime.Name="lbl_DateTime";
            lbl_DateTime.Size=new System.Drawing.Size(380, 40);
            lbl_DateTime.TabIndex=0;
            lbl_DateTime.Text="lbl_DateTime";
            lbl_DateTime.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_FrmHome
            // 
            tmr_FrmHome.Enabled=true;
            tmr_FrmHome.Interval=1000;
            tmr_FrmHome.Tick+=tmr_FrmHome_Tick;
            // 
            // FrmHome
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            BackColor=System.Drawing.SystemColors.Control;
            BackgroundImage=Properties.Resources.FrmHomeBackgroundImage;
            BackgroundImageLayout=System.Windows.Forms.ImageLayout.Stretch;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(lbl_DateTime);
            Controls.Add(txb_IdRushOrders);
            Controls.Add(lbl_IdRushOrders);
            Controls.Add(txb_RushOrders);
            Controls.Add(lbl_RushOrders);
            Controls.Add(lbl_Welcome);
            Controls.Add(txb_UnfinishedOrders);
            Controls.Add(lbl_UnfinishedOrders);
            Controls.Add(txb_FinishedOrders);
            Controls.Add(lbl_FinishedOrders);
            Controls.Add(lbl_MaintOrderDb);
            Controls.Add(pcb_Front);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmHome";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmHome";
            Load+=FrmHome_Load;
            ((System.ComponentModel.ISupportInitialize)pcb_Front).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txb_FinishedOrders;
        private System.Windows.Forms.Label lbl_FinishedOrders;
        private System.Windows.Forms.TextBox txb_UnfinishedOrders;
        private System.Windows.Forms.Label lbl_UnfinishedOrders;
        private System.Windows.Forms.Label lbl_MaintOrderDb;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.PictureBox pcb_Front;
        private System.Windows.Forms.TextBox txb_RushOrders;
        private System.Windows.Forms.Label lbl_RushOrders;
        private System.Windows.Forms.TextBox txb_IdRushOrders;
        private System.Windows.Forms.Label lbl_IdRushOrders;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Timer tmr_FrmHome;
    }
}