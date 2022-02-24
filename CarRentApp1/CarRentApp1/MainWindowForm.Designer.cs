
namespace CarRentApp1
{
    partial class MainWindowForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArhiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCarRentalRecords = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRentalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehicleToolStripMenuItem,
            this.manageRentalToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehicleToolStripMenuItem
            // 
            this.manageVehicleToolStripMenuItem.Name = "manageVehicleToolStripMenuItem";
            this.manageVehicleToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.manageVehicleToolStripMenuItem.Text = "Manage Vehicle";
            // 
            // manageRentalToolStripMenuItem
            // 
            this.manageRentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalToolStripMenuItem,
            this.editRentalToolStripMenuItem,
            this.viewArhiveToolStripMenuItem});
            this.manageRentalToolStripMenuItem.Name = "manageRentalToolStripMenuItem";
            this.manageRentalToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.manageRentalToolStripMenuItem.Text = "Manage Rental";
            // 
            // addRentalToolStripMenuItem
            // 
            this.addRentalToolStripMenuItem.Name = "addRentalToolStripMenuItem";
            this.addRentalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRentalToolStripMenuItem.Text = "Add Rental";
            this.addRentalToolStripMenuItem.Click += new System.EventHandler(this.addRentalToolStripMenuItem_Click);
            // 
            // editRentalToolStripMenuItem
            // 
            this.editRentalToolStripMenuItem.Name = "editRentalToolStripMenuItem";
            this.editRentalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editRentalToolStripMenuItem.Text = "Edit Rental";
            this.editRentalToolStripMenuItem.Click += new System.EventHandler(this.editRentalToolStripMenuItem_Click);
            // 
            // viewArhiveToolStripMenuItem
            // 
            this.viewArhiveToolStripMenuItem.Name = "viewArhiveToolStripMenuItem";
            this.viewArhiveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewArhiveToolStripMenuItem.Text = "View Arhive";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // dgvCarRentalRecords
            // 
            this.dgvCarRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarRentalRecords.Location = new System.Drawing.Point(12, 31);
            this.dgvCarRentalRecords.Name = "dgvCarRentalRecords";
            this.dgvCarRentalRecords.RowHeadersWidth = 51;
            this.dgvCarRentalRecords.RowTemplate.Height = 24;
            this.dgvCarRentalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarRentalRecords.Size = new System.Drawing.Size(776, 407);
            this.dgvCarRentalRecords.TabIndex = 1;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarRentalRecords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindowForm";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRentalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArhiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCarRentalRecords;
    }
}