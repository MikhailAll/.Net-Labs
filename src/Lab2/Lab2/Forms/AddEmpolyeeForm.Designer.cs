namespace Lab2.Forms
{
    partial class AddEmpolyeeForm
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
            this.nudEmployeeSalary = new System.Windows.Forms.NumericUpDown();
            this.bAddEmployee = new System.Windows.Forms.Button();
            this.tbEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lEmployeeSalary = new System.Windows.Forms.Label();
            this.lEmployeeLastName = new System.Windows.Forms.Label();
            this.tbEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lEmployeeFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEmployeeSalary
            // 
            this.nudEmployeeSalary.Location = new System.Drawing.Point(171, 85);
            this.nudEmployeeSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudEmployeeSalary.Name = "nudEmployeeSalary";
            this.nudEmployeeSalary.Size = new System.Drawing.Size(130, 20);
            this.nudEmployeeSalary.TabIndex = 3;
            // 
            // bAddEmployee
            // 
            this.bAddEmployee.Location = new System.Drawing.Point(171, 128);
            this.bAddEmployee.Name = "bAddEmployee";
            this.bAddEmployee.Size = new System.Drawing.Size(130, 23);
            this.bAddEmployee.TabIndex = 4;
            this.bAddEmployee.Text = "Добавить сотрудника";
            this.bAddEmployee.UseVisualStyleBackColor = true;
            this.bAddEmployee.Click += new System.EventHandler(this.bAddEmployee_Click);
            // 
            // tbEmployeeLastName
            // 
            this.tbEmployeeLastName.Location = new System.Drawing.Point(171, 57);
            this.tbEmployeeLastName.Name = "tbEmployeeLastName";
            this.tbEmployeeLastName.Size = new System.Drawing.Size(130, 20);
            this.tbEmployeeLastName.TabIndex = 2;
            // 
            // lEmployeeSalary
            // 
            this.lEmployeeSalary.AutoSize = true;
            this.lEmployeeSalary.Location = new System.Drawing.Point(28, 87);
            this.lEmployeeSalary.Name = "lEmployeeSalary";
            this.lEmployeeSalary.Size = new System.Drawing.Size(116, 13);
            this.lEmployeeSalary.TabIndex = 0;
            this.lEmployeeSalary.Text = "Зарплата сотрудника";
            // 
            // lEmployeeLastName
            // 
            this.lEmployeeLastName.AutoSize = true;
            this.lEmployeeLastName.Location = new System.Drawing.Point(28, 60);
            this.lEmployeeLastName.Name = "lEmployeeLastName";
            this.lEmployeeLastName.Size = new System.Drawing.Size(120, 13);
            this.lEmployeeLastName.TabIndex = 0;
            this.lEmployeeLastName.Text = "Фамилия сотрудника:";
            // 
            // tbEmployeeFirstName
            // 
            this.tbEmployeeFirstName.Location = new System.Drawing.Point(171, 31);
            this.tbEmployeeFirstName.Name = "tbEmployeeFirstName";
            this.tbEmployeeFirstName.Size = new System.Drawing.Size(130, 20);
            this.tbEmployeeFirstName.TabIndex = 1;
            // 
            // lEmployeeFirstName
            // 
            this.lEmployeeFirstName.AutoSize = true;
            this.lEmployeeFirstName.Location = new System.Drawing.Point(28, 34);
            this.lEmployeeFirstName.Name = "lEmployeeFirstName";
            this.lEmployeeFirstName.Size = new System.Drawing.Size(93, 13);
            this.lEmployeeFirstName.TabIndex = 0;
            this.lEmployeeFirstName.Text = "Имя сотрудника:";
            // 
            // AddEmpolyeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 168);
            this.Controls.Add(this.nudEmployeeSalary);
            this.Controls.Add(this.bAddEmployee);
            this.Controls.Add(this.tbEmployeeLastName);
            this.Controls.Add(this.lEmployeeSalary);
            this.Controls.Add(this.lEmployeeLastName);
            this.Controls.Add(this.tbEmployeeFirstName);
            this.Controls.Add(this.lEmployeeFirstName);
            this.Name = "AddEmpolyeeForm";
            this.Text = "AddEmpolyee";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEmployeeSalary;
        private System.Windows.Forms.Button bAddEmployee;
        private System.Windows.Forms.TextBox tbEmployeeLastName;
        private System.Windows.Forms.Label lEmployeeSalary;
        private System.Windows.Forms.Label lEmployeeLastName;
        private System.Windows.Forms.TextBox tbEmployeeFirstName;
        private System.Windows.Forms.Label lEmployeeFirstName;
    }
}