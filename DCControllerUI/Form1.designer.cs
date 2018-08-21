namespace DCControllerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.updateIntervalTB = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.timeoutTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.retryTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.readCommunityTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.writeCommunityTB = new System.Windows.Forms.TextBox();
            this.deviceIPTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.portBGroup = new System.Windows.Forms.GroupBox();
            this.bSlopeTB = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.bInstalledCB = new System.Windows.Forms.ComboBox();
            this.bMuteCB = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bInverseCB = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.bAttenuationTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.bConfigureMuteCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bFrequencyTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portAGroup = new System.Windows.Forms.GroupBox();
            this.aSlopeTB = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.aInstalledCB = new System.Windows.Forms.ComboBox();
            this.aMuteCB = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.aInverseCB = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.aAttenuationTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.aConfigureMuteCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aFrequencyTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadConfigBtn = new System.Windows.Forms.Button();
            this.alarmsDataGrid = new System.Windows.Forms.DataGridView();
            this.Alarms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getStateBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.connectionGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.portBGroup.SuspendLayout();
            this.portAGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.updateIntervalTB);
            this.connectionGroupBox.Controls.Add(this.label21);
            this.connectionGroupBox.Controls.Add(this.portTB);
            this.connectionGroupBox.Controls.Add(this.label12);
            this.connectionGroupBox.Controls.Add(this.timeoutTB);
            this.connectionGroupBox.Controls.Add(this.label11);
            this.connectionGroupBox.Controls.Add(this.retryTB);
            this.connectionGroupBox.Controls.Add(this.label10);
            this.connectionGroupBox.Controls.Add(this.readCommunityTB);
            this.connectionGroupBox.Controls.Add(this.label9);
            this.connectionGroupBox.Controls.Add(this.label8);
            this.connectionGroupBox.Controls.Add(this.writeCommunityTB);
            this.connectionGroupBox.Controls.Add(this.deviceIPTB);
            this.connectionGroupBox.Controls.Add(this.label5);
            this.connectionGroupBox.Location = new System.Drawing.Point(470, 22);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(160, 293);
            this.connectionGroupBox.TabIndex = 0;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // updateIntervalTB
            // 
            this.updateIntervalTB.Location = new System.Drawing.Point(47, 269);
            this.updateIntervalTB.Name = "updateIntervalTB";
            this.updateIntervalTB.Size = new System.Drawing.Size(100, 20);
            this.updateIntervalTB.TabIndex = 18;
            this.updateIntervalTB.Text = "1000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 254);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Update interval (ms)";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(47, 74);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(100, 20);
            this.portTB.TabIndex = 16;
            this.portTB.Text = "161";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Port";
            // 
            // timeoutTB
            // 
            this.timeoutTB.Location = new System.Drawing.Point(47, 231);
            this.timeoutTB.Name = "timeoutTB";
            this.timeoutTB.Size = new System.Drawing.Size(100, 20);
            this.timeoutTB.TabIndex = 14;
            this.timeoutTB.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Timeout (ms)";
            // 
            // retryTB
            // 
            this.retryTB.Location = new System.Drawing.Point(47, 192);
            this.retryTB.Name = "retryTB";
            this.retryTB.Size = new System.Drawing.Size(100, 20);
            this.retryTB.TabIndex = 12;
            this.retryTB.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Number of retries";
            // 
            // readCommunityTB
            // 
            this.readCommunityTB.Location = new System.Drawing.Point(47, 153);
            this.readCommunityTB.Name = "readCommunityTB";
            this.readCommunityTB.Size = new System.Drawing.Size(100, 20);
            this.readCommunityTB.TabIndex = 10;
            this.readCommunityTB.Text = "public";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Read Community";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Write Community";
            // 
            // writeCommunityTB
            // 
            this.writeCommunityTB.Location = new System.Drawing.Point(47, 114);
            this.writeCommunityTB.Name = "writeCommunityTB";
            this.writeCommunityTB.Size = new System.Drawing.Size(100, 20);
            this.writeCommunityTB.TabIndex = 7;
            this.writeCommunityTB.Text = "private";
            // 
            // deviceIPTB
            // 
            this.deviceIPTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deviceIPTB.Location = new System.Drawing.Point(47, 35);
            this.deviceIPTB.Name = "deviceIPTB";
            this.deviceIPTB.Size = new System.Drawing.Size(100, 20);
            this.deviceIPTB.TabIndex = 3;
            this.deviceIPTB.Text = "192.168.2.13";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "LBC-4000 Device IP";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(467, 321);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(163, 25);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.portBGroup);
            this.groupBox2.Controls.Add(this.portAGroup);
            this.groupBox2.Location = new System.Drawing.Point(5, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // portBGroup
            // 
            this.portBGroup.Controls.Add(this.bSlopeTB);
            this.portBGroup.Controls.Add(this.label23);
            this.portBGroup.Controls.Add(this.bInstalledCB);
            this.portBGroup.Controls.Add(this.bMuteCB);
            this.portBGroup.Controls.Add(this.label19);
            this.portBGroup.Controls.Add(this.bInverseCB);
            this.portBGroup.Controls.Add(this.label17);
            this.portBGroup.Controls.Add(this.bAttenuationTB);
            this.portBGroup.Controls.Add(this.label16);
            this.portBGroup.Controls.Add(this.bConfigureMuteCB);
            this.portBGroup.Controls.Add(this.label13);
            this.portBGroup.Controls.Add(this.label3);
            this.portBGroup.Controls.Add(this.bFrequencyTB);
            this.portBGroup.Controls.Add(this.label4);
            this.portBGroup.Location = new System.Drawing.Point(230, 19);
            this.portBGroup.Name = "portBGroup";
            this.portBGroup.Size = new System.Drawing.Size(216, 203);
            this.portBGroup.TabIndex = 4;
            this.portBGroup.TabStop = false;
            this.portBGroup.Text = "Port B";
            // 
            // bSlopeTB
            // 
            this.bSlopeTB.Location = new System.Drawing.Point(89, 175);
            this.bSlopeTB.Name = "bSlopeTB";
            this.bSlopeTB.Size = new System.Drawing.Size(121, 20);
            this.bSlopeTB.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 178);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Slope";
            // 
            // bInstalledCB
            // 
            this.bInstalledCB.FormattingEnabled = true;
            this.bInstalledCB.Location = new System.Drawing.Point(89, 18);
            this.bInstalledCB.Name = "bInstalledCB";
            this.bInstalledCB.Size = new System.Drawing.Size(121, 21);
            this.bInstalledCB.TabIndex = 16;
            // 
            // bMuteCB
            // 
            this.bMuteCB.FormattingEnabled = true;
            this.bMuteCB.Location = new System.Drawing.Point(89, 70);
            this.bMuteCB.Name = "bMuteCB";
            this.bMuteCB.Size = new System.Drawing.Size(121, 21);
            this.bMuteCB.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Installed";
            // 
            // bInverseCB
            // 
            this.bInverseCB.FormattingEnabled = true;
            this.bInverseCB.Location = new System.Drawing.Point(89, 148);
            this.bInverseCB.Name = "bInverseCB";
            this.bInverseCB.Size = new System.Drawing.Size(121, 21);
            this.bInverseCB.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Inverse";
            // 
            // bAttenuationTB
            // 
            this.bAttenuationTB.Location = new System.Drawing.Point(89, 123);
            this.bAttenuationTB.Name = "bAttenuationTB";
            this.bAttenuationTB.Size = new System.Drawing.Size(121, 20);
            this.bAttenuationTB.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Attenuation";
            // 
            // bConfigureMuteCB
            // 
            this.bConfigureMuteCB.FormattingEnabled = true;
            this.bConfigureMuteCB.Location = new System.Drawing.Point(89, 97);
            this.bConfigureMuteCB.Name = "bConfigureMuteCB";
            this.bConfigureMuteCB.Size = new System.Drawing.Size(121, 21);
            this.bConfigureMuteCB.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Configure Mute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Frequency (kHz)";
            // 
            // bFrequencyTB
            // 
            this.bFrequencyTB.Location = new System.Drawing.Point(89, 45);
            this.bFrequencyTB.Name = "bFrequencyTB";
            this.bFrequencyTB.Size = new System.Drawing.Size(121, 20);
            this.bFrequencyTB.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mute";
            // 
            // portAGroup
            // 
            this.portAGroup.Controls.Add(this.aSlopeTB);
            this.portAGroup.Controls.Add(this.label22);
            this.portAGroup.Controls.Add(this.aInstalledCB);
            this.portAGroup.Controls.Add(this.aMuteCB);
            this.portAGroup.Controls.Add(this.label18);
            this.portAGroup.Controls.Add(this.aInverseCB);
            this.portAGroup.Controls.Add(this.label15);
            this.portAGroup.Controls.Add(this.aAttenuationTB);
            this.portAGroup.Controls.Add(this.label14);
            this.portAGroup.Controls.Add(this.aConfigureMuteCB);
            this.portAGroup.Controls.Add(this.label6);
            this.portAGroup.Controls.Add(this.label1);
            this.portAGroup.Controls.Add(this.aFrequencyTB);
            this.portAGroup.Controls.Add(this.label2);
            this.portAGroup.Location = new System.Drawing.Point(7, 19);
            this.portAGroup.Name = "portAGroup";
            this.portAGroup.Size = new System.Drawing.Size(217, 203);
            this.portAGroup.TabIndex = 3;
            this.portAGroup.TabStop = false;
            this.portAGroup.Text = "Port A";
            // 
            // aSlopeTB
            // 
            this.aSlopeTB.Location = new System.Drawing.Point(90, 175);
            this.aSlopeTB.Name = "aSlopeTB";
            this.aSlopeTB.Size = new System.Drawing.Size(121, 20);
            this.aSlopeTB.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Slope";
            // 
            // aInstalledCB
            // 
            this.aInstalledCB.FormattingEnabled = true;
            this.aInstalledCB.Location = new System.Drawing.Point(90, 18);
            this.aInstalledCB.Name = "aInstalledCB";
            this.aInstalledCB.Size = new System.Drawing.Size(121, 21);
            this.aInstalledCB.TabIndex = 15;
            // 
            // aMuteCB
            // 
            this.aMuteCB.FormattingEnabled = true;
            this.aMuteCB.Location = new System.Drawing.Point(90, 71);
            this.aMuteCB.Name = "aMuteCB";
            this.aMuteCB.Size = new System.Drawing.Size(121, 21);
            this.aMuteCB.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Installed";
            // 
            // aInverseCB
            // 
            this.aInverseCB.FormattingEnabled = true;
            this.aInverseCB.Location = new System.Drawing.Point(90, 148);
            this.aInverseCB.Name = "aInverseCB";
            this.aInverseCB.Size = new System.Drawing.Size(121, 21);
            this.aInverseCB.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Inverse";
            // 
            // aAttenuationTB
            // 
            this.aAttenuationTB.Location = new System.Drawing.Point(90, 124);
            this.aAttenuationTB.Name = "aAttenuationTB";
            this.aAttenuationTB.Size = new System.Drawing.Size(121, 20);
            this.aAttenuationTB.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Attenuation";
            // 
            // aConfigureMuteCB
            // 
            this.aConfigureMuteCB.FormattingEnabled = true;
            this.aConfigureMuteCB.Location = new System.Drawing.Point(90, 98);
            this.aConfigureMuteCB.Name = "aConfigureMuteCB";
            this.aConfigureMuteCB.Size = new System.Drawing.Size(121, 21);
            this.aConfigureMuteCB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Configure Mute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequency (kHz)";
            // 
            // aFrequencyTB
            // 
            this.aFrequencyTB.Location = new System.Drawing.Point(90, 45);
            this.aFrequencyTB.Name = "aFrequencyTB";
            this.aFrequencyTB.Size = new System.Drawing.Size(121, 20);
            this.aFrequencyTB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mute";
            // 
            // downloadConfigBtn
            // 
            this.downloadConfigBtn.Location = new System.Drawing.Point(467, 381);
            this.downloadConfigBtn.Name = "downloadConfigBtn";
            this.downloadConfigBtn.Size = new System.Drawing.Size(163, 25);
            this.downloadConfigBtn.TabIndex = 6;
            this.downloadConfigBtn.Text = "Download Config";
            this.downloadConfigBtn.UseVisualStyleBackColor = true;
            this.downloadConfigBtn.Click += new System.EventHandler(this.downloadConfigBtn_Click);
            // 
            // alarmsDataGrid
            // 
            this.alarmsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alarmsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alarms,
            this.State});
            this.alarmsDataGrid.Location = new System.Drawing.Point(2, 269);
            this.alarmsDataGrid.Name = "alarmsDataGrid";
            this.alarmsDataGrid.Size = new System.Drawing.Size(459, 137);
            this.alarmsDataGrid.TabIndex = 0;
            // 
            // Alarms
            // 
            this.Alarms.HeaderText = "Alarms";
            this.Alarms.Name = "Alarms";
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            // 
            // getStateBtn
            // 
            this.getStateBtn.Location = new System.Drawing.Point(467, 350);
            this.getStateBtn.Name = "getStateBtn";
            this.getStateBtn.Size = new System.Drawing.Size(163, 25);
            this.getStateBtn.TabIndex = 7;
            this.getStateBtn.Text = "Get State";
            this.getStateBtn.UseVisualStyleBackColor = true;
            this.getStateBtn.Click += new System.EventHandler(this.getStateBtn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Current alarm status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 413);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.getStateBtn);
            this.Controls.Add(this.alarmsDataGrid);
            this.Controls.Add(this.downloadConfigBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.connectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.portBGroup.ResumeLayout(false);
            this.portBGroup.PerformLayout();
            this.portAGroup.ResumeLayout(false);
            this.portAGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aFrequencyTB;
        private System.Windows.Forms.GroupBox portAGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deviceIPTB;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox aConfigureMuteCB;
        private System.Windows.Forms.TextBox writeCommunityTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox readCommunityTB;
        private System.Windows.Forms.TextBox retryTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button downloadConfigBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox timeoutTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.ComboBox aInverseCB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox aAttenuationTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView alarmsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alarms;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button getStateBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox portBGroup;
        private System.Windows.Forms.ComboBox bMuteCB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox bInverseCB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox bAttenuationTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox bConfigureMuteCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bFrequencyTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox aMuteCB;
        private System.Windows.Forms.TextBox updateIntervalTB;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox bInstalledCB;
        private System.Windows.Forms.ComboBox aInstalledCB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox bSlopeTB;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox aSlopeTB;
        private System.Windows.Forms.Label label22;
    }
}

