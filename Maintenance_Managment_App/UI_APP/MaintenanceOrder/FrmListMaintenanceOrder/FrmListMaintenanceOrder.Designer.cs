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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListMaintenanceOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            btn_Close=new System.Windows.Forms.Button();
            iml_ListMaintOrder=new System.Windows.Forms.ImageList(components);
            dtg_MaintOrderDb=new System.Windows.Forms.DataGridView();
            btn_AddMaintOrder=new System.Windows.Forms.Button();
            btn_DeleteMaintOrder=new System.Windows.Forms.Button();
            btn_EditMaintOrder=new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtg_MaintOrderDb).BeginInit();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Anchor=System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right;
            btn_Close.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Close.ImageList=iml_ListMaintOrder;
            btn_Close.Location=new System.Drawing.Point(883, 488);
            btn_Close.Name="btn_Close";
            btn_Close.Size=new System.Drawing.Size(50, 50);
            btn_Close.TabIndex=1;
            btn_Close.UseVisualStyleBackColor=true;
            btn_Close.Click+=btn_Close_Click;
            // 
            // iml_ListMaintOrder
            // 
            iml_ListMaintOrder.ColorDepth=System.Windows.Forms.ColorDepth.Depth8Bit;
            iml_ListMaintOrder.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("iml_ListMaintOrder.ImageStream");
            iml_ListMaintOrder.TransparentColor=System.Drawing.Color.Transparent;
            iml_ListMaintOrder.Images.SetKeyName(0, "mas.png");
            iml_ListMaintOrder.Images.SetKeyName(1, "lapiz.png");
            iml_ListMaintOrder.Images.SetKeyName(2, "borrar.png");
            iml_ListMaintOrder.Images.SetKeyName(3, "marca-de-la-cruz.png");
            // 
            // dtg_MaintOrderDb
            // 
            dtg_MaintOrderDb.AllowUserToAddRows=false;
            dtg_MaintOrderDb.AllowUserToDeleteRows=false;
            dtg_MaintOrderDb.AllowUserToResizeColumns=false;
            dtg_MaintOrderDb.AllowUserToResizeRows=false;
            dtg_MaintOrderDb.Anchor=System.Windows.Forms.AnchorStyles.Top|System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Left|System.Windows.Forms.AnchorStyles.Right;
            dtg_MaintOrderDb.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor=System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            dtg_MaintOrderDb.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle1;
            dtg_MaintOrderDb.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor=System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor=System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            dtg_MaintOrderDb.DefaultCellStyle=dataGridViewCellStyle2;
            dtg_MaintOrderDb.EnableHeadersVisualStyles=false;
            dtg_MaintOrderDb.Location=new System.Drawing.Point(83, 12);
            dtg_MaintOrderDb.MultiSelect=false;
            dtg_MaintOrderDb.Name="dtg_MaintOrderDb";
            dtg_MaintOrderDb.ReadOnly=true;
            dataGridViewCellStyle3.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            dtg_MaintOrderDb.RowHeadersDefaultCellStyle=dataGridViewCellStyle3;
            dtg_MaintOrderDb.RowHeadersVisible=false;
            dtg_MaintOrderDb.RowTemplate.Height=25;
            dtg_MaintOrderDb.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtg_MaintOrderDb.Size=new System.Drawing.Size(850, 450);
            dtg_MaintOrderDb.TabIndex=2;
            dtg_MaintOrderDb.TabStop=false;
            dtg_MaintOrderDb.VirtualMode=true;
            // 
            // btn_AddMaintOrder
            // 
            btn_AddMaintOrder.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_AddMaintOrder.ImageList=iml_ListMaintOrder;
            btn_AddMaintOrder.Location=new System.Drawing.Point(18, 12);
            btn_AddMaintOrder.Name="btn_AddMaintOrder";
            btn_AddMaintOrder.Size=new System.Drawing.Size(50, 50);
            btn_AddMaintOrder.TabIndex=3;
            btn_AddMaintOrder.UseVisualStyleBackColor=true;
            btn_AddMaintOrder.Click+=btn_AddMaintOrder_Click;
            // 
            // btn_DeleteMaintOrder
            // 
            btn_DeleteMaintOrder.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_DeleteMaintOrder.ImageList=iml_ListMaintOrder;
            btn_DeleteMaintOrder.Location=new System.Drawing.Point(18, 124);
            btn_DeleteMaintOrder.Name="btn_DeleteMaintOrder";
            btn_DeleteMaintOrder.Size=new System.Drawing.Size(50, 50);
            btn_DeleteMaintOrder.TabIndex=4;
            btn_DeleteMaintOrder.UseVisualStyleBackColor=true;
            btn_DeleteMaintOrder.Click+=btn_DeleteMaintOrder_Click;
            // 
            // btn_EditMaintOrder
            // 
            btn_EditMaintOrder.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_EditMaintOrder.ImageList=iml_ListMaintOrder;
            btn_EditMaintOrder.Location=new System.Drawing.Point(18, 68);
            btn_EditMaintOrder.Name="btn_EditMaintOrder";
            btn_EditMaintOrder.Size=new System.Drawing.Size(50, 50);
            btn_EditMaintOrder.TabIndex=5;
            btn_EditMaintOrder.UseVisualStyleBackColor=true;
            // 
            // FrmListMaintenanceOrder
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(950, 550);
            Controls.Add(btn_EditMaintOrder);
            Controls.Add(btn_DeleteMaintOrder);
            Controls.Add(btn_AddMaintOrder);
            Controls.Add(dtg_MaintOrderDb);
            Controls.Add(btn_Close);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmListMaintenanceOrder";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            Text="FrmListMaintenanceOrder";
            Load+=FrmListMaintenanceOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_MaintOrderDb).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dtg_MaintOrderDb;
        private System.Windows.Forms.Button btn_AddMaintOrder;
        private System.Windows.Forms.ImageList iml_ListMaintOrder;
        private System.Windows.Forms.Button btn_DeleteMaintOrder;
        private System.Windows.Forms.Button btn_EditMaintOrder;
    }
}