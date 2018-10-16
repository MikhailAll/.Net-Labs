namespace Lab2.Forms
{
    partial class ManageStudioForm
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.nudInstrumentCount = new System.Windows.Forms.NumericUpDown();
            this.nudTimePerTrack = new System.Windows.Forms.NumericUpDown();
            this.nudPricePerTrack = new System.Windows.Forms.NumericUpDown();
            this.tbStudioAddress = new System.Windows.Forms.TextBox();
            this.lInstrumentCount = new System.Windows.Forms.Label();
            this.lTimePerTrack = new System.Windows.Forms.Label();
            this.lPricePerTrack = new System.Windows.Forms.Label();
            this.lStudioAddress = new System.Windows.Forms.Label();
            this.tbStudioName = new System.Windows.Forms.TextBox();
            this.lStudioName = new System.Windows.Forms.Label();
            this.bAddRoom = new System.Windows.Forms.Button();
            this.bRemoveRoom = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.bRemoveEmployee = new System.Windows.Forms.Button();
            this.bAddEmployee = new System.Windows.Forms.Button();
            this.lStudioSalary = new System.Windows.Forms.Label();
            this.bAddEmployeeToRoom = new System.Windows.Forms.Button();
            this.bUseRoom = new System.Windows.Forms.Button();
            this.lStudioCash = new System.Windows.Forms.Label();
            this.bSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrumentCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(326, 11);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.Size = new System.Drawing.Size(281, 326);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellDoubleClick);
            // 
            // nudInstrumentCount
            // 
            this.nudInstrumentCount.Location = new System.Drawing.Point(196, 118);
            this.nudInstrumentCount.Name = "nudInstrumentCount";
            this.nudInstrumentCount.Size = new System.Drawing.Size(124, 20);
            this.nudInstrumentCount.TabIndex = 15;
            // 
            // nudTimePerTrack
            // 
            this.nudTimePerTrack.Location = new System.Drawing.Point(196, 92);
            this.nudTimePerTrack.Name = "nudTimePerTrack";
            this.nudTimePerTrack.Size = new System.Drawing.Size(124, 20);
            this.nudTimePerTrack.TabIndex = 14;
            // 
            // nudPricePerTrack
            // 
            this.nudPricePerTrack.Location = new System.Drawing.Point(196, 65);
            this.nudPricePerTrack.Name = "nudPricePerTrack";
            this.nudPricePerTrack.Size = new System.Drawing.Size(124, 20);
            this.nudPricePerTrack.TabIndex = 13;
            // 
            // tbStudioAddress
            // 
            this.tbStudioAddress.Location = new System.Drawing.Point(196, 37);
            this.tbStudioAddress.Name = "tbStudioAddress";
            this.tbStudioAddress.Size = new System.Drawing.Size(124, 20);
            this.tbStudioAddress.TabIndex = 12;
            // 
            // lInstrumentCount
            // 
            this.lInstrumentCount.AutoSize = true;
            this.lInstrumentCount.Location = new System.Drawing.Point(12, 120);
            this.lInstrumentCount.Name = "lInstrumentCount";
            this.lInstrumentCount.Size = new System.Drawing.Size(183, 13);
            this.lInstrumentCount.TabIndex = 6;
            this.lInstrumentCount.Text = "Количество инстументов в студии:";
            // 
            // lTimePerTrack
            // 
            this.lTimePerTrack.AutoSize = true;
            this.lTimePerTrack.Location = new System.Drawing.Point(12, 94);
            this.lTimePerTrack.Name = "lTimePerTrack";
            this.lTimePerTrack.Size = new System.Drawing.Size(114, 13);
            this.lTimePerTrack.TabIndex = 7;
            this.lTimePerTrack.Text = "Время записи трека:";
            // 
            // lPricePerTrack
            // 
            this.lPricePerTrack.AutoSize = true;
            this.lPricePerTrack.Location = new System.Drawing.Point(12, 67);
            this.lPricePerTrack.Name = "lPricePerTrack";
            this.lPricePerTrack.Size = new System.Drawing.Size(77, 13);
            this.lPricePerTrack.TabIndex = 8;
            this.lPricePerTrack.Text = "Цена за трек:";
            // 
            // lStudioAddress
            // 
            this.lStudioAddress.AutoSize = true;
            this.lStudioAddress.Location = new System.Drawing.Point(12, 40);
            this.lStudioAddress.Name = "lStudioAddress";
            this.lStudioAddress.Size = new System.Drawing.Size(78, 13);
            this.lStudioAddress.TabIndex = 9;
            this.lStudioAddress.Text = "Адрес студии:";
            // 
            // tbStudioName
            // 
            this.tbStudioName.Location = new System.Drawing.Point(196, 11);
            this.tbStudioName.Name = "tbStudioName";
            this.tbStudioName.Size = new System.Drawing.Size(124, 20);
            this.tbStudioName.TabIndex = 11;
            // 
            // lStudioName
            // 
            this.lStudioName.AutoSize = true;
            this.lStudioName.Location = new System.Drawing.Point(12, 14);
            this.lStudioName.Name = "lStudioName";
            this.lStudioName.Size = new System.Drawing.Size(97, 13);
            this.lStudioName.TabIndex = 10;
            this.lStudioName.Text = "Название студии:";
            // 
            // bAddRoom
            // 
            this.bAddRoom.Location = new System.Drawing.Point(326, 343);
            this.bAddRoom.Name = "bAddRoom";
            this.bAddRoom.Size = new System.Drawing.Size(93, 38);
            this.bAddRoom.TabIndex = 17;
            this.bAddRoom.Text = "Добавить комнату\r\n";
            this.bAddRoom.UseVisualStyleBackColor = true;
            this.bAddRoom.Click += new System.EventHandler(this.bAddRoom_Click);
            // 
            // bRemoveRoom
            // 
            this.bRemoveRoom.Location = new System.Drawing.Point(514, 343);
            this.bRemoveRoom.Name = "bRemoveRoom";
            this.bRemoveRoom.Size = new System.Drawing.Size(93, 38);
            this.bRemoveRoom.TabIndex = 18;
            this.bRemoveRoom.Text = "Удалить комнату";
            this.bRemoveRoom.UseVisualStyleBackColor = true;
            this.bRemoveRoom.Click += new System.EventHandler(this.bRemoveRoom_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(746, 11);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(281, 326);
            this.dgvEmployees.TabIndex = 19;
            // 
            // bRemoveEmployee
            // 
            this.bRemoveEmployee.Location = new System.Drawing.Point(934, 343);
            this.bRemoveEmployee.Name = "bRemoveEmployee";
            this.bRemoveEmployee.Size = new System.Drawing.Size(93, 38);
            this.bRemoveEmployee.TabIndex = 21;
            this.bRemoveEmployee.Text = "Уволить сотрудника";
            this.bRemoveEmployee.UseVisualStyleBackColor = true;
            this.bRemoveEmployee.Click += new System.EventHandler(this.bRemoveEmployee_Click);
            // 
            // bAddEmployee
            // 
            this.bAddEmployee.Location = new System.Drawing.Point(746, 343);
            this.bAddEmployee.Name = "bAddEmployee";
            this.bAddEmployee.Size = new System.Drawing.Size(93, 38);
            this.bAddEmployee.TabIndex = 20;
            this.bAddEmployee.Text = "Нанять сотрудника";
            this.bAddEmployee.UseVisualStyleBackColor = true;
            this.bAddEmployee.Click += new System.EventHandler(this.bAddEmployee_Click);
            // 
            // lStudioSalary
            // 
            this.lStudioSalary.AutoSize = true;
            this.lStudioSalary.Location = new System.Drawing.Point(12, 192);
            this.lStudioSalary.Name = "lStudioSalary";
            this.lStudioSalary.Size = new System.Drawing.Size(202, 13);
            this.lStudioSalary.TabIndex = 0;
            this.lStudioSalary.Text = "Общая зарплата сотрудников студии: ";
            // 
            // bAddEmployeeToRoom
            // 
            this.bAddEmployeeToRoom.Location = new System.Drawing.Point(632, 151);
            this.bAddEmployeeToRoom.Name = "bAddEmployeeToRoom";
            this.bAddEmployeeToRoom.Size = new System.Drawing.Size(93, 48);
            this.bAddEmployeeToRoom.TabIndex = 22;
            this.bAddEmployeeToRoom.Text = "Добавить сотрудика в комнату";
            this.bAddEmployeeToRoom.UseVisualStyleBackColor = true;
            this.bAddEmployeeToRoom.Click += new System.EventHandler(this.bAddEmployeeToRoom_Click);
            // 
            // bUseRoom
            // 
            this.bUseRoom.Location = new System.Drawing.Point(632, 224);
            this.bUseRoom.Name = "bUseRoom";
            this.bUseRoom.Size = new System.Drawing.Size(93, 45);
            this.bUseRoom.TabIndex = 23;
            this.bUseRoom.Text = "Использовать комнату";
            this.bUseRoom.UseVisualStyleBackColor = true;
            this.bUseRoom.Click += new System.EventHandler(this.bUseRoom_Click);
            // 
            // lStudioCash
            // 
            this.lStudioCash.AutoSize = true;
            this.lStudioCash.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lStudioCash.Location = new System.Drawing.Point(12, 214);
            this.lStudioCash.Name = "lStudioCash";
            this.lStudioCash.Size = new System.Drawing.Size(78, 13);
            this.lStudioCash.TabIndex = 24;
            this.lStudioCash.Text = "Касса студии:";
            // 
            // bSaveChanges
            // 
            this.bSaveChanges.Location = new System.Drawing.Point(15, 279);
            this.bSaveChanges.Name = "bSaveChanges";
            this.bSaveChanges.Size = new System.Drawing.Size(134, 23);
            this.bSaveChanges.TabIndex = 25;
            this.bSaveChanges.Text = "Сохранить изменения";
            this.bSaveChanges.UseVisualStyleBackColor = true;
            this.bSaveChanges.Click += new System.EventHandler(this.bSaveChanges_Click);
            // 
            // ManageStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 408);
            this.Controls.Add(this.bSaveChanges);
            this.Controls.Add(this.lStudioCash);
            this.Controls.Add(this.bUseRoom);
            this.Controls.Add(this.bAddEmployeeToRoom);
            this.Controls.Add(this.lStudioSalary);
            this.Controls.Add(this.bRemoveEmployee);
            this.Controls.Add(this.bAddEmployee);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.bRemoveRoom);
            this.Controls.Add(this.bAddRoom);
            this.Controls.Add(this.nudInstrumentCount);
            this.Controls.Add(this.nudTimePerTrack);
            this.Controls.Add(this.nudPricePerTrack);
            this.Controls.Add(this.tbStudioAddress);
            this.Controls.Add(this.lInstrumentCount);
            this.Controls.Add(this.lTimePerTrack);
            this.Controls.Add(this.lPricePerTrack);
            this.Controls.Add(this.lStudioAddress);
            this.Controls.Add(this.tbStudioName);
            this.Controls.Add(this.lStudioName);
            this.Controls.Add(this.dgvRooms);
            this.Name = "ManageStudioForm";
            this.Text = "ManageStudioForm";
            this.Load += new System.EventHandler(this.ManageStudioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrumentCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.NumericUpDown nudInstrumentCount;
        private System.Windows.Forms.NumericUpDown nudTimePerTrack;
        private System.Windows.Forms.NumericUpDown nudPricePerTrack;
        private System.Windows.Forms.TextBox tbStudioAddress;
        private System.Windows.Forms.Label lInstrumentCount;
        private System.Windows.Forms.Label lTimePerTrack;
        private System.Windows.Forms.Label lPricePerTrack;
        private System.Windows.Forms.Label lStudioAddress;
        private System.Windows.Forms.TextBox tbStudioName;
        private System.Windows.Forms.Label lStudioName;
        private System.Windows.Forms.Button bAddRoom;
        private System.Windows.Forms.Button bRemoveRoom;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button bRemoveEmployee;
        private System.Windows.Forms.Button bAddEmployee;
        private System.Windows.Forms.Label lStudioSalary;
        private System.Windows.Forms.Button bAddEmployeeToRoom;
        private System.Windows.Forms.Button bUseRoom;
        private System.Windows.Forms.Label lStudioCash;
        private System.Windows.Forms.Button bSaveChanges;
    }
}