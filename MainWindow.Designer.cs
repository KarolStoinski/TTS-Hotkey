namespace TTS_Hotkey
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.voiceSelector = new System.Windows.Forms.ListBox();
            this.voiceGroup = new System.Windows.Forms.GroupBox();
            this.controlsGroup = new System.Windows.Forms.GroupBox();
            this.speechRateBar = new System.Windows.Forms.TrackBar();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.voiceGroup.SuspendLayout();
            this.controlsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speechRateBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Win + Shift + A to read any selected text aloud";
            // 
            // voiceSelector
            // 
            this.voiceSelector.FormattingEnabled = true;
            this.voiceSelector.Location = new System.Drawing.Point(6, 19);
            this.voiceSelector.Name = "voiceSelector";
            this.voiceSelector.Size = new System.Drawing.Size(322, 147);
            this.voiceSelector.TabIndex = 1;
            this.voiceSelector.SelectedValueChanged += new System.EventHandler(this.ChangeVoice);
            // 
            // voiceGroup
            // 
            this.voiceGroup.Controls.Add(this.voiceSelector);
            this.voiceGroup.Location = new System.Drawing.Point(16, 63);
            this.voiceGroup.Name = "voiceGroup";
            this.voiceGroup.Size = new System.Drawing.Size(334, 174);
            this.voiceGroup.TabIndex = 2;
            this.voiceGroup.TabStop = false;
            this.voiceGroup.Text = "Voice";
            // 
            // controlsGroup
            // 
            this.controlsGroup.Controls.Add(this.speechRateBar);
            this.controlsGroup.Controls.Add(this.volumeBar);
            this.controlsGroup.Controls.Add(this.label3);
            this.controlsGroup.Controls.Add(this.label2);
            this.controlsGroup.Location = new System.Drawing.Point(16, 243);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Size = new System.Drawing.Size(334, 150);
            this.controlsGroup.TabIndex = 3;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Controls";
            // 
            // speechRateBar
            // 
            this.speechRateBar.Location = new System.Drawing.Point(7, 99);
            this.speechRateBar.Minimum = -10;
            this.speechRateBar.Name = "speechRateBar";
            this.speechRateBar.Size = new System.Drawing.Size(321, 45);
            this.speechRateBar.TabIndex = 3;
            this.speechRateBar.Value = 9;
            this.speechRateBar.ValueChanged += new System.EventHandler(this.ChangeSpeechRate);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(7, 33);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(321, 45);
            this.volumeBar.TabIndex = 2;
            this.volumeBar.Value = 90;
            this.volumeBar.ValueChanged += new System.EventHandler(this.ChangeVolume);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Speech rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Volume";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TTS Hotkey";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowWindow);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minimizing hides app into tray";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(365, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.controlsGroup);
            this.Controls.Add(this.voiceGroup);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 444);
            this.MinimumSize = new System.Drawing.Size(381, 444);
            this.Name = "MainWindow";
            this.Text = "TTS Hotkey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Resize += new System.EventHandler(this.FormResize);
            this.voiceGroup.ResumeLayout(false);
            this.controlsGroup.ResumeLayout(false);
            this.controlsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speechRateBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox voiceSelector;
        private System.Windows.Forms.GroupBox voiceGroup;
        private System.Windows.Forms.GroupBox controlsGroup;
        private System.Windows.Forms.TrackBar speechRateBar;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label4;
    }
}

