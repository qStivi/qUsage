using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace qUsage
{
    public partial class TaskManager : Form
    {
        private const int ColCount = 3;
        private static int _rowCount;

        private readonly List<Process> _processes = new();

        private readonly BackgroundWorker _worker;
        private TableLayoutPanel _tblProcesses;

        private BackgroundWorker bgw;

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
            bgw = (BackgroundWorker) sender;

            _rowCount = GetNumberOfAppsWeActuallyCareAbout(bgw);
            InitializeTable();
            PopulateTable();
        }

        private void InitializeTable()
        {
            const float width = (float) 100 / ColCount;
            _tblProcesses = new TableLayoutPanel
            {
                ColumnCount = ColCount,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "tblProcesses",
                RowCount = _rowCount,
                Size = new Size(814, 530),
                TabIndex = 99
            };
            for (var i = 0; i < ColCount; i++) _tblProcesses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, width));

            for (var i = 0; i < _rowCount; i++) _tblProcesses.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void PopulateTable()
        {
            var lblNameArray = new Label[_rowCount];
            var lblCompanyArray = new Label[_rowCount];
            for (var i = 0; i < _rowCount; i++)
            {
                lblNameArray[i] = new Label
                {
                    Size = new Size(500, 42),
                    Dock = DockStyle.Fill,
                    Name = "processName" + i,
                    TabIndex = 0,
                    Text = _processes[i].MainModule?.FileVersionInfo.ProductName
                };
                _tblProcesses.Controls.Add(lblNameArray[i], 0, i);
                
                lblCompanyArray[i] = new Label
                {
                    Size = new Size(500, 42),
                    Dock = DockStyle.Fill,
                    Name = "processCompany" + i,
                    TabIndex = 0,
                    Text = _processes[i].MainModule?.FileVersionInfo.CompanyName
                };
                _tblProcesses.Controls.Add(lblCompanyArray[i], 1, i);
            }
        }

        private int GetNumberOfAppsWeActuallyCareAbout(BackgroundWorker backgroundWorker)
        {
            var allProcesses = Process.GetProcesses().ToList();
            for (var i = 0; i < allProcesses.Count; i++)
            {
                var process = allProcesses[i];
                try
                {
                    if (process.MainModule == null) continue;
                    var companyName = process.MainModule.FileVersionInfo.CompanyName;

                    if (companyName.Equals("Microsoft Corporation") || companyName == "") continue;
                    _processes.Add(process);


                    var progress = (int) ((double) i / allProcesses.Count * 100);
                    backgroundWorker.ReportProgress(progress);
                }
                catch (Exception)
                {
                    //ignored
                }
            }

            // Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.CompanyName);
            // Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.ProductName);
            // Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.FileDescription);
            // Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.FileName);
            // Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.OriginalFilename);
            // Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.InternalName);
            return _processes.Count;
        }

        private void ShowTable(object sender, RunWorkerCompletedEventArgs e)
        {
            Controls.Add(_tblProcesses);
            progressBar1.Hide();
            circularProgressBar.Hide();
        }
    }
}
