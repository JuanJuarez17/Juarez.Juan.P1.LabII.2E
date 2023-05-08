namespace UI_APP
{
    partial class FrmListMaintenanceOrder
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
            rtb_Test=new System.Windows.Forms.RichTextBox();
            btn_Close=new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // rtb_Test
            // 
            rtb_Test.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            rtb_Test.Location=new System.Drawing.Point(35, 29);
            rtb_Test.Name="rtb_Test";
            rtb_Test.Size=new System.Drawing.Size(880, 327);
            rtb_Test.TabIndex=0;
            rtb_Test.Text="";
            // 
            // btn_Close
            // 
            btn_Close.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Close.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Close.Location=new System.Drawing.Point(838, 508);
            btn_Close.Name="btn_Close";
            btn_Close.Size=new System.Drawing.Size(100, 30);
            btn_Close.TabIndex=1;
            btn_Close.Text="Cerrar";
            btn_Close.UseVisualStyleBackColor=true;
            btn_Close.Click+=btn_Close_Click;
            // 
            // FrmListMaintenanceOrder
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(btn_Close);
            Controls.Add(rtb_Test);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmListMaintenanceOrder";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmListMaintenanceOrder";
            Load+=FrmListMaintenanceOrder_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Test;
        private System.Windows.Forms.Button btn_Close;
    }
}