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
            btn_Close=new System.Windows.Forms.Button();
            cbb_Machine=new System.Windows.Forms.ComboBox();
            cbb_Section=new System.Windows.Forms.ComboBox();
            cbb_Urgency=new System.Windows.Forms.ComboBox();
            richTextBox1=new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Close.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Close.Location=new System.Drawing.Point(838, 508);
            btn_Close.Name="btn_Close";
            btn_Close.Size=new System.Drawing.Size(100, 30);
            btn_Close.TabIndex=2;
            btn_Close.Text="Cerrar";
            btn_Close.UseVisualStyleBackColor=true;
            btn_Close.Click+=btn_Close_Click;
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
            // FrmAddMaintenanceOrder
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(richTextBox1);
            Controls.Add(cbb_Urgency);
            Controls.Add(cbb_Section);
            Controls.Add(cbb_Machine);
            Controls.Add(btn_Close);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmAddMaintenanceOrder";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmAddMaintenanceOrder";
            Load+=FrmAddMaintenanceOrder_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cbb_Machine;
        private System.Windows.Forms.ComboBox cbb_Section;
        private System.Windows.Forms.ComboBox cbb_Urgency;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}