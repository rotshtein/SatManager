namespace WebSocketS
{
    partial class MainWindow
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
            this.btnStart = new System.Windows.Forms.Button();
            this.numFrequency = new System.Windows.Forms.NumericUpDown();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblSymbolRate = new System.Windows.Forms.Label();
            this.numSymbolRate = new System.Windows.Forms.NumericUpDown();
            this.numSNR = new System.Windows.Forms.NumericUpDown();
            this.lblSNR = new System.Windows.Forms.Label();
            this.grpRFInput = new System.Windows.Forms.GroupBox();
            this.grpE1Output = new System.Windows.Forms.GroupBox();
            this.numE1Port2 = new System.Windows.Forms.NumericUpDown();
            this.lblE1Port2 = new System.Windows.Forms.Label();
            this.numE1Port1 = new System.Windows.Forms.NumericUpDown();
            this.lblE1Port1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).BeginInit();
            this.grpRFInput.SuspendLayout();
            this.grpE1Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(132, 208);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // numFrequency
            // 
            this.numFrequency.DecimalPlaces = 3;
            this.numFrequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numFrequency.Location = new System.Drawing.Point(163, 32);
            this.numFrequency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFrequency.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFrequency.Minimum = new decimal(new int[] {
            68,
            0,
            0,
            0});
            this.numFrequency.Name = "numFrequency";
            this.numFrequency.Size = new System.Drawing.Size(87, 26);
            this.numFrequency.TabIndex = 1;
            this.numFrequency.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.Location = new System.Drawing.Point(8, 32);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(138, 20);
            this.lblFrequency.TabIndex = 2;
            this.lblFrequency.Text = "Frequency [MHz]";
            // 
            // lblSymbolRate
            // 
            this.lblSymbolRate.AutoSize = true;
            this.lblSymbolRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolRate.Location = new System.Drawing.Point(8, 75);
            this.lblSymbolRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbolRate.Name = "lblSymbolRate";
            this.lblSymbolRate.Size = new System.Drawing.Size(104, 20);
            this.lblSymbolRate.TabIndex = 4;
            this.lblSymbolRate.Text = "Symbol Rate";
            // 
            // numSymbolRate
            // 
            this.numSymbolRate.Location = new System.Drawing.Point(163, 75);
            this.numSymbolRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSymbolRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSymbolRate.Name = "numSymbolRate";
            this.numSymbolRate.Size = new System.Drawing.Size(87, 26);
            this.numSymbolRate.TabIndex = 2;
            this.numSymbolRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numSNR
            // 
            this.numSNR.DecimalPlaces = 2;
            this.numSNR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSNR.Location = new System.Drawing.Point(163, 126);
            this.numSNR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSNR.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numSNR.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.numSNR.Name = "numSNR";
            this.numSNR.Size = new System.Drawing.Size(87, 26);
            this.numSNR.TabIndex = 3;
            this.numSNR.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            // 
            // lblSNR
            // 
            this.lblSNR.AutoSize = true;
            this.lblSNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNR.Location = new System.Drawing.Point(8, 126);
            this.lblSNR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSNR.Name = "lblSNR";
            this.lblSNR.Size = new System.Drawing.Size(77, 20);
            this.lblSNR.TabIndex = 4;
            this.lblSNR.Text = "SNR [db]";
            // 
            // grpRFInput
            // 
            this.grpRFInput.Controls.Add(this.numFrequency);
            this.grpRFInput.Controls.Add(this.lblSNR);
            this.grpRFInput.Controls.Add(this.lblFrequency);
            this.grpRFInput.Controls.Add(this.numSNR);
            this.grpRFInput.Controls.Add(this.numSymbolRate);
            this.grpRFInput.Controls.Add(this.lblSymbolRate);
            this.grpRFInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRFInput.Location = new System.Drawing.Point(16, 15);
            this.grpRFInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRFInput.Name = "grpRFInput";
            this.grpRFInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRFInput.Size = new System.Drawing.Size(281, 190);
            this.grpRFInput.TabIndex = 5;
            this.grpRFInput.TabStop = false;
            this.grpRFInput.Text = "RF Input";
            // 
            // grpE1Output
            // 
            this.grpE1Output.Controls.Add(this.numE1Port2);
            this.grpE1Output.Controls.Add(this.lblE1Port2);
            this.grpE1Output.Controls.Add(this.numE1Port1);
            this.grpE1Output.Controls.Add(this.lblE1Port1);
            this.grpE1Output.Location = new System.Drawing.Point(305, 15);
            this.grpE1Output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpE1Output.Name = "grpE1Output";
            this.grpE1Output.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpE1Output.Size = new System.Drawing.Size(281, 190);
            this.grpE1Output.TabIndex = 6;
            this.grpE1Output.TabStop = false;
            this.grpE1Output.Text = "E1 Output";
            // 
            // numE1Port2
            // 
            this.numE1Port2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numE1Port2.Location = new System.Drawing.Point(163, 110);
            this.numE1Port2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numE1Port2.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numE1Port2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numE1Port2.Name = "numE1Port2";
            this.numE1Port2.Size = new System.Drawing.Size(87, 24);
            this.numE1Port2.TabIndex = 5;
            this.numE1Port2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblE1Port2
            // 
            this.lblE1Port2.AutoSize = true;
            this.lblE1Port2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE1Port2.Location = new System.Drawing.Point(8, 110);
            this.lblE1Port2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE1Port2.Name = "lblE1Port2";
            this.lblE1Port2.Size = new System.Drawing.Size(129, 20);
            this.lblE1Port2.TabIndex = 6;
            this.lblE1Port2.Text = "E1 Port2 Output";
            // 
            // numE1Port1
            // 
            this.numE1Port1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numE1Port1.Location = new System.Drawing.Point(163, 69);
            this.numE1Port1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numE1Port1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numE1Port1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numE1Port1.Name = "numE1Port1";
            this.numE1Port1.Size = new System.Drawing.Size(87, 24);
            this.numE1Port1.TabIndex = 4;
            this.numE1Port1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblE1Port1
            // 
            this.lblE1Port1.AutoSize = true;
            this.lblE1Port1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE1Port1.Location = new System.Drawing.Point(8, 69);
            this.lblE1Port1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE1Port1.Name = "lblE1Port1";
            this.lblE1Port1.Size = new System.Drawing.Size(129, 20);
            this.lblE1Port1.TabIndex = 4;
            this.lblE1Port1.Text = "E1 Port1 Output";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(352, 208);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(159, 43);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 265);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.grpE1Output);
            this.Controls.Add(this.grpRFInput);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).EndInit();
            this.grpRFInput.ResumeLayout(false);
            this.grpRFInput.PerformLayout();
            this.grpE1Output.ResumeLayout(false);
            this.grpE1Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblSymbolRate;
        private System.Windows.Forms.NumericUpDown numSymbolRate;
        private System.Windows.Forms.NumericUpDown numSNR;
        private System.Windows.Forms.Label lblSNR;
        private System.Windows.Forms.GroupBox grpRFInput;
        private System.Windows.Forms.GroupBox grpE1Output;
        private System.Windows.Forms.NumericUpDown numE1Port2;
        private System.Windows.Forms.Label lblE1Port2;
        private System.Windows.Forms.NumericUpDown numE1Port1;
        private System.Windows.Forms.Label lblE1Port1;
        private System.Windows.Forms.Button btnStop;
    }
}

