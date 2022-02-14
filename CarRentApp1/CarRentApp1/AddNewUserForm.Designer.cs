
namespace CarRentApp1
{
    partial class AddNewUserForm
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
            this.lUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUserName.Location = new System.Drawing.Point(42, 42);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(135, 29);
            this.lUserName.TabIndex = 0;
            this.lUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(209, 42);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(221, 34);
            this.tbUserName.TabIndex = 1;
            // 
            // lRole
            // 
            this.lRole.AutoSize = true;
            this.lRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRole.Location = new System.Drawing.Point(42, 150);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(64, 29);
            this.lRole.TabIndex = 2;
            this.lRole.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(209, 153);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(221, 37);
            this.cbRole.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(47, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 42);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(47, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lRole);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lUserName);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}