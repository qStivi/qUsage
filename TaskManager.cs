using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace qUsage
{
    public partial class TaskManager : Form
    {
        private const int ColCount = 3;
        private static int _rowCount;

        private readonly BackgroundWorker _worker;
        private TableLayoutPanel _tblProcesses;

        private List<Process> AllProcesses;

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

        private void TaskManager_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void GenerateTable(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var numberOfApps = GetNumberOfAppsWeActuallyCareAbout();
            _rowCount = numberOfApps;
            var bgWorker = (BackgroundWorker) sender;
            InitializeTable(ColCount, _rowCount);
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
            var labels = new Label[_rowCount];
            for (var i = 0; i < _rowCount; i++)
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
                var progress = (int) ((double) i / _rowCount * 100);
                backgroundWorker.ReportProgress(progress);
            }
        }

        private int GetNumberOfAppsWeActuallyCareAbout()
        {
            AllProcesses = Process.GetProcesses().ToList();
            var processesWeHaveAccessTo = new List<Process>();
            foreach (var process in AllProcesses)
            {
                try
                {
                    if (process.MainModule == null) continue;
                    var companyName = process.MainModule.FileVersionInfo.CompanyName;
                    
                    if (companyName.Equals("Microsoft Corporation") || companyName == "") continue;
                    processesWeHaveAccessTo.Add(process);
                    Debug.WriteLine(process.MainModule.FileVersionInfo.CompanyName);

                }
                catch (Exception)
                {
                    //ignored
                }
            }

            return processesWeHaveAccessTo.Count;
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
