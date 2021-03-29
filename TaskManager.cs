using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace qUsage
{
    public partial class TaskManager : Form
    {
        private const int ColCount = 3;
        private const int RowCount = 500;

        private readonly BackgroundWorker _worker;
        private TableLayoutPanel _tblProcesses;

        public TaskManager()
        {
            InitializeComponent();
            circularProgressBar.Value = 0;

            _worker = new BackgroundWorker {WorkerReportsProgress = true};
            _worker.DoWork += GenerateTable;
            _worker.ProgressChanged += worker_ProgressChanged;
            _worker.RunWorkerCompleted += ShowTable;
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            circularProgressBar.Value = e.ProgressPercentage;
            circularProgressBar.Text = e.ProgressPercentage.ToString();
            progressBar1.Value = e.ProgressPercentage;
        }

        private void UpdateProgress(int progress)
        {
            circularProgressBar.Value = progress;
            circularProgressBar.Text = progress.ToString();
            progressBar1.Value = progress;
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void GenerateTable(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var bgWorker = (BackgroundWorker) sender;
            InitializeTable(ColCount, RowCount);
            PopulateTable(bgWorker);
        }

        private void InitializeTable(int rows, int cols)
        {
            _tblProcesses = new TableLayoutPanel
            {
                // Location = new Point(40, 38),
                // Size = new Size(100, 23),
                AutoScroll = true,
                ColumnCount = cols,
                RowCount = rows,
                Name = "tblProcesses",
                Dock = DockStyle.Fill,
                TabIndex = 1
            };
            // for (var i = 0; i < cols; i++) _tblProcesses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // for (var i = 0; i < rows; i++) _tblProcesses.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        }

        private void PopulateTable(BackgroundWorker backgroundWorker)
        {
            var labels = new Label[RowCount];
            for (var i = 0; i < RowCount; i++)
            {
                labels[i] = new Label
                {
                    // Location = new Point(40, 38),
                    // Size = new Size(100, 23),
                    Dock = DockStyle.Fill,
                    Name = "label1",
                    TabIndex = 0,
                    Text = "Name"
                };
                _tblProcesses.Controls.Add(labels[i], 0, i);
                // ReSharper disable once PossibleLossOfFraction
                var progress = (int) ((double) i / RowCount * 100);
                backgroundWorker.ReportProgress(progress);
                // UpdateProgress(progress);
            }
        }

        private void ShowTable(object sender, RunWorkerCompletedEventArgs e)
        {
            Controls.Add(_tblProcesses);
            progressBar1.Hide();
            progressBar1.Dispose();
            circularProgressBar.Hide();
            circularProgressBar.Dispose();
        }
    }
}
