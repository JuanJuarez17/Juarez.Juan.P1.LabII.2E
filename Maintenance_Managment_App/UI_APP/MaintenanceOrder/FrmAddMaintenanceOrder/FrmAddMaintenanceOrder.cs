﻿using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_APP.MaintenanceOrder.FrmAddMaintenanceOrder
{
    public partial class FrmAddMaintenanceOrder : Form
    {
        private User activeUser;
        private FrmAddMaintenanceOrder()
        {
            InitializeComponent();
        }
        public FrmAddMaintenanceOrder(User inputUser) : this()
        {
            this.activeUser = inputUser;
        }
        private void FrmAddMaintenanceOrder_Load(object sender, EventArgs e)
        {
            this.cbb_Section.DataSource = Enum.GetValues(typeof(Section));
            this.cbb_Machine.DataSource = Enum.GetValues(typeof(Machine));
            this.cbb_Urgency.DataSource = Enum.GetValues(typeof(Urgency));
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}