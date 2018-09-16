using System;
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
            //c.Send(DateTime.Now.ToString());
            btnStart.Enabled = false;
            if (numE1Port1.Value == numE1Port2.Value)
            {
                MessageBox.Show("Please setup 2 different E1 port at the output", "Output E ports", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStart.Enabled = true;
            }

            #region Start DC and Wait until DC is setup and operational 
            #endregion

            #region Start the CICD and wait it to be in running state
            if (cicdDevicve != null)
            {
                await cicdDevicve.Stop();
            }
            cicdDevicve = new CICDDevice(new Uri(Properties.Settings.Default.CICCDUrl), this);

            await cicdDevicve.Start((float)numFrequency.Value, (float)numLBandFreq.Value, (float)numUsefulBw.Value, (float)numGain.Value,
                    1,"", new Uri(Properties.Settings.Default.CICDtoMedCICUri1), new Uri(Properties.Settings.Default.CICDtoMedCICUri2));
            if (!cicdDevicve.IsRunnign())
            {
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

        public void ShowMessage(string msg)
        {

        }

        private void lblFrequency_Click(object sender, EventArgs e)
        {

        }
    }


}
