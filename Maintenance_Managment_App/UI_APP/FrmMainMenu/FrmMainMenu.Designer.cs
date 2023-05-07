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
            smi_LoadWO=new System.Windows.Forms.ToolStripMenuItem();
            smi_SeeWO=new System.Windows.Forms.ToolStripMenuItem();
            smi_Operators=new System.Windows.Forms.ToolStripMenuItem();
            lbl_Test=new System.Windows.Forms.Label();
            rtb_Test=new System.Windows.Forms.RichTextBox();
            mst_MainMenuOpt.SuspendLayout();
            SuspendLayout();
            // 
            // mst_MainMenuOpt
            // 
            mst_MainMenuOpt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { smi_LoadWO, smi_SeeWO, smi_Operators });
            mst_MainMenuOpt.Location=new System.Drawing.Point(0, 0);
            mst_MainMenuOpt.Name="mst_MainMenuOpt";
            mst_MainMenuOpt.Size=new System.Drawing.Size(784, 24);
            mst_MainMenuOpt.TabIndex=0;
            mst_MainMenuOpt.Text="menuStrip1";
            // 
            // smi_LoadWO
            // 
            smi_LoadWO.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            smi_LoadWO.Name="smi_LoadWO";
            smi_LoadWO.Size=new System.Drawing.Size(71, 20);
            smi_LoadWO.Text="Cargar OT";
            // 
            // smi_SeeWO
            // 
            smi_SeeWO.Name="smi_SeeWO";
            smi_SeeWO.Size=new System.Drawing.Size(52, 20);
            smi_SeeWO.Text="Ver OT";
            // 
            // smi_Operators
            // 
            smi_Operators.Name="smi_Operators";
            smi_Operators.Size=new System.Drawing.Size(70, 20);
            smi_Operators.Text="Operarios";
            // 
            // lbl_Test
            // 
            lbl_Test.Font=new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Test.Location=new System.Drawing.Point(199, 40);
            lbl_Test.Name="lbl_Test";
            lbl_Test.Size=new System.Drawing.Size(386, 30);
            lbl_Test.TabIndex=1;
            lbl_Test.Text="label1";
            lbl_Test.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb_Test
            // 
            rtb_Test.Location=new System.Drawing.Point(17, 98);
            rtb_Test.Name="rtb_Test";
            rtb_Test.Size=new System.Drawing.Size(750, 200);
            rtb_Test.TabIndex=2;
            rtb_Test.Text="";
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(784, 461);
            Controls.Add(rtb_Test);
            Controls.Add(lbl_Test);
            Controls.Add(mst_MainMenuOpt);
            Name="FrmMainMenu";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="Maintenance Management Assistant";
            FormClosing+=FrmMainMenu_FormClosing;
            Load+=FrmMainMenu_Load;
            mst_MainMenuOpt.ResumeLayout(false);
            mst_MainMenuOpt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mst_MainMenuOpt;
        private System.Windows.Forms.ToolStripMenuItem smi_LoadWO;
        private System.Windows.Forms.ToolStripMenuItem smi_SeeWO;
        private System.Windows.Forms.ToolStripMenuItem smi_Operators;
        private System.Windows.Forms.Label lbl_Test;
        private System.Windows.Forms.RichTextBox rtb_Test;
    }
}