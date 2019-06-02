using SlicerProto.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlicerProto
{
    public partial class ProgressForm : Form
    {
        private bool abort = false;
        private delegate void InvokeDelegate();

        public ProgressForm()
        {
            InitializeComponent();
        }

        public IExporter Exporter { get; set; }
        public string FileName { get; set; }

        private void butAbort_Click(object sender, EventArgs e)
        {
            abort = true;
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            if (Exporter != null)
            {
                Exporter.OnProgress += Exporter_OnProgress;
                this.BeginInvoke(new InvokeDelegate(RunExport));
            }
        }

        private void RunExport()
        {
            try
            {
                Exporter.Export(FileName);
                DialogResult = abort ? DialogResult.Abort : DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не могу записать файл '{FileName}'!\n{ex.Message}",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }

        private void ProgressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Exporter != null)
                Exporter.OnProgress -= Exporter_OnProgress;
        }

        private void Exporter_OnProgress(object sender, ExportProgressEventArgs e)
        {
            progressBar1.Value = e.Progress;
            lblProgress.Text = $"{e.Progress}%";
            e.Abort = abort;
            Application.DoEvents();
        }
    }
}
