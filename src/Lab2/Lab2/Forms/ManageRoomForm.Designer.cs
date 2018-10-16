namespace Lab2.Forms
{
    partial class ManageRoomForm
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.bRemoveEmployeeFromRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(258, 264);
            this.dgvEmployees.TabIndex = 0;
            // 
            // bRemoveEmployeeFromRoom
            // 
            this.bRemoveEmployeeFromRoom.Location = new System.Drawing.Point(12, 282);
            this.bRemoveEmployeeFromRoom.Name = "bRemoveEmployeeFromRoom";
            this.bRemoveEmployeeFromRoom.Size = new System.Drawing.Size(258, 23);
            this.bRemoveEmployeeFromRoom.TabIndex = 1;
            this.bRemoveEmployeeFromRoom.Text = "Удалить сотрудника из комнаты";
            this.bRemoveEmployeeFromRoom.UseVisualStyleBackColor = true;
            this.bRemoveEmployeeFromRoom.Click += new System.EventHandler(this.bRemoveEmployeeFromRoom_Click);
            // 
            // ManageRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 321);
            this.Controls.Add(this.bRemoveEmployeeFromRoom);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "ManageRoomForm";
            this.Text = "ManageRoomForm";
            this.Load += new System.EventHandler(this.ManageRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button bRemoveEmployeeFromRoom;
    }
}