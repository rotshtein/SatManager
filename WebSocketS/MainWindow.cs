using System;
using System.Windows.Forms;
using WebSocketSharp;

namespace WebSocketS
{
    public partial class MainWindow : Form, IguiInterface
    {
        Client c = null;
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            //c.Send(DateTime.Now.ToString());
            btnStart.Enabled = false;
            if (numE1Port1.Value == numE1Port2.Value)
            {
                MessageBox.Show("Please setup 2 different E1 port at the output", "Output E ports", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStart.Enabled = true;
            }




        }

        public void ShowMessage(string msg)
        {

        }
    }


}
