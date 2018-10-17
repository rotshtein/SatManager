using System;
using System.Drawing;
using System.Windows.Forms;
using WebSocketSharp;

namespace WebSocketS
{
    public partial class MainWindow : Form, IguiInterface
    {
        Client c = null;

        #region Deveice
        // DC
        CICDDevice cicdDevicve;
        MediationDevice medationDevice;
        CygnusDevice cygnusDevice;
        #endregion

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

        private async void btnSend_Click(object sender, EventArgs e)
        {
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

            #region Start DC and Wait until DC is setup and operational 
            #endregion

            #region Start the CICD and wait it to be in running state
            if (cicdDevicve != null)
            {
               // await cicdDevicve.Stop();
            }
            cicdDevicve = new CICDDevice(new Uri(Properties.Settings.Default.CICCDUrl), this);
            if (chkUseFile.Checked)
            {
                await cicdDevicve.Start(txtInputFilename.Text, (float)numFrequency.Value, (float)numLBandFreq.Value, (float)numUsefulBw.Value, (float)numGain.Value,
                        (int)numSno.Value, "", new Uri(Properties.Settings.Default.CICDtoMedCICUri1), new Uri(Properties.Settings.Default.CICDtoMedCICUri2));
            }
            else
            {
                await cicdDevicve.Start(null, (float)numFrequency.Value, (float)numLBandFreq.Value, (float)numUsefulBw.Value, (float)numGain.Value,
                        1, "", new Uri(Properties.Settings.Default.CICDtoMedCICUri1), new Uri(Properties.Settings.Default.CICDtoMedCICUri2));
            }
            if (!cicdDevicve.IsRunnign())
            {
                btnStop_Click(sender, e);
                return;
            }
            #endregion

            #region Start the Mediation
            medationDevice = new MediationDevice(new Uri(Properties.Settings.Default.MedCicUrl), this);
            await medationDevice.Start(new Uri(Properties.Settings.Default.CICDtoMedCICUri1), new Uri(Properties.Settings.Default.CICDtoMedCICUri2),
                                       new Uri(Properties.Settings.Default.MedCictoCygnusUrl1), new Uri(Properties.Settings.Default.MedCictoCygnusUrl2));
            #endregion

            #region Start the Orion (if needed)
            if (!IsSAToP())
            {
                cygnusDevice = new CygnusDevice(new Uri(Properties.Settings.Default.CygnusUrl), this);
                //cygnusDevice.Start()
            }
            #endregion
        }

       

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cicdDevicve != null)
            {
                cicdDevicve.stopCICD();
            }

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

        #region GuiInterface
        public void ShowMessage(string msg)
        {
            if (txtStatus.InvokeRequired)
            {
                txtStatus.Invoke(new MethodInvoker(() => { ShowMessage(msg); }));
            }
            else
            {
                txtStatus.Text = msg +Environment.NewLine + txtStatus.Text;
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
