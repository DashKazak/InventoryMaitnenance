namespace InventoryMaintenance
{
    partial class frmNewItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdioPlant = new System.Windows.Forms.RadioButton();
            this.rdioSupply = new System.Windows.Forms.RadioButton();
            this.lblManifact = new System.Windows.Forms.Label();
            this.cmbManifact = new System.Windows.Forms.ComboBox();
            this.lblManifactur = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item no:";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(134, 78);
            this.txtItemNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(121, 27);
            this.txtItemNo.TabIndex = 1;
            this.txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 202);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(293, 27);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Tag = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(134, 242);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 27);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 271);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(396, 271);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdioPlant
            // 
            this.rdioPlant.AutoSize = true;
            this.rdioPlant.Location = new System.Drawing.Point(45, 27);
            this.rdioPlant.Name = "rdioPlant";
            this.rdioPlant.Size = new System.Drawing.Size(63, 25);
            this.rdioPlant.TabIndex = 8;
            this.rdioPlant.TabStop = true;
            this.rdioPlant.Text = "Plant";
            this.rdioPlant.UseVisualStyleBackColor = true;
            this.rdioPlant.CheckedChanged += new System.EventHandler(this.rdioPlant_CheckedChanged);
            // 
            // rdioSupply
            // 
            this.rdioSupply.AutoSize = true;
            this.rdioSupply.Location = new System.Drawing.Point(122, 27);
            this.rdioSupply.Name = "rdioSupply";
            this.rdioSupply.Size = new System.Drawing.Size(76, 25);
            this.rdioSupply.TabIndex = 9;
            this.rdioSupply.TabStop = true;
            this.rdioSupply.Text = "Supply";
            this.rdioSupply.UseVisualStyleBackColor = true;
            this.rdioSupply.CheckedChanged += new System.EventHandler(this.rdioSupply_CheckedChanged);
            // 
            // lblManifact
            // 
            this.lblManifact.AutoSize = true;
            this.lblManifact.Location = new System.Drawing.Point(11, 116);
            this.lblManifact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManifact.Name = "lblManifact";
            this.lblManifact.Size = new System.Drawing.Size(0, 21);
            this.lblManifact.TabIndex = 10;
            // 
            // cmbManifact
            // 
            this.cmbManifact.FormattingEnabled = true;
            this.cmbManifact.Items.AddRange(new object[] {
            "Shaun",
            "Toys.com",
            "KnittinAllDay"});
            this.cmbManifact.Location = new System.Drawing.Point(134, 116);
            this.cmbManifact.Name = "cmbManifact";
            this.cmbManifact.Size = new System.Drawing.Size(149, 28);
            this.cmbManifact.TabIndex = 12;
            this.cmbManifact.Visible = false;
            // 
            // lblManifactur
            // 
            this.lblManifactur.AutoSize = true;
            this.lblManifactur.Location = new System.Drawing.Point(16, 119);
            this.lblManifactur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManifactur.Name = "lblManifactur";
            this.lblManifactur.Size = new System.Drawing.Size(106, 21);
            this.lblManifactur.TabIndex = 13;
            this.lblManifactur.Text = "Manifacturer: ";
            this.lblManifactur.Visible = false;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(134, 156);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(121, 27);
            this.txtSize.TabIndex = 15;
            this.txtSize.Tag = "Item no";
            this.txtSize.Visible = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(70, 162);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(45, 21);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Size: ";
            this.lblSize.Visible = false;
            // 
            // frmNewItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 325);
            this.ControlBox = false;
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblManifactur);
            this.Controls.Add(this.cmbManifact);
            this.Controls.Add(this.lblManifact);
            this.Controls.Add(this.rdioSupply);
            this.Controls.Add(this.rdioPlant);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Inventory Item";
            this.Load += new System.EventHandler(this.frmNewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdioPlant;
        private System.Windows.Forms.RadioButton rdioSupply;
        private System.Windows.Forms.Label lblManifact;
        private System.Windows.Forms.ComboBox cmbManifact;
        private System.Windows.Forms.Label lblManifactur;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
    }
}