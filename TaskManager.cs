using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



// Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.CompanyName);
// Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.ProductName);
// Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.FileDescription);
// Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.FileName);
// Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.OriginalFilename);
// Debug.WriteLine(_processes[0].MainModule?.FileVersionInfo.InternalName);


namespace qUsage
{
    public partial class TaskManager : Form
    {
        private const int ColCount = 3;
        private static int _rowCount;

        private List<Process> _processes = new();

        private readonly BackgroundWorker _worker;
        private TableLayoutPanel _tblProcesses;

        private BackgroundWorker _bgw;

        public TaskManager()
        {
            InitializeComponent();
            circularProgressBar.Value = 0;

            _worker = new BackgroundWorker {WorkerReportsProgress = true};
            _worker.DoWork += GenerateTable;
            _worker.ProgressChanged += worker_ProgressChanged;
            _worker.RunWorkerCompleted += ShowTable;
        }

        private void RefreshList(object sender, EventArgs eventArgs)
        {
            var newProcessList = GetProcesses(false, _bgw);
            if (!_processes.All(newProcessList.Contains))
            {
                Debug.WriteLine("yee");
            }
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
            _bgw = (BackgroundWorker) sender;

            _processes = GetProcesses(true, _bgw);
            _rowCount = _processes.Count;
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
            _tblProcesses.MouseMove += RefreshList;
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

        private static List<Process> GetProcesses(bool updateProgress, BackgroundWorker bgw)
        {
            var allProcesses = Process.GetProcesses().ToList();
            var newProcessList = new List<Process>();
            for (var i = 0; i < allProcesses.Count; i++)
            {
                var process = allProcesses[i];
                try
                {
                    if (process.MainModule == null) continue;
                    var companyName = process.MainModule.FileVersionInfo.CompanyName;

                    if (companyName.Equals("Microsoft Corporation") || companyName == "") continue;
                    newProcessList.Add(process);

                    if (!updateProgress) continue;
                    var progress = (int) ((double) i / allProcesses.Count * 100);
                    bgw.ReportProgress(progress);
                }
                catch (Exception e) {Nothing(e);}
            }

            return newProcessList;
        }

        private static void Nothing(object o){}
        private void ShowTable(object sender, RunWorkerCompletedEventArgs e)
        {
            Controls.Add(_tblProcesses);
            progressBar1.Hide();
            circularProgressBar.Hide();
        }
    }
}
