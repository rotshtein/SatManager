using System;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lbc4000SnmpDriver.Configuration;
using Lbc4000SnmpDriver.Enums;
using Lbc4000SnmpDriver;
using Lbc4000Logger;

namespace DCControllerUI
{
    public partial class MainForm : Form
    {
        private Logger _logger;
        private Lbc4000 _device;
        private bool _connected = false;
        private int _timeout;
        private Color _defaultColor;

        public void Init()
        {
            _logger = Logger.GetLogger(silence: false);
            InitializeComponent();
            this.Text = "DCController - Disconnected";

            #region confiugre ui

            #region datagrid
            alarmsDataGrid.ColumnCount = 2;
            alarmsDataGrid.Columns[0].Name = "Alarm";
            alarmsDataGrid.Columns[1].Name = "State";
            alarmsDataGrid.Columns[0].Width = 170;
            alarmsDataGrid.Columns[1].Width = 50;
            #endregion datagrid

            #region tooltips
            var aAttenuationTT = new ToolTip();
            var aFrequencyTT = new ToolTip();
            var aSlopeTT = new ToolTip();
            var bAttenuationTT = new ToolTip();
            var bFrequencyTT = new ToolTip();
            var bSlopeTT = new ToolTip();
            aAttenuationTT.Active = true;
            aAttenuationTT.InitialDelay = 0;
            aAttenuationTT.SetToolTip(aAttenuationTB, "0...2000");
            aFrequencyTT.Active = true;
            aFrequencyTT.InitialDelay = 0;
            aFrequencyTT.SetToolTip(aFrequencyTB, "950000...2150000");
            aSlopeTT.Active = true;
            aSlopeTT.InitialDelay = 0;
            aSlopeTT.SetToolTip(aSlopeTB, "0...10");
            bAttenuationTT.Active = true;
            bAttenuationTT.InitialDelay = 0;
            bAttenuationTT.SetToolTip(bAttenuationTB, "0...2000");
            bFrequencyTT.Active = true;
            bFrequencyTT.InitialDelay = 0;
            bFrequencyTT.SetToolTip(bFrequencyTB, "950000...2150000");
            bSlopeTT.Active = true;
            bSlopeTT.InitialDelay = 0;
            bSlopeTT.SetToolTip(bSlopeTB, "0...10");

            #endregion tooltips

            #region comboboxes
            aMuteCB.Items.Add(MuteOptions.Off);
            aMuteCB.Items.Add(MuteOptions.On);
            bMuteCB.Items.Add(MuteOptions.Off);
            bMuteCB.Items.Add(MuteOptions.On);
            aMuteCB.DropDownStyle = ComboBoxStyle.DropDownList;
            bMuteCB.DropDownStyle = ComboBoxStyle.DropDownList;

            aConfigureMuteCB.Items.Add(ConfigMuteOptions.Off);
            aConfigureMuteCB.Items.Add(ConfigMuteOptions.On);
            bConfigureMuteCB.Items.Add(ConfigMuteOptions.Off);
            bConfigureMuteCB.Items.Add(ConfigMuteOptions.On);
            aConfigureMuteCB.DropDownStyle = ComboBoxStyle.DropDownList;
            bConfigureMuteCB.DropDownStyle = ComboBoxStyle.DropDownList;

            aInverseCB.Items.Add(InverseOptions.Nrm);
            aInverseCB.Items.Add(InverseOptions.Inv);
            bInverseCB.Items.Add(InverseOptions.Nrm);
            bInverseCB.Items.Add(InverseOptions.Inv);
            aInverseCB.DropDownStyle = ComboBoxStyle.DropDownList;
            bInverseCB.DropDownStyle = ComboBoxStyle.DropDownList;

            aInstalledCB.Items.Add(InstalledOptions.No);
            aInstalledCB.Items.Add(InstalledOptions.Yes);
            bInstalledCB.Items.Add(InstalledOptions.No);
            bInstalledCB.Items.Add(InstalledOptions.Yes);
            aInstalledCB.DropDownStyle = ComboBoxStyle.DropDownList;
            bInstalledCB.DropDownStyle = ComboBoxStyle.DropDownList;
            #endregion comboboxes

            #region buttons
            _defaultColor = connectBtn.BackColor;
            getStateBtn.Enabled = false;
            downloadConfigBtn.Enabled = false;
            #endregion buttons

            #endregion configure ui
        }

