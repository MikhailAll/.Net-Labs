namespace Lab2.Forms
{
    partial class MainForm
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
            this.bAddStudio = new System.Windows.Forms.Button();
            this.dgvStudios = new System.Windows.Forms.DataGridView();
            this.bRemoveStudio = new System.Windows.Forms.Button();
            this.bCloneStudio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudios)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddStudio
            // 
            this.bAddStudio.Location = new System.Drawing.Point(12, 268);
            this.bAddStudio.Name = "bAddStudio";
            this.bAddStudio.Size = new System.Drawing.Size(120, 39);
            this.bAddStudio.TabIndex = 2;
            this.bAddStudio.Text = "Добавить новую студию";
            this.bAddStudio.UseVisualStyleBackColor = true;
            this.bAddStudio.Click += new System.EventHandler(this.bAddStudio_Click);
            // 
            // dgvStudios
            // 
            this.dgvStudios.AllowUserToAddRows = false;
            this.dgvStudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudios.Location = new System.Drawing.Point(12, 12);
            this.dgvStudios.Name = "dgvStudios";
            this.dgvStudios.ReadOnly = true;
            this.dgvStudios.Size = new System.Drawing.Size(575, 235);
            this.dgvStudios.TabIndex = 3;
            this.dgvStudios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudios_CellDoubleClick);
            // 
            // bRemoveStudio
            // 
            this.bRemoveStudio.Location = new System.Drawing.Point(138, 268);
            this.bRemoveStudio.Name = "bRemoveStudio";
            this.bRemoveStudio.Size = new System.Drawing.Size(120, 39);
            this.bRemoveStudio.TabIndex = 4;
            this.bRemoveStudio.Text = "Удалить выбранную студию";
            this.bRemoveStudio.UseVisualStyleBackColor = true;
            this.bRemoveStudio.Click += new System.EventHandler(this.bRemoveStudio_Click);
            // 
            // bCloneStudio
            // 
            this.bCloneStudio.Location = new System.Drawing.Point(264, 268);
            this.bCloneStudio.Name = "bCloneStudio";
            this.bCloneStudio.Size = new System.Drawing.Size(120, 39);
            this.bCloneStudio.TabIndex = 5;
            this.bCloneStudio.Text = "Клонировать выбранную студию";
            this.bCloneStudio.UseVisualStyleBackColor = true;
            this.bCloneStudio.Click += new System.EventHandler(this.bCloneStudio_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 316);
            this.Controls.Add(this.bCloneStudio);
            this.Controls.Add(this.bRemoveStudio);
            this.Controls.Add(this.dgvStudios);
            this.Controls.Add(this.bAddStudio);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bAddStudio;
        private System.Windows.Forms.DataGridView dgvStudios;
        private System.Windows.Forms.Button bRemoveStudio;
        private System.Windows.Forms.Button bCloneStudio;
    }
}

