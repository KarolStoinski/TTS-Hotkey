using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_Hotkey
{
    public partial class MainWindow : Form
    {
        private readonly SpeechSynthesizer Synth = new SpeechSynthesizer();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static public extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public MainWindow()
        {
            InitializeComponent();

            foreach (InstalledVoice v in Synth.GetInstalledVoices())
            {
                voiceSelector.Items.Add(v.VoiceInfo.Name);
            }

            voiceSelector.SelectedIndex = 0;

            Synth.SelectVoice(voiceSelector.SelectedItem.ToString());

            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)(KeyModifier.WinKey | KeyModifier.Shift), Keys.A.GetHashCode());

            Synth.Volume = 90;
            Synth.Rate = 9;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {

                if (Synth.State == SynthesizerState.Speaking)
                {
                    Synth.SpeakAsyncCancelAll();
                }
                else
                {
                    SendCtrlC();
                    Synth.SpeakAsync(Clipboard.GetText());
                }
            }
        }
        private void SendCtrlC()
        {
            Thread.Sleep(300);
            SendKeys.SendWait("^c");
        }

        private void ChangeVolume(object sender, EventArgs e)
        {
            Synth.Volume = volumeBar.Value;
        }

        private void ChangeSpeechRate(object sender, EventArgs e)
        {
            Synth.Rate = speechRateBar.Value;
        }

        private void ChangeVoice(object sender, EventArgs e)
        {
            Synth.SelectVoice(voiceSelector.SelectedItem.ToString());
        }

        private void ShowWindow(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void FormResize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
        }
    }
}