        public MainForm()
        {
            Init();
            this.FormClosed += _logger.Dispose;
        }

        ~MainForm()
        {
            Disconnect();
        }

        #region private methods
        private void Disconnect()
        {
            _connected = false;
            connectBtn.Text = "Connect";
            connectBtn.BackColor = _defaultColor;
            connectBtn.UseVisualStyleBackColor = true;
            if (_device != null)
            {
                _device.Dispose();
                _device = null;
            }
            alarmsDataGrid.Rows.Clear();
            getStateBtn.Enabled = false;
            downloadConfigBtn.Enabled = false;
            ResetPorts();
            this.Text = "DCController - Disconnected";
        }

        private void InitPorts()
        {
            if (!_device.PortAInstalled)
            {
                portAGroup.Text = "Port A (disabled)";
                foreach (var control in portAGroup.Controls)
                {
                    if (control is TextBox)
                        ((TextBox)control).Enabled = false;
                    else if (control is ComboBox)
                        ((ComboBox)control).Enabled = false;
                }
                aInstalledCB.Enabled = true;
                aInstalledCB.SelectedItem = InstalledOptions.No;
            }
            else aInstalledCB.SelectedItem = InstalledOptions.Yes;
            aInstalledCB.Enabled = false;

            if (!_device.PortBInstalled)
            {
                portBGroup.Text = "Port B (disabled)";
                foreach (var control in portBGroup.Controls)
                {
                    if (control is TextBox)
                        ((TextBox)control).Enabled = false;
                    else if (control is ComboBox)
                    ((ComboBox)control).Enabled = false;
                }
                bInstalledCB.Enabled = true;
                bInstalledCB.SelectedItem = InstalledOptions.No;
            }
            else bInstalledCB.SelectedItem = InstalledOptions.Yes;
            bInstalledCB.Enabled = false;

            foreach(var control in connectionGroupBox.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Enabled = false;
            }
        }

        private void ResetPorts()
        {
            portAGroup.Text = "Port A";
            portBGroup.Text = "Port B";

            foreach(var control in portAGroup.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Enabled = true;
                else if (control is ComboBox)
                    ((ComboBox)control).Enabled = true;
            }

            foreach (var control in portBGroup.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Enabled = true;
                else if (control is ComboBox)
                    ((ComboBox)control).Enabled = true;
            }

            foreach (var control in connectionGroupBox.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Enabled = true;
            }

            aInstalledCB.Enabled = false;
            bInstalledCB.Enabled = false;
        }

        #endregion private methods

