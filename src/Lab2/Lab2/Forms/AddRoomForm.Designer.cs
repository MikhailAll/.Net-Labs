namespace Lab2.Forms
{
    partial class AddRoomForm
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
            this.nudInstrumentCount = new System.Windows.Forms.NumericUpDown();
            this.nudRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.lInstrumentCount = new System.Windows.Forms.Label();
            this.lRoomNumber = new System.Windows.Forms.Label();
            this.bAddRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrumentCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudInstrumentCount
            // 
            this.nudInstrumentCount.Location = new System.Drawing.Point(215, 33);
            this.nudInstrumentCount.Name = "nudInstrumentCount";
            this.nudInstrumentCount.Size = new System.Drawing.Size(124, 20);
            this.nudInstrumentCount.TabIndex = 15;
            // 
            // nudRoomNumber
            // 
            this.nudRoomNumber.Location = new System.Drawing.Point(215, 7);
            this.nudRoomNumber.Name = "nudRoomNumber";
            this.nudRoomNumber.Size = new System.Drawing.Size(124, 20);
            this.nudRoomNumber.TabIndex = 14;
            // 
            // lInstrumentCount
            // 
            this.lInstrumentCount.AutoSize = true;
            this.lInstrumentCount.Location = new System.Drawing.Point(12, 35);
            this.lInstrumentCount.Name = "lInstrumentCount";
            this.lInstrumentCount.Size = new System.Drawing.Size(192, 13);
            this.lInstrumentCount.TabIndex = 6;
            this.lInstrumentCount.Text = "Количество инстументов в комнате:";
            // 
            // lRoomNumber
            // 
            this.lRoomNumber.AutoSize = true;
            this.lRoomNumber.Location = new System.Drawing.Point(12, 9);
            this.lRoomNumber.Name = "lRoomNumber";
            this.lRoomNumber.Size = new System.Drawing.Size(92, 13);
            this.lRoomNumber.TabIndex = 7;
            this.lRoomNumber.Text = "Номер комнаты:";
            // 
            // bAddRoom
            // 
            this.bAddRoom.Location = new System.Drawing.Point(215, 83);
            this.bAddRoom.Name = "bAddRoom";
            this.bAddRoom.Size = new System.Drawing.Size(124, 23);
            this.bAddRoom.TabIndex = 16;
            this.bAddRoom.Text = "Добавить комнату";
            this.bAddRoom.UseVisualStyleBackColor = true;
            this.bAddRoom.Click += new System.EventHandler(this.bAddRoom_Click);
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 118);
            this.Controls.Add(this.bAddRoom);
            this.Controls.Add(this.nudInstrumentCount);
            this.Controls.Add(this.nudRoomNumber);
            this.Controls.Add(this.lInstrumentCount);
            this.Controls.Add(this.lRoomNumber);
            this.Name = "AddRoomForm";
            this.Text = "AddRoomForm";
            this.Load += new System.EventHandler(this.AddRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrumentCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudInstrumentCount;
        private System.Windows.Forms.NumericUpDown nudRoomNumber;
        private System.Windows.Forms.Label lInstrumentCount;
        private System.Windows.Forms.Label lRoomNumber;
        private System.Windows.Forms.Button bAddRoom;
    }
}