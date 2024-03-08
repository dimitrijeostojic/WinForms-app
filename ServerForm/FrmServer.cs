using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public partial class FrmServer : Form
    {
        private Server server;
        private bool kraj = false;
        public FrmServer()
        {
            InitializeComponent();
            server = new Server();
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnBeginTime_Click(object sender, EventArgs e)
        {
            kraj = false;
            btnBeginTime.Enabled = false;
            btnStopTime.Enabled = true;
            Thread thread = new Thread(StartTime);
            thread.Start();

        }

        private void StartTime()
        {
            while (!kraj)
            {
                this.Invoke(new Action(() =>
                {
                    lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                }));
                Thread.Sleep(1000);
            }

        }

        private void btnStopTime_Click(object sender, EventArgs e)
        {
            btnBeginTime.Enabled = true;
            btnStopTime.Enabled = false;
            kraj = true;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
