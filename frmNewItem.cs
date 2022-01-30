using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the inventory item.
        private InvItem item = null;
        public InvItem GetInv()
        {
            this.ShowDialog();
            return item;
        }
        // Add a method here that gets and returns a new item.

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Add code here that creates a new item
                // and closes the form.
                if (rdioPlant.Checked)
                {
                    item = new Plant(txtItemNo.Text, txtSize.Text, txtDescription.Text, txtPrice.Text);
                }
                if (rdioSupply.Checked)
                {
                    item = new Supply(txtItemNo.Text, cmbManifact.Text, txtDescription.Text, txtPrice.Text);
                }
                
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewItem_Load(object sender, EventArgs e)
        {

        }

        private void rdioPlant_CheckedChanged(object sender, EventArgs e)
        {
            txtSize.Visible = true;
            lblSize.Visible = true;
            
        }

        private void rdioSupply_CheckedChanged(object sender, EventArgs e)
        {
            lblManifactur.Visible = true;
            cmbManifact.Visible = true; 
        }
    }
}
