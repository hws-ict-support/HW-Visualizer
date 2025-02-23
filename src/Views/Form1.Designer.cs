
namespace HWS_Visualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkAutoReconnect = new System.Windows.Forms.CheckBox();
            this.chkMirror = new System.Windows.Forms.CheckBox();
            this.lnkDevices = new System.Windows.Forms.LinkLabel();
            this.timerAutoReconnect = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCameras
            // 
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(114, 5);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(433, 23);
            this.cmbCameras.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Lime;
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(553, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(147, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Start Displaying";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Aqua;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(706, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Freeze";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // picCam
            // 
            this.picCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCam.Location = new System.Drawing.Point(0, 0);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(1363, 307);
            this.picCam.TabIndex = 3;
            this.picCam.TabStop = false;
            this.picCam.Click += new System.EventHandler(this.picCam_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkAutoReconnect);
            this.splitContainer1.Panel1.Controls.Add(this.chkMirror);
            this.splitContainer1.Panel1.Controls.Add(this.lnkDevices);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCameras);
            this.splitContainer1.Panel1.Controls.Add(this.btnGo);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picCam);
            this.splitContainer1.Size = new System.Drawing.Size(1363, 621);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 5;
            // 
            // chkAutoReconnect
            // 
            this.chkAutoReconnect.AutoSize = true;
            this.chkAutoReconnect.Location = new System.Drawing.Point(984, 7);
            this.chkAutoReconnect.Name = "chkAutoReconnect";
            this.chkAutoReconnect.Size = new System.Drawing.Size(111, 19);
            this.chkAutoReconnect.TabIndex = 5;
            this.chkAutoReconnect.Text = "Auto Reconnect";
            this.chkAutoReconnect.UseVisualStyleBackColor = true;
            this.chkAutoReconnect.CheckedChanged += new System.EventHandler(this.chkAutoReconnect_CheckedChanged);
            // 
            // chkMirror
            // 
            this.chkMirror.AutoSize = true;
            this.chkMirror.Checked = true;
            this.chkMirror.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMirror.Location = new System.Drawing.Point(859, 7);
            this.chkMirror.Name = "chkMirror";
            this.chkMirror.Size = new System.Drawing.Size(119, 19);
            this.chkMirror.TabIndex = 4;
            this.chkMirror.Text = "Mirror/Flip Image";
            this.chkMirror.UseVisualStyleBackColor = true;
            // 
            // lnkDevices
            // 
            this.lnkDevices.AutoSize = true;
            this.lnkDevices.Location = new System.Drawing.Point(3, 7);
            this.lnkDevices.Name = "lnkDevices";
            this.lnkDevices.Size = new System.Drawing.Size(105, 15);
            this.lnkDevices.TabIndex = 3;
            this.lnkDevices.TabStop = true;
            this.lnkDevices.Text = "Refresh Device List";
            this.lnkDevices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDevices_LinkClicked);
            // 
            // timerAutoReconnect
            // 
            this.timerAutoReconnect.Interval = 750;
            this.timerAutoReconnect.Tick += new System.EventHandler(this.timerAutoReconnect_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 621);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HWS Visualizer Software 0.2b";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel lnkDevices;
        private System.Windows.Forms.CheckBox chkMirror;
        private System.Windows.Forms.CheckBox chkAutoReconnect;
        private System.Windows.Forms.Timer timerAutoReconnect;
    }
}

