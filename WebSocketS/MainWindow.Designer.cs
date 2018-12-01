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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnStart = new System.Windows.Forms.Button();
            this.numSampleFrequency = new System.Windows.Forms.NumericUpDown();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblSymbolRate = new System.Windows.Forms.Label();
            this.numSymbolRate = new System.Windows.Forms.NumericUpDown();
            this.numSNR = new System.Windows.Forms.NumericUpDown();
            this.lblSNR = new System.Windows.Forms.Label();
            this.grpRFInput = new System.Windows.Forms.GroupBox();
            this.numSno = new System.Windows.Forms.NumericUpDown();
            this.lblSno = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.numGain = new System.Windows.Forms.NumericUpDown();
            this.numCenterFreq = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsefulBwhz = new System.Windows.Forms.Label();
            this.numUsefulBw = new System.Windows.Forms.NumericUpDown();
            this.txtInputFilename = new System.Windows.Forms.TextBox();
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
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.grpCouters = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMonitorMediation = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMonitorDC = new System.Windows.Forms.CheckBox();
            this.grpMonitorCICD = new System.Windows.Forms.GroupBox();
            this.chkMonitorCicd = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCiC2Error = new System.Windows.Forms.TextBox();
            this.txtCiC2Data = new System.Windows.Forms.TextBox();
            this.txtCiC1Error = new System.Windows.Forms.TextBox();
            this.lblCIC1Data = new System.Windows.Forms.Label();
            this.lblCIC2Data = new System.Windows.Forms.Label();
            this.lblCIC1Errors = new System.Windows.Forms.Label();
            this.lblCIC2Errors = new System.Windows.Forms.Label();
            this.txtCiC1Data = new System.Windows.Forms.TextBox();
            this.cmbInputType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSubType = new System.Windows.Forms.Label();
            this.cmbInputSubType = new System.Windows.Forms.ComboBox();
            this.tmrMonitor = new System.Windows.Forms.Timer(this.components);
            this.grpFileInput = new System.Windows.Forms.GroupBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.chkUseFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).BeginInit();
            this.grpRFInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsefulBw)).BeginInit();
            this.grpE1Output.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tabE1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE1Port1)).BeginInit();
            this.tabSAToP.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpCouters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpMonitorCICD.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpFileInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(347, 557);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // numSampleFrequency
            // 
            this.numSampleFrequency.DecimalPlaces = 3;
            this.numSampleFrequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSampleFrequency.Location = new System.Drawing.Point(170, 16);
            this.numSampleFrequency.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numSampleFrequency.Name = "numSampleFrequency";
            this.numSampleFrequency.Size = new System.Drawing.Size(73, 22);
            this.numSampleFrequency.TabIndex = 0;
            this.numSampleFrequency.Tag = "SampleFrequncy";
            this.numSampleFrequency.Value = new decimal(new int[] {
            125,
            0,
            0,
            65536});
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.Location = new System.Drawing.Point(7, 18);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(160, 16);
            this.lblFrequency.TabIndex = 3;
            this.lblFrequency.Text = "Sample Frequency [MHz]";
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
            this.numSymbolRate.Location = new System.Drawing.Point(170, 100);
            this.numSymbolRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numSymbolRate.Name = "numSymbolRate";
            this.numSymbolRate.Size = new System.Drawing.Size(73, 22);
            this.numSymbolRate.TabIndex = 2;
            this.numSymbolRate.Tag = "SymbolRate";
            // 
            // numSNR
            // 
            this.numSNR.DecimalPlaces = 2;
            this.numSNR.Enabled = false;
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
            this.numSNR.TabIndex = 5;
            this.numSNR.Tag = "SNR";
            this.numSNR.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            // 
            // lblSNR
            // 
            this.lblSNR.AutoSize = true;
            this.lblSNR.Enabled = false;
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
            this.grpRFInput.Controls.Add(this.lblGain);
            this.grpRFInput.Controls.Add(this.numGain);
            this.grpRFInput.Controls.Add(this.numCenterFreq);
            this.grpRFInput.Controls.Add(this.label1);
            this.grpRFInput.Controls.Add(this.lblUsefulBwhz);
            this.grpRFInput.Controls.Add(this.numUsefulBw);
            this.grpRFInput.Controls.Add(this.numSampleFrequency);
            this.grpRFInput.Controls.Add(this.lblSNR);
            this.grpRFInput.Controls.Add(this.lblFrequency);
            this.grpRFInput.Controls.Add(this.numSNR);
            this.grpRFInput.Controls.Add(this.numSymbolRate);
            this.grpRFInput.Controls.Add(this.lblSymbolRate);
            this.grpRFInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpRFInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRFInput.Location = new System.Drawing.Point(12, 12);
            this.grpRFInput.Name = "grpRFInput";
            this.grpRFInput.Size = new System.Drawing.Size(535, 211);
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
            this.numSno.Location = new System.Drawing.Point(170, 141);
            this.numSno.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numSno.Name = "numSno";
            this.numSno.Size = new System.Drawing.Size(73, 22);
            this.numSno.TabIndex = 3;
            this.numSno.Tag = "SnoEstimate";
            this.numSno.Value = new decimal(new int[] {
            17,
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
            this.numGain.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numGain.Name = "numGain";
            this.numGain.Size = new System.Drawing.Size(73, 22);
            this.numGain.TabIndex = 7;
            this.numGain.Tag = "Gain";
            // 
            // numCenterFreq
            // 
            this.numCenterFreq.DecimalPlaces = 3;
            this.numCenterFreq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCenterFreq.Location = new System.Drawing.Point(170, 58);
            this.numCenterFreq.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numCenterFreq.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numCenterFreq.Name = "numCenterFreq";
            this.numCenterFreq.Size = new System.Drawing.Size(73, 22);
            this.numCenterFreq.TabIndex = 1;
            this.numCenterFreq.Tag = "CenterFrequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Center Frequency [MHz]";
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
            5,
            0,
            0,
            0});
            this.numUsefulBw.Name = "numUsefulBw";
            this.numUsefulBw.Size = new System.Drawing.Size(73, 22);
            this.numUsefulBw.TabIndex = 6;
            this.numUsefulBw.Tag = "UsefulBW_MHz";
            this.numUsefulBw.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numUsefulBw.ValueChanged += new System.EventHandler(this.numUsefulBw_ValueChanged);
            // 
            // txtInputFilename
            // 
            this.txtInputFilename.Enabled = false;
            this.txtInputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFilename.Location = new System.Drawing.Point(83, 19);
            this.txtInputFilename.Name = "txtInputFilename";
            this.txtInputFilename.Size = new System.Drawing.Size(431, 21);
            this.txtInputFilename.TabIndex = 4;
            this.txtInputFilename.Tag = "InputFilename";
            this.txtInputFilename.Text = "/media/cicd/Elements/62E_13m_oct18/62E_C-band_LH_1013.34MHz_QPSK_17dB_fs_12.5MHz_" +
    "041018.bin";
            // 
            // grpE1Output
            // 
            this.grpE1Output.Controls.Add(this.tabOutput);
            this.grpE1Output.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpE1Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpE1Output.Location = new System.Drawing.Point(13, 371);
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
            this.tabOutput.Size = new System.Drawing.Size(512, 149);
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
            this.tabE1.Size = new System.Drawing.Size(504, 121);
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
            this.numE1Port2.TabIndex = 1;
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
            this.numE1Port1.TabIndex = 0;
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
            this.tabSAToP.Size = new System.Drawing.Size(504, 121);
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
            this.txtSAToPUrl2.Tag = "CICDtoMedCICUri2";
            // 
            // txtSAToPUrl1
            // 
            this.txtSAToPUrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSAToPUrl1.Location = new System.Drawing.Point(84, 35);
            this.txtSAToPUrl1.Name = "txtSAToPUrl1";
            this.txtSAToPUrl1.Size = new System.Drawing.Size(414, 21);
            this.txtSAToPUrl1.TabIndex = 2;
            this.txtSAToPUrl1.Tag = "CICDtoMedCICUri1";
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
            this.btnStop.Location = new System.Drawing.Point(661, 557);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 35);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.txtStatus);
            this.grpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.Location = new System.Drawing.Point(560, 371);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(542, 181);
            this.grpStatus.TabIndex = 0;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 19);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(498, 156);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtStatus_MouseDoubleClick);
            // 
            // grpCouters
            // 
            this.grpCouters.Controls.Add(this.groupBox2);
            this.grpCouters.Controls.Add(this.groupBox1);
            this.grpCouters.Controls.Add(this.grpMonitorCICD);
            this.grpCouters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCouters.Location = new System.Drawing.Point(560, 12);
            this.grpCouters.Name = "grpCouters";
            this.grpCouters.Size = new System.Drawing.Size(542, 343);
            this.grpCouters.TabIndex = 9;
            this.grpCouters.TabStop = false;
            this.grpCouters.Text = "Monitor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMonitorMediation);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(6, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // chkMonitorMediation
            // 
            this.chkMonitorMediation.AutoSize = true;
            this.chkMonitorMediation.Location = new System.Drawing.Point(11, -2);
            this.chkMonitorMediation.Name = "chkMonitorMediation";
            this.chkMonitorMediation.Size = new System.Drawing.Size(95, 20);
            this.chkMonitorMediation.TabIndex = 1;
            this.chkMonitorMediation.Text = "Mediation";
            this.chkMonitorMediation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.43435F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.56565F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(332, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(84, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(332, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "CIC 1 Input";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "CIC 2 Input";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(190, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "CIC 1 Output";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(190, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "CIC 2 Output";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(84, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.TabStop = false;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMonitorDC);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chkMonitorDC
            // 
            this.chkMonitorDC.AutoSize = true;
            this.chkMonitorDC.Location = new System.Drawing.Point(11, -2);
            this.chkMonitorDC.Name = "chkMonitorDC";
            this.chkMonitorDC.Size = new System.Drawing.Size(136, 20);
            this.chkMonitorDC.TabIndex = 1;
            this.chkMonitorDC.Text = "Down Convertor";
            this.chkMonitorDC.UseVisualStyleBackColor = true;
            // 
            // grpMonitorCICD
            // 
            this.grpMonitorCICD.Controls.Add(this.chkMonitorCicd);
            this.grpMonitorCICD.Controls.Add(this.tableLayoutPanel1);
            this.grpMonitorCICD.Location = new System.Drawing.Point(6, 102);
            this.grpMonitorCICD.Name = "grpMonitorCICD";
            this.grpMonitorCICD.Size = new System.Drawing.Size(517, 109);
            this.grpMonitorCICD.TabIndex = 1;
            this.grpMonitorCICD.TabStop = false;
            // 
            // chkMonitorCicd
            // 
            this.chkMonitorCicd.AutoSize = true;
            this.chkMonitorCicd.Location = new System.Drawing.Point(11, -2);
            this.chkMonitorCicd.Name = "chkMonitorCicd";
            this.chkMonitorCicd.Size = new System.Drawing.Size(62, 20);
            this.chkMonitorCicd.TabIndex = 1;
            this.chkMonitorCicd.Text = "CICD";
            this.chkMonitorCicd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.43435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.56565F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.txtCiC2Error, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCiC2Data, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCiC1Error, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC1Data, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC2Data, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC1Errors, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCIC2Errors, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCiC1Data, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCiC2Error
            // 
            this.txtCiC2Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiC2Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiC2Error.Location = new System.Drawing.Point(332, 30);
            this.txtCiC2Error.Name = "txtCiC2Error";
            this.txtCiC2Error.ReadOnly = true;
            this.txtCiC2Error.Size = new System.Drawing.Size(163, 22);
            this.txtCiC2Error.TabIndex = 7;
            this.txtCiC2Error.TabStop = false;
            this.txtCiC2Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCiC2Data
            // 
            this.txtCiC2Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiC2Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiC2Data.Location = new System.Drawing.Point(84, 30);
            this.txtCiC2Data.Name = "txtCiC2Data";
            this.txtCiC2Data.ReadOnly = true;
            this.txtCiC2Data.Size = new System.Drawing.Size(100, 22);
            this.txtCiC2Data.TabIndex = 6;
            this.txtCiC2Data.TabStop = false;
            this.txtCiC2Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCiC1Error
            // 
            this.txtCiC1Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiC1Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiC1Error.Location = new System.Drawing.Point(332, 3);
            this.txtCiC1Error.Name = "txtCiC1Error";
            this.txtCiC1Error.ReadOnly = true;
            this.txtCiC1Error.Size = new System.Drawing.Size(163, 22);
            this.txtCiC1Error.TabIndex = 5;
            this.txtCiC1Error.TabStop = false;
            this.txtCiC1Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCIC1Data
            // 
            this.lblCIC1Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCIC1Data.AutoSize = true;
            this.lblCIC1Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIC1Data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC1Data.Location = new System.Drawing.Point(3, 0);
            this.lblCIC1Data.Name = "lblCIC1Data";
            this.lblCIC1Data.Size = new System.Drawing.Size(75, 27);
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
            this.lblCIC2Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIC2Data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC2Data.Location = new System.Drawing.Point(3, 27);
            this.lblCIC2Data.Name = "lblCIC2Data";
            this.lblCIC2Data.Size = new System.Drawing.Size(75, 27);
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
            this.lblCIC1Errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIC1Errors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC1Errors.Location = new System.Drawing.Point(190, 0);
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
            this.lblCIC2Errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIC2Errors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCIC2Errors.Location = new System.Drawing.Point(190, 27);
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
            this.txtCiC1Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiC1Data.Location = new System.Drawing.Point(84, 3);
            this.txtCiC1Data.Name = "txtCiC1Data";
            this.txtCiC1Data.ReadOnly = true;
            this.txtCiC1Data.Size = new System.Drawing.Size(100, 22);
            this.txtCiC1Data.TabIndex = 4;
            this.txtCiC1Data.TabStop = false;
            this.txtCiC1Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbInputType
            // 
            this.cmbInputType.Enabled = false;
            this.cmbInputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInputType.FormattingEnabled = true;
            this.cmbInputType.Items.AddRange(new object[] {
            "REAL",
            "COMPLEX"});
            this.cmbInputType.Location = new System.Drawing.Point(131, 67);
            this.cmbInputType.Name = "cmbInputType";
            this.cmbInputType.Size = new System.Drawing.Size(121, 23);
            this.cmbInputType.TabIndex = 14;
            this.cmbInputType.Tag = "InputType";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Enabled = false;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(169, 94);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 15);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type";
            // 
            // lblSubType
            // 
            this.lblSubType.AutoSize = true;
            this.lblSubType.Enabled = false;
            this.lblSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubType.Location = new System.Drawing.Point(348, 94);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(55, 15);
            this.lblSubType.TabIndex = 17;
            this.lblSubType.Text = "SubType";
            // 
            // cmbInputSubType
            // 
            this.cmbInputSubType.Enabled = false;
            this.cmbInputSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInputSubType.FormattingEnabled = true;
            this.cmbInputSubType.Items.AddRange(new object[] {
            "UINT16",
            "INT16",
            "UINT32",
            "INT",
            "FLOAT",
            "DOUBLE"});
            this.cmbInputSubType.Location = new System.Drawing.Point(323, 67);
            this.cmbInputSubType.Name = "cmbInputSubType";
            this.cmbInputSubType.Size = new System.Drawing.Size(121, 23);
            this.cmbInputSubType.TabIndex = 16;
            this.cmbInputSubType.Tag = "InputSubType";
            // 
            // tmrMonitor
            // 
            this.tmrMonitor.Interval = 500;
            this.tmrMonitor.Tick += new System.EventHandler(this.tmrMonitor_Tick);
            // 
            // grpFileInput
            // 
            this.grpFileInput.Controls.Add(this.lblInputFile);
            this.grpFileInput.Controls.Add(this.lblSubType);
            this.grpFileInput.Controls.Add(this.chkUseFile);
            this.grpFileInput.Controls.Add(this.cmbInputSubType);
            this.grpFileInput.Controls.Add(this.txtInputFilename);
            this.grpFileInput.Controls.Add(this.lblType);
            this.grpFileInput.Controls.Add(this.cmbInputType);
            this.grpFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFileInput.Location = new System.Drawing.Point(12, 229);
            this.grpFileInput.Name = "grpFileInput";
            this.grpFileInput.Size = new System.Drawing.Size(535, 126);
            this.grpFileInput.TabIndex = 11;
            this.grpFileInput.TabStop = false;
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Enabled = false;
            this.lblInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFile.Location = new System.Drawing.Point(3, 20);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(57, 15);
            this.lblInputFile.TabIndex = 18;
            this.lblInputFile.Text = "Input File";
            // 
            // chkUseFile
            // 
            this.chkUseFile.AutoSize = true;
            this.chkUseFile.Location = new System.Drawing.Point(6, 0);
            this.chkUseFile.Name = "chkUseFile";
            this.chkUseFile.Size = new System.Drawing.Size(86, 19);
            this.chkUseFile.TabIndex = 12;
            this.chkUseFile.Tag = "FileMode";
            this.chkUseFile.Text = "File Input";
            this.chkUseFile.UseVisualStyleBackColor = true;
            this.chkUseFile.CheckedChanged += new System.EventHandler(this.chkUseFile_CheckedChanged_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 605);
            this.Controls.Add(this.grpFileInput);
            this.Controls.Add(this.grpCouters);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.grpE1Output);
            this.Controls.Add(this.grpRFInput);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "SatManager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSampleFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNR)).EndInit();
            this.grpRFInput.ResumeLayout(false);
            this.grpRFInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenterFreq)).EndInit();
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMonitorCICD.ResumeLayout(false);
            this.grpMonitorCICD.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpFileInput.ResumeLayout(false);
            this.grpFileInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numSampleFrequency;
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
        private System.Windows.Forms.NumericUpDown numCenterFreq;
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
        private System.Windows.Forms.TextBox txtInputFilename;
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
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.ComboBox cmbInputSubType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbInputType;
        private System.Windows.Forms.GroupBox grpMonitorCICD;
        private System.Windows.Forms.CheckBox chkMonitorCicd;
        private System.Windows.Forms.Timer tmrMonitor;
        private System.Windows.Forms.GroupBox grpFileInput;
        private System.Windows.Forms.CheckBox chkUseFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMonitorMediation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMonitorDC;
        private System.Windows.Forms.Label lblInputFile;
    }
}

