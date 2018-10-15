namespace Lab2.Forms
{
    partial class AddStudioForm
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
            this.lStudioName = new System.Windows.Forms.Label();
            this.tbStudioName = new System.Windows.Forms.TextBox();
            this.lStudioAddress = new System.Windows.Forms.Label();
            this.lPricePerTrack = new System.Windows.Forms.Label();
            this.lTimePerTrack = new System.Windows.Forms.Label();
            this.lInstrumentCount = new System.Windows.Forms.Label();
            this.tbStudioAddress = new System.Windows.Forms.TextBox();
            this.bAddStudio = new System.Windows.Forms.Button();
            this.nudPricePerTrack = new System.Windows.Forms.NumericUpDown();
            this.nudTimePerTrack = new System.Windows.Forms.NumericUpDown();
            this.nudInstrumentCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrumentCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lStudioName
            // 
            this.lStudioName.AutoSize = true;
            this.lStudioName.Location = new System.Drawing.Point(27, 13);
            this.lStudioName.Name = "lStudioName";
            this.lStudioName.Size = new System.Drawing.Size(97, 13);
            this.lStudioName.TabIndex = 0;
            this.lStudioName.Text = "Название студии:";
            // 
            // tbStudioName
            // 
            this.tbStudioName.Location = new System.Drawing.Point(211, 10);
            this.tbStudioName.Name = "tbStudioName";
            this.tbStudioName.Size = new System.Drawing.Size(124, 20);
            this.tbStudioName.TabIndex = 1;
            // 
            // lStudioAddress
            // 
            this.lStudioAddress.AutoSize = true;
            this.lStudioAddress.Location = new System.Drawing.Point(27, 39);
            this.lStudioAddress.Name = "lStudioAddress";
            this.lStudioAddress.Size = new System.Drawing.Size(78, 13);
            this.lStudioAddress.TabIndex = 0;
            this.lStudioAddress.Text = "Адрес студии:";
            // 
            // lPricePerTrack
            // 
            this.lPricePerTrack.AutoSize = true;
            this.lPricePerTrack.Location = new System.Drawing.Point(27, 66);
            this.lPricePerTrack.Name = "lPricePerTrack";
            this.lPricePerTrack.Size = new System.Drawing.Size(77, 13);
            this.lPricePerTrack.TabIndex = 0;
            this.lPricePerTrack.Text = "Цена за трек:";
            // 
            // lTimePerTrack
            // 
            this.lTimePerTrack.AutoSize = true;
            this.lTimePerTrack.Location = new System.Drawing.Point(27, 93);
            this.lTimePerTrack.Name = "lTimePerTrack";
            this.lTimePerTrack.Size = new System.Drawing.Size(114, 13);
            this.lTimePerTrack.TabIndex = 0;
            this.lTimePerTrack.Text = "Время записи трека:";
            // 
            // lInstrumentCount
            // 
            this.lInstrumentCount.AutoSize = true;
            this.lInstrumentCount.Location = new System.Drawing.Point(27, 119);
            this.lInstrumentCount.Name = "lInstrumentCount";
            this.lInstrumentCount.Size = new System.Drawing.Size(183, 13);
            this.lInstrumentCount.TabIndex = 0;
            this.lInstrumentCount.Text = "Количество инстументов в студии:";
            // 
            // tbStudioAddress
            // 
            this.tbStudioAddress.Location = new System.Drawing.Point(211, 36);
            this.tbStudioAddress.Name = "tbStudioAddress";
            this.tbStudioAddress.Size = new System.Drawing.Size(124, 20);
            this.tbStudioAddress.TabIndex = 2;
            // 
            // bAddStudio
            // 
            this.bAddStudio.Location = new System.Drawing.Point(211, 158);
            this.bAddStudio.Name = "bAddStudio";
            this.bAddStudio.Size = new System.Drawing.Size(124, 23);
            this.bAddStudio.TabIndex = 6;
            this.bAddStudio.Text = "Добавить студию";
            this.bAddStudio.UseVisualStyleBackColor = true;
            this.bAddStudio.Click += new System.EventHandler(this.bAddStudio_Click);
            // 
            // nudPricePerTrack
            // 
            this.nudPricePerTrack.Location = new System.Drawing.Point(211, 64);
            this.nudPricePerTrack.Name = "nudPricePerTrack";
            this.nudPricePerTrack.Size = new System.Drawing.Size(124, 20);
            this.nudPricePerTrack.TabIndex = 3;
            // 
            // nudTimePerTrack
            // 
            this.nudTimePerTrack.Location = new System.Drawing.Point(211, 91);
            this.nudTimePerTrack.Name = "nudTimePerTrack";
            this.nudTimePerTrack.Size = new System.Drawing.Size(124, 20);
            this.nudTimePerTrack.TabIndex = 4;
            // 
            // nudInstrumentCount
            // 
            this.nudInstrumentCount.Location = new System.Drawing.Point(211, 117);
            this.nudInstrumentCount.Name = "nudInstrumentCount";
            this.nudInstrumentCount.Size = new System.Drawing.Size(124, 20);
            this.nudInstrumentCount.TabIndex = 5;
            // 
            // AddStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 193);
            this.Controls.Add(this.nudInstrumentCount);
            this.Controls.Add(this.nudTimePerTrack);
            this.Controls.Add(this.nudPricePerTrack);
            this.Controls.Add(this.bAddStudio);
            this.Controls.Add(this.tbStudioAddress);
            this.Controls.Add(this.lInstrumentCount);
            this.Controls.Add(this.lTimePerTrack);
            this.Controls.Add(this.lPricePerTrack);
            this.Controls.Add(this.lStudioAddress);
            this.Controls.Add(this.tbStudioName);
            this.Controls.Add(this.lStudioName);
            this.Name = "AddStudioForm";
            this.Text = "Добавить студию";
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrumentCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lStudioName;
        private System.Windows.Forms.TextBox tbStudioName;
        private System.Windows.Forms.Label lStudioAddress;
        private System.Windows.Forms.Label lPricePerTrack;
        private System.Windows.Forms.Label lTimePerTrack;
        private System.Windows.Forms.Label lInstrumentCount;
        private System.Windows.Forms.TextBox tbStudioAddress;
        private System.Windows.Forms.Button bAddStudio;
        private System.Windows.Forms.NumericUpDown nudPricePerTrack;
        private System.Windows.Forms.NumericUpDown nudTimePerTrack;
        private System.Windows.Forms.NumericUpDown nudInstrumentCount;
    }
}