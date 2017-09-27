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
using Biometrics;
using BioMetrixCore;

namespace Biometrics
{
    public partial class frmProgress : Form
    {
        public frmProgress ()
        {
            InitializeComponent();
        }

        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter _inputparameter;

        private void backgroundWorker_DoWork ( object sender, DoWorkEventArgs e )
        {
            int process = ( (DataParameter)e.Argument ).Process;
            int delay = ( (DataParameter)e.Argument ).Delay;
            int index = 1;

            try
            {
                Master master = new Master();
                master.sendTest();
                for (int i = 0; i < process; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        Thread.Sleep(delay);
                        //Add code here
                    }
                }
            }

            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_ProgressChanged ( object sender, ProgressChangedEventArgs e )
        {
            progress.Value = e.ProgressPercentage;
            lblPercent.Text = string.Format("Processing...{0}%", e.ProgressPercentage);
            progress.Update();
        }

        private void backgroundWorker_RunWorkerCompleted ( object sender, RunWorkerCompletedEventArgs e )
        {
             MessageBox.Show("Process has been completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            backgroundWorker.CancelAsync();
        }

        public void start ()
        {
            if (!backgroundWorker.IsBusy)
            {
                _inputparameter.Delay = 10;
                _inputparameter.Process = 1200;
                backgroundWorker.RunWorkerAsync(_inputparameter);
            }

        }

        private void frmProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
