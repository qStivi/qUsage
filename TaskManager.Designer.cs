using System.ComponentModel;

namespace qUsage
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 1;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Meiryo UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (51)))), ((int) (((byte) (73)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(309, 170);
            this.circularProgressBar.Margin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int) (((byte) (42)))), ((int) (((byte) (30)))), ((int) (((byte) (54)))));
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (162)))), ((int) (((byte) (249)))));
            this.circularProgressBar.ProgressWidth = 7;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.circularProgressBar.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int) (((byte) (166)))), ((int) (((byte) (166)))), ((int) (((byte) (166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int) (((byte) (166)))), ((int) (((byte) (166)))), ((int) (((byte) (166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "%";
            this.circularProgressBar.TabIndex = 2;
            this.circularProgressBar.Text = "0";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.circularProgressBar.Value = 68;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(332, 368);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (51)))), ((int) (((byte) (73)))));
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.circularProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.ResumeLayout(false);
        }

        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;

        #endregion
    }
}
