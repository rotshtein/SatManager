using log4net;
using System;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketS
{
    public partial class MainWindow : Form, IguiInterface
    {
        #region Members
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        Client c = null;
        
        // DC
        CICDDevice cicdDevicve;
        MediationDevice medationDevice;
        CygnusDevice cygnusDevice;
        #endregion

        #region GUI callbacks
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            c = new Client("ws://echo.websocket.org");
            
            c.Send("Hello");
            c.Send(new byte[] { 1, 2, 3, 4, 5 });
            
        }

        private bool IsSAToP()
        {
            return tabOutput.SelectedTab == tabOutput.TabPages["tabSAToP"];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            log.Debug("Starting....");
            btnStart.Enabled = false;
            if (numE1Port1.Value == numE1Port2.Value)
            {
                MessageBox.Show("Please setup 2 different E1 port at the output", "Output E ports", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStart.Enabled = true;
            }

            if (chkUseFile.Checked)
            {
                if (string.IsNullOrEmpty(chkUseFile.Text) )
                {
                    MessageBox.Show("Please setup the input file names ", "Input Filename", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnStart.Enabled = true;
                }

                Properties.Settings.Default.InputFilename = txtInputFilename.Text;
                Properties.Settings.Default.Save();
            }

            #region DownConverter
            bool dcStarted = StartDC();
            if (!dcStarted)
            {
                log.Info("Failed to start Down Converter");
                //btnStop_Click(sender, e);
            }
            #endregion

            #region CICD
            StartCICD();
            /*
            bool cicdStarted = StartCICD();
            if (!cicdStarted)
            {
                log.Info("Failed to start CICD");
                //btnStop_Click(sender, e);
            }*/
            #endregion

            #region Mediation
            /*
            bool mediationStarted = await StartMediation();
            if (!mediationStarted)
            {
                log.Info("Failed to start Mediation");
                //btnStop_Click(sender, e);
            }
            */
            #endregion

            #region Cygnus
            /*
            if (!IsSAToP())
            {
                bool cygnusStarted = await StartCICD();
                if (!cygnusStarted)
                {
                    log.Info("Failed to start Cygnus");
                    //btnStop_Click(sender, e);
                }
            }
            */
            #endregion
        }
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cicdDevicve != null)
            {
                cicdDevicve.Stop();
            }
            btnStart.Enabled = true;
        }

        private void chkUseFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseFile.Checked)
            {
                chkUseFile.Enabled = true;
            }
            else
            {
                chkUseFile.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cicdDevicve != null)
            {
                cicdDevicve.getReport();
            }
        }

        private void txtStatus_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtStatus.Text = string.Empty;
        }
        #endregion

        #region Start devices
        #region Start DC and Wait until DC is setup and operational 
        private bool StartDC()
        {
            log.Debug("Starting Down converter - Not implemented yet");
            return false;
        }
        #endregion

        #region Start the CICD and wait it to be in running state
        private void StartCICD()
        {
            log.Debug("Starting CICD");

            if (cicdDevicve != null)
            {
                if (cicdDevicve.IsRunnign())
                {
                    cicdDevicve.Stop();
                    log.Debug("Stoping already running CICD");
                }
            }

            cicdDevicve = new CICDDevice(new Uri(Properties.Settings.Default.CICCDUrl), this);

            try
            {
                if (chkUseFile.Checked)
                {
                    log.Debug("Starting CICD - Software FE");
                    cicdDevicve.Start(txtInputFilename.Text, (float)numFrequency.Value, (float)numLBandFreq.Value, (float)numUsefulBw.Value, (float)numGain.Value,
                            (int)numSno.Value, "", new Uri(Properties.Settings.Default.CICDtoMedCICUri1), new Uri(Properties.Settings.Default.CICDtoMedCICUri2));
                }
                else
                {
                    log.Debug("Starting CICD - Hardware FE");
                    cicdDevicve.Start(null, (float)numFrequency.Value, (float)numLBandFreq.Value, (float)numUsefulBw.Value, (float)numGain.Value,
                            1, "", new Uri(Properties.Settings.Default.CICDtoMedCICUri1), new Uri(Properties.Settings.Default.CICDtoMedCICUri2));
                }
            }
            catch (Exception ex)
            {
                log.Error("Failed to start CICD", ex);
            }
            
        }
        #endregion
        
        #region Start the Mediation
        private async Task<bool> StartMediation()
        {
            try
            {
                log.Debug("Starting Mediation");
                medationDevice = new MediationDevice(new Uri(Properties.Settings.Default.MedCicUrl), this);
                medationDevice.Start(new Uri(Properties.Settings.Default.CICDtoMedCICUri1), new Uri(Properties.Settings.Default.CICDtoMedCICUri2),
                                           new Uri(Properties.Settings.Default.MedCictoCygnusUrl1), new Uri(Properties.Settings.Default.MedCictoCygnusUrl2));
            }
            catch (Exception ex)
            {
                log.Error("Failed to start Mediation", ex);
                return await Task.FromResult(false); 
            }
            return await Task.FromResult(true);
        }
        #endregion

        #region Start the Orion
        private async Task<bool> StartCygnus()
        {
            try
            {
                log.Debug("Starting Cygnus");
                cygnusDevice = new CygnusDevice(new Uri(Properties.Settings.Default.CygnusUrl), this);
                //cygnusDevice.Start()
            }
            catch (Exception ex)
            {
                log.Error("Failed to start Cygnus", ex);
                return await Task.FromResult(false);
            }
            return await Task.FromResult(true);
        }
        #endregion
        #endregion

        #region GuiInterface
        public void ShowMessage(string msg)
        {
            if (txtStatus.InvokeRequired)
            {
                txtStatus.Invoke(new MethodInvoker(() => { ShowMessage(msg); }));
            }
            else
            {
                txtStatus.AppendText(msg + Environment.NewLine);
            }
        }

        public void UpdateCicdState(bool SeperationState)
        {
             if (txtCiC1Data.InvokeRequired)
            {
                txtCiC1Data.Invoke(new MethodInvoker(() => { UpdateCicdState(SeperationState); }));
            }
            else
            {
                if (SeperationState)
                {
                    txtCiC1Data.BackColor = Color.Green;
                    txtCiC2Data.BackColor = Color.Green;
                    txtCiC1Error.BackColor = Color.Green;
                    txtCiC2Error.BackColor = Color.Green;
                }
                else
                {
                    txtCiC1Data.BackColor = Color.Red;
                    txtCiC2Data.BackColor = Color.Red;
                    txtCiC1Error.BackColor = Color.Red;
                    txtCiC2Error.BackColor = Color.Red;
                }
            }
        }

        public void UpdateCicdCounter(ulong Cic1Data, ulong Cic2Data, ulong Cic1Errors, ulong Cic2Errors)
        {
            if (txtCiC1Data.InvokeRequired)
            {
                txtCiC1Data.Invoke(new MethodInvoker(() => { UpdateCicdCounter(Cic1Data, Cic2Data, Cic1Errors, Cic2Errors); }));
            }
            else
            {
                txtCiC1Data.Text = Cic1Data.ToString();
                txtCiC2Data.Text = Cic2Data.ToString();
                txtCiC1Error.Text = Cic1Errors.ToString();
                txtCiC2Error.Text = Cic2Errors.ToString();
            }
        }

        #endregion
        
    }
}
