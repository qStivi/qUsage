using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace qUsage
{
    public partial class MainForm : Form
    {
        private const int WmNclbuttondown = 0xA1;
        private const int HtCaption = 0x2;
        private readonly Home _home = new Home {Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None};
        private readonly Settings _settings = new Settings {Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None};
        private readonly TaskManager _taskManager = new TaskManager {Dock = DockStyle.Fill, TopLevel = false,TopMost = true, FormBorderStyle = FormBorderStyle.None};

        private Control _prevBtn;

        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void MainForm_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            _prevBtn = btnMenu1;
            LoadForm(_home, "Home", btnMenu1);
        }

        private void LoadForm(Control control, string title, object sender)
        {
            labelTitle.Text = title;
            panelFormLoader.Controls.Clear();
            panelFormLoader.Controls.Add(control);
            control.Show();
            SetBackColor(sender);
        }

        private void SetBackColor(object sender)
        {
            if (sender is Control control)
            {
                _prevBtn.BackColor = Color.FromArgb(24, 30, 54);
                _prevBtn = control;
                pnlNav.Height = control.Height;
                pnlNav.Top = control.Top;
                pnlNav.Left = control.Left;
                control.BackColor = Color.FromArgb(46, 51, 73);
            }
            else
            {
                throw new NotImplementedException("This shouldn't happen...");
            }
        }

        private void ResetBackColor(object sender, EventArgs e)
        {
            if (sender is Control control)
                control.BackColor = Color.FromArgb(24, 30, 54);
            else
                throw new NotImplementedException("This shouldn't happen...");
        }

        private void HideToTray(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.ShowBalloonTip(5000);
        }

        private void Exit(object sender, EventArgs e)
        {
            Program.Close();
        }

        private void OpenFromTray(object sender, MouseEventArgs e)
        {
            Show();
            Focus();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
        }

        private void btnMenu1_MouseUp(object sender, MouseEventArgs e)
        {
            LoadForm(_home, "Home", sender);
        }

        private void btnMenuTasks_MouseUp(object sender, MouseEventArgs e)
        {
            LoadForm(_taskManager, "Task Manager", sender);
        }

        private void btnMenu3_MouseUp(object sender, MouseEventArgs e)
        {
            LoadForm(_home, "Home", sender);
        }

        private void btnMenu4_MouseUp(object sender, MouseEventArgs e)
        {
            LoadForm(_home, "Home", sender);
        }

        private void btnMenuSettings_MouseUp(object sender, MouseEventArgs e)
        {
            LoadForm(_settings, "Settings", sender);
        }

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }
    }
}
