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
            components=new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListMaintenanceOrder));
            btn_Close=new System.Windows.Forms.Button();
            dtg_MaintOrderDB=new System.Windows.Forms.DataGridView();
            btn_AddMaintOrder=new System.Windows.Forms.Button();
            iml_ListMaintOrder=new System.Windows.Forms.ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dtg_MaintOrderDB).BeginInit();
            SuspendLayout();
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
            // dtg_MaintOrderDB
            // 
            dtg_MaintOrderDB.AllowUserToAddRows=false;
            dtg_MaintOrderDB.AllowUserToDeleteRows=false;
            dtg_MaintOrderDB.AllowUserToResizeColumns=false;
            dtg_MaintOrderDB.AllowUserToResizeRows=false;
            dtg_MaintOrderDB.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            dtg_MaintOrderDB.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor=System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            dtg_MaintOrderDB.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle4;
            dtg_MaintOrderDB.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor=System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor=System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            dtg_MaintOrderDB.DefaultCellStyle=dataGridViewCellStyle5;
            dtg_MaintOrderDB.EnableHeadersVisualStyles=false;
            dtg_MaintOrderDB.Location=new System.Drawing.Point(88, 12);
            dtg_MaintOrderDB.MultiSelect=false;
            dtg_MaintOrderDB.Name="dtg_MaintOrderDB";
            dtg_MaintOrderDB.ReadOnly=true;
            dataGridViewCellStyle6.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor=System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            dtg_MaintOrderDB.RowHeadersDefaultCellStyle=dataGridViewCellStyle6;
            dtg_MaintOrderDB.RowHeadersVisible=false;
            dtg_MaintOrderDB.RowTemplate.Height=25;
            dtg_MaintOrderDB.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtg_MaintOrderDB.Size=new System.Drawing.Size(850, 400);
            dtg_MaintOrderDB.TabIndex=2;
            dtg_MaintOrderDB.TabStop=false;
            dtg_MaintOrderDB.VirtualMode=true;
            // 
            // btn_AddMaintOrder
            // 
            btn_AddMaintOrder.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_AddMaintOrder.ImageList=iml_ListMaintOrder;
            btn_AddMaintOrder.Location=new System.Drawing.Point(12, 12);
            btn_AddMaintOrder.Name="btn_AddMaintOrder";
            btn_AddMaintOrder.Size=new System.Drawing.Size(50, 50);
            btn_AddMaintOrder.TabIndex=3;
            btn_AddMaintOrder.UseVisualStyleBackColor=true;
            btn_AddMaintOrder.Click+=btn_AddMaintOrder_Click;
            // 
            // iml_ListMaintOrder
            // 
            iml_ListMaintOrder.ColorDepth=System.Windows.Forms.ColorDepth.Depth8Bit;
            iml_ListMaintOrder.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("iml_ListMaintOrder.ImageStream");
            iml_ListMaintOrder.TransparentColor=System.Drawing.Color.Transparent;
            iml_ListMaintOrder.Images.SetKeyName(0, "plus.png");
            // 
            // FrmListMaintenanceOrder
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(btn_AddMaintOrder);
            Controls.Add(dtg_MaintOrderDB);
            Controls.Add(btn_Close);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmListMaintenanceOrder";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmListMaintenanceOrder";
            Load+=FrmListMaintenanceOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_MaintOrderDB).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dtg_MaintOrderDB;
        private System.Windows.Forms.Button btn_AddMaintOrder;
        private System.Windows.Forms.ImageList iml_ListMaintOrder;
    }
}