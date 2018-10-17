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
            this.numSno = new System.Windows.Forms.NumericUpDown();
            this.lblSno = new System.Windows.Forms.Label();
            this.chkUseFile = new System.Windows.Forms.CheckBox();
            this.txtInputFilename = new System.Windows.Forms.TextBox();
            this.lblGain = new System.Windows.Forms.Label();
            this.numGain = new System.Windows.Forms.NumericUpDown();
            this.numLBandFreq = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsefulBwhz = new System.Windows.Forms.Label();
            this.numUsefulBw = new System.Windows.Forms.NumericUpDown();
            this.grpE1Output = new System.Windows.Forms.GroupBox();
            this.tabOutput = new System.Windows.Forms.TabControl();
            this.tabE1 = new System.Windows.Forms.TabPage();
            this.lblE1Port2 = new System.Windows.Forms.Label();
            this.numE1Port2 = new System.Windows.Forms.NumericUpDown();
            this.lblE1Port1 = new System.Windows.Forms.Label();
            this.numE1Port1 = new System.Windows.Forms.NumericUpDown();
            this.tabSAToP = new System.Windows.Forms.TabPage();
            this.txtSAToPUrl2 = new System.Windows.Forms.TextBox();
            this.txtSAToPUrl1 = new System.Windows.Forms.TextBox();
            this.lblSAToP2 = new System.Windows.Forms.Label();
            this.lblSATop1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.grpCouters = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCIC1Data = new System.Windows.Forms.Label();
            this.lblCIC2Data = new System.Windows.Forms.Label();
            this.lblCIC1Errors = new System.Windows.Forms.Label();
            this.lblCIC2Errors = new System.Windows.Forms.Label();
            this.txtCiC1Data = new System.Windows.Forms.TextBox();
            this.txtCiC1Error = new System.Windows.Forms.TextBox();
            this.txtCiC2Data = new System.Windows.Forms.TextBox();
            this.txtCiC2Error = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).BeginInit();
            this.grpRFInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLBandFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsefulBw)).BeginInit();
            this.grpE1Output.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tabE1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port1)).BeginInit();
            this.tabSAToP.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpCouters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(128, 453);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
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
            this.grpRFInput.Controls.Add(this.numSno);
            this.grpRFInput.Controls.Add(this.lblSno);
            this.grpRFInput.Controls.Add(this.chkUseFile);
            this.grpRFInput.Controls.Add(this.txtInputFilename);
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
            this.grpRFInput.Size = new System.Drawing.Size(535, 216);
            this.grpRFInput.TabIndex = 5;
            this.grpRFInput.TabStop = false;
            this.grpRFInput.Text = "RF Input";
            // 
            // numSno
            // 
            this.numSno.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSno.Location = new System.Drawing.Point(161, 141);
            this.numSno.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numSno.Name = "numSno";
            this.numSno.Size = new System.Drawing.Size(73, 22);
            this.numSno.TabIndex = 14;
            this.numSno.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSno.Location = new System.Drawing.Point(7, 143);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(117, 16);
            this.lblSno.TabIndex = 13;
            this.lblSno.Text = "SNo Estimate [db]";
            // 
            // chkUseFile
            // 
            this.chkUseFile.AutoSize = true;
            this.chkUseFile.Checked = true;
            this.chkUseFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseFile.Location = new System.Drawing.Point(20, 181);
            this.chkUseFile.Name = "chkUseFile";
            this.chkUseFile.Size = new System.Drawing.Size(85, 20);
            this.chkUseFile.TabIndex = 12;
            this.chkUseFile.Text = "Use File";
            this.chkUseFile.UseVisualStyleBackColor = true;
            // 
            // txtInputFilename
            // 
            this.txtInputFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputFilename.Location = new System.Drawing.Point(116, 179);
            this.txtInputFilename.Name = "txtInputFilename";
            this.txtInputFilename.Size = new System.Drawing.Size(406, 22);
            this.txtInputFilename.TabIndex = 11;
            this.txtInputFilename.Text = "/home/cicd/CICD/data/testDataName/TestS13.0V0.5330.533M44I11A0.50F-2000.00T0.50O2" +
    ".50R0.35S1ns.bin";
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
            200,
            0,
            0,
            0});
            this.numGain.Name = "numGain";
            this.numGain.Size = new System.Drawing.Size(73, 22);
            this.numGain.TabIndex = 9;
            this.numGain.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
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
            3000,
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
            this.numUsefulBw.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpE1Output
            // 
            this.grpE1Output.Controls.Add(this.tabOutput);
            this.grpE1Output.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpE1Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpE1Output.Location = new System.Drawing.Point(13, 234);
            this.grpE1Output.Name = "grpE1Output";
            this.grpE1Output.Size = new System.Drawing.Size(535, 181);
            this.grpE1Output.TabIndex = 6;
            this.grpE1Output.TabStop = false;
            this.grpE1Output.Text = "Output";
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
            // txtSAToPUrl2
            // 
            this.txtSAToPUrl2.Location = new System.Drawing.Point(84, 68);
            this.txtSAToPUrl2.Name = "txtSAToPUrl2";
            this.txtSAToPUrl2.Size = new System.Drawing.Size(414, 21);
            this.txtSAToPUrl2.TabIndex = 3;
            // 
            // txtSAToPUrl1
            // 
            this.txtSAToPUrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSAToPUrl1.Location = new System.Drawing.Point(84, 35);
            this.txtSAToPUrl1.Name = "txtSAToPUrl1";
            this.txtSAToPUrl1.Size = new System.Drawing.Size(414, 21);
            this.txtSAToPUrl1.TabIndex = 2;
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
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(279, 453);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 35);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(428, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.txtStatus);
            this.grpStatus.Location = new System.Drawing.Point(554, 234);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(548, 181);
            this.grpStatus.TabIndex = 9;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // grpCouters
            // 
            this.grpCouters.Controls.Add(this.tableLayoutPanel1);
            this.grpCouters.Location = new System.Drawing.Point(554, 12);
            this.grpCouters.Name = "grpCouters";
            this.grpCouters.Size = new System.Drawing.Size(548, 216);
            this.grpCouters.TabIndex = 9;
            this.grpCouters.TabStop = false;
            this.grpCouters.Text = "Couters";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(6, 26);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(536, 138);
            this.txtStatus.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.43435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.56565F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Controls.Add(this.txtCiC2Error, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCiC2Data, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCiC1Error, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC1Data, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC2Data, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC1Errors, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC2Errors, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCiC1Data, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCIC1Data
            // 
            this.lblCIC1Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCIC1Data.AutoSize = true;
            this.lblCIC1Data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC1Data.Location = new System.Drawing.Point(3, 0);
            this.lblCIC1Data.Name = "lblCIC1Data";
            this.lblCIC1Data.Size = new System.Drawing.Size(80, 27);
            this.lblCIC1Data.TabIndex = 0;
            this.lblCIC1Data.Text = "CIC 1 Data";
            this.lblCIC1Data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCIC2Data
            // 
            this.lblCIC2Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCIC2Data.AutoSize = true;
            this.lblCIC2Data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC2Data.Location = new System.Drawing.Point(3, 27);
            this.lblCIC2Data.Name = "lblCIC2Data";
            this.lblCIC2Data.Size = new System.Drawing.Size(80, 27);
            this.lblCIC2Data.TabIndex = 1;
            this.lblCIC2Data.Text = "CIC 2 Data";
            this.lblCIC2Data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCIC1Errors
            // 
            this.lblCIC1Errors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCIC1Errors.AutoSize = true;
            this.lblCIC1Errors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC1Errors.Location = new System.Drawing.Point(201, 0);
            this.lblCIC1Errors.Name = "lblCIC1Errors";
            this.lblCIC1Errors.Size = new System.Drawing.Size(136, 27);
            this.lblCIC1Errors.TabIndex = 2;
            this.lblCIC1Errors.Text = "CIC 1 Errors";
            this.lblCIC1Errors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCIC2Errors
            // 
            this.lblCIC2Errors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCIC2Errors.AutoSize = true;
            this.lblCIC2Errors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC2Errors.Location = new System.Drawing.Point(201, 27);
            this.lblCIC2Errors.Name = "lblCIC2Errors";
            this.lblCIC2Errors.Size = new System.Drawing.Size(136, 27);
            this.lblCIC2Errors.TabIndex = 3;
            this.lblCIC2Errors.Text = "CIC 2 Errors";
            this.lblCIC2Errors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCiC1Data
            // 
            this.txtCiC1Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiC1Data.Location = new System.Drawing.Point(89, 3);
            this.txtCiC1Data.Name = "txtCiC1Data";
            this.txtCiC1Data.ReadOnly = true;
            this.txtCiC1Data.Size = new System.Drawing.Size(106, 20);
            this.txtCiC1Data.TabIndex = 4;
            this.txtCiC1Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCiC1Error
            // 
            this.txtCiC1Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiC1Error.Location = new System.Drawing.Point(343, 3);
            this.txtCiC1Error.Name = "txtCiC1Error";
            this.txtCiC1Error.ReadOnly = true;
            this.txtCiC1Error.Size = new System.Drawing.Size(152, 20);
            this.txtCiC1Error.TabIndex = 5;
            this.txtCiC1Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCiC2Data
            // 
            this.txtCiC2Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiC2Data.Location = new System.Drawing.Point(89, 30);
            this.txtCiC2Data.Name = "txtCiC2Data";
            this.txtCiC2Data.ReadOnly = true;
            this.txtCiC2Data.Size = new System.Drawing.Size(106, 20);
            this.txtCiC2Data.TabIndex = 6;
            this.txtCiC2Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCiC2Error
            // 
            this.txtCiC2Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiC2Error.Location = new System.Drawing.Point(343, 30);
            this.txtCiC2Error.Name = "txtCiC2Error";
            this.txtCiC2Error.ReadOnly = true;
            this.txtCiC2Error.Size = new System.Drawing.Size(152, 20);
            this.txtCiC2Error.TabIndex = 7;
            this.txtCiC2Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 534);
            this.Controls.Add(this.grpCouters);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.grpE1Output);
            this.Controls.Add(this.grpRFInput);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "SatManager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).EndInit();
            this.grpRFInput.ResumeLayout(false);
            this.grpRFInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLBandFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsefulBw)).EndInit();
            this.grpE1Output.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.tabE1.ResumeLayout(false);
            this.tabE1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port1)).EndInit();
            this.tabSAToP.ResumeLayout(false);
            this.tabSAToP.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpCouters.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkUseFile;
        private System.Windows.Forms.TextBox txtInputFilename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numSno;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox grpCouters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCiC2Error;
        private System.Windows.Forms.TextBox txtCiC2Data;
        private System.Windows.Forms.TextBox txtCiC1Error;
        private System.Windows.Forms.Label lblCIC1Data;
        private System.Windows.Forms.Label lblCIC2Data;
        private System.Windows.Forms.Label lblCIC1Errors;
        private System.Windows.Forms.Label lblCIC2Errors;
        private System.Windows.Forms.TextBox txtCiC1Data;
    }
}

