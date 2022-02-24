
namespace CarRentApp1
{
    partial class AddEditRentalForm
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
            this.lCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lDateRented = new System.Windows.Forms.Label();
            this.lDateReturned = new System.Windows.Forms.Label();
            this.lTypesOfCars = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.cbTypesOfCars = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lCustomerName
            // 
            this.lCustomerName.AutoSize = true;
            this.lCustomerName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCustomerName.Location = new System.Drawing.Point(53, 54);
            this.lCustomerName.Name = "lCustomerName";
            this.lCustomerName.Size = new System.Drawing.Size(188, 29);
            this.lCustomerName.TabIndex = 0;
            this.lCustomerName.Text = "Customer Name";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCustomerName.Location = new System.Drawing.Point(297, 54);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(406, 34);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCost.Location = new System.Drawing.Point(53, 128);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(62, 29);
            this.lCost.TabIndex = 2;
            this.lCost.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCost.Location = new System.Drawing.Point(297, 128);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(406, 34);
            this.tbCost.TabIndex = 3;
            // 
            // lDateRented
            // 
            this.lDateRented.AutoSize = true;
            this.lDateRented.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateRented.Location = new System.Drawing.Point(53, 195);
            this.lDateRented.Name = "lDateRented";
            this.lDateRented.Size = new System.Drawing.Size(147, 29);
            this.lDateRented.TabIndex = 4;
            this.lDateRented.Text = "Date Rented";
            // 
            // lDateReturned
            // 
            this.lDateReturned.AutoSize = true;
            this.lDateReturned.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateReturned.Location = new System.Drawing.Point(53, 265);
            this.lDateReturned.Name = "lDateReturned";
            this.lDateReturned.Size = new System.Drawing.Size(168, 29);
            this.lDateReturned.TabIndex = 5;
            this.lDateReturned.Text = "Date Returned";
            // 
            // lTypesOfCars
            // 
            this.lTypesOfCars.AutoSize = true;
            this.lTypesOfCars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTypesOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTypesOfCars.Location = new System.Drawing.Point(59, 331);
            this.lTypesOfCars.Name = "lTypesOfCars";
            this.lTypesOfCars.Size = new System.Drawing.Size(162, 29);
            this.lTypesOfCars.TabIndex = 6;
            this.lTypesOfCars.Text = "Types of Cars";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(168, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 59);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateRented.Location = new System.Drawing.Point(297, 195);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(406, 34);
            this.dtpDateRented.TabIndex = 9;
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateReturned.Location = new System.Drawing.Point(297, 265);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(406, 34);
            this.dtpDateReturned.TabIndex = 10;
            // 
            // cbTypesOfCars
            // 
            this.cbTypesOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypesOfCars.FormattingEnabled = true;
            this.cbTypesOfCars.Location = new System.Drawing.Point(297, 334);
            this.cbTypesOfCars.Name = "cbTypesOfCars";
            this.cbTypesOfCars.Size = new System.Drawing.Size(406, 37);
            this.cbTypesOfCars.TabIndex = 11;
            // 
            // AddEditRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentApp1.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.cbTypesOfCars);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lTypesOfCars);
            this.Controls.Add(this.lDateReturned);
            this.Controls.Add(this.lDateRented);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lCustomerName);
            this.Name = "AddEditRentalForm";
            this.Text = "AddEditRentalForm";
            this.Load += new System.EventHandler(this.AddEditRentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lDateRented;
        private System.Windows.Forms.Label lDateReturned;
        private System.Windows.Forms.Label lTypesOfCars;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.ComboBox cbTypesOfCars;
    }
}