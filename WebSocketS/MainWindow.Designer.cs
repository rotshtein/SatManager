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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.lblUsefulBwhz = new System.Windows.Forms.Label();
            this.numUsefulBw = new System.Windows.Forms.NumericUpDown();
            this.numLBandFreq = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.numGain = new System.Windows.Forms.NumericUpDown();
            this.tabOutput = new System.Windows.Forms.TabControl();
            this.tabE1 = new System.Windows.Forms.TabPage();
            this.tabSAToP = new System.Windows.Forms.TabPage();
            this.lblSATop1 = new System.Windows.Forms.Label();
            this.lblSAToP2 = new System.Windows.Forms.Label();
            this.txtSAToPUrl1 = new System.Windows.Forms.TextBox();
            this.txtSAToPUrl2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).BeginInit();
            this.grpRFInput.SuspendLayout();
            this.grpE1Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsefulBw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLBandFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).BeginInit();
            this.tabOutput.SuspendLayout();
            this.tabE1.SuspendLayout();
            this.tabSAToP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(136, 371);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 35);
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
            this.numFrequency.Location = new System.Drawing.Point(161, 16);
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
            this.numFrequency.Size = new System.Drawing.Size(73, 22);
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
            this.lblFrequency.Location = new System.Drawing.Point(7, 18);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(124, 16);
            this.lblFrequency.TabIndex = 2;
            this.lblFrequency.Text = "IF Frequency [MHz]";
            this.lblFrequency.Click += new System.EventHandler(this.lblFrequency_Click);
            // 
            // lblSymbolRate
            // 
            this.lblSymbolRate.AutoSize = true;
            this.lblSymbolRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolRate.Location = new System.Drawing.Point(7, 102);
            this.lblSymbolRate.Name = "lblSymbolRate";
            this.lblSymbolRate.Size = new System.Drawing.Size(86, 16);
            this.lblSymbolRate.TabIndex = 4;
            this.lblSymbolRate.Text = "Symbol Rate";
            // 
            // numSymbolRate
            // 
            this.numSymbolRate.Location = new System.Drawing.Point(161, 100);
            this.numSymbolRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSymbolRate.Name = "numSymbolRate";
            this.numSymbolRate.Size = new System.Drawing.Size(73, 22);
            this.numSymbolRate.TabIndex = 2;
            // 
            // numSNR
            // 
            this.numSNR.DecimalPlaces = 2;
            this.numSNR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSNR.Location = new System.Drawing.Point(449, 16);
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
            this.numSNR.Size = new System.Drawing.Size(73, 22);
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
            this.lblSNR.Location = new System.Drawing.Point(294, 18);
            this.lblSNR.Name = "lblSNR";
            this.lblSNR.Size = new System.Drawing.Size(64, 16);
            this.lblSNR.TabIndex = 4;
            this.lblSNR.Text = "SNR [db]";
            // 
            // grpRFInput
            // 
            this.grpRFInput.Controls.Add(this.lblGain);
            this.grpRFInput.Controls.Add(this.numGain);
            this.grpRFInput.Controls.Add(this.numLBandFreq);
            this.grpRFInput.Controls.Add(this.label1);
            this.grpRFInput.Controls.Add(this.lblUsefulBwhz);
            this.grpRFInput.Controls.Add(this.numUsefulBw);
            this.grpRFInput.Controls.Add(this.numFrequency);
            this.grpRFInput.Controls.Add(this.lblSNR);
            this.grpRFInput.Controls.Add(this.lblFrequency);
            this.grpRFInput.Controls.Add(this.numSNR);
            this.grpRFInput.Controls.Add(this.numSymbolRate);
            this.grpRFInput.Controls.Add(this.lblSymbolRate);
            this.grpRFInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpRFInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRFInput.Location = new System.Drawing.Point(12, 12);
            this.grpRFInput.Name = "grpRFInput";
            this.grpRFInput.Size = new System.Drawing.Size(535, 138);
            this.grpRFInput.TabIndex = 5;
            this.grpRFInput.TabStop = false;
            this.grpRFInput.Text = "RF Input";
            // 
            // grpE1Output
            // 
            this.grpE1Output.Controls.Add(this.tabOutput);
            this.grpE1Output.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpE1Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpE1Output.Location = new System.Drawing.Point(12, 167);
            this.grpE1Output.Name = "grpE1Output";
            this.grpE1Output.Size = new System.Drawing.Size(535, 181);
            this.grpE1Output.TabIndex = 6;
            this.grpE1Output.TabStop = false;
            this.grpE1Output.Text = "Output";
            // 
            // numE1Port2
            // 
            this.numE1Port2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numE1Port2.Location = new System.Drawing.Point(122, 68);
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
            this.numE1Port2.Size = new System.Drawing.Size(65, 21);
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
            this.lblE1Port2.Location = new System.Drawing.Point(6, 68);
            this.lblE1Port2.Name = "lblE1Port2";
            this.lblE1Port2.Size = new System.Drawing.Size(99, 16);
            this.lblE1Port2.TabIndex = 6;
            this.lblE1Port2.Text = "E1 Port2 Output";
            // 
            // numE1Port1
            // 
            this.numE1Port1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numE1Port1.Location = new System.Drawing.Point(122, 35);
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
            this.numE1Port1.Size = new System.Drawing.Size(65, 21);
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
            this.lblE1Port1.Location = new System.Drawing.Point(6, 35);
            this.lblE1Port1.Name = "lblE1Port1";
            this.lblE1Port1.Size = new System.Drawing.Size(99, 16);
            this.lblE1Port1.TabIndex = 4;
            this.lblE1Port1.Text = "E1 Port1 Output";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(305, 371);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 35);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblUsefulBwhz
            // 
            this.lblUsefulBwhz.AutoSize = true;
            this.lblUsefulBwhz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsefulBwhz.Location = new System.Drawing.Point(294, 60);
            this.lblUsefulBwhz.Name = "lblUsefulBwhz";
            this.lblUsefulBwhz.Size = new System.Drawing.Size(149, 16);
            this.lblUsefulBwhz.TabIndex = 6;
            this.lblUsefulBwhz.Text = "Useful Bandwidth [MHz]";
            // 
            // numUsefulBw
            // 
            this.numUsefulBw.DecimalPlaces = 4;
            this.numUsefulBw.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUsefulBw.Location = new System.Drawing.Point(449, 58);
            this.numUsefulBw.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUsefulBw.Name = "numUsefulBw";
            this.numUsefulBw.Size = new System.Drawing.Size(73, 22);
            this.numUsefulBw.TabIndex = 5;
            // 
            // numLBandFreq
            // 
            this.numLBandFreq.DecimalPlaces = 3;
            this.numLBandFreq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLBandFreq.Location = new System.Drawing.Point(161, 58);
            this.numLBandFreq.Maximum = new decimal(new int[] {
            2150,
            0,
            0,
            0});
            this.numLBandFreq.Minimum = new decimal(new int[] {
            950,
            0,
            0,
            0});
            this.numLBandFreq.Name = "numLBandFreq";
            this.numLBandFreq.Size = new System.Drawing.Size(73, 22);
            this.numLBandFreq.TabIndex = 7;
            this.numLBandFreq.Value = new decimal(new int[] {
            950,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "LBand Frequency [MHz]";
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGain.Location = new System.Drawing.Point(294, 102);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(63, 16);
            this.lblGain.TabIndex = 10;
            this.lblGain.Text = "Gain [db]";
            // 
            // numGain
            // 
            this.numGain.DecimalPlaces = 4;
            this.numGain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGain.Location = new System.Drawing.Point(449, 100);
            this.numGain.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numGain.Name = "numGain";
            this.numGain.Size = new System.Drawing.Size(73, 22);
            this.numGain.TabIndex = 9;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.tabE1);
            this.tabOutput.Controls.Add(this.tabSAToP);
            this.tabOutput.Location = new System.Drawing.Point(10, 26);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.SelectedIndex = 0;
            this.tabOutput.Size = new System.Drawing.Size(512, 142);
            this.tabOutput.TabIndex = 7;
            // 
            // tabE1
            // 
            this.tabE1.Controls.Add(this.lblE1Port2);
            this.tabE1.Controls.Add(this.numE1Port2);
            this.tabE1.Controls.Add(this.lblE1Port1);
            this.tabE1.Controls.Add(this.numE1Port1);
            this.tabE1.Location = new System.Drawing.Point(4, 24);
            this.tabE1.Name = "tabE1";
            this.tabE1.Padding = new System.Windows.Forms.Padding(3);
            this.tabE1.Size = new System.Drawing.Size(504, 114);
            this.tabE1.TabIndex = 0;
            this.tabE1.Text = "E1";
            this.tabE1.UseVisualStyleBackColor = true;
            // 
            // tabSAToP
            // 
            this.tabSAToP.Controls.Add(this.txtSAToPUrl2);
            this.tabSAToP.Controls.Add(this.txtSAToPUrl1);
            this.tabSAToP.Controls.Add(this.lblSAToP2);
            this.tabSAToP.Controls.Add(this.lblSATop1);
            this.tabSAToP.Location = new System.Drawing.Point(4, 24);
            this.tabSAToP.Name = "tabSAToP";
            this.tabSAToP.Padding = new System.Windows.Forms.Padding(3);
            this.tabSAToP.Size = new System.Drawing.Size(504, 114);
            this.tabSAToP.TabIndex = 1;
            this.tabSAToP.Text = "SAToP";
            this.tabSAToP.UseVisualStyleBackColor = true;
            // 
            // lblSATop1
            // 
            this.lblSATop1.AutoSize = true;
            this.lblSATop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSATop1.Location = new System.Drawing.Point(6, 38);
            this.lblSATop1.Name = "lblSATop1";
            this.lblSATop1.Size = new System.Drawing.Size(72, 15);
            this.lblSATop1.TabIndex = 0;
            this.lblSATop1.Text = "SATop Url 1";
            // 
            // lblSAToP2
            // 
            this.lblSAToP2.AutoSize = true;
            this.lblSAToP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAToP2.Location = new System.Drawing.Point(6, 71);
            this.lblSAToP2.Name = "lblSAToP2";
            this.lblSAToP2.Size = new System.Drawing.Size(72, 15);
            this.lblSAToP2.TabIndex = 1;
            this.lblSAToP2.Text = "SATop Url 2";
            // 
            // txtSAToPUrl1
            // 
            this.txtSAToPUrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSAToPUrl1.Location = new System.Drawing.Point(84, 35);
            this.txtSAToPUrl1.Name = "txtSAToPUrl1";
            this.txtSAToPUrl1.Size = new System.Drawing.Size(414, 21);
            this.txtSAToPUrl1.TabIndex = 2;
            // 
            // txtSAToPUrl2
            // 
            this.txtSAToPUrl2.Location = new System.Drawing.Point(84, 68);
            this.txtSAToPUrl2.Name = "txtSAToPUrl2";
            this.txtSAToPUrl2.Size = new System.Drawing.Size(414, 21);
            this.txtSAToPUrl2.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 417);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.grpE1Output);
            this.Controls.Add(this.grpRFInput);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "SatManager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).EndInit();
            this.grpRFInput.ResumeLayout(false);
            this.grpRFInput.PerformLayout();
            this.grpE1Output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsefulBw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLBandFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).EndInit();
            this.tabOutput.ResumeLayout(false);
            this.tabE1.ResumeLayout(false);
            this.tabE1.PerformLayout();
            this.tabSAToP.ResumeLayout(false);
            this.tabSAToP.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown numLBandFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsefulBwhz;
        private System.Windows.Forms.NumericUpDown numUsefulBw;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.NumericUpDown numGain;
        private System.Windows.Forms.TabControl tabOutput;
        private System.Windows.Forms.TabPage tabE1;
        private System.Windows.Forms.TabPage tabSAToP;
        private System.Windows.Forms.TextBox txtSAToPUrl2;
        private System.Windows.Forms.TextBox txtSAToPUrl1;
        private System.Windows.Forms.Label lblSAToP2;
        private System.Windows.Forms.Label lblSATop1;
    }
}