        #region buttons

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (_connected)
            {
                Disconnect();
                ResetPorts();
                return;
            }
            _logger.WriteMessage("Pressed Connect button.", DebugLevel.VERBOSE);
            try
            {
                var ipAddress = IPAddress.Parse(deviceIPTB.Text);
                var readCommunity = readCommunityTB.Text;
                var writeCommunity = writeCommunityTB.Text;
                var port = int.Parse(portTB.Text);
                var retry = int.Parse(retryTB.Text);
                _timeout = int.Parse(timeoutTB.Text);
                var updateInterval = int.Parse(updateIntervalTB.Text);
                _device = Lbc4000.GetDevice(ipAddress, writeCommunity, readCommunity, port, retry, _timeout, updateInterval);
                if (_device.Connect())
                {
                    _device.Run();
                    InitPorts();
                    _connected = true;
                    connectBtn.BackColor = Color.Green;
                    connectBtn.Text = "Disconnect";
                    Text = "DCController - Connected";
                    getStateBtn.Enabled = true;
                    downloadConfigBtn.Enabled = true;
                    getStateBtn_Click(sender, e);
                }

                else
                {
                    _logger.WriteMessage("Couldn't connect to device", DebugLevel.ERROR);
                    _connected = false;
                    Disconnect();
                    MessageBox.Show("Couldn't connect to specified IP address", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
                _connected = false;
                Disconnect();
                MessageBox.Show("Thrown exception: " + ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void downloadConfigBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = "DCController - Sending command...";
                var aFrequency = Int32.Parse(aFrequencyTB.Text);
                var aMute = (MuteOptions)aMuteCB.SelectedItem;
                var aConfigureMute = (ConfigMuteOptions)aConfigureMuteCB.SelectedItem;
                var aAttenuation = Int32.Parse(aAttenuationTB.Text);
                var aInverse = (InverseOptions)aInverseCB.SelectedItem; 
                var aSlope = Int32.Parse(aSlopeTB.Text);
                var bFrequency = Int32.Parse(bFrequencyTB.Text);
                var bMute = (MuteOptions)bMuteCB.SelectedItem;
                var bConfigureMute = (ConfigMuteOptions)bConfigureMuteCB.SelectedItem;
                var bAttenuation = Int32.Parse(bAttenuationTB.Text);
                var bSlope = Int32.Parse(aSlopeTB.Text);
                var bInverse = (InverseOptions)bInverseCB.SelectedItem;
                try
                {
                    var portA = new PortAConfiguration(aFrequency, aMute, aConfigureMute, aAttenuation, aSlope, aInverse);
                    var portB = new PortBConfiguration(bFrequency, bMute, bConfigureMute, bAttenuation, bSlope, bInverse);
                    _device.AddConfigureAllCommand(portA, portB);
                }
                catch (Exception ex)
                {
                    _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
                    this.Text = "DCController - Connected";
                    MessageBox.Show(String.Format("Invalid argument!\r\n{0}", ex.Message), "Sorry", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
                MessageBox.Show(String.Format("Invalid operation!\r\n{0}", ex.Message), "Sorry", MessageBoxButtons.OK);
            }
            getStateBtn_Click(sender, e);
        }

        private void getStateBtn_Click(object sender, EventArgs e)
        {
            this.Text = "DCController - Gathering information...";
            if (_device == null) return;
            Thread.Sleep(_timeout);

            if (_device.Status == null)
            {
                _logger.WriteMessage("Couldn't get infromation from device", DebugLevel.ERROR);
                MessageBox.Show("Couldn't get information from device", "Sorry", MessageBoxButtons.OK);
                Disconnect();
                return;
            }

            if (_device.Status.PortBConfiguration == null)
            {
                _logger.WriteMessage("Couldn't get information from device", DebugLevel.ERROR);
                MessageBox.Show("Couldn't get information from device", "Sorry", MessageBoxButtons.OK);
                Disconnect();
                return;
            }

            var portA = _device.Status.PortAConfiguration;
            var portB = _device.Status.PortBConfiguration;

            aFrequencyTB.Text = portA.Frequency.ToString();
            bFrequencyTB.Text = portB.Frequency.ToString();
            aMuteCB.SelectedItem = (MuteOptions)portA.Mute;
            bMuteCB.SelectedItem = (MuteOptions)portB.Mute;
            aConfigureMuteCB.SelectedItem = (ConfigMuteOptions)portA.ConfigMute;
            bConfigureMuteCB.SelectedItem = (ConfigMuteOptions)portB.ConfigMute;
            aAttenuationTB.Text = portA.Attenuation.ToString();
            bAttenuationTB.Text = portB.Attenuation.ToString();
            aSlopeTB.Text = portA.Slope.ToString();
            bSlopeTB.Text = portB.Slope.ToString();
            aInverseCB.SelectedItem = (InverseOptions)portA.Inverse;
            bInverseCB.SelectedItem = (InverseOptions)portB.Inverse;

            FillAlarmsDataGridView();
            this.Text = "DCController - Connected";
        }

        private void FillAlarmsDataGridView()
        {
            alarmsDataGrid.Rows.Clear();
            foreach (var fault in _device.Status.ActiveFaults)
            {
                var str = fault.Key;
                var state = fault.Value == 1 ? "ON" : "OFF";
                alarmsDataGrid.Rows.Add(new string[] { str, state });
            }
        }

        #endregion buttons
    }
}
